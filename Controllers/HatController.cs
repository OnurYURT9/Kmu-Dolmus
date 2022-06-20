using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using KmuDolmus.Migrations;
using KmuDolmus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Controllers
{
    public class HatController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
           
        {
            List<SelectListItem> a = (from x in c.Guns.ToList()
                                      select new SelectListItem
                                      {
                                          Text = x.GunAd.Trim(),
                                          Value = x.GunId.ToString()
                                      }).ToList();
            ViewBag.v1 = a;

            var result = c.Hatlars.Include(x=>x.Gun);
            var result2 = result.Include(y =>y.Yon ).ToList();
            return View(result2);

        }
       


    }

}
