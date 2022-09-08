using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    //subclass to product / Inheritance
    public class Book : Product
    {
        //default book constructor
        public Book()
        {
        }

        //add the Author property with getter and setter methods
        public string Author { get; set; }

        //constructor with parameters
        public Book(string author, string code, string description, decimal price) : base(code, description, price)
        {
            // Initializes the Author field after
            // the base class constructor is called.
            this.Author = author; 
        }

        //Override the GetDisplayText method to include Author
        public override string GetDisplayText(string sep) => $"Author: {Author}, {base.GetDisplayText(sep)}";
    }
}
