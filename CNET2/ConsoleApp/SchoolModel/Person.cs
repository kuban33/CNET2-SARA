using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SchoolModel
{
    internal class Person
    {
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public Person(string name, DateOnly dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
            => $"Name: {Name}, DateOfBirth:{DateOfBirth.ToString("yyyy-MM-dd")}";
      
    }
}
