
namespace RunTime_Drag_and_Drop_2
{
    partial class ArabaIslemleriForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSatilanlar = new System.Windows.Forms.Panel();
            this.pnlSatilacaklar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(390, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 336);
            this.label4.TabIndex = 8;
            // 
            // pnlSatilanlar
            // 
            this.pnlSatilanlar.AllowDrop = true;
            this.pnlSatilanlar.Location = new System.Drawing.Point(410, 90);
            this.pnlSatilanlar.Name = "pnlSatilanlar";
            this.pnlSatilanlar.Size = new System.Drawing.Size(316, 322);
            this.pnlSatilanlar.TabIndex = 6;
            this.pnlSatilanlar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlSatilanlar_DragEnter);
            // 
            // pnlSatilacaklar
            // 
            this.pnlSatilacaklar.AllowDrop = true;
            this.pnlSatilacaklar.Location = new System.Drawing.Point(74, 90);
            this.pnlSatilacaklar.Name = "pnlSatilacaklar";
            this.pnlSatilacaklar.Size = new System.Drawing.Size(310, 322);
            this.pnlSatilacaklar.TabIndex = 7;
            this.pnlSatilacaklar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlSatilacaklar_DragDrop);
            this.pnlSatilacaklar.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlSatilacaklar_DragOver);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(530, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "SATILANLAR";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(74, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 11);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "SATILACAKLAR";
            // 
            // ArabaIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlSatilanlar);
            this.Controls.Add(this.pnlSatilacaklar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArabaIslemleriForm";
            this.Text = "ArabaİşlemleriForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSatilanlar;
        private System.Windows.Forms.Panel pnlSatilacaklar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}