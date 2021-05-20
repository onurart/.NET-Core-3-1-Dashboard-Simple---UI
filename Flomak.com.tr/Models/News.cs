using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flomak.com.tr.Models
{
    public class News
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime History { get; set; }
        public string Image { get; set; }
    }
}
