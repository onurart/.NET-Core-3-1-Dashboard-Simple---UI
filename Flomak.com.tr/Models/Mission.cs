using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flomak.com.tr.Models
{
    public class Mission
    {
        [Key]
        public int ID { get; set; }
        public string Hood { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }



    }
}
