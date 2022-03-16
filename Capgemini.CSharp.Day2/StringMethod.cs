using System;

namespace Capgemini.CSharp.Day2
{
    internal class StringMethod
    {
        static void Main(string[] args)
        {
            String str = "Capgemini";

            Console.WriteLine($"Length : {str.Length}");

            //clone
            String s = str.Clone() as String;
            Console.WriteLine($"clone : {s}");


            //triming
            Console.WriteLine($"Remove Left space :{str.TrimStart()}");


            string str1 = "Good Morning Everyone";
            string[] test = str1.Split(' ');
            //foreach(string X in test)
           // {
            //    WriteLine(X+",");
            //}
            Console.WriteLine($"Join string using comma :{string.Join(',',test)}");


            //substring
            //"P0001"
            string Pid = "P0001";
            int id = int.Parse(Pid.Substring(1, 5));
            id++;
            Console.WriteLine($"New id : {"P0000" + id}");
            Console.WriteLine(id);
            Console.WriteLine(Pid + 1);
            Console.WriteLine($"str.substring(3, 6)");


            //padding
            Console.WriteLine($"Pad Left : {str.PadLeft(str.Length+2, '$')}");


           

        }
    }
}
