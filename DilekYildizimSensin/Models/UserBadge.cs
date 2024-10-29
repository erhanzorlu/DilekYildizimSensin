using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilekYildizimSensin.Models
{
    public class UserBadge : BaseEntity
    {
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public Guid BadgeId { get; set; }
        public Badge Badge { get; set; }
    }
}
