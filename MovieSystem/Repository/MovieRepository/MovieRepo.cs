using Microsoft.EntityFrameworkCore;
using MovieSystem.DTOs;
using MovieSystem.Models;

namespace MovieSystem.Repository.MovieRepository
{
    public class MovieRepo: IMovieRepo
    {
        private readonly AppDbContext _cotext;

        public MovieRepo(AppDbContext context)
        {
            _cotext = context;
        }
        public void AddAll(AddAll addAll)
        {
            Movie movie = new Movie
            {
                Title = addAll.Title,
                ReleaseDate = addAll.ReleaseDate,
                Directors = addAll.directorDtos.Select(x => new Director
                {
                    Name = x.Name,
                    Contact = x.Contact,
                    Email = x.Email,
                    Nationality = new Nationality
                    {
                        Name = x.nationalityDto.Name,
                    }
                }).ToList(),
                Category = new Category
                {
                    Name = addAll.categoryDto.Name,
                }
            };
            _cotext.Movies.Add(movie);
            _cotext.SaveChanges();
        }
        public List<AddAll> GetAll()
        {
            var res = _cotext.Movies
                .Include(x => x.Directors)
                .ThenInclude(x => x.Nationality)
                .Include(x => x.Category)
                .Select(x => new AddAll
                {
                    Title = x.Title,
                    ReleaseDate = x.ReleaseDate,
                    directorDtos = x.Directors.Select(x => new DirectorDto
                    {
                        Name = x.Name,
                        Contact = x.Contact,
                        Email = x.Email,
                        nationalityDto = new NationalityDto
                        {
                            Name = x.Nationality.Name,
                        }
                    }).ToList(),
                    categoryDto = new CategoryDto
                    {
                        Name = x.Category.Name,
                    }
                }).ToList();
            return res;
        }
        public GeTByIdDto GetById(int id)
        {
            var res = _cotext.Movies
                .Include(x => x.Directors)
                .ThenInclude(x => x.Nationality)
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
            if (res != null)
            {
                return new GeTByIdDto
                {
                    Title = res.Title,
                    ReleaseDate = res.ReleaseDate,
                    directorByIdDtos = res.Directors.Select(x => new DirectorByIdDto
                    {
                        Name = x.Name,
                        nationalityDto = new NationalityDto
                        {
                            Name = x.Nationality.Name
                        }
                    }).ToList(),
                    categoryDto = new CategoryDto
                    {
                        Name = res.Category.Name,
                    }
                };
            }
            else
            {
                throw new Exception("Not Found");
            }
        }
    }
}
