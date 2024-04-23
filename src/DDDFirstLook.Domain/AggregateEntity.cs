namespace DDDFirstLook.Domain
{
    public class AggregateEntity<TId>
    {
        public TId Id { get; protected set; }
    }
}
