using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"Emploee\nName: {Name}\nSurname: {Surname} Birth date: {BirthDate}\n" +
                $"Salary: {Salary}\n\n";
        }
    }
}
