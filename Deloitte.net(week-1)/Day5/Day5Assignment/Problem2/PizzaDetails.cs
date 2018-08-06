using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class PizzaDetails
    {
        [Key]
        public int PizzaID { get; set; }
        [Required]
        public string PizzaName { get; set; }
        [Required]
        public string Toppings { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public char Size { get; set; }
        [Required] [Range(minimum:100,maximum:5000 ,ErrorMessage ="Range should be between 100 and 5000")]
        public double Price { get; set; }

    }
}




