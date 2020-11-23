using System.Collections.Generic;
using System.IO;

namespace HomeWorkOOPSample.Creator
{
    public static class FileReader
    {
        public static CarInfoFromFile[] ReadFile(string path)
        {
            var strings = File.ReadLines(path);
            var list = new List<CarInfoFromFile>();

            foreach (var s in strings)
            {
                var data = s.Split(',');
                list.Add(new CarInfoFromFile() {Manufacturer = data[0], Model = data[1]});
            }

            return list.ToArray();
        } 
    }

    public struct CarInfoFromFile
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}