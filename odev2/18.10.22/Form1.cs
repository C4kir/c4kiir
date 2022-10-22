using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18._10._22
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkranı kitapEklemeEkranı = new KitapEklemeEkranı(this);
            kitapEklemeEkranı.Show();

        }

        public void kitapEkle (string kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;

            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible =false;
            textBox2.Visible =false;

            int secim = listBox1.SelectedIndex;

            if (secim != -1)
            {
                listBox1.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Değer Seçiniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible =true;

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
            }
            else
            {
                int selected = listBox1.SelectedIndex;
               
                listBox1.Items.Insert(selected, textBox1.Text + " " + textBox2.Text);
                listBox1.Items.RemoveAt(selected + 1);
                listBox1.SelectedIndex = selected;
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }
    }
}
