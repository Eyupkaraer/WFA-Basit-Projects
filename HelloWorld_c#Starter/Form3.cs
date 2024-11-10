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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " +textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
            MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir.");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("İşleminiz başarıyla silinmiştir.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            MessageBox.Show("Textboxlar başarılı bir şekilde silinmiştir");

        }
    }
}
