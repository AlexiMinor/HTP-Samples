using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Murzik", 3, Color.Grey, true);
            var str = new SpecialStructure(){Value = "value", Number = 1111};

            var bf = new BinaryFormatter();

            using (var fs = new FileStream(@"C:\Users\AlexiMinor\Desktop\111\cat2.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, cat);
            }

            using (var fs = new FileStream(@"C:\Users\AlexiMinor\Desktop\111\cat2.txt", FileMode.OpenOrCreate))
            {
                var deserializedCat = (Cat) bf.Deserialize(fs);
                Console.WriteLine($"{deserializedCat.Name} - {deserializedCat.Color} - {deserializedCat.Age}");
            }

            using (var fs = new FileStream(@"C:\Users\AlexiMinor\Desktop\111\struct.data", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, str);
            }
            using (var fs = new FileStream(@"C:\Users\AlexiMinor\Desktop\111\struct.data", FileMode.OpenOrCreate))
            {
                var deserializedCat = (SpecialStructure)bf.Deserialize(fs);

            }

            Do(cat);
        }

        static void Do(Animal animal)
        {
            var bf = new BinaryFormatter();

            using (var fs = new FileStream(@"C:\Users\AlexiMinor\Desktop\111\animal.data", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, animal);
            }

            using (var fs = new FileStream(@"C:\Users\AlexiMinor\Desktop\111\animal.data", FileMode.OpenOrCreate))
            {
                var deserializedCat = (Animal)bf.Deserialize(fs);
                Console.WriteLine($"{deserializedCat.Age}");
            }

        }
    }

}
