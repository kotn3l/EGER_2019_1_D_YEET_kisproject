using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PetYeeter
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        Graphics g;
        Area FiftyOne;
        public static Timer newtimer;

        public Form1()
        {
            InitializeComponent();

            
            //FiftyOne.AddCat(, new Point(1, 2)); //i am confusion
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //FiftyOne.Draw(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPlayer vmi = new NewPlayer();
            vmi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            of.OpenFile();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
