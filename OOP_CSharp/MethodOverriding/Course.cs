using System;

namespace OOP_CSharp.MethodOverriding
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }

        public virtual void Print(int Id, string Name, string CourseCode)
        {
            Console.WriteLine("Course Id: " + Id);
            Console.WriteLine($"Course Name: {Name}");
            Console.WriteLine($"Course Code: {CourseCode}");
        }
    }
}
