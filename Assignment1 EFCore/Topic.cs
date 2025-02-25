using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_EFCore
{
    class Topic
    {

        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
