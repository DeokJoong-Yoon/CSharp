﻿using System;

namespace COntinue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {
                if (i % 2 == 0)
                    continue;

                Console.WriteLine($"{i} : 홀수");
            }
        }
    }
}