namespace SalesOrder.Api.Models
{
    public class PhotoModel
    {
        public IEnumerable<Guid> MediasId { get; set; }

        public string BrendName { get; set; }

        public string Country { get; set; }

        public string Price { get; set; }

        public string AvailableSize { get; set; }

    }
}
