using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KmuDolmus.Models;
namespace KmuDolmus.Controllers
{
    public class KonumGuzergah : Controller
    {
        Context a = new Context();
        public IActionResult Index()
        {
            var degerler = a.Duraks.ToList();
                return View(degerler);
        }
    }
}
