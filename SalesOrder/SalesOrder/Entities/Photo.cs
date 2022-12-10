namespace SalesOrder.Api.Entities
{
    public class Photo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Media> Medias { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Brend { get; set; }

        public string Country { get; set; }

        public int Price { get; set; }

        public string AvailableSize { get; set; }
    }
}
