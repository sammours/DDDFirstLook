using DDDFirstLook.Domain.Primitives;

namespace DDDFirstLook.Domain.Products
{
    public class Address
    {
        public string Street { get; set; }

        public PostalCode PostalCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
