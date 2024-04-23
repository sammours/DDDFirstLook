using AutoMapper;
using Bogus;
using DDDFirstLook.Domain.Customers;
using DDDFirstLook.Domain.Products;
using DDDFirstLook.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirstLook.Infrastructure.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMapper mapper;
        private readonly MyDbContext dbContext;

        public ProductRepository(IMapper mapper, MyDbContext dbContext)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            var products = this.dbContext.Products.Include(x => x.Address).Include(x => x.Availabilities).ToList();
            return this.mapper.Map<List<Product>>(products);
        }

        public Product GetById(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public Product Insert(Product product)
        {
            var dbEntity = this.mapper.Map<ProductDbEntity>(product);
            this.dbContext.Products.Add(dbEntity);
            this.dbContext.SaveChanges();
            return product;
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
