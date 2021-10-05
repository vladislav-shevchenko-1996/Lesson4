using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public enum CategoryType
    {

    }
    class Product
    {
        private readonly DateTime ManufactureDate;
        public Product()
        {
            this.ManufactureDate = DateTime.Now;
        }
        public string Name { get; set; }

        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        

        public override string ToString()
        {
            return $"Product\nName: {Name}\nCategory: {Category}\nPrice: {Price}\n" +
                $"Manufacture date: {ManufactureDate}\n\n";
        }
    }
}
