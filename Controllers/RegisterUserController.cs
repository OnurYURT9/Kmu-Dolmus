using DocumentFormat.OpenXml.EMMA;
using KmuDolmus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Model = Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;


namespace KmuDolmus.Controllers
{
    using KmuDolmus.Models;
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        { 
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index (UserSignUpViewModel p)
        {
            Console.WriteLine(p.ToString());
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName, 
                    NameSurname = p.nameSurname
                };
                var result = await _userManager.CreateAsync(user, p.Password);
                if(result.Succeeded)
                {
                    /* await _userManager.AddAsync(Model);
                     _userManager.SaveChangesAsync();*/
                    
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }

                }
            }
            return View(p);
        }
    }
}
