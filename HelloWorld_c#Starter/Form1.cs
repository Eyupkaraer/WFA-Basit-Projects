using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld_c_Starter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Hüseyin";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Ali";
            label7.Text = "Veli";
            label8.Text = "Yazılımcı";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Nargile Dünyası"; // Yorum sastırı yapıldı
            label9.Text = textBox1.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }
}
