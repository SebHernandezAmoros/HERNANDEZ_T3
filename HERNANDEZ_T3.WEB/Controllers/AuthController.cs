using HERNANDEZ_T3.WEB.DB;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HERNANDEZ_T3.WEB.Controllers
{
    public class AuthController : Controller
    {
        private DbEntities dbEntities;
        public AuthController(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            if (dbEntities.Empleados.Any(o => o.Usuario == Username && o.Clave == Password))
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, Username),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("ViewList", "Mascota");
            }

            ModelState.AddModelError("AuthError", "Usuario y/o contraseña incorrecta");
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            return View();
        }
    }
}
