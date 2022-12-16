using System;

namespace OOP_CSharp.Polymorphism
{
    public class Specification : Mobile
    {
        public string DisplayType = "IPS";
        public string PrimaryCamera = "48MP";
        public string Processor = "Mediatek";

        public Specification()
        {
            Console.WriteLine("Display Type: " + DisplayType);
            Console.WriteLine("Primary Camera: " + PrimaryCamera);
            Console.WriteLine("Processor: " + Processor + "\n");
        }
    }
}
