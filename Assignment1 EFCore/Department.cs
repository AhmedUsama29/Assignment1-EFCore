using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_EFCore
{
    class Department
    {

        public int id { get; set; }

        public string name { get; set; }

        public DateOnly HiringDate { get; set; }

        public int ins_id { get; set; }
    }
}
