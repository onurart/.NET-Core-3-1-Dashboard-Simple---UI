using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flomak.com.tr.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryExplanation { get; set; }





    }
}
