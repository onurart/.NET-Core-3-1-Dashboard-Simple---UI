using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flomak.com.tr.Models
{
    public class Services
    {
        [Key]
        public int ID { get; set; }

        public string Menu { get; set; }
        public string Image { get; set; }
        public string ServiceName { get; set; }
        public string ServiceExplanation { get; set; }




















    }
}
