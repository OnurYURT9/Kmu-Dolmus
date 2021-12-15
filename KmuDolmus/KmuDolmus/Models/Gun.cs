using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace KmuDolmus.Models
{
    public class Gun
    {
        [Key]
        public int GunId { get; set; }
        public string GunAd { get; set; }
        public List<Hatlar> Hatlars { get; set; }
    }
}