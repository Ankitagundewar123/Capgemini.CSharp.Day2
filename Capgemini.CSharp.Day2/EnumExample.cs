using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class EnumExample
    {
        enum Fruits
        {
            Apple = 123,
            Banana = 456,
            Pears ,
            Orange = 47,
            Grapes
        }

        static void Main(string[] args)
        {
            foreach (var f1 in Enum.GetValues(typeof(Fruits)))
            {
                Console.WriteLine(f1);
            }

            foreach (int f1 in Enum.GetValues(typeof (Fruits)))
            {
                Console.WriteLine(f1);
            }
            


        }





    }
}
