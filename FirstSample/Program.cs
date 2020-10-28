using System;

namespace FirstSample
{
    class Program
    {
        static void Main(string[] args)
        {

            //////Logical literals
            //Console.WriteLine(true);
            //Console.WriteLine(false);

            ////// Integer 
            //Console.WriteLine(1);
            //Console.WriteLine(-15);
            //Console.WriteLine(156776767667);
            //Console.WriteLine(0b111);//7
            //Console.WriteLine(0x12AF);

            //////real literals
            //Console.WriteLine(1.15);
            //Console.WriteLine(-2.14);
            //Console.WriteLine(3.2e45);

            //////symbol literals
            //Console.WriteLine('a');
            //Console.WriteLine('\n'); // перенос строки
            //Console.WriteLine('\t'); // табуляция
            //Console.WriteLine('\\'); // обратный слэш

            //Console.WriteLine('\x78'); // x
            //Console.WriteLine('\u0420'); // Р/С

            ////string literals 
            //Console.WriteLine("Hello World \x78");
            //Console.WriteLine();
            
            //Console.WriteLine("Hello \nWorld");
            //Console.WriteLine();
            
            //Console.WriteLine("Hello \tWorld");
            //Console.WriteLine();

            //Console.WriteLine("Company \"Horns & Hooves\""); //Company "Horns & Hooves"

            //variables 
            bool unknown;
            bool isAlive = true;
            bool isDead = false;

            // 1 byte = 8 bit => 8 разрядов 0000 0000 - 1111 1111 
            byte x = 1; //0 - 255
            byte xa = 2; //0 - 255

            sbyte y = -100; //-128 - 127 

            short a; //-32768 - 32767  2byte
            ushort b; //0 - 65535

            int i; // -2147483648 - 2 147 483 647 4 byte

            long l; // –9 223 372 036 854 775 808  –9 223 372 036 854 775 807 8 byte

            int xaa = 1000000;
            int xbb = 2000000;

            double zx = xaa * xbb;
            Console.WriteLine(zx);

            float fl; //-3.4*10^28 - 3.4*10^28

            double d;//+-5*10^-324 - +-1.7*10^308

            decimal dec;

            object obj = 15;
            object obj2 = "15";
            object obj3 = '1';
        }
    }
}
