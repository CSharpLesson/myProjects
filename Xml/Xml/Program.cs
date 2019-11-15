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



            //Odinc odinc = new Odinc();
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
            //XmlReaderSettings settings = new XmlReaderSettings
            //{
            //    Async = true
            //};
            //XmlReader reader = XmlReader.Create(@"C:\Project\productsKolberg.xml", settings);

            //int a = 0;
            //while (reader.Read())
            //{
            //    switch (reader.NodeType)
            //    {
            //        case XmlNodeType.Element:
            //            Console.WriteLine("<" + reader.Name + ">  ");
            //            switch (reader.Name)
            //            {

            //                case "Товар":
            //                    a++;
            //                    break;
            //                case "Ид":
            //                    if (a == 1)
            //                    {
            //                        a ++;
            //                    }
            //                    if (a == 5)
            //                    {
            //                        Console.WriteLine("end");
            //                        a = 0;
            //                    }
            //                    break;
            //                case "Наименование":
            //                    if (a == 3)
            //                    {
            //                        a++;
            //                    }                                
            //                    break;

            //            }
            //            break;
            //        case XmlNodeType.Text:
            //            switch (a)
            //            {
            //                case 2:
            //                    Console.WriteLine(reader.Value + "   id " );
            //                    a++;
            //                    break;
            //                case 4:
            //                    Console.WriteLine(reader.Value + "  name "  );
            //                    a++;
            //                    break;
            //            }
            //            Console.WriteLine(reader.Value + "  boshqa ");
            //            break;

            //    }
            //}

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:/Project/productsKolberg.xml");
            //// получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            //// обход всех узлов в корневом элементе
            //foreach (XmlNode xnode in xRoot)
            //{
            //    // получаем атрибут name
            //    if (xnode.Attributes.Count > 0)
            //    {
            //        XmlNode attr = xnode.Attributes.GetNamedItem("Наименование");
            //        if (attr != null)
            //            Console.WriteLine(attr.Value);
            //    }
            //    // обходим все дочерние узлы элемента user
            //    foreach (XmlNode childnode in xnode.ChildNodes)
            //    {
            //        // если узел - company
            //        if (childnode.Name == "Наименование")
            //        {
            //            Console.WriteLine($"Наименование: {childnode.InnerText}");
            //        }
            //        // если узел age
            //        if (childnode.Name == "Товар")
            //        {
            //            Console.WriteLine($"Товар: {childnode.InnerText}");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("D://users.xml");
            //XmlElement xRoot = xDoc.DocumentElement;
            //// создаем новый элемент user
            //XmlElement userElem = xDoc.CreateElement("user");
            //// создаем атрибут name
            //XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            //// создаем элементы company и age
            //XmlElement companyElem = xDoc.CreateElement("company");
            //XmlElement ageElem = xDoc.CreateElement("age");
            //// создаем текстовые значения для элементов и атрибута
            //XmlText nameText = xDoc.CreateTextNode("Mark Zuckerberg");
            //XmlText companyText = xDoc.CreateTextNode("Facebook");
            //XmlText ageText = xDoc.CreateTextNode("30");

            ////добавляем узлы
            //nameAttr.AppendChild(nameText);
            //companyElem.AppendChild(companyText);
            //ageElem.AppendChild(ageText);
            //userElem.Attributes.Append(nameAttr);
            //userElem.AppendChild(companyElem);
            //userElem.AppendChild(ageElem);
            //xRoot.AppendChild(userElem);
            //xDoc.Save("D://users.xml");

            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("D://users.xml");
            //XmlElement xRoot = xDoc.DocumentElement;

            //XmlNode firstNode = xRoot.FirstChild;
            //xRoot.RemoveChild(firstNode);
            //xDoc.Save("D://users.xml");
            XmlNodeList childnodes = xRoot.SelectNodes("Наименование");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.Value);

            /*
             * XmlNode: представляет узел xml. В качестве узла может использоваться весь документ, так и отдельный элемент

XmlDocument: представляет весь xml-документ

XmlElement: представляет отдельный элемент. Наследуется от класса XmlNode

XmlAttribute: представляет атрибут элемента

XmlText: представляет значение элемента в виде текста, то есть тот текст, который находится в элементе между его открывающим и закрывающим тегами

XmlComment: представляет комментарий в xml

XmlNodeList: используется для работы со списком узлов

Ключевым классом, который позволяет манипулировать содержимым xml, является XmlNode, поэтому рассмотрим некоторые его основные методы и свойства:

Свойство Attributes возвращает объект XmlAttributeCollection, который представляет коллекцию атрибутов

Свойство ChildNodes возвращает коллекцию дочерних узлов для данного узла

Свойство HasChildNodes возвращает true, если текущий узел имеет дочерние узлы

Свойство FirstChild возвращает первый дочерний узел

Свойство LastChild возвращает последний дочерний узел

Свойство InnerText возвращает текстовое значение узла

Свойство InnerXml возвращает всю внутреннюю разметку xml узла

Свойство Name возвращает название узла. Например, <user> - значение свойства Name равно "user"

Свойство ParentNode возвращает родительский узел у текущего узла
AppendChild: добавляет в конец текущего узла новый дочерний узел

InsertAfter: добавляет новый узел после определенного узла

InsertBefore: добавляет новый узел до определенного узла

RemoveAll: удаляет все дочерние узлы текущего узла

RemoveChild: удаляет у текущего узла один дочерний узел и возвращает его

Класс XmlElement, унаследованный от XmlNode, добавляет еще ряд методов, которые позволяют создавать новые узлы:

CreateNode: создает узел любого типа

CreateElement: создает узел типа XmlDocument

CreateAttribute: создает узел типа XmlAttribute

CreateTextNode: создает узел типа XmlTextNode

CreateComment: создает комментарий
             */

        }
    }
}
