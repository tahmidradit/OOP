using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp.SwitchCase
{
    public class MarksGrade
    {
        public MarksGrade()
        {
            CheckGrade();
        }
        public void CheckGrade()
        {
            Console.Write("Enter grade: ");
            int mark = int.Parse(Console.ReadLine());

            switch (mark)
            {
                case 90:
                    Console.WriteLine("{0} : A+ ", mark);
                    break;
                case 80:
                    Console.WriteLine("{0} : B+", mark);
                    break;
                case 70:
                    Console.WriteLine("{0} : C+", mark);
                    break;
                case 60:
                    Console.WriteLine("{0} : D+", mark);
                    break;
                case 50:
                    Console.WriteLine("{0} : D", mark);
                    break;
                default:
                    Console.WriteLine("{0} : Error.Try again with round figure marks for this time only.", mark);
                    break;
            }
        }
    }
}
