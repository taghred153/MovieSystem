using MovieSystem.DTOs;

namespace MovieSystem.Repository.MovieRepository
{
    public interface IMovieRepo
    {
        public void AddAll(AddAll addAll);
        public List<AddAll> GetAll();
        public GeTByIdDto GetById(int id);
    }
}
