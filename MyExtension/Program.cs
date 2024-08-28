﻿using System;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtenstion
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; ++i)
            {
                result = result * myInt;
            }

            return result;
        }

        public static string Append(this string myString, string exponent)
        {
            return  myString + exponent;
        }
    }
}

namespace ExtenstionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}