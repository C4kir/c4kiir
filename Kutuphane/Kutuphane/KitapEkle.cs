﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KitapEkle : Form
    {
        AnaEkran anaEkran;

        public KitapEkle(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YazarEkle yazar = new YazarEkle();
            comboYazar.Items.Add(yazar.listBoxYazarlar);

            Kitap kitap = new Kitap(textBox1.Text, comboYazar.Text);
            anaEkran.kitapEkle(kitap);
            
            anaEkran.Show();
            this.Close();
        }

        private void KitapEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
                      
        }
    }
}