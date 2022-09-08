using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    //subclass to product / Inheritance
    public class Software : Product
    {
        //default software constructor
        public Software()
        {
        }

        //add the Version property with getter and setter methods
        public string Version { get; set; }

        //constructor with parameters
        public Software(string version, string code, string description, decimal price) 
            : base(code, description, price)
        {
            // Initializes the Version field after
            // the base class constructor is called.
            this.Version = version;
        }

        //Override the GetDisplayText method to include Version
        public override string GetDisplayText(string sep) => $"Version: {Version}, {base.GetDisplayText(sep)}";
    }
}
