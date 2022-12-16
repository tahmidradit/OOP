using System;

namespace OOP_CSharp.Polymorphism
{
    public class Brand : Mobile
    {
        public string[] BrandName = { "NOKIA", "SAMSUNG", "OnePlus", "Redmi", "XIAOMI" };
        public Brand()
        {
            Console.WriteLine("Brand Name: " + BrandName[0]);   
        }
    }
}
