using KmuDolmus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Controllers
{
    public class Uyelik : Controller
    {
        private readonly Context _context;

        public Uyelik (Context context)
        {
            _context = context;
        }
          
           

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Uyeol()
        {
            return View();
        }
        public async Task<IActionResult> Register(Kullanici model)
        {
          await _context.AddAsync(model);
            await _context.SaveChangesAsync();
            return Redirect("Index");
        }
    }
}
