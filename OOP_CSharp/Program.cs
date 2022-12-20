using OOP_CSharp.Inheritance;
using OOP_CSharp.MethodOverriding;
using OOP_CSharp.Polymorphism;
using OOP_CSharp.SwitchCase;

namespace OOP_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Method Overriding
            Student student = new Student();
            student.Print(34, "Radit, Tahmid", "CSE");
            
            //Inheritance
            Employee employee = new Employee();

            //Polymorphism
            Mobile brand = new Brand();
            Mobile specification = new Specification();

            //Switch-case
            MarksGrade marksGrade = new MarksGrade();   
        }
    }
}
