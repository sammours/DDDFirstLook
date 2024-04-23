using DDDFirstLook.Domain.Primitives;
using DDDFirstLook.Domain.Products;
using System;
using Xunit;

namespace DDDFirstLook.Domain.Tests.Products
{
    public class ProductTests
    {
        [Fact]
        public void ProductTest_CreateTest()
        {
            var product = new Product(1, "product 1");
            Assert.Equal(1, product.Id);
            Assert.Equal("product 1", product.Name);
        }
    }
}
