using DilekYildizimSensin.Dtos;
using DilekYildizimSensin.Models;
using DilekYildizimSensin.Services.Abstracts;
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


      


        [HttpGet]
        public async Task<IActionResult> ListEventsWithUsers()
        {
            var events = await _userService.ListUserEventsAsync();
            return View(events);
        }


        [HttpGet]
        public async Task<IActionResult> SearchUsers(string searchTerm)
        {
            var users = string.IsNullOrEmpty(searchTerm)
                ? new List<AppUser>()
                : await _userService.SearchUsersAsync(searchTerm);

            var result = users.Select(u => new { u.Id, u.FirstName, u.LastName, u.Email }).ToList();

            return Json(result);
        }


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
