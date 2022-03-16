using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class EqualsExample
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "Hello1";
            Object str3 = str2.Substring(0, 5);
            Console.WriteLine(str3);
            
            Console.WriteLine($"Equals :(str.Equals(str3)");
            Console.WriteLine($"== :(str == str3)");
        }
    }
}
