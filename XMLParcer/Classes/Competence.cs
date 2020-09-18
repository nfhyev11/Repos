using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLParcer.Classes
{
    class Competence
    {
        public static List<Competence> competencesAll { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string content { get; set; }
    }
}
