using KmuDolmus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Controllers
{
    public class HatController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Hatlars.Include(x=>x.Gun).ToList();
            return View(degerler);
        }
       
 
    }
}
