using DilekYildizimSensin.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilekYildizimSensin.Models
{
    public class AppUser : IdentityUser<Guid>, IBaseEntity
    {
        public  GenderEnum Gender { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<UserBadge> UserBadges { get; set; }
    }
}
