namespace DilekYildizimSensin.Models
{
    public class VolunteerScore : BaseEntity
    {
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int Year { get; set; } // Yıl bilgisi
        public int Month { get; set; } // Ay bilgisi (1 - 12 arası değer alacak)
        public int Score { get; set; } // Aylık puan

    }
}
