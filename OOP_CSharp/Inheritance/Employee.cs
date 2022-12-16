using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp.Inheritance
{
    public class Employee : Department
    {
        private int Id = 2;
        private string Name = "Tahmid Radit";
        public Employee() 
        {
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("DepartmentId: " + DepartmentId);
            Console.WriteLine("DepartmentName: " + DepartmentName + "\n");
        }
    }
}
