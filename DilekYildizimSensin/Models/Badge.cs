using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilekYildizimSensin.Models
{
    public class Badge : BaseEntity
    {
        public string BadgeName { get; set; }
        public string BadgeIcon { get; set; }

        public ICollection<UserBadge> UserBadges { get; set; }
    }
}
