using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Perfomace perfomance;

        private void button1_Click(object sender, EventArgs e)
        {
            perfomance = new Perfomace(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            richTextBox1.Text = perfomance.toString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perfomance = new Play(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text));
            richTextBox1.Text = perfomance.toString();
        }
    }
}
