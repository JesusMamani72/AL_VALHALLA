
using AL_VALHALLA.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;


namespace AL_VALHALLA.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim("FullName", user.NombreCompleto),
                    new Claim(ClaimTypes.Role, user.Rol)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "CookieAuth");
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                if (user.Rol == "Administrador")
                {
                    return RedirectToAction("Index", "Administrador");
                }
                else if (user.Rol == "Recepcionista")
                {
                    return RedirectToAction("Index", "Recepcionista");
                }
            }

            ModelState.AddModelError("", "Correo o contraseña incorrecta");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
