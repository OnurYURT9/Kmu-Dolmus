using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Models
{
    public class Guzergah_Durak
    {
        [Key]
        public int GuzergahdurakId { get; set; }
        public int GuzergahId { get; set; }
        public int DurakID { get; set; }
        public Guzergah Guzergah { get; set; }
        public Durak Durak { get; set; }
    }
}
