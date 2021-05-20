using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flomak.com.tr.Models
{
    public class Context:DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Services> Services  { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<FlomakSector> FlomakSectors { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
