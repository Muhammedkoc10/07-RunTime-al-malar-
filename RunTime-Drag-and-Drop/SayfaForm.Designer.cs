
namespace RunTime_Drag_and_Drop
{
    partial class SayfaForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAlinacaklar = new System.Windows.Forms.Panel();
            this.pnlAlinanlar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınacaklar";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 11);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alınanlar";
            // 
            // pnlAlinacaklar
            // 
            this.pnlAlinacaklar.AllowDrop = true;
            this.pnlAlinacaklar.Location = new System.Drawing.Point(62, 101);
            this.pnlAlinacaklar.Name = "pnlAlinacaklar";
            this.pnlAlinacaklar.Size = new System.Drawing.Size(310, 322);
            this.pnlAlinacaklar.TabIndex = 1;
            this.pnlAlinacaklar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlAlinacaklar_DragDrop);
            this.pnlAlinacaklar.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlAlinacaklar_DragOver);
            // 
            // pnlAlinanlar
            // 
            this.pnlAlinanlar.AllowDrop = true;
            this.pnlAlinanlar.Location = new System.Drawing.Point(398, 101);
            this.pnlAlinanlar.Name = "pnlAlinanlar";
            this.pnlAlinanlar.Size = new System.Drawing.Size(316, 322);
            this.pnlAlinanlar.TabIndex = 1;
            this.pnlAlinanlar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlAlinanlar_DragEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(378, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 336);
            this.label4.TabIndex = 2;
            // 
            // SayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlAlinanlar);
            this.Controls.Add(this.pnlAlinacaklar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SayfaForm";
            this.Text = "SayfaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAlinacaklar;
        private System.Windows.Forms.Panel pnlAlinanlar;
        private System.Windows.Forms.Label label4;
    }
}