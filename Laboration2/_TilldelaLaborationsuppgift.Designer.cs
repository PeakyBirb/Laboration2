namespace Laboration2
{
    partial class _TilldelaLaborationsuppgift
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
            this.KurserListBox = new System.Windows.Forms.ListBox();
            this.RedigeraKursText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KurserListBox
            // 
            this.KurserListBox.FormattingEnabled = true;
            this.KurserListBox.Location = new System.Drawing.Point(63, 87);
            this.KurserListBox.Name = "KurserListBox";
            this.KurserListBox.Size = new System.Drawing.Size(259, 108);
            this.KurserListBox.TabIndex = 0;
            // 
            // RedigeraKursText
            // 
            this.RedigeraKursText.AutoSize = true;
            this.RedigeraKursText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedigeraKursText.Location = new System.Drawing.Point(60, 48);
            this.RedigeraKursText.Name = "RedigeraKursText";
            this.RedigeraKursText.Size = new System.Drawing.Size(62, 16);
            this.RedigeraKursText.TabIndex = 2;
            this.RedigeraKursText.Text = "Välj kurs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Namn på laborationsuppgift:";
            // 
            // _TilldelaLaborationsuppgift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RedigeraKursText);
            this.Controls.Add(this.KurserListBox);
            this.Name = "_TilldelaLaborationsuppgift";
            this.Text = "Tilldela laborationsuppgift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox KurserListBox;
        private System.Windows.Forms.Label RedigeraKursText;
        private System.Windows.Forms.Label label1;
    }
}