using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    class Employee
    {
        int EmpID;
        string Name;
        string City;
        public Employee()
        {
        }
        public Employee(int EmpID, string Name)
        {
            this.EmpID = EmpID;
            this.Name = Name;
        }
        public Employee(int EmpID, string Name, string City) : this(EmpID, Name)
        {
            this.City = City;
        }
        public void Display()
        {
            Console.WriteLine("Employee ID: " + EmpID);
            Console.WriteLine("Employee Name: " + Name);

        }
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "john", "rjkt");
            e1.Display();

            Employee e2 = new Employee(2, "hello");
            e2.Display();
        }
    }
}
