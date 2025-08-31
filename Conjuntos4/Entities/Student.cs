using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos4.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public HashSet<Course> Courses { get; set; } = new HashSet<Course>();

        public Student(int id)
        {
            Id = id;
        }
        
        public override int GetHashCode() 
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = (Student)obj;

            return Id.Equals(other.Id);
        }
    }
}
