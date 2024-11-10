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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Manisa");


        }

        private void button2_Click(object sender, EventArgs e)
        {
           var Secım = comboBox1.Items.Add(textBox1.Text);
           MessageBox.Show("Başarıyla Eklendi");
                


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yazılımcı");
            listBox1.Items.Add("Futbolcu");
            MessageBox.Show("Meslekler Eklenmiştir");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text + "" + textBox1.Text);
            MessageBox.Show("Meslek başarılı bir şekilde eklenmiştir.");


        }
    }
}
