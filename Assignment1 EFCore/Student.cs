using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_EFCore
{
    class Student
    {
        public int id { get; set; }
        public required string FName { get; set; }
        public required string LName { get; set; }
        public string? Address { get; set; }
        public short? Age { get; set; }
        public int Dep_id { get; set; }

    }
}
