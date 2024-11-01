namespace DilekYildizimSensin.Models
{
    public class UserEvent:BaseEntity
    {
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public DateOnly EventDate { get; set; }
    }
}
