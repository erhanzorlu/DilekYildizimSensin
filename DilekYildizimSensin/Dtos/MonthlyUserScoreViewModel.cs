namespace DilekYildizimSensin.Dtos
{
    public class MonthlyUserScoreViewModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public int MonthlyScore { get; set; }
    }
}
