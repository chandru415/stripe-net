using Domain.Common;

namespace Application.Common.Interfaces.Categories
{
    public interface ICategoryCommand
    {
        Task<GenericPair> SaveCategoryAsync();
        Task<GenericPair> UpdateCategoryAsync();
        Task<GenericPair> DeleteCategoryAsync();
    }
}
