using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int? Instructorid { get; set; }

        [InverseProperty(nameof(Instructor.ManagedDepartment))]
        [ForeignKey("Instructorid")]
        public Instructor Manager { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
    }
}
