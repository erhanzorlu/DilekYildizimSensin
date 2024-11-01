using DilekYildizimSensin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DilekYildizimSensin.Data.Mappings
{
    public class UserBadgeMap : IEntityTypeConfiguration<UserBadge>
    {
        public void Configure(EntityTypeBuilder<UserBadge> builder)
        {
            builder.HasData(new UserBadge
            {
                AppUserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"),
                BadgeId = Guid.Parse("0299A520-25CA-49EC-9492-035CCF2ED5B8"),
            });
            builder.HasData(new UserBadge
            {
                AppUserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"),
                BadgeId = Guid.Parse("8BF1DA2F-A48E-4ECF-94A0-3B85E3CB32D2"),
            });
            builder.HasData(new UserBadge
            {
                AppUserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"),
                BadgeId = Guid.Parse("5D706D85-8780-43EB-9F0B-21F6D6AE9A07"),
            });

             /////////////////////////////////////////////////////////////////

            builder.HasData(new UserBadge
            {
                AppUserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                BadgeId = Guid.Parse("820B74D4-C6F7-4823-A45E-6DBD41311212"),
            });
            builder.HasData(new UserBadge
            {
                AppUserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                BadgeId = Guid.Parse("0299A520-25CA-49EC-9492-035CCF2ED5B8"),
            });
        }
    }
}
