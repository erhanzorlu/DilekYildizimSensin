using DilekYildizimSensin.Models;

namespace DilekYildizimSensin.Dtos
{
    public class AppUserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public string? ImageUrl { get; set; }
        public List<BadgeDto> UserBadges { get; set; } 
    }

}
