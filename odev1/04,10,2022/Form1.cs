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


                //Butonlarla Geçti Kaldı Yeşil Kırmızı
                if (ortalama >= 50)
                {
                    btnYesil.BackColor = Color.Green;
                    btnKirmizi.BackColor = Color.Gray;
                }
                if (ortalama < 50)
                {
                    btnKirmizi.BackColor = Color.Red;
                    btnYesil.BackColor = Color.Gray;
                }


                label3.Text = ortalama.ToString();

                //Harf Notu Kısmı
                if (ortalama >= 85)
                {
                    label4.Text = "AA";
                }
                if (ortalama >= 80 && ortalama <= 84)
                {
                    label4.Text = "BA";
                }
                if (ortalama >= 75 && ortalama <= 79)
                {
                    label4.Text = "BB";
                }
                if (ortalama >= 70 && ortalama <= 74)
                {
                    label4.Text = "CB";
                }
                if (ortalama >= 70 && ortalama <= 74)
                {
                    label4.Text = "CB";
                }
                if (ortalama >= 60 && ortalama <= 69)
                {
                    label4.Text = "CC";
                }
                if (ortalama >= 55 && ortalama <= 59)
                {
                    label4.Text = "DC";
                }
                if (ortalama >= 50 && ortalama <= 54)
                {
                    label4.Text = "DD";
                }
                if (ortalama >= 40 && ortalama <= 49)
                {
                    label4.Text = "FD";
                }
                if (ortalama >= 0 && ortalama <= 39)
                {
                    label4.Text = "FF";
                }

            }
            catch (Exception)
            {
             
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            

        }

        private void numericUpDown2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void numericUpDown2_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
