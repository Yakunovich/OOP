using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int CompareTo(Product o)
        {
            Product p = o as Product;
            if (p != null)
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("These objects cannot compare");
        }
        public Product(string name,int price,string manufacturer)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
        }
        public override string ToString()
        {
            return $"{Name} {Price} {Manufacturer}" ;
        }
    }
}
