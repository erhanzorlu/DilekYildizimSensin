using DilekYildizimSensin.Dtos;
using DilekYildizimSensin.Models;
using DilekYildizimSensin.Services.Abstracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace DilekYildizimSensin.Controllers
{
    public class HomeController : Controller
    {
       private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;

        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            AppUserDto appUserDto = null;

            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var appUser = await _userManager.Users
                    .Include(u => u.UserBadges)
                    .ThenInclude(ub => ub.Badge)
                    .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

                if (appUser != null)
                {
                    appUserDto = new AppUserDto
                    {
                        Id=appUser.Id,
                        FirstName = appUser.FirstName,
                        LastName = appUser.LastName,
                        Gender = appUser.Gender.ToString(),
                        Age = appUser.Age,
                        Score = appUser.Score,
                        ImageUrl = appUser.ImageUrl,
                        UserBadges = appUser.UserBadges
                            .Select(ub => new BadgeDto
                            {
                                BadgeName = ub.Badge.BadgeName,
                                BadgeIcon = ub.Badge.BadgeIcon
                            })
                            .ToList()
                    };
                }
            }

            var latestBadge =await _userService.GetLatestBadgeAsync(appUserDto.Id);
            var getTop5UsersByScoreAsync = await _userService.GetTop5UsersByScoreAsync();

            var indexViewModel = new IndexViewModel
            {
                AppUserDto = appUserDto,
                GetLatestBadgeAsync=latestBadge,
                GetTop5UsersByScoreAsync=getTop5UsersByScoreAsync
                
            };

            return View(indexViewModel);
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return View(request); // Ge�ersiz model durumunda tekrar giri� sayfas�n� g�sterir.
            }

            AppUser? appUser = await _userManager.Users
                .FirstOrDefaultAsync(p => p.Email == request.UserNameOrEmail || p.UserName == request.UserNameOrEmail, cancellationToken);

            if (appUser is null)
            {
                ModelState.AddModelError(string.Empty, "Kullan�c� bulunamad�");
                return View(request); // Kullan�c� bulunamad���nda hata mesaj�yla giri� sayfas�n� g�sterir.
            }

            bool result = await _userManager.CheckPasswordAsync(appUser, request.Password);
            if (!result)
            {
                ModelState.AddModelError(string.Empty, "�ifre yanl��");
                return View(request); // �ifre yanl��sa hata mesaj�yla giri� sayfas�n� g�sterir.
            }

            // Kullan�c� ba�ar�yla giri� yapt�ysa
            await _signInManager.SignInAsync(appUser, isPersistent: false);

            // Kullan�c�n�n rol�n� kontrol et
            bool isAdmin = await _userManager.IsInRoleAsync(appUser, "Superadmin");
            if (isAdmin)
            {
                return RedirectToAction("Index", "Admin"); // E�er kullan�c� Admin ise Admin sayfas�na y�nlendir
            }

            return RedirectToAction("Index", "Home"); // Kullan�c� Admin de�ilse ana sayfaya y�nlendir
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
