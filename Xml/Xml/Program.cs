using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Xml
{
    class Odinc
    {
        public string Name { get; set; }
    }
    class Program
    {
       

        static void Main(string[] args)
        {
            // Bu kod web dasturda fileni wwwroot ni ichiga yozadi
            //////путь к папке Files
            //string path = "\\ImportXML\\" + uploadedFile.FileName; wwwroot ni ichiga fileni nomini berib uni joylashtirish
            //// сохраняем файл в папку Files в каталоге wwwroot
            //using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            //{
            //    await uploadedFile.CopyToAsync(fileStream);// fileni saqlash
            //}



            Odinc odinc = new Odinc();
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("C:\\Project\\txt.xml");
            //XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Product");
            //string proID = "", proName = "", price = "";
            //foreach (XmlNode node in nodeList)
            //{
            //    proID = node.SelectSingleNode("Product_id").InnerText;
            //    proName = node.SelectSingleNode("Product_name").InnerText;
            //    price = node.SelectSingleNode("Product_price").InnerText;
            //    Console.WriteLine(proID + " " + proName + " " + price);
            //}
            XmlReaderSettings settings = new XmlReaderSettings
            {
                Async = true
            };
            XmlReader reader = XmlReader.Create("C:\\Project\\productsKolberg.xml", settings);

            int a = 0;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.WriteLine("<" + reader.Name + ">");
                        switch (reader.Name)
                        {
                            
                            case "Товар":
                                a++;
                                break;
                            case "Ид":
                                if (a == 1)
                                {
                                    a ++;
                                }
                                if (a == 5)
                                {
                                    Console.WriteLine("end");
                                    a = 0;
                                }
                                break;
                            case "Наименование":
                                if (a == 3)
                                {
                                    a++;
                                }                                
                                break;
                            
                        }
                        break;
                    case XmlNodeType.Text:
                        switch (a)
                        {
                            case 2:
                                Console.WriteLine(reader.Value + "   id " );
                                a++;
                                break;
                            case 4:
                                Console.WriteLine(reader.Value + "  name "  );
                                a++;
                                break;
                        }
                        Console.WriteLine(reader.Value + "  boshqa ");
                        break;
                    
                }
            }




        }
    }
}
