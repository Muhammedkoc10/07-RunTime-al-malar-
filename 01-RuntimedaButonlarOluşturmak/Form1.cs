using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_RuntimedaButonlarOluşturmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void btnUret_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Width = 60;
            btn.Height = 50;

            Random rnd = new Random();

            int btnX = rnd.Next(0, this.ClientSize.Width - btn.Width);
            btn.Left = btnX;

            int btnY = rnd.Next(0, this.ClientSize.Height - btn.Height);
            btn.Top = btnY;

            this.Controls.Add(btn); // Bu formun controllerine btn isimli buton ekle

            //btn.Text = "Hello World!";
            
            btn.Text = sayac +". Buton";
            sayac++;

            btn.Click += btn_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender; // unboxing işlemidir. Object tipinden bilinen tipe dönüştürme işlemi.

            MessageBox.Show(tiklanan.Text +" numaralı butona tıkladınız");
        }
    }
}
