using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Models
{
    public class harita
    {
        [Key]
        public int HaritaID { get; set; }
        public string Adres { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string Aciklama { get; set; }

        public List<harita> haritas { get; set; }
    }
}
