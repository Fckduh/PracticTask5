using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PracitcTask5._4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\Repos\PracitcTask5.4\bin\Debug\docer.xml");
            XmlElement xRoot = doc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    if (xnode.Name == "Adress")
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("name");
                        Console.WriteLine(attr?.Value);
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {

                            if (childnode.Name == "Street")
                            {
                                Console.WriteLine($"Street: {childnode.InnerText}");
                            }
                            if (childnode.Name == "HouseNumber")
                            {
                                Console.WriteLine($"HouseNumber: {childnode.InnerText}");
                            }
                            if (childnode.Name == "FlatNumber")
                            {
                                Console.WriteLine($"FlatNumber: {childnode.InnerText}");
                            }
                        }
                    }
                    else if (xnode.Name == "Phones")
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("name");
                        Console.WriteLine(attr?.Value);
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == "MobilePhone")
                            {
                                Console.WriteLine($"MobilePhone: {childnode.InnerText}");
                            }
                            if (childnode.Name == "FlatPhone")
                            {
                                Console.WriteLine($"FlatPhone: {childnode.InnerText}");
                            }
                        }
                    }
                    
                }
                Console.ReadKey();
            }
        }
    }
}
