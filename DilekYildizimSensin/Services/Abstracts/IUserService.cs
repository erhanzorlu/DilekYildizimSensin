using DilekYildizimSensin.Dtos;
using DilekYildizimSensin.Models;
using Microsoft.AspNetCore.Identity;

namespace DilekYildizimSensin.Services.Abstracts
{
    public interface IUserService
    {
        Task<List<Badge>> GetUserBadgesAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<Badge> GetLatestBadgeAsync(Guid userId);
        Task<List<AppUserDto>> GetTop5UsersByScoreAsync();
        Task<List<UserEvent>> CreateUserEventsAsync(List<Guid> userIds, Guid eventId, DateTime eventDate, CancellationToken cancellationToken = default);
        Task<List<AppUser>> SearchUsersAsync(string searchTerm);
        Task<List<UserEvent>> ListUserEventsAsync();
        Task CheckAndAssignBadgesAsync(List<Guid> userIds, Guid eventId, DateTime eventDate);
    }
}
