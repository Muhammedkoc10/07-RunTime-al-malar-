using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTime_Drag_and_Drop
{
    public partial class SayfaForm : Form
    {
        public SayfaForm()
        {
            InitializeComponent();
        }

        public void YeniMaddeEkle(string mesaj)
        {
            Label yeniNot = new Label();
            yeniNot.AutoSize = true;
            yeniNot.Text = mesaj;
            yeniNot.BorderStyle = BorderStyle.FixedSingle;

            yeniNot.MouseDown += yeniNot_MouseDown;
            yeniNot.Top = EklenecegiYer(pnlAlinacaklar); // Metottan dönen toplam değeri burada yeni eklenecek Label controlünün üst konumunu versin.
            pnlAlinacaklar.Controls.Add(yeniNot); // İlgilipanelde ilgili top özelliğinegörekonumu belirlenen label'ı eklesin.
        }

        private int EklenecegiYer(Panel panelim) // Bu panel pnlAlinacaklar ya da pnlAlinanlar olarak gelebilir. Dinamik olmalı.
        {
            int toplam = 0;
            foreach (Control item in panelim.Controls)
            {
                toplam += item.Height; // İçerideki tüm controller'in yüksekliklerini topla.
            }
            return toplam; // Toplam değerini geri döndür.
        }

        private void yeniNot_MouseDown(object sender, MouseEventArgs e)
        {
            Label secilen = (Label)sender;
            secilen.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void pnlAlinacaklar_DragDrop(object sender, DragEventArgs e)
        {
            Label lbl = (Label)e.Data.GetData(typeof(Label)); // Sürükleme işlemi yapılan argümanı
            lbl.Top = EklenecegiYer((Panel)sender); // Yeni sürüklendiği panelde ekleneceği yeri tespit et.
            ((Panel)lbl.Parent).Controls.Remove(lbl); // Sürüklenen Label'ı önceki yerden sil.
            ((Panel)sender).Controls.Add(lbl); // Bırakılan Label'ı yeni sürüklendiği yere ekle.

        }

        private void pnlAlinacaklar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pnlAlinanlar_DragEnter(object sender, DragEventArgs e)
        {
            Label lbl = (Label)e.Data.GetData(typeof(Label));
            lbl.Top = EklenecegiYer((Panel)sender);
            ((Panel)sender).Controls.Add(lbl);
        }
    }
}
