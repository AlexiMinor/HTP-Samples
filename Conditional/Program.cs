using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;

            bool c1 = a == b;//false
            bool c2 = a != b;//true
            bool c3 = a < b;
            bool c4 = a > b;
            bool c5 = a <= b;
            bool c6 = a >= b;
            //_______________________________

            bool x = (5 > 6) | (4 < 6); // if left or right is true
            bool y = (5 > 6) | (4 > 6);
            Console.WriteLine(x);
            Console.WriteLine(y);

            bool x1 = (5 > 6) || (4 < 6); // if left or right is true
            bool y1 = (5 > 6) || (4 > 6);
            Console.WriteLine(x1);
            Console.WriteLine(y1);

            bool q = (5 > 6) & (4 < 6); // if left and right are true -> true
            bool p = (5 < 6) & (4 < 6);
            Console.WriteLine(q);
            Console.WriteLine(p);
            
            bool q1 = (5 > 6) && (4 < 6); // if left and right are true -> true
            bool p1 = (5 < 6) && (4 < 6);
            Console.WriteLine(q1);
            Console.WriteLine(p1);

            bool c = true;
            bool d = !c;//false


            bool q2 = (5 > 6) ^ (4 < 6); // if left or right is true, bot not both -> true
            bool p2 = (5 < 6) ^ (4 < 6); //-> false
            Console.WriteLine(q);
            Console.WriteLine(p);



            bool specValue = (4 < 6) | (5 > 6);
            // 4 < 6 -> true
            // 5 >  6 -> false
            // | -> true
            //spec value = true;

            bool specValue2 = (4 < 6) || (5 > 6);
            // 4 < 6 -> true
            // || -> true
            //spec value = true;
        }
    }
}
