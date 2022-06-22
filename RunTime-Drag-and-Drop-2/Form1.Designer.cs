
namespace RunTime_Drag_and_Drop_2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmArabaEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmArabaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArabaEkle,
            this.tsmArabaIslemleri,
            this.tsmCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmArabaEkle
            // 
            this.tsmArabaEkle.Name = "tsmArabaEkle";
            this.tsmArabaEkle.Size = new System.Drawing.Size(74, 20);
            this.tsmArabaEkle.Text = "Araba Ekle";
            this.tsmArabaEkle.Click += new System.EventHandler(this.tsmArabaEkle_Click);
            // 
            // tsmArabaIslemleri
            // 
            this.tsmArabaIslemleri.Name = "tsmArabaIslemleri";
            this.tsmArabaIslemleri.Size = new System.Drawing.Size(97, 20);
            this.tsmArabaIslemleri.Text = "Araba İşlemleri";
            this.tsmArabaIslemleri.Click += new System.EventHandler(this.tsmArabaIslemleri_Click);
            // 
            // tsmCikis
            // 
            this.tsmCikis.Name = "tsmCikis";
            this.tsmCikis.Size = new System.Drawing.Size(44, 20);
            this.tsmCikis.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmArabaEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmArabaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmCikis;
    }
}

