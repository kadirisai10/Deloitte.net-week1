using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstExample
{
    //POCO classes
    //plain old CLR objects
    class EmplyoeeInfo
    {
        [Key]//primary key in table
        public int EmpID { get; set; }
        [Required]//not null in table
        public string name { get; set; }

        [Required]
        public string dept { get; set; }

        [Required]
        [Range(minimum:10000,maximum:50000,ErrorMessage ="salary between 10000 and 50000")]
        public double salary { get; set; } //manage nu get packages(download Entity framework)

    }
}
