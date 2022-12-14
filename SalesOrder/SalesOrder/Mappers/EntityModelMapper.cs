using SalesOrder.Api.Entities;
using SalesOrder.Api.Models;
using System.Runtime.CompilerServices;

namespace SalesOrder.Api.Mappers
{
    public static class EntityModelMapper
    {
        public static Photo ToEntity(this PhotoModel photo, IEnumerable<Media> media)
        {
            return new Photo(
                brendName: photo.BrendName,
                country: photo.Country,
                price: photo.Price,
                availableSize: photo.AvailableSize,
                createdAt: DateTime.Today,
                medias: media.ToList()
                );
        }

        private static Media GetImageEnt(IFormFile file)
        {
            using var stream = new MemoryStream();

            file.CopyTo(stream);

            return new Media(Guid.NewGuid(), stream.ToArray());
        }
    }
}
