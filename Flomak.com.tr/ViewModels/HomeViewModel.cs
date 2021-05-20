using Flomak.com.tr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flomak.com.tr.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Missions = new Mission();
            News = new List<News>();
            Services = new List<Services>();
            Sectors = new List<Sector>();
            FlomakSectors = new List<FlomakSector>();
            References = new List<Reference>();
            Sliders = new List<Slider>();
        }
        public Mission Missions { get; set; }
        public IEnumerable<News> News { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Services> Services { get; set; }
        public IEnumerable<Sector> Sectors { get; set; }
        public IEnumerable<FlomakSector> FlomakSectors { get; set; }
        public IEnumerable<Reference> References { get; set; }
    }
}