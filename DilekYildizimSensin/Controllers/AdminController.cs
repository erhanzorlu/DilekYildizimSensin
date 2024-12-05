using DilekYildizimSensin.Dtos;
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


        public async Task<IActionResult> MonthlyUserScores(int? year, int? month)
        {
            // Eğer yıl ve ay belirtilmemişse, geçerli yıl ve ayı kullan
            var selectedYear = year ?? DateTime.Now.Year;
            var selectedMonth = month ?? DateTime.Now.Month;

            // Seçilen ay ve yıla göre kullanıcıların puanlarını getir
            var monthlyUserScores = await _context.UserEvents
                .Where(ue => ue.Year == selectedYear && ue.Month == selectedMonth)
                .GroupBy(ue => ue.AppUserId)
                .Select(g => new MonthlyUserScoreViewModel
                {
                    UserId = g.Key,
                    UserName = _context.Users
                                .Where(u => u.Id == g.Key)
                                .Select(u => u.FirstName + " " + u.LastName)
                                .FirstOrDefault(),
                    MonthlyScore = g.Sum(ue => ue.Score ?? 0)
                })
                .ToListAsync();

            // View'e yıl ve ay bilgilerini de gönder
            ViewData["SelectedYear"] = selectedYear;
            ViewData["SelectedMonth"] = selectedMonth;

            return View(monthlyUserScores);
        }





        // Kullanıcı etkinliklerini listeleme ve filtreleme
        public async Task<IActionResult> ListUserEvents(string searchTerm = null)
        {
            // UserEvents tablosunda sorgu başlat
            var query = _context.UserEvents
                .Include(ue => ue.AppUser) // Kullanıcı bilgilerini dahil et
                .Include(ue => ue.Event)  // Etkinlik bilgilerini dahil et
                .AsQueryable();

            // Eğer bir arama kriteri varsa, ad ve soyada göre filtreleme yap
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(ue =>
                    ue.AppUser.FirstName.Contains(searchTerm) ||
                    ue.AppUser.LastName.Contains(searchTerm));
            }

            // Sorguyu çalıştır ve sonuçları tarihe göre sırala
            var userEvents = await query
                .OrderByDescending(ue => ue.EventDate) // Tarihe göre sıralama
                .ToListAsync();

            // Arama kriterini view'da göstermek için ViewData kullan
            ViewData["SearchTerm"] = searchTerm;

            return View(userEvents);
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
                return RedirectToAction("ListUserEvents");
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
                return RedirectToAction("ListUserEvents");
            }

            _context.UserEvents.Remove(userEvent);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Etkinlik başarıyla silindi!";
            return RedirectToAction("ListUserEvents");
        }
    }
}
