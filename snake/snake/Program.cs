﻿using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Drow();

            Point p2 = new Point(4, 5, '#');
            p2.Drow();
                       
            Console.ReadLine();
        }

    }
}