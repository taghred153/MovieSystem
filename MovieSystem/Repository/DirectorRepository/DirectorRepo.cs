using Microsoft.EntityFrameworkCore;
using MovieSystem.DTOs;
using MovieSystem.Models;

namespace MovieSystem.Repository.DirectorRepository
{
    public class DirectorRepo: IDirectorRepo
    {
        private readonly AppDbContext _context;

        public DirectorRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(DirectorDto directorDto)
        {
            Director director = new Director
            {
                Name = directorDto.Name,
                Contact = directorDto.Contact,
                Email = directorDto.Email,
                Nationality = new Nationality
                {
                    Name = directorDto.nationalityDto.Name,
                }
            };
            _context.Directors.Add(director);
            _context.SaveChanges();
        }
        public void Update(int id, Update_Delete update_Delete)
        {
            var res = _context.Directors
                .Include(x => x.Movies)
                .ThenInclude(x => x.Category)
                .Include(x => x.Nationality)
                .FirstOrDefault(x => x.Id == id);
            if (res != null)
            {
                res.Name = update_Delete.Name;
                res.Contact = update_Delete.Contact;
                res.Email = update_Delete.Email;
                res.Movies = update_Delete.movieDtos.Select(x => new Movie
                {
                    Title = x.Title,
                    ReleaseDate = x.ReleaseDate,
                    Category = new Category
                    {
                        Name = x.categoryDto.Name,
                    }
                }).ToList();
                res.Nationality = new Nationality
                {
                    Name = update_Delete.nationalityDto.Name,
                };
                _context.Directors.Update(res);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not Found");
            }
        }
        public void Delete(int id)
        {
            var res = _context.Directors
                .Include(x => x.Movies)
                .ThenInclude(x => x.Category)
                .Include(x => x.Nationality)
                .FirstOrDefault(x => x.Id == id);
            if (res != null)
            {
                if (res.Movies != null)
                {
                    _context.Movies.RemoveRange(res.Movies);
                }
                if (res.Nationality != null)
                {
                    _context.Nationalities.Remove(res.Nationality);
                }
                _context.Directors.Remove(res);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not Found");
            }
        }
    }
}
