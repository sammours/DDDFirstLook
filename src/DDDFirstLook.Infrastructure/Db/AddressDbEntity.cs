namespace DDDFirstLook.Infrastructure.Db
{
    public class AddressDbEntity : Entity<int>
    {
        public string Street { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public int ProductId { get; set; }

        public ProductDbEntity Product { get; set; }
    }
}
