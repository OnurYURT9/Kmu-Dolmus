using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Models
{
    public class Kullanici
    {
        [Key]
        public int kullanici_id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string email { get; set; }
        public string kullanici_sifre { get; set; }

    }
}
