using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var testString = "Test string for samples with string methods"; // "" != null
            var testString2 = "Test string"; // "" != null
            var testString3 = "for samples with string methods"; // "" != null
            var testString4 = "Test string for samples with string methods Test string Test string"; // "" != null

            var isEqual = testString.Equals(testString3);
            //strA, strB -> if strA<strB => -1
            var compareResult = testString2.CompareTo(testString3);
            var compareResult1 = string.Compare(testString2, testString3, StringComparison.CurrentCulture);
            var string4 = testString2.Concat(testString3);

            //bool
            var isSubstring = testString.Contains(testString2);
            var isSubstring2 = testString4.Contains("methods");
            var isStartWithSubstring = testString.StartsWith(testString2);
            var isEndWithSubstring = testString.EndsWith(testString2);

            var substring = testString.Substring(2,5);//get substring

            //____________________________________________

            
            var resultString = testString.Replace("string", "ABC");
            var tokenString =
                "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
            var chars = new[] {',', '.'};
            var words = tokenString.Split(chars);

            var testStringForTrim = "******* *****Test string for samples with string methods_________________"; // "" != null

            var trimmedString1 = testStringForTrim.Trim(' ', '*', '_');
            var removeAllSpaces = testStringForTrim.Replace(" ", "");

            

            //var trimmedString2 = trimmedString1.TrimStart('*', ' ');
            //var trimmedString3 = trimmedString2.TrimStart('_');


            
            Console.WriteLine("Hello World!");
        }
    }
}
