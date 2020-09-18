using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLParcer.Classes
{
    class Disciplines
    {
        public string disciplineName { get; set; }
        public string identificator { get; set; }
        public static string passString { get; set; } //Зачет с оценкой, экзамен и тд. Просто строка для запихивания в 


        public Disciplines(XmlNode xmlNode)
        {
            disciplineName = xmlNode.Attributes.GetNamedItem("Дис").Value;
            identificator = xmlNode.Attributes.GetNamedItem("ИдетификаторДисциплины").Value;
        }
    }
}
