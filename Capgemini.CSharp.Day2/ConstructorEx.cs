using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class ConstructorEx
    {
        //member variables or Instance variables
        public int Id, Age;
        public string Name;

        //constant variables cannot be changed / modified
        //public const float PI = 3.14 f ;
        public const float salary = 45000.78f;

        //Readonly variables


        //static variables
        public static string city = "NA";
         
        //Explicit default constructor 

        public ConstructorEx()
        {
            Id = 1001;
            Age = 40;
            Name = "Test";

        }


        ~ConstructorEx()
        {
            Console.WriteLine("Destructor Called");
        }

        public void print()
        {
            //int pid = 10001;  //method level variable
            Console.WriteLine($"Id : {Id}\tName :{Name}\tAge : {Age}");
        }

        static void Main(string[] args)
        {
            //classname objectname = new DefaultConstructor() ;  //new - used to allocate the new memry
            ConstructorEx c1 = new ConstructorEx();
            c1.Id = 1002;
            c1.print();
            
            ConstructorEx c2 = new ConstructorEx();
            c2.Id = 1006;
            //c2.print();

            //static variable
            Console.WriteLine($"Static variable ; {ConstructorEx.city}");
            ConstructorEx.city = "Mumbai";
            Console.WriteLine($"Static ariable : {ConstructorEx.city}");

            TestClass t1 = new TestClass();
           // t1.TestMethod();

            //constant variables
            //salary = 78900.0f
            Console.WriteLine($"Constant.Variabale :{ConstructorEx.salary}");
        }
    }

    class TestClass
    {

        public void Testmethod()
        {
            ConstructorEx c1 = new ConstructorEx();
            c1.print();

            Console.WriteLine($"static variablr in TestClass: {ConstructorEx.city}");
        }
    }



}


