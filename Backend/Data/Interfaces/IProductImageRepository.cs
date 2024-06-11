using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IProductImageRepository : IGenericRepository<ProductImageEntity, int>
    {
        IQueryable<ProductImageEntity> ProductImages { get; }
        Task<List<ProductImageEntity>> GetProductImagesByProductIdAsync(int id);
        Task RemoveProductImagesByProductIdAsync(int productId);
    }
}
