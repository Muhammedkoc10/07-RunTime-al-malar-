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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsmArabaEkle.Enabled = false;
        }
        private void tsmArabaEkle_Click(object sender, EventArgs e)
        {
            ArabaEkleForm arabaEkleForm = new ArabaEkleForm();
            arabaEkleForm.Owner = this;
            arabaEkleForm.ShowDialog(); // Farklı pencerede açılacak. DialogForm olarak açılacak. Bu sebeple MdiChild - MdiParant ilişkisi yerine Owner ilişkisi olacak.
        }

        private void tsmArabaIslemleri_Click(object sender, EventArgs e)
        {
            tsmArabaEkle.Enabled = true;

            ArabaIslemleriForm arabaIslemleriForm = new ArabaIslemleriForm();
            arabaIslemleriForm.MdiParent = this; //Form1, ArabaIslemleriForm'un parantıdır. ArabaIslemleriForm ise Form1'in child'dır.
            arabaIslemleriForm.Show();
        }
    }
}
