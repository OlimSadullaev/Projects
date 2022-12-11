namespace SalesOrder.Api.Entities
{
    public class Photo
    {
        public Guid Id { get; set; }

        public IEnumerable<Media> Medias { get; set; }

        public DateTime CreatedAt { get; set; }

        public string BrendName { get; set; }

        public string Country { get; set; }

        public int Price { get; set; }

        public string AvailableSize { get; set; }

        public Photo(IEnumerable<Media> medias, DateTime createdAt, string brendName, string country, int price, string availableSize)
        {
            Id = Guid.NewGuid();
            Medias = medias;
            CreatedAt = createdAt;
            BrendName = brendName;
            Country = country;
            Price = price;
            AvailableSize = availableSize;
        }
    }
}
