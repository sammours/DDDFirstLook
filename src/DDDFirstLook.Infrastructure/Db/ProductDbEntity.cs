using System.Collections.Generic;

namespace DDDFirstLook.Infrastructure.Db
{
    public class ProductDbEntity : Entity<int>
    {
        public string Name { get; set; }

        public int Total { get; set; }

        public AddressDbEntity Address { get; set; }

        public List<AvailabilityDbEntity> Availabilities { get; set; }
    }
}
