using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    //main product class
    public class Product
    {
        //default product constructor
        public Product()
        {
        }

        //constructor with parameters
        public Product(string code, string description, decimal price)
        {
            Code = code;
            Description = description;
            Price = price;
        }

        //get and set methods for properties / encapsulation
        public string Code {get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        //method to print text to the form
        public virtual string GetDisplayText(string sep) => $"{Code}{sep}{Description}{sep}{Price:C}";
    }
}
