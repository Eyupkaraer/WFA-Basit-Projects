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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int vize = Convert.ToInt32(Vizetxt.Text);
            int final = Convert.ToInt32(Finaltxt.Text);

            int toplam = (int)(vize * 0.4 + final * 0.6);


            Sonuctxt.Text = toplam.ToString();

            if (vize >= 85 && vize <= 100)
            {
                HarfNotutxt.Text = "AA";
            }

            if (vize >= 70 && vize <= 84)
            {
                HarfNotutxt.Text = "BA";
            }

            if (vize >= 56 && vize <= 69)
            {
                HarfNotutxt.Text = "CC";
            }

            if (vize >= 45 && vize <=55)
            {
                HarfNotutxt.Text = "DD";
            }
            if (vize >= 0 && vize <=44 )
            {
                HarfNotutxt.Text = "FF";
            }


        }
    }
}
