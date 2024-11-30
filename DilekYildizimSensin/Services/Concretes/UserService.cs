﻿using DilekYildizimSensin.Dtos;
using DilekYildizimSensin.Models;
using DilekYildizimSensin.Services.Abstracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace DilekYildizimSensin.Services.Concretes
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public UserService(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<List<VolunteerScore>> ListAllScoresAsync()
        {
            return await _context.VolunteerScores
                .Include(vs => vs.AppUser)
                .OrderByDescending(vs => vs.Year)
                .ThenByDescending(vs => vs.Month)
                .ToListAsync();
        }

        public async Task<List<VolunteerScore>> ListScoresByMonthAsync(int year, int month)
        {
            return await _context.VolunteerScores
                .Include(vs => vs.AppUser)
                .Where(vs => vs.Year == year && vs.Month == month)
                .OrderByDescending(vs => vs.Score)
                .ToListAsync();
        }

        public async Task<List<UserEvent>> ListUserEventsByNameAsync(string name)
        {
            var userEvents = await _context.UserEvents
                .Include(ue => ue.AppUser)  // Katılan kullanıcı bilgilerini dahil et
                .Include(ue => ue.Event)    // Katıldığı etkinlik bilgilerini dahil et
                .Where(ue => ue.AppUser.FirstName.Contains(name) || ue.AppUser.LastName.Contains(name)) // İsme göre filtreleme
                .OrderByDescending(ue => ue.EventDate) // En yeni tarihten en eskiye doğru sıralama
                .ToListAsync();

            return userEvents;
        }



        public async Task<List<LeaderboardItemDto>> GetMonthlyLeaderboardAsync(int month)
        {
            var leaderboardData = await _context.VolunteerScores
                .Where(s => s.Month == month) // Sadece belirtilen ayın verilerini alıyoruz
                .GroupBy(s => new { s.AppUser.FirstName, s.AppUser.LastName }) // Kullanıcı adına göre grupluyoruz
                .Select(g => new LeaderboardItemDto
                {
                    FirstName = g.Key.FirstName,
                    LastName = g.Key.LastName,
                    Month = month,
                    Score = g.Sum(s => s.Score)
                })
                .OrderByDescending(x => x.Score) // Puanlara göre sıralıyoruz
                .Take(10) // İlk 10 sonucu alıyoruz
                .ToListAsync();

            return leaderboardData;
        }



        public async Task<Dictionary<int, int>> GetMonthlyScoresAsync(Guid userId)
        {
            // Verilen UserId'ye göre veritabanından ay bazında toplam puanları grupluyoruz.
            var monthlyScores = await _context.VolunteerScores
                .Where(s => s.AppUserId == userId)
                .GroupBy(s => s.Month)
                .Select(g => new { Month = g.Key, TotalScore = g.Sum(s => s.Score) })
                .ToListAsync();

            // Dictionary olarak döndürüyoruz: Ay -> Toplam Puan
            return monthlyScores.ToDictionary(x => x.Month, x => x.TotalScore);
        }


        public async Task<List<UserEvent>> ListUserEventsAsync()
        {
            var userEvents = await _context.UserEvents
                .Include(ue => ue.AppUser)  // Katılan kullanıcı bilgilerini dahil et
                .Include(ue => ue.Event)    // Katıldığı etkinlik bilgilerini dahil et
                .OrderByDescending(ue => ue.EventDate) // En yeni tarihten en eskiye doğru sıralama
                .ToListAsync();

            return userEvents;
        }

        public async Task<List<Badge>> GetUserBadgesAsync(Guid userId, CancellationToken cancellationToken = default)
        {
            // Verilen kullanıcı ID'sine göre rozetleri getir
            return await _context.UserBadges
                .Where(ub => ub.AppUserId == userId)
                .Select(ub => ub.Badge)
                .ToListAsync(cancellationToken);
        }

        public async Task<Badge> GetLatestBadgeAsync(Guid userId)
        {
            var latestBadge = await _context.UserBadges
                .Where(ub => ub.AppUserId == userId)
                .OrderByDescending(ub => ub.CreatedDate)
                .Select(ub => ub.Badge)
                .FirstOrDefaultAsync();

            return latestBadge;
        }

        public async Task<List<AppUserDto>> GetTop10UsersByScoreAsync()
        {
            var topUsers = await _userManager.Users
                .OrderByDescending(u => u.Score)
                .Take(10)
                .Select(u => new AppUserDto
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Score = u.Score,
                    ImageUrl = u.ImageUrl
                })
                .ToListAsync();

            return topUsers;
        } //Silinebilir

        public async Task CheckAndAssignBadgesAsync(List<Guid> userIds, Guid eventId, DateTime eventDate)
        {
            var eventInfo = await _context.Events.FindAsync(eventId);
            if (eventInfo == null) throw new Exception("Etkinlik bulunamadı");

            foreach (var userId in userIds)
            {
                var user = await _context.Users
                    .Include(u => u.UserEvents)
                        .ThenInclude(ue => ue.Event) // Event bilgilerini UserEvents ile birlikte yükle
                    .Include(u => u.UserBadges)
                    .FirstOrDefaultAsync(u => u.Id == userId);

                if (user == null) continue;

                // Etkinlik türüne göre sadece ilgili koşulları kontrol et
                switch (eventInfo.EventName)
                {
                    case "Dilek Gerçekleştirme Etkinliği":
                        var dilekGerceklestirmeCount = user.UserEvents
                            .Count(ue => ue.Event.EventName == "Dilek Gerçekleştirme Etkinliği");

                        if (dilekGerceklestirmeCount >= 3)
                        {
                            await AssignBadgeAsync(user, "Dilek Perisi", eventDate);
                        }
                        break;

                    case "Diğer Gönüllü Faaliyetleri":
                        var digerFaaliyetCount = user.UserEvents
                            .Count(ue => ue.Event.EventName == "Diğer Gönüllü Faaliyetleri");

                        if (digerFaaliyetCount >= 3)
                        {
                            await AssignBadgeAsync(user, "Gülen Yüz", eventDate);
                        }
                        break;

                    case "Dilek Alma Etkinliği":
                        var dilekAlmaCount = user.UserEvents
                            .Count(ue => ue.Event.EventName == "Dilek Alma Etkinliği");

                        if (dilekAlmaCount >= 3)
                        {
                            await AssignBadgeAsync(user, "Dilek Yıldızı", eventDate);
                        }
                        break;

                    default:
                        break;
                }
            }

            await _context.SaveChangesAsync();
        }



        private async Task AssignBadgeAsync(AppUser user, string badgeName, DateTime eventDate)
        {
            // Rozetin mevcut olup olmadığını kontrol et
            var badge = await _context.Badges.FirstOrDefaultAsync(b => b.BadgeName == badgeName);
            if (badge == null) throw new Exception($"{badgeName} rozeti bulunamadı");

            // Kullanıcıda rozet yoksa ekle
            if (!user.UserBadges.Any(ub => ub.BadgeId == badge.Id))
            {
                var userBadge = new UserBadge
                {
                    AppUserId = user.Id,
                    BadgeId = badge.Id,
                };
                var appUser= await _context.Users.FindAsync(user.Id);
                appUser.Score+=20; // Kullanıcıya 20 puan ekle;
                _context.Add(userBadge);

                var userVolunteerScore = new VolunteerScore
                {
                    AppUserId = appUser.Id,
                    Score = 20,
                    Year = eventDate.Year,
                    Month = eventDate.Month

                };
                _context.Add(userVolunteerScore);
            }

         }



        // Birden fazla kullanıcı için UserEvent kaydı oluşturur
        public async Task<List<UserEvent>> CreateUserEventsAsync(List<Guid> userIds, Guid eventId, DateTime eventDate, CancellationToken cancellationToken = default)
        {
            var userEvents = new List<UserEvent>();
            var userVolunteerScores = new List<VolunteerScore>();

            // Etkinliğin geçerli olup olmadığını kontrol et
            var selectedEvent = await _context.Events.FindAsync(eventId);
            if (selectedEvent == null) throw new Exception("Etkinlik bulunamadı");
            if (userIds.Count == 0) throw new Exception("Kullanıcılar bulunamadı");

            // Her kullanıcı için UserEvent kaydı oluştur
            foreach (var userId in userIds)
            {
                var appUser = await _context.Users.FindAsync(userId);
                if (appUser == null) throw new Exception($"Kullanıcı bulunamadı: {userId}");

                // Etkinlik türüne göre puanlama
                int scoreToAdd = 0;
                switch (selectedEvent.EventName)
                {
                    case "Dilek Gerçekleştirme Etkinliği":
                        scoreToAdd = 15;
                        break;
                    case "Diğer Gönüllü Faaliyetleri":
                        scoreToAdd = 10;
                        break;
                    case "Dilek Alma Etkinliği":
                        scoreToAdd = 5;
                        break;
                    default:
                        throw new Exception("Geçersiz etkinlik türü");
                }

                var userEvent = new UserEvent
                {
                    Id = Guid.NewGuid(),
                    AppUserId = userId,
                    EventId = eventId,
                    CreatedDate = DateTime.Now,
                    Event = selectedEvent,
                    AppUser = appUser,
                    EventDate = DateOnly.FromDateTime(eventDate), // Convert DateTime to DateOnly
                };

                userEvents.Add(userEvent);

                var userVolunteerScore = new VolunteerScore
                {
                    AppUserId = userId,
                    Score = scoreToAdd,
                    CreatedDate = DateTime.Now,
                    Year = eventDate.Year,
                    Month = eventDate.Month
                };
                userVolunteerScores.Add(userVolunteerScore);
                appUser.Score += scoreToAdd; // Kullanıcıya uygun puanı ekle
            }

            _context.AddRange(userEvents);
            _context.AddRange(userVolunteerScores);

            // Toplu olarak ekleme ve kaydetme
            await _context.SaveChangesAsync();

            return userEvents;
        }



        public async Task<List<AppUser>> SearchUsersAsync(string searchTerm)
        {
            return await _userManager.Users
                .Where(u => u.FirstName.Contains(searchTerm) || u.LastName.Contains(searchTerm))
                .ToListAsync();
        }//Silinebilir
    }

}
