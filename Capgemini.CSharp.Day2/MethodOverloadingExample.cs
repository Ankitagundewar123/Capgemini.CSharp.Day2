using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class Employee
    {
        string Name, City, MobileNo;
        double Salary;
        DateTime BirthDate;

        public void AcceptEmployeeDetails(string name,string city)
        {
            Name = name;    
            City = city;
        }

        public void AcceptEmployeeDetails(string name)
        {
            Name=name;
        }

        public void AcceptEmployeeDetails(string name , double salary)
        {
            Name= name;
            salary = salary;
        }

        public void AcceptemployeeDetails(string name , string mobileNo)
        {


        }

        public void print()
        {
            Console.WriteLine($"--Employee Details--");
            Console.WriteLine($"Name:{Name}\tCity:{City}\tMobileNo:{MobileNo}\tBirthDate:{BirthDate});
        }
       

    }
}
