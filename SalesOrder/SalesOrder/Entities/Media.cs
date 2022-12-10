namespace SalesOrder.Api.Entities
{
    public class Media
    {
        public Guid Id { get; set; }

        public byte[] Data { get; set; }

        public Media(Guid id, byte[] data)
        {
            Id = id;
            Data = data;
        }
    }
}
