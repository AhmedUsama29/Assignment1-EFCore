using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_EFCore
{
    class Course
    {

        public int id { get; set; }

        public TimeOnly Duration { get; set; }

        public required string name { get; set; }

        public string? Description { get; set; }
        public int Top_id { get; set; }

    }
}
