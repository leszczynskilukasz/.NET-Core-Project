using Microsoft.EntityFrameworkCore;
using Project.DataConfig;
using Project.Models;
using Project.Repositories.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductdbContext _context;

        public ProductRepository(ProductdbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }

        public async Task<Product> GetById(Guid productId)
        {
            var result = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (result == null)
            {
                throw new Exception("Product could not be found");
            }
            return result;
        }

        public async Task<Product> Create(ProductDto product)
        {
            var newProduct = new Product
            {
                Id = Guid.NewGuid(),
                Name = product.Name,
                Price = product.Price,
            };
            await _context.Products.AddAsync(newProduct);
            _context.SaveChanges();
            return newProduct;
        }

        public async Task<Product> Update(Guid productId, ProductDto product)
        {
            var result = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (result == null)
            {
                throw new Exception("Update failed");
            }
            result.Name = product.Name;
            result.Price = product.Price;

            _context.SaveChanges();
            return result;
        }

        public async Task<Product> Remove(Guid productId)
        {
            var result = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (result == null)
            {
                throw new Exception("Product does not exist");
            }
            _context.Products.Remove(result);
            _context.SaveChanges();
            return result;
        }
    }
}
