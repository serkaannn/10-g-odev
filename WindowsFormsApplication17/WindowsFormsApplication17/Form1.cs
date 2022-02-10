using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(textBox1.Text);
            if (sayı < 10)
            {
                sayı++;
            }
            textBox1.Text = sayı.ToString();



            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(textBox1.Text);
            if (sayı > 0)
            {
                sayı--;
            }
            textBox1.Text = sayı.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             int sayı = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            for (int s = 1; s < 11; s++)     
            {
                listBox1.Items.Add(s + "*" + (textBox1.Text) + "=" + s * sayı);
            }


        }
    }
}

