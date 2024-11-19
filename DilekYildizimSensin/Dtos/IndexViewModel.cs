using DilekYildizimSensin.Models;

namespace DilekYildizimSensin.Dtos
{
    public class IndexViewModel
    {
        public AppUserDto AppUserDto { get; set; }
        public  Badge GetLatestBadgeAsync { get; set; }
        public List<AppUserDto> GetTop10UsersByScoreAsync { get; set; }
}
}
