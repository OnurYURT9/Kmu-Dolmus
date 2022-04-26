using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Controllers
{
    public class KonumGuzergah : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
