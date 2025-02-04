using System;
namespace AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"Name: {a.Name}, Age : {a.Age}");
        }
    }
}