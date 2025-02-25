using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_EFCore
{
    class Instructor
    {

        public int id { get; set; }

        public required string name { get; set; }

        public decimal Bonus { get; set; }

        public decimal Salary { get; set; }

        [MaxLength(50)]
        public required string address { get; set; }

        public decimal HourRate { get; set; }

        public int Dept_id { get; set; }
    }
}
