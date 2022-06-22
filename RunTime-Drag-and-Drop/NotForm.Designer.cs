
namespace RunTime_Drag_and_Drop
{
    partial class NotForm
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
            this.txtNot = new System.Windows.Forms.TextBox();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.lblKalan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOT YAZINIZ:";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(12, 50);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(349, 156);
            this.txtNot.TabIndex = 1;
            this.txtNot.TextChanged += new System.EventHandler(this.txtNot_TextChanged);
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Location = new System.Drawing.Point(260, 212);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(101, 60);
            this.btnNotEkle.TabIndex = 2;
            this.btnNotEkle.Text = "NOT EKLE";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.Location = new System.Drawing.Point(13, 213);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(52, 32);
            this.lblKalan.TabIndex = 3;
            // 
            // NotForm
            // 
            this.AcceptButton = this.btnNotEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 284);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.label1);
            this.Name = "NotForm";
            this.Text = "NotForm";
            this.Load += new System.EventHandler(this.NotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.Label lblKalan;
    }
}