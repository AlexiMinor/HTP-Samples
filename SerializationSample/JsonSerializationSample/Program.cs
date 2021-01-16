using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace JsonSerializationSample
{
    class Program
    {
      
        static async Task Main(string[] args)
        {
            var folderPath = @"C:\Users\AlexiMinor\Desktop\111\";

            var dictionary = new Dictionary<Guid, Cat>
            {
                {
                    Guid.NewGuid(),
                    new Cat()
                    {
                        Name = "Murzik",
                        Age = 3,
                        Color = Color.Black,
                        Lives = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                        Symbol = 'a'
                    }
                },
                {
                    Guid.NewGuid(),
                    new Cat()
                    {
                        Name = "Barsik",
                        Age = 5,
                        Color = Color.White,
                        Lives = new[] {1, 2, 3, 4, 5, 6, 7,},
                        Symbol = 'b'
                    }
                }
            };


            await using (var fs = new FileStream(folderPath+"cat-collection.json", FileMode.OpenOrCreate))
            {
               var jsonString =  JsonConvert.SerializeObject(dictionary);
               await fs.WriteAsync(Encoding.UTF8.GetBytes(jsonString));
            }

            
            Thread.Sleep(2000);


            //var catCollection =
            //    JsonConvert.DeserializeObject<Dictionary<Guid, Cat>>(
            //        await File.ReadAllTextAsync(folderPath + "cat-collection.json"));

            using (var fs = File.OpenText(folderPath + "cat-collection.json"))
            {
                var jsonString = await fs.ReadToEndAsync();
                var catCollection2 = JsonConvert.DeserializeObject<Dictionary<string, Cat>>(jsonString);
            }

            var x = 0;

            //using (var fs = new FileStream(folderPath + "cat-collection.json", FileMode.OpenOrCreate))
            //{
            //    var deserializedCat = await JsonSerializer.DeserializeAsync<Dictionary<Guid, Cat>>(fs);

            //    var x = 0;
            //}

            //var json = JsonSerializer.Serialize(cat);

            //Console.WriteLine(json);

            //var deserializedCat = JsonSerializer.Deserialize<Cat>(json);

        }
    }
}
