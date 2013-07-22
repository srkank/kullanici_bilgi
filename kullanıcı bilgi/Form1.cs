using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kullanıcı_bilgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BebekBilgileri bebek = new BebekBilgileri();
            bebek.Ad=Ad.Text;
            bebek.Soyad=Soyad.Text;
            if(erkek.Checked==true)
            {
                bebek.Cinsiyet=erkek.Text;
            }
            else
            {
                bebek.Cinsiyet=kız.Text;
            }
            bebek.Tc=Tc.Text;
            listBox1.Items.Add(bebek);
            bebek.Dtarih=DateTime.Now;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BebekBilgileri secili = listBox1.SelectedItem as BebekBilgileri;
            lblad.Text = secili.Ad;
            lblsoyad.Text = secili.Soyad;
            lbldtarih.Text = secili.Dtarih.ToString();
            lblcinsiyet.Text = secili.Cinsiyet;
            lbltcno.Text = secili.Tc;
            
        }
    }
}
