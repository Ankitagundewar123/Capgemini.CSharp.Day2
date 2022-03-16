
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    public class AccessSpecifier
    {
        public string UserId;
        internal string City;
        protected internal string Country;

       internal AccessSpecifier()
        {

        }
    }

    class Testclass1 
    {
        static void Main(string[] args)
        
        {
            AccessSpecifier obj = new AccessSpecifier();
            obj.UserId = "Admin";
            obj.City = "Mumbai";
            obj.Country = "India";
        }
    }

    
}
