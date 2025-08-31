using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos4.Entities
{
    internal class Course
    {
        public string Name { get; set; }

        public Course(string name)
        {
            Name = name;
        }
    }
}
