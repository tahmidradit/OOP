using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp.MethodOverriding
{
    public class Student : Course
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Department { get; set; }
        public override void Print(int StudentId, string StudentName, string Department)
        {
            base.Print(1,"OOP 2", "CSC 3115");
            Console.WriteLine("Student Id: " + StudentId);
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine($"Department: {Department} \n");
        }
    }
}
