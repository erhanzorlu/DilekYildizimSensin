using DilekYildizimSensin.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DilekYildizimSensin.Data.Mappings
{
    public class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData(
                new Event
                {
                    Id = Guid.Parse("1328A6C8-9EBD-4B22-978A-453F0C31BBDF"),
                    EventName = "Diğer Gönüllü Faaliyetleri",
                    CreatedDate = DateTime.UtcNow
                },
                new Event
                {
                    Id = Guid.Parse("1E7BC8E4-59A8-4F63-AF21-C7697A727F64"),
                    EventName = "Dilek Alma Etkinliği",
                    CreatedDate = DateTime.UtcNow
                },
                new Event
                {
                    Id = Guid.Parse("3C5B8E39-A8F8-4671-A573-2E1E5E8A6F85"),
                    EventName = "Dilek Gerçekleştirme Etkinliği",
                    CreatedDate = DateTime.UtcNow
                }
                   //new Event
                   //{
                   //    Id = Guid.Parse("E6481D73-37E2-4B7E-A817-A7D0921797C6"),
                   //    EventName = "Stant Etkinliği",
                   //    CreatedDate = DateTime.UtcNow
                   //}
            );
        }
    }
}
