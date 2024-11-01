using DilekYildizimSensin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DilekYildizimSensin.Data.Mappings
{
    public class BadgeMap : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasData(new Badge
            {
                Id = Guid.Parse("0299A520-25CA-49EC-9492-035CCF2ED5B8"),
                BadgeName = "Karda Yürüyen",
                BadgeIcon= "https://w7.pngwing.com/pngs/423/1004/png-transparent-medal-gold-winner-badge-achievement-reward-army-champion-awards-icon.png",
                
                
            });
            builder.HasData(new Badge
            {
                Id = Guid.Parse("6296D6F2-052E-40FB-BF0B-72EB2AC34A6D"),
                BadgeName = "Sosyal Kelebek",
                BadgeIcon = "https://static.vecteezy.com/system/resources/previews/014/606/031/original/golden-yellow-trophy-icon-for-the-winner-of-a-sports-event-png.png",


            });
            builder.HasData(new Badge
            {
                Id = Guid.Parse("820B74D4-C6F7-4823-A45E-6DBD41311212"),
                BadgeName = "Gülen Yüz",
                BadgeIcon = "https://e7.pngegg.com/pngimages/1002/183/png-clipart-smiley-smiley-miscellaneous-smiley.png",


            });
            builder.HasData(new Badge
            {
                Id = Guid.Parse("5D706D85-8780-43EB-9F0B-21F6D6AE9A07"),
                BadgeName = "Yüce Gönüllü",
                BadgeIcon = "https://www.shutterstock.com/image-vector/transparent-winner-icon-png-vector-260nw-1945885621.jpg",


            });
            builder.HasData(new Badge
            {
                Id = Guid.Parse("8BF1DA2F-A48E-4ECF-94A0-3B85E3CB32D2"),
                BadgeName = "Ayın Elemanı",
                BadgeIcon = "https://img.lovepik.com/png/20231009/Outstanding-color-male-employees-of-the-month-staff-the-company_136776_wh860.png",


            });
        }
    }
}
