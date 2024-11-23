using MovieSystem.DTOs;
using MovieSystem.Models;

namespace MovieSystem.Repository.NationalityRepository
{
    public class NationalityRepo: INationalityRepo
    {
        private readonly AppDbContext _context;

        public NationalityRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(NationalityDto nationalityDto)
        {
            Nationality nationality = new Nationality
            {
                Name = nationalityDto.Name,
            };
            _context.Nationalities.Add(nationality);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var res = _context.Nationalities
                .FirstOrDefault(x => x.Id == id);
            if (res != null)
            {
                _context.Nationalities.Remove(res);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not Found");
            }
        }
    }
}
