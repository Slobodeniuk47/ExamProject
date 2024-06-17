using Infrastructure.Models.DTO.CategoryDTO;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ICategoryService
    {
        Task<ServiceResponse> GetAllAsync();
        Task<ServiceResponse> GetByIdAsync(int id);
        Task<ServiceResponse> GetMainCategoriesAsync();
        Task<ServiceResponse> Create(CategoryCreateDTO model);
        Task<ServiceResponse> EditCategoryAsync(CategoryEditDTO model);
        Task<ServiceResponse> DeleteCategoryAsync(int id);
    }
}
