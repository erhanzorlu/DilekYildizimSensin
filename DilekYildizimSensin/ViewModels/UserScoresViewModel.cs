namespace DilekYildizimSensin.ViewModels
{
    public class UserScoresViewModel
    {
        public Guid? SelectedUserId { get; set; } // Seçili kullanıcı ID'si
        public List<UserItem> Users { get; set; } // Kullanıcı listesi
        public Dictionary<int, int> MonthlyScores { get; set; } // Ay bazında puanlar

        public class UserItem
        {
            public Guid Id { get; set; }
            public string UserName { get; set; }
        }
    }
}
