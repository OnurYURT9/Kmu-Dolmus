using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Models
{
    public class Yon
    {
        [Key]
        public int YonId { get; set; }
        public string Yonad { get; set; }
        public List<Hatlar> Hatlars { get; set; }
    }
}
