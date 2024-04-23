namespace DDDFirstLook.Infrastructure.Db
{
    public class AvailabilityDbEntity: Entity<int>
    {
        public string Type { get; set; }

        public int Count { get; set; }

        public bool IsActive { get; set; }

        public int ProductId { get; set; }

        public ProductDbEntity Product { get; set; }
    }
}
