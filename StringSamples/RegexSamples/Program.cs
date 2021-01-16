using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();


        }

        static void IsPasswordValide(string str)
        {//check 1 or more small latin char, 1 or more big latin char, 1 or more numeric symbol, 8+ lenght

            var regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,})$", RegexOptions.Compiled);//decimal digit

            /*
                ^ - начало строки 
                $ - конец строки
                . - любой одиночный символ
                * - предыдущий символ повторяется 0+ раз
                + - предыдущий символ повторяется 1+ раз
                ? - предыдущий символ повторяется 0 или 1 раз
                \\s - любой пробельный символ
                \\S - любой символ кроме пробельного
                \\w - любой алфавитно-цифровой символ
                \\W - любой символ кроме алфавитно-цифрового
                \\d - любая десятичная(0-9) цифра
                \\D - 
             */

            var result = regex.Matches(str);

            
        }
    }
}
