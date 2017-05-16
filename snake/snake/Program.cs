using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Drow();

            Point p2 = new Point(14, 15, '#');
            p2.Drow();

            Point p3 = new Point(26, 16, '$');
            p3.Drow();

            Point p4 = new Point(38, 12, '&');
            p4.Drow();

            Point p5 = new Point(57, 18, '%');
            p5.Drow();

            Point p6 = new Point(34, 17, '^');
            p6.Drow();

            List<Point> newpList = new List<Point>
            {
                p3,
                p4,
                p5,
                p6
            };
            //newpList.Add(p3);
            //newpList.Add(p4); 
            //newpList.Add(p5);
            //newpList.Add(p6);



            List<char> symList = new List<char>();
            symList.Add('*');
            symList.Add('#');
            symList.Add('%');


            char a = symList[0];
            char b = symList[2];
            char c = symList[1];

            foreach (char i in symList)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //Console.WriteLine("c = " + c);

            List<int> numList = new List<int>();
            numList.Add(3);
            numList.Add(11);
            numList.Add(32);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
    }
}