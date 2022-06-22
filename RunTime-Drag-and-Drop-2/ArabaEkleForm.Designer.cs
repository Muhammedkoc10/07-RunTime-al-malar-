
namespace RunTime_Drag_and_Drop_2
{
    partial class ArabaEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.cmbRenkler = new System.Windows.Forms.ComboBox();
            this.btnArabaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araba Markası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Araba Rengi";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(137, 30);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 20);
            this.txtMarka.TabIndex = 1;
            this.txtMarka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbRenkler
            // 
            this.cmbRenkler.FormattingEnabled = true;
            this.cmbRenkler.Location = new System.Drawing.Point(137, 84);
            this.cmbRenkler.Name = "cmbRenkler";
            this.cmbRenkler.Size = new System.Drawing.Size(121, 21);
            this.cmbRenkler.TabIndex = 2;
            this.cmbRenkler.SelectedIndexChanged += new System.EventHandler(this.cmbRenkler_SelectedIndexChanged);
            // 
            // btnArabaEkle
            // 
            this.btnArabaEkle.Location = new System.Drawing.Point(137, 128);
            this.btnArabaEkle.Name = "btnArabaEkle";
            this.btnArabaEkle.Size = new System.Drawing.Size(121, 42);
            this.btnArabaEkle.TabIndex = 3;
            this.btnArabaEkle.Text = "ARABA EKLE";
            this.btnArabaEkle.UseVisualStyleBackColor = true;
            this.btnArabaEkle.Click += new System.EventHandler(this.btnArabaEkle_Click);
            // 
            // ArabaEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 185);
            this.Controls.Add(this.btnArabaEkle);
            this.Controls.Add(this.cmbRenkler);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArabaEkleForm";
            this.Text = "ArabaEkleForm";
            this.Load += new System.EventHandler(this.ArabaEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox cmbRenkler;
        private System.Windows.Forms.Button btnArabaEkle;
    }
}