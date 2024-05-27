using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SchoolModel
{
    internal class Teacher : Person
    {
        public List<string> Subjects { get; set; }

        public Teacher(string name, DateOnly dateOfBirth, List<string> subjects) : base(name, dateOfBirth)
        {
            Subjects = subjects;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + String.Join(", ", Subjects);
        }
    }
}
