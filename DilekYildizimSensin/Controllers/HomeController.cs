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

            // Yeni kullan�c� olu�turma
            var user = new AppUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                Age = model.Age,
                ImageUrl = model.ImageUrl,
                Score = 0 // Varsay�lan ba�lang�� puan�

            };

            // Kullan�c�y� kaydetme
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // Yeni kullan�c�ya "User" rol�n� atama
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
