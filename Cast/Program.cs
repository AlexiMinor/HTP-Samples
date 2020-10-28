using System;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 4; //1byte
            //0000 0100
            short b = a;//2byte
            //0000 0000 0000 0100


            sbyte s = -7;//11111111
            short sh = s; //1111 1111 1111 1111

            sbyte s1 = 7;//0000 0111
            short sh1 = s; //0000 0000 0000 0111

            //0000000000000100
            short c = 4;
            //00000100
            byte d = (byte)c;

            try
            {
                int a1 = 33;
                int b1 = 150000;

                byte cc = checked((byte)(a1 + b1));
                Console.WriteLine(cc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
