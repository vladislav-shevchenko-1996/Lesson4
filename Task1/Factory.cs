using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Factory
    {
        private Employee[] Employees;
        private Product[] Products;
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Factory\nName: {Name}\n\n";
        }
    }
}
