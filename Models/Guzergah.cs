
using System;
using global::KmuDolmus.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace KmuDolmus.Models
{
    public class Guzergah
    {
        [Key]
        public int GuzergahId { get; set; }
        public string GuzergahAd { get; set; }
        public List<Guzergah_Durak> GuzergahDuraks { get; set; }
    }
}