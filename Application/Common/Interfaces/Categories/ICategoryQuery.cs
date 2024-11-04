

using Domain.Entities.Categories;

namespace Application.Common.Interfaces.Categories
{
    public interface ICategoryQuery
    {
        Task<IEnumerable<Category>> FetchCategories();
    }
}
