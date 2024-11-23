using MovieSystem.DTOs;

namespace MovieSystem.Repository.CategoryRepository
{
    public interface ICategoryRepo
    {
        public void Add(CategoryDto categoryDto);
        public void Update(CategoryDto categoryDto, int id);
    }
}
