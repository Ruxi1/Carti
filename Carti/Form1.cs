using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carti
{
    public partial class Form1 : Form
    {
        public List<Carte> carti;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            var lines = Read.CitireDinFisier();
            carti = lines.Select(x => Read.Parse(x)).Where(x => x != null).ToList();

            int nrcomun = 0;
            int index = -1;
            for (int i = 0; i < carti.Count(); i++)
            {
                int ctor = 0;
                foreach (string s in checkedListAutor.CheckedItems)
                {
                    var nume = s.Split(' ');
                    if (carti[i].Autor.firstName == nume[0] && carti[i].Autor.lastName == nume[1])
                        ctor++;
                }
                foreach (string s in checkedListGen.CheckedItems)
                    if (carti[i].gen == s)
                        ctor++;
                foreach (string s in checkedListSubgen.CheckedItems)
                    if (carti[i].subgen == s)
                        ctor++;
                foreach (string s in checkedListEcranizare.CheckedItems)
                    if (carti[i].ecranizare == s)
                        ctor++;
                if (ctor > nrcomun)
                {
                    nrcomun = ctor;
                    index = i;
                }
            }
            if (index > -1)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.labelChosenBook.Text = carti[index].name;
                f2.Show();
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                f2.labelChosenBook.Text = "NU EXISTĂ";
            }

        
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
