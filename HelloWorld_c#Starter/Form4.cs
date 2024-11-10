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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text + " " + maskedTextBox4.Text);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);


        }
    }
}
