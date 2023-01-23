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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void imagini()
        {
            this.Hide();
            Form3 f3 = new Form3();
            if (labelChosenBook.Text == "Sub aceeași stea")
            {
                f3.pictureBox1.Image = Image.FromFile("Sub aceeasi stea-front.png");
                f3.pictureBox2.Image = Image.FromFile("Sub aceeasi stea-back.jpg");
            }
            if (labelChosenBook.Text == "Tuturor băieților pe care i-am iubit")
            {
                f3.pictureBox1.Image = Image.FromFile("Tuturor baietilor-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Tuturor baietilor-back.jpg");
            }
            if (labelChosenBook.Text == "Divergent")
            {
                f3.pictureBox1.Image = Image.FromFile("Divergent-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Divergent-back.jpg");
            }
            if (labelChosenBook.Text == "Fata cu vise alb negru")
            {
                f3.pictureBox1.Image = Image.FromFile("Fata cu vise alb negru-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Fata cu vise alb negru-back.jpg");
            }
            if (labelChosenBook.Text == "Codul lui Da Vinci")
            {
                f3.pictureBox1.Image = Image.FromFile("Codul lui Da Vinci-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Codul lui Da Vinci-back.jpg");
            }
            if (labelChosenBook.Text == "Ocolul Pământului în 80 de zile")
            {
                f3.pictureBox1.Image = Image.FromFile("Ocolul pamantului-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Ocolul pamantului-back.jpg");
            }
            if (labelChosenBook.Text == "Dacă aș rămâne")
            {
                f3.pictureBox1.Image = Image.FromFile("Daca as ramane-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Daca as ramane-back.jpg");
            }
            if (labelChosenBook.Text == "Jocurile foamei")
            {
                f3.pictureBox1.Image = Image.FromFile("Jocurile foamei-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Jocurile foamei-back.jpg");
            }
            if (labelChosenBook.Text == "Prima iubire")
            {
                f3.pictureBox1.Image = Image.FromFile("Prima iubire-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Prima iubire-back.jpg");
            }
            if (labelChosenBook.Text == "Silver Bay")
            {
                f3.pictureBox1.Image = Image.FromFile("Silver bay-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Silver bay-back.jpg");
            }
            if (labelChosenBook.Text == "Fata din tren")
            {
                f3.pictureBox1.Image = Image.FromFile("Fata din tren-front.png");
                f3.pictureBox2.Image = Image.FromFile("Fata din tren-back.jpg");
            }
            if (labelChosenBook.Text == "Instrumente mortale")
            {
                f3.pictureBox1.Image = Image.FromFile("Instrumente mortale-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Instrumente mortale-back.jpg");
            }
            if (labelChosenBook.Text == "Oamenii fericiți citesc și beau cafea")
            {
                f3.pictureBox1.Image = Image.FromFile("Oamenii fericiti-front.jpg");
                f3.pictureBox2.Image = Image.FromFile("Oamenii fericiti-back.jpg");
            }
            f3.Show();
        }

        private void Coperta_Click(object sender, EventArgs e)
        {
            imagini();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
