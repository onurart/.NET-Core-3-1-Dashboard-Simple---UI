using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flomak.com.tr.Models
{
    public class Sector
    { 
        [Key]
        public int ID { get; set; }
        public string SectorName  { get; set; }
        public string TextTitle { get; set; }
        public string TextExplanation { get; set; }
        public string SectorImage { get; set; }
    }
}
