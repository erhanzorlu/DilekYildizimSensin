using DilekYildizimSensin.Models;

namespace DilekYildizimSensin.Dtos
{
    public class AddEventToUserViewModel
    {
        public List<Guid> SelectedUserIds { get; set; } = new List<Guid>(); // Çoklu kullanıcı seçimi için
        public Guid EventId { get; set; } // Seçilen etkinlik
        public DateTime EventDate { get; set; } = DateTime.Today; // Varsayılan olarak bugünün tarihi
        public List<AppUser> Users { get; set; } // Kullanıcı listesi
        public List<Event> Events { get; set; } // Etkinlik listesi
    }

}
