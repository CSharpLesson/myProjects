using System;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWriteAsyn();

            Console.WriteLine("Некоторая работа");
            Console.Read();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\Desktop");
            //Console.WriteLine(dir.FullName);
            //Console.WriteLine(dir.Attributes.ToString());
            //FileInfo[] txt = dir.GetFiles("*.txt");//tekst fayllarni txtsi berilgan
            //Console.WriteLine(txt.Length.ToString());
            //foreach (FileInfo item in txt)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Length);
            //    Console.WriteLine(item.CreationTime);
            //    Console.WriteLine(item.Attributes);
            //    Console.WriteLine(Environment.NewLine);//pustoy qator qoshishga
            //}
            //try
            //{
            //    dir.CreateSubdirectory("Cat");// papka qoshish 
            //    dir.CreateSubdirectory(@"Cat\Sub");//qo'shilgan papka ichiga yana papka qoshish
            //}
            //catch (IOException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //FileInfo file = new FileInfo(@"C:\Users\User\Desktop\txt1.txt");//FileInfo classi  fayllar haqida malumot olishga joyini ozgartirish ochirish yangi fayllarni tuzish fayllarni ochish va unga malumot yozish moljalangan
            //FileStream fs = file.Create();// Shu faylni yasash
            //Console.WriteLine(file.CreationTime);
            //fs.Close();
            //FileInfo file = new FileInfo(@"C:\Users\User\Desktop\txt1.txt");//FileInfo classi  fayllar haqida malumot olishga joyini ozgartirish ochirish yangi fayllarni tuzish fayllarni ochish va unga malumot yozish moljalangan
            //file.Delete();// Shu faylni ochirish
            //Console.WriteLine(file.FullName);
            //FileInfo file = new FileInfo(@"C:\Users\User\Desktop\txt1.txt");//FileInfo classi  fayllar haqida malumot olishga joyini ozgartirish ochirish yangi fayllarni tuzish fayllarni ochish va unga malumot yozish moljalangan
            //FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.Read);// yangi fayl tuzish boshqacha variyant
            //FileInfo file = new FileInfo(@"C:\Users\User\Desktop\txt1.txt");
            //StreamWriter writer = file.CreateText();
            //writer.WriteLine("Assalom");
            //writer.WriteLine(writer.NewLine);
            //writer.WriteLine("Alaykum");
            //writer.Close();
            //Console.WriteLine("malumot yozildi");
            //Console.ReadKey();
            //StreamReader reader = new StreamReader(@"C:\Users\User\Desktop\txt1.txt");
            //int counter = 0;
            //string ln;

            //while ((ln = reader.ReadLine()) != null)
            //{
            //    Console.WriteLine(ln);
            //    counter++;
            //}
            //reader.Close();
            //Console.WriteLine($"File has {counter} lines.");//filedan malumot olish
            //file ni barchasini birdaniga o'qish
            //StreamReader reader = new StreamReader(@"C:\Users\User\Desktop\txt1.txt");
            //string alltext = reader.ReadToEnd();
            //Console.WriteLine(reader.CurrentEncoding);
            //Console.Write(alltext);

          
       
        }
        static async void ReadWriteAsyn()
        {
            string s = "Hello world! One step at a time";

            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine(result);
            }
            // hello.txt - файл, который будет записываться и считываться
            using (StreamWriter writer = new StreamWriter("hello.txt", false))
            {
                await writer.WriteLineAsync(s);  // асинхронная запись в файл
            }
            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine(result);
            }

        }
        
    }
}
