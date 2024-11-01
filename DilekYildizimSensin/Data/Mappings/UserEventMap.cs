using DilekYildizimSensin.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DilekYildizimSensin.Data.Mappings
{
    public class UserEventMap : IEntityTypeConfiguration<UserEvent>
    {
        public void Configure(EntityTypeBuilder<UserEvent> builder)
        {
            builder.HasData(
                new UserEvent
                {
                    Id = Guid.NewGuid(),
                    AppUserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"), // superadmin
                    EventId = Guid.Parse("1328A6C8-9EBD-4B22-978A-453F0C31BBDF"), // Ofis Etkinliği
                    CreatedDate = DateTime.UtcNow
                },
                new UserEvent
                {
                    Id = Guid.NewGuid(),
                    AppUserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"), // admin
                    EventId = Guid.Parse("1E7BC8E4-59A8-4F63-AF21-C7697A727F64"), // Dilek Alma Etkinliği
                    CreatedDate = DateTime.UtcNow
                },
                new UserEvent
                {
                    Id = Guid.NewGuid(),
                    AppUserId = Guid.Parse("5BDF3B72-62AF-4D30-8BC8-0B6CF723AE57"), // user1
                    EventId = Guid.Parse("3C5B8E39-A8F8-4671-A573-2E1E5E8A6F85"), // Dilek Gerçekleştirme Etkinliği
                    CreatedDate = DateTime.UtcNow
                },
                new UserEvent
                {
                    Id = Guid.NewGuid(),
                    AppUserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"), // superadmin
                    EventId = Guid.Parse("E6481D73-37E2-4B7E-A817-A7D0921797C6"), // Stant Etkinliği
                    CreatedDate = DateTime.UtcNow
                }
            );
        }
    }

}
