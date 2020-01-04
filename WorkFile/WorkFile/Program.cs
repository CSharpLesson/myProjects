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
            if (!drives.Exists)
            {
                drives.Create();
                //string a = @"C:\Users\User\Desktop\1.txt";

                //string[] direct = Directory.GetFiles(path);
                //foreach (var dir in direct)
                //{
                //    WriteLine(dir);
                //    if (dir.EndsWith(".txt"))
                //    {                        
                //    }//}            
            }
            string text = ReadLine();
                
                // запись в файл
                using (FileStream file = new FileStream($"{path}\\note.txt", FileMode.OpenOrCreate))
                {
                    // преобразуем строку в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    // запись массива байтов в файл
                    file.Write(array, 0, array.Length);
                    WriteLine("Текст записан в файл");
                };
            using (FileStream fstream = File.OpenRead($"{path}\\note.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                WriteLine($"Текст из файла: {textFromFile}");
            }

            using (StreamWriter sw = new StreamWriter(@"C:\Users\User\Desktop\dd.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }

            using (StreamWriter sw = new StreamWriter(@"C:\Users\User\Desktop\dd.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine("Дозапись");
                sw.Write(4.5);
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
