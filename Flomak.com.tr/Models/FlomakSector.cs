using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flomak.com.tr.Models
{
    public class FlomakSector
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string SectorName { get; set; }
        public string SectorCategory { get; set; }
        public string Label { get; set; }
        public string User { get; set; }
        public DateTime History { get; set; }
    }
}
