﻿using DilekYildizimSensin.Dtos;
using DilekYildizimSensin.Models;
using DilekYildizimSensin.Services.Abstracts;
using DilekYildizimSensin.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DilekYildizimSensin.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserService _userService;
        private readonly AppDbContext _context;

        public AdminController(UserManager<AppUser> userManager, AppDbContext context, IUserService userService)
        {
            _userManager = userManager;
            _context = context;
            _userService = userService;
        }


        // Tüm gönüllü puanlarını listeleme
        public async Task<IActionResult> ListVolunteerScores()
        {
            var scores = await _userService.ListAllScoresAsync();
            return View(scores); // View'da VolunteerScore modelini kullanacağız
        }

        // Yıl ve aya göre gönüllü puanlarını filtreleme
        [HttpGet]
        public async Task<IActionResult> FilterVolunteerScores(int year, int month)
        {
            var scores = await _userService.ListScoresByMonthAsync(year, month);
            ViewData["Year"] = year;
            ViewData["Month"] = month;

            return View("ListVolunteerScores", scores); // Aynı view ile sonuçlar gösteriliyor
        }


        [HttpGet]
        public IActionResult UserScores()
        {
            // Kullanıcıları al ve ViewModel'e ata
            var model = new UserScoresViewModel
            {
                SelectedUserId = null,
                Users = _userManager.Users
                    .Select(u => new UserScoresViewModel.UserItem
                    {
                        Id = u.Id,
                        UserName = u.UserName
                    })
                    .ToList(),
                MonthlyScores = null // İlk açılışta boş bırakılır
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UserScores(Guid userId)
        {
            // Seçili kullanıcının aylık puanlarını al
            var monthlyScores = await _userService.GetMonthlyScoresAsync(userId);

            // ViewModel'i doldur
            var model = new UserScoresViewModel
            {
                SelectedUserId = userId,
                Users = _userManager.Users
                    .Select(u => new UserScoresViewModel.UserItem
                    {
                        Id = u.Id,
                        UserName = u.UserName
                    })
                    .ToList(),
                MonthlyScores = monthlyScores // Aylık puanları ViewModel'e ekle
            };

            return View(model);
        }


        public async Task<IActionResult> Index()
        {
            // Şu anki kullanıcıyı al
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUser = await _userManager.FindByIdAsync(userId);

            if (currentUser == null)
            {
                return RedirectToAction("Login", "Auth"); // Kullanıcı oturum açmamışsa login sayfasına yönlendir
            }

            // Kullanıcı sayısını al
            var totalUsers = await _userManager.Users.CountAsync();

            // İstatistikleri ViewData ile gönder
            ViewData["TotalUsers"] = totalUsers;


            // Kullanıcı bilgilerini View'e ilet
            return View(currentUser);
        }





        public async Task<IActionResult> ListEventsWithUsers(string name)
        {
            var userEvents = string.IsNullOrEmpty(name)
                ? await _userService.ListUserEventsAsync() // Tüm kullanıcı etkinliklerini getir
                : await _userService.ListUserEventsByNameAsync(name); // İsme göre filtrele

            ViewData["SearchQuery"] = name; // Arama kriterini view'a gönder

            return View("ListEventsWithUsers", userEvents);
        }



        //[HttpGet]
        //public async Task<IActionResult> SearchUsers(string searchTerm)
        //{
        //    var users = string.IsNullOrEmpty(searchTerm)
        //        ? new List<AppUser>()
        //        : await _userService.SearchUsersAsync(searchTerm);

        //    var result = users.Select(u => new { u.Id, u.FirstName, u.LastName, u.Email }).ToList();

        //    return Json(result);
        //}


        [HttpGet]
        public async Task<IActionResult> AddEventToUser()
        {
            // Tüm kullanıcıları ve etkinlikleri ViewModel'e ekleyelim
            var viewModel = new AddEventToUserViewModel
            {
                Users = await _context.Users.ToListAsync(),
                Events = await _context.Events.ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddEventToUser(AddEventToUserViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    // Model geçerli değilse kullanıcı ve etkinlik listelerini tekrar yükleyin
            //    model.Users = await _context.Users.ToListAsync();
            //    model.Events = await _context.Events.ToListAsync();
            //    return View(model);
            //}

            try
           {
                // UserService üzerinden çoklu kullanıcı için etkinlik kaydı oluştur
                await _userService.CreateUserEventsAsync(model.SelectedUserIds, model.EventId, model.EventDate);
                await _userService.CheckAndAssignBadgesAsync(model.SelectedUserIds, model.EventId,model.EventDate);
                TempData["SuccessMessage"] = "Etkinlik kaydi basariyla olusturuldu.";
                return RedirectToAction("ListEventsWithUsers");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                model.Users = await _context.Users.ToListAsync();
                model.Events = await _context.Events.ToListAsync();
                TempData["Fail"] = "Etkinlik kaydi olusturulamadi.Kullanici secilmedi!!";
                return View(model);
            }
        }

        // Silme işlemi
        [HttpPost]
        public async Task<IActionResult> DeleteEvent(Guid id)
        {
            var userEvent = await _context.UserEvents.FindAsync(id);
            if (userEvent == null)
            {
                TempData["SuccessMessage"] = "Etkinlik bulunamadı!";
                return RedirectToAction("ListEventsWithUsers");
            }

            _context.UserEvents.Remove(userEvent);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Etkinlik başarıyla silindi!";
            return RedirectToAction("ListEventsWithUsers");
        }
    }
}
