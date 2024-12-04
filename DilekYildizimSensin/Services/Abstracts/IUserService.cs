using DilekYildizimSensin.Dtos;
using DilekYildizimSensin.Models;
using Microsoft.AspNetCore.Identity;

namespace DilekYildizimSensin.Services.Abstracts
{
    public interface IUserService
    {
        Task<List<Badge>> GetUserBadgesAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<Badge> GetLatestBadgeAsync(Guid userId);
        Task<List<UserEvent>> CreateUserEventsAsync(List<Guid> userIds, Guid eventId, DateTime eventDate, CancellationToken cancellationToken = default);
        Task CheckAndAssignBadgesAsync(List<Guid> userIds, Guid eventId, DateTime eventDate);


    }
}
