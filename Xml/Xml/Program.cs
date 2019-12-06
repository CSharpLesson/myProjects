using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Xml
{
    
    class Program
    {


        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument();
            // создаем первый элемент
            XElement iphone6 = new XElement("phone");
            XElement phones = new XElement("phones");
            // создаем атрибут
            for (int i = 0; i < 5; i++)
            {
                XElement name = new XElement("name", "asdasd");
                XElement iphoneCompanyElem = new XElement("company", "Apple");
                XElement iphonePriceElem = new XElement("price", "40000{Convert.ToString(i)}");
                // добавляем атрибут и элементы в первый элемент
                iphone6.Add(name);
                iphone6.Add(iphoneCompanyElem);
                iphone6.Add(iphonePriceElem);
                phones.Add(iphone6);
                iphone6 = new XElement("phone");
            }          
           
            // создаем второй элемент

            // создаем корневой элемент

            // добавляем в корневой элемент
            

            // добавляем корневой элемент в документ
            xdoc.Add(phones);
            //сохраняем документ
            xdoc.Save(@"C:\Users\User\Desktop\zakaz.xml");
            // Bu kod web dasturda fileni wwwroot ni ichiga yozadi
            //////путь к папке Files
            //string path = "\\ImportXML\\" + uploadedFile.FileName; wwwroot ni ichiga fileni nomini berib uni joylashtirish
            //// сохраняем файл в папку Files в каталоге wwwroot
            //using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            //{
            //    await uploadedFile.CopyToAsync(fileStream);// fileni saqlash
            //}




        }
    }
}
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

            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("C:/Project/productsKolberg.xml");
            ////// получим корневой элемент
            //XmlElement xRoot = xDoc.DocumentElement;
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
            ////xDoc.Save("D://users.xml");
            //XmlNodeList childnodes = xRoot.SelectNodes("Наименование");
            //foreach (XmlNode n in childnodes)
            //    Console.WriteLine(n.Value);

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


Выберем все узлы <user>:

1
XmlNodeList childnodes = xRoot.SelectNodes("user");


                
Выведем на консоль значения атрибутов name у элементов user:

XmlNodeList childnodes = xRoot.SelectNodes("user");
foreach (XmlNode n in childnodes)
    Console.WriteLine(n.SelectSingleNode("@name").Value);
    Выберем узел, у которого атрибут name имеет значение "Bill Gates":


XmlNode childnode = xRoot.SelectSingleNode("user[@name='Bill Gates']");
if (childnode != null)
    Console.WriteLine(childnode.OuterXml);
Выберем узел, у которого вложенный элемент "company" имеет значение "Microsoft":


XmlNode childnode = xRoot.SelectSingleNode("user[company='Microsoft']");
if (childnode != null)
    Console.WriteLine(childnode.OuterXml);
Допустим, нам надо получить только компании. Для этого надо осуществить выборку вниз по иерархии элементов:

XmlNodeList childnodes = xRoot.SelectNodes("//user/company");
foreach (XmlNode n in childnodes)
    Console.WriteLine(n.InnerText);



            Еще один подход к работе с Xml представляет технология LINQ to XML. Вся функциональность LINQ to XML содержится в пространстве имен System.Xml.Linq. Рассмотрим основные классы этого пространства имен:

XAttribute: представляет атрибут xml-элемента

XComment: представляет комментарий

XDocument: представляет весь xml-документ

XElement: представляет отдельный xml-элемент

Ключевым классом является XElement, который позволяет получать вложенные элементы и управлять ими. Среди его методов можно отметить следующие:

Add(): добавляет новый атрибут или элемент

Attributes(): возвращает коллекцию атрибутов для данного элемента

Elements(): возвращает все дочерние элементы данного элемента

Remove(): удаляет данный элемент из родительского объекта

RemoveAll(): удаляет все дочерние элементы и атрибуты у данного элемента

Итак, используем функциональность LINQ to XML и создадим новый XML-документ:


XDocument xdoc = new XDocument();
// создаем первый элемент
XElement iphone6 = new XElement("phone");
// создаем атрибут
XAttribute iphoneNameAttr = new XAttribute("name", "iPhone 6");
XElement iphoneCompanyElem = new XElement("company", "Apple");
XElement iphonePriceElem = new XElement("price", "40000");
// добавляем атрибут и элементы в первый элемент
iphone6.Add(iphoneNameAttr);
iphone6.Add(iphoneCompanyElem);
iphone6.Add(iphonePriceElem);
 
// создаем второй элемент
XElement galaxys5 = new XElement("phone");
XAttribute galaxysNameAttr = new XAttribute("name", "Samsung Galaxy S5");
XElement galaxysCompanyElem = new XElement("company", "Samsung");
XElement galaxysPriceElem = new XElement("price", "33000");
galaxys5.Add(galaxysNameAttr);
galaxys5.Add(galaxysCompanyElem);
galaxys5.Add(galaxysPriceElem);
// создаем корневой элемент
XElement phones = new XElement("phones");
// добавляем в корневой элемент
phones.Add(iphone6);
phones.Add(galaxys5);
// добавляем корневой элемент в документ
xdoc.Add(phones);
//сохраняем документ
xdoc.Save("phones.xml");
Чтобы создать документ, нам нужно создать объект класса XDocument. Это объект самого верхнего уровня в хml-документе.

Элементы создаются с помощью конструктора класса XElement. Конструктор имеет ряд перегруженных версий. Первый параметр конструктора передает название элемента, например, phone. Второй параметр передает значение этого элемента.

Создание атрибута аналогично созданию элемента. Затем все атрибуты и элементы добавляются в элементы phone с помощью метода Add().

Так как документ xml должен иметь один корневой элемент, то затем все элементы phone добавляются в один контейнер - элемент phones.

В конце корневой элемент добавляется в объект XDocument, и этот объект сохраняется на диске в xml-файл с помощью метода Save().
             */


      

