
namespace RunTime_Drag_and_Drop
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
            this.tsmFormIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmYeniForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmYeniNot = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFormIslemleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFormIslemleri
            // 
            this.tsmFormIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmYeniForm,
            this.tsmYeniNot});
            this.tsmFormIslemleri.Name = "tsmFormIslemleri";
            this.tsmFormIslemleri.Size = new System.Drawing.Size(94, 20);
            this.tsmFormIslemleri.Text = "Form İşlemleri";
            // 
            // tsmYeniForm
            // 
            this.tsmYeniForm.Name = "tsmYeniForm";
            this.tsmYeniForm.Size = new System.Drawing.Size(180, 22);
            this.tsmYeniForm.Text = "Yeni Form";
            this.tsmYeniForm.Click += new System.EventHandler(this.tsmYeniForm_Click);
            // 
            // tsmYeniNot
            // 
            this.tsmYeniNot.Enabled = false;
            this.tsmYeniNot.Name = "tsmYeniNot";
            this.tsmYeniNot.Size = new System.Drawing.Size(180, 22);
            this.tsmYeniNot.Text = "Yeni Not Ekle";
            this.tsmYeniNot.Click += new System.EventHandler(this.tsmYeniNot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 490);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFormIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmYeniForm;
        private System.Windows.Forms.ToolStripMenuItem tsmYeniNot;
    }
}

