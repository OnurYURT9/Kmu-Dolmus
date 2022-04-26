using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Models
{
    public class Durak
    {
        [Key]
        public int DurakID { get; set; }
        public string Durakad { get; set; }
        public int Koordinat { get; set; }
        public List<Guzergah_Durak> GuzergahDuraks { get; set; }
    }
}
