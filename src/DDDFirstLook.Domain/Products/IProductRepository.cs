using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDFirstLook.Domain.Products
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product GetById(int id);

        Product Insert(Product product);

        Product Update(Product product);

        void Delete(int id);
    }
}
