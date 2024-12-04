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
        public async Task<IActionResult> BestOfs()
        {

            return View();

        }
     


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Yeni kullanýcý oluþturma
            var user = new AppUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                Age = model.Age,
                ImageUrl = model.ImageUrl,
                Score = 0 // Varsayýlan baþlangýç puaný

            };

            // Kullanýcýyý kaydetme
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // Yeni kullanýcýya "User" rolünü atama
                await _userManager.AddToRoleAsync(user, "User");

                TempData["SuccessMessage"] = "Kayit basarili!";
                return RedirectToAction("Login", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
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
                return View(request); // Geçersiz model durumunda tekrar giriþ sayfasýný gösterir.
            }

            AppUser? appUser = await _userManager.Users
                .FirstOrDefaultAsync(p => p.Email == request.UserNameOrEmail || p.UserName == request.UserNameOrEmail, cancellationToken);

            if (appUser is null)
            {
                ModelState.AddModelError(string.Empty, "Kullanýcý bulunamadý");
                return View(request); // Kullanýcý bulunamadýðýnda hata mesajýyla giriþ sayfasýný gösterir.
            }

            bool result = await _userManager.CheckPasswordAsync(appUser, request.Password);
            if (!result)
            {
                ModelState.AddModelError(string.Empty, "Þifre yanlýþ");
                return View(request); // Þifre yanlýþsa hata mesajýyla giriþ sayfasýný gösterir.
            }

            // Kullanýcý baþarýyla giriþ yaptýysa
            await _signInManager.SignInAsync(appUser, isPersistent: false);

            // Kullanýcýnýn rolünü kontrol et
            bool isAdmin = await _userManager.IsInRoleAsync(appUser, "Superadmin");
            if (isAdmin)
            {
                return RedirectToAction("Index", "Admin"); // Eðer kullanýcý Admin ise Admin sayfasýna yönlendir
            }

            return RedirectToAction("Index", "Home"); // Kullanýcý Admin deðilse ana sayfaya yönlendir
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
