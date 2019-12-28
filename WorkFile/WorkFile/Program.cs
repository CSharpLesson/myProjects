using static System.Console;
using System.IO;

namespace WorkFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop";
            DirectoryInfo drives = new  DirectoryInfo(path);
            if (drives.Exists)
            {
                string a = @"C:\Users\User\Desktop\1.txt";
                
                string[] direct = Directory.GetFiles(path);
                foreach (var dir in direct)
                {
                    WriteLine(dir);
                    if (dir.EndsWith(".txt"))
                    {
                       
                                               
                    }
                }

            }
            //foreach (var item in drives)
            //{
            //    //WriteLine(item.Name);
            //    //WriteLine(item.DriveType);
            //    //if (item.IsReady)
            //    //{
            //    //    WriteLine($"Объем диска: {item.TotalSize}");
            //    //    WriteLine($"Свободное пространство: {item.TotalFreeSpace}");
            //    //    WriteLine($"Метка: {item.VolumeLabel}");
            //    //}
            //}
        }
    }
}
