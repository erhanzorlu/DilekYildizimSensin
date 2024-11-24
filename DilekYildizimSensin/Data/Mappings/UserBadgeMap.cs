using DilekYildizimSensin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DilekYildizimSensin.Data.Mappings
{
    public class UserBadgeMap : IEntityTypeConfiguration<UserBadge>
    {
        public void Configure(EntityTypeBuilder<UserBadge> builder)
        {
            
        }
    }
}
