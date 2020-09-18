using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using XMLParcer.Classes;

namespace XMLParcer
{
    class XMLParce
    {
        public static string specialty { get; set; }
        public static string specialisation { get; set; }
        public static string qualification { get; set; }
        public static string educationForm { get; set; }
        public static List<Competence> competences { get; set; }


        public static List<Disciplines> disciplines;

        public static void LoadAll(string str)
        {
            disciplines = new List<Disciplines>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(str);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                foreach(XmlNode xnode2 in xnode)
                {
                    if(xnode2.Name == "СтрокиПлана")
                    {
                        foreach(XmlNode xnode3 in xnode2)
                        {
                            disciplines.Add(new Disciplines(xnode3));
                        }
                    }
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - company
                    if (childnode.Name == "Строка")
                    {
                        Console.WriteLine($"Компания: {childnode.InnerText}");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
