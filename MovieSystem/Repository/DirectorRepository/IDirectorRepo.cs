using MovieSystem.DTOs;

namespace MovieSystem.Repository.DirectorRepository
{
    public interface IDirectorRepo
    {
        public void Add(DirectorDto directorDto);
        public void Update(int id, Update_Delete update_Delete);
        public void Delete(int id);
    }
}
