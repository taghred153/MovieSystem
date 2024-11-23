using MovieSystem.DTOs;

namespace MovieSystem.Repository.NationalityRepository
{
    public interface INationalityRepo
    {
        public void Add(NationalityDto nationalityDto);
        public void Delete(int id);
    }
}
