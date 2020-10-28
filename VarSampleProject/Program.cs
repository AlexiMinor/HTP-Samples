using System;
using System.Collections.Concurrent;

namespace VarSampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //int y = 10 + 5; //15
            //Console.WriteLine(y);

            //int z = x - 5;//5
            //Console.WriteLine(z);

            //long a = x * y;
            //Console.WriteLine(a);
            //double b = x / 4.0; //2.5
            //double d = 10.0 / 4; //2.5
            //Console.WriteLine(b);
            //Console.WriteLine(d);

            //double c = x % 3.0;//1
            //Console.WriteLine(c);

            //int x1 = 10;
            //int y1 = ++x1; // x1 = 11, y1 =11;

            //Console.WriteLine($"{x1} - {y1}");

            //int x2 = 10;
            //int y2 = x2++; 
            //Console.WriteLine($"{x2} - {y2}");


            //int a = 10;
            //int b = 5;
            //int c = 150;

            //int d = (c--) - b * a; 

            int a = 10;

            int b = 5;


            //b += a; //=> b = b + a;
            //b -= a; //=> b = b + a;
            //b *= a; //=> b = b + a;
            //b /= a; //=> b = b + a;
            //b %= a; //=> b = b + a;

            int c = (a += (b -= 5)); //10


            //// _________________
            //b &= a; //=> b = b + a;
            //b |= a; //=> b = b + a;
            //b <<= a; //=> b = b + a;
            //b >>= a; //=> b = b + a;
        }
    }
}
