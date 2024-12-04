namespace DilekYildizimSensin.Models
{
    public class UserEvent : BaseEntity
    {
        public Guid AppUserId { get; set; } // Kullanıcı ID'si
        public AppUser AppUser { get; set; } // Kullanıcı bilgisi

        // Gönüllü puanları için
        public int? Year { get; set; } // Yıl bilgisi
        public int? Month { get; set; } // Ay bilgisi
        public int? Score { get; set; } // Aylık puan

        // Etkinlikler için
        public Guid? EventId { get; set; } // Etkinlik ID'si
        public Event Event { get; set; } // Etkinlik bilgisi
        public DateOnly? EventDate { get; set; } // Etkinlik tarihi
    }

}
