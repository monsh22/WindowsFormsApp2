using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TE1.Text = "0.0";
            TEX2.Text = "0.0";
            MessageBox.Show("se resertearon los valores de texto");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float fare = float.Parse(TEX2.Text);
            float cel = (fare - 32) * 5.0f / 9.0f;
            TE1.Text = cel.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cels = float.Parse(TE1.Text);
            float faret = (cels * 9f / 5f) + 32;
            TEX2.Text = faret.ToString();

        }
    }
}
