using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carti
{
    public class Read
    {
        public static List<string> CitireDinFisier()
        {
            try
            {
                return File.ReadAllLines("DateCarti.txt").ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
        public static Carte Parse(string line)
        {
            Carte carte = null;
            Autor autor = null;
            try
            {
                var values = line.Split(',');
                var name = values[0];
                var firstName = values[1];
                var lastName = values[2];
                var gen = values[3];
                var subgen = values[4];
                var ecranizare = values[5];

                autor = new Autor(firstName, lastName);
                carte = new Carte(name, autor, gen, subgen, ecranizare);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return carte;
        }
    }
}
