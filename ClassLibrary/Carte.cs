using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Carte
    {
        public string name { get; set; }
        public Autor Autor { get; set; }
        public string gen { get; set; }
        public string subgen { get; set; }
        public string ecranizare { get; set; }

        public Carte(string name, Autor autor, string gen, string subgen, string ecranizare)
        {
            this.name = name;
            Autor = autor;
            this.gen = gen;
            this.subgen = subgen;
            this.ecranizare = ecranizare;
        }
    }
}
