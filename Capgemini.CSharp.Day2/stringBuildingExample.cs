using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class stringBuildingExample
    {
        static void Main(string[] args)
        {
            //string is immatable , stringbuilder is mutable
            //string X = "abc" ;//x1001
            //x="1234";//x1008
            //x+="abcd";//x10010

            //hi - x11
            //hi good morning //x13

            //hi good morning good night //x18

            //x1001
            //8 character -space
            //16 character 
            //32

            StringBuilder sb = new StringBuilder();
            String msg;
            do
            {
                Console.WriteLine("enter your messange : ");
                msg = Console.ReadLine();
                sb.Append(msg);
            } while (msg.ToLower() == "no");
            Console.WriteLine(sb.ToString());

        }
    }
}
