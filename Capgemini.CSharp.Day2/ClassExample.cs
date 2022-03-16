using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class ClassExample
    {
        //member Variable
        int Id;
        string Name;
        Double salary;

        //Member method / function 

        public void store()
        {
            Id = 1001;
            Name = "Kumar";
            salary = 4555.66;

        }
    }

    struct StructExample
    {
        public int Id;
        public string Name;
        public double salary;
    }

    class ExecuteClass
    {



        static void main(string[] args) //entry point
        {
            ClassExample obj;
            //obj.store();
            //Console.WriteLine($"id : {obj.Id}\tName : {obj.Name}\tsalary : {obj.salary}");

            //struct
            StructExample obj2;
            obj2.Id = 1002;
            obj2.Name = "Ankita";
            obj2.salary = 7888;


        }
    }
}
