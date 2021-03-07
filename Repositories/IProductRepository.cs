using Project.Models;
using Project.Repositories.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetById(Guid productId);

        Task<IEnumerable<Product>> GetAll();

        Task<Product> Create(ProductDto product);

        Task<Product> Update(Guid productId, ProductDto product);

        Task<Product> Remove(Guid productId);
    }
}
