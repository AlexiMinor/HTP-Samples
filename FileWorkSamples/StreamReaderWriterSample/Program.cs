using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderWriterSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string pathForNewFile = @"C:\Users\AlexiMinor\Desktop\123\444.txt";

            string data = "Hello World!";

            try
            {
                await using (StreamWriter sw = new StreamWriter(pathForNewFile, false, Encoding.UTF8))
                {
                    await sw.WriteAsync(data);
                }

                var isEnd = false;
                while (!isEnd)
                {
                    var userInput = Console.ReadLine();

                    await using (StreamWriter sw = new StreamWriter(pathForNewFile, true, Encoding.UTF32))
                    {
                        await sw.WriteLineAsync("append text");
                        await sw.WriteLineAsync(userInput);
                    }
                    
                    Console.WriteLine("Do you want to continue? y/n");
                    isEnd  = Console.ReadLine().ToLowerInvariant().Equals("n");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


            try
            {
                using (var sr = new StreamReader(pathForNewFile))
                {
                    Console.WriteLine(await sr.ReadToEndAsync());
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
