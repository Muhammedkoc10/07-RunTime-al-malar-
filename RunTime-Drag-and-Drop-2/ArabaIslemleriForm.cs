using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTime_Drag_and_Drop_2
{
    public partial class ArabaIslemleriForm : Form
    {
        public ArabaIslemleriForm()
        {
            InitializeComponent();
        }

        public void YeniArabaEkle (string arabaMarkasi, Color arabaRengi)
        {
            Button yeniAraba = new Button();
            yeniAraba.Text = arabaMarkasi;
            yeniAraba.ForeColor = arabaRengi;
            yeniAraba.Width = pnlSatilacaklar.Width;
            yeniAraba.Height = 35;
            yeniAraba.FlatStyle = FlatStyle.Flat;

            yeniAraba.MouseDown += yeniAraba_MouseDown;
            yeniAraba.Top = EklenecegiYer(pnlSatilacaklar);

            pnlSatilacaklar.Controls.Add(yeniAraba);
        }

        private int EklenecegiYer(Panel hangiPanel)
        {
            int toplam = 0;
            foreach (Control item in hangiPanel.Controls)
            {
                toplam += item.Height;
            }
            return toplam;
        }

        private void yeniAraba_MouseDown(object sender, MouseEventArgs e)
        {
            Button basilanButton = (Button)sender;
            basilanButton.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void pnlSatilacaklar_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = (Button)e.Data.GetData(typeof(Button));
            btn.Top = EklenecegiYer((Panel)sender);
            ((Panel)btn.Parent).Controls.Remove(btn);
            ((Panel)sender).Controls.Add(btn);
        }

        private void pnlSatilacaklar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pnlSatilanlar_DragEnter(object sender, DragEventArgs e)
        {
            Button btn = (Button)e.Data.GetData(typeof(Button));
            btn.Top = EklenecegiYer((Panel)sender);
            ((Panel)sender).Controls.Add(btn);
        }
    }
}
