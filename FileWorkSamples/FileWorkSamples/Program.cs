using System;
using System.IO;
using System.Text;

namespace FileWorkSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var drives = DriveInfo.GetDrives();

            //foreach (var driveInfo in drives)
            //{
            //    Console.WriteLine($"{driveInfo.Name} - {driveInfo.RootDirectory} - {driveInfo.DriveType} - {driveInfo.DriveFormat} - {driveInfo.TotalSize} - {driveInfo.TotalFreeSpace}");
            //}

            //var path = @"C:\"; 
            //var directoryInfo = new DirectoryInfo(path);

            //var directories = directoryInfo.GetDirectories();
            //var files = directoryInfo.GetFiles();


            //var path2 = @"C:\12";
            //var directoryInfo2 = new DirectoryInfo(path2);

            //directoryInfo2.Create();

            var path = @"C:\Users\AlexiMinor\Desktop\123\";
            var files = new DirectoryInfo(path).GetFiles();

            var fi = files[0];

            var newFile = new FileInfo(path + "222.txt");

            if (newFile.Exists)
            {
                return;
            }
          
            var data = File.ReadAllText(path + "1111.txt", Encoding.UTF8);
            
            File.WriteAllText(path + "222.txt", data, Encoding.UTF8);


            var x = 0;
        }
    }
}
