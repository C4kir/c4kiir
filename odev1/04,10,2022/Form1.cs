using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_10_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama, vize, final;
            try
            {
                vize = Convert.ToDouble(numericUpDown1.Value);
                
                final = Convert.ToDouble(numericUpDown2.Value);
                
                ortalama = vize * 0.4 + final * 0.6;

                label3.Text = ortalama.ToString();
   
                             

            }
            catch (Exception)
            {
             
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            button1.Visible = false;
        }

        private void numericUpDown2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void numericUpDown2_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
