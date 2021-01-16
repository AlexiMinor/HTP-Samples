using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace StreamSamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var path = @"C:\Users\AlexiMinor\Desktop\123\";
            var dirInfo = new DirectoryInfo(path);

            string textInFile;

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }


            await using (var fs = File.OpenRead(path+"1111.txt"))
            {
                var data = new byte[fs.Length];
                await fs.ReadAsync(data, 0, data.Length);

                string txt = System.Text.Encoding.UTF8.GetString(data);
                Console.WriteLine(txt);
                textInFile = txt;
            }

            await using (var fs = new FileStream(path + "222.dfma", FileMode.OpenOrCreate, FileAccess.Write))
            {
                var firstElements = "Hello World! ";
                var dataFromFile = System.Text.Encoding.UTF8.GetBytes(firstElements + Environment.NewLine + textInFile);
                await fs.WriteAsync(dataFromFile, 0, dataFromFile.Length);
            }

            var firstDataInBinaryFile = "Hello World! ";

            await using (var fs = new FileStream(path + "222.dfma", FileMode.Open, FileAccess.ReadWrite))
            {
                var prefixLenght = System.Text.Encoding.UTF8.GetBytes(firstDataInBinaryFile).Length;

                var data = new byte[System.Text.Encoding.UTF8.GetByteCount(Environment.NewLine + textInFile)];

                fs.Seek(prefixLenght, SeekOrigin.Begin);

                var dataInBinFile = await fs.ReadAsync(data);

                Console.WriteLine(System.Text.Encoding.UTF8.GetString(data));

                fs.Seek(prefixLenght, SeekOrigin.Begin);

                var newText = "Bye World";
                var dataFromFile = System.Text.Encoding.UTF8.GetBytes(newText);
                await fs.WriteAsync(dataFromFile);

                fs.Close();
            } 

            /* using (B) {
                A
            }*/

            /*
                try {
                    B
                    A
                }
                finally{
                    b.Dispose();
                }
             */

        }
    }
}
