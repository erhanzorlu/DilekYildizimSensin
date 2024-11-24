using DilekYildizimSensin.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DilekYildizimSensin.Data.Mappings
{
    public class UserEventMap : IEntityTypeConfiguration<UserEvent>
    {
        public void Configure(EntityTypeBuilder<UserEvent> builder)
        {
          
        }
    }

}
