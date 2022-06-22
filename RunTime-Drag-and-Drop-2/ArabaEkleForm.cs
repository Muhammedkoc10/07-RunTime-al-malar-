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
    public partial class ArabaEkleForm : Form
    {
        public ArabaEkleForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRenkler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            Form1 anaform = (Form1)this.Owner;
            ((ArabaIslemleriForm)anaform.ActiveMdiChild).YeniArabaEkle(txtMarka.Text, (Color)cmbRenkler.SelectedItem);

            this.Hide();
            txtMarka.Text = string.Empty;

            cmbRenkler.SelectedIndex = -1; // ComboBox'taki seçimi kaldırır.
        }

        private void ArabaEkleForm_Load(object sender, EventArgs e)
        {
            cmbRenkler.Items.Add(Color.Black);
            cmbRenkler.Items.Add(Color.White);
            cmbRenkler.Items.Add(Color.Navy);
            cmbRenkler.Items.Add(Color.DeepSkyBlue);
            cmbRenkler.Items.Add(Color.Coral);
            cmbRenkler.Items.Add(Color.Orange);
            cmbRenkler.Items.Add(Color.Bisque);
            cmbRenkler.Items.Add(Color.DeepPink);
            cmbRenkler.Items.Add(Color.Lime);
            cmbRenkler.Items.Add(Color.Firebrick);
        }
    }
}
