namespace Laboration2
{
    partial class _RedigeraKurs
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
            this.VisaAllaKurserListBox = new System.Windows.Forms.ListBox();
            this.RedigeraKursText = new System.Windows.Forms.Label();
            this.RedigeraKursKnapp = new System.Windows.Forms.Button();
            this.TaBortKursKnapp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VisaAllaKurserListBox
            // 
            this.VisaAllaKurserListBox.FormattingEnabled = true;
            this.VisaAllaKurserListBox.Location = new System.Drawing.Point(54, 72);
            this.VisaAllaKurserListBox.Name = "VisaAllaKurserListBox";
            this.VisaAllaKurserListBox.Size = new System.Drawing.Size(284, 95);
            this.VisaAllaKurserListBox.TabIndex = 0;
            // 
            // RedigeraKursText
            // 
            this.RedigeraKursText.AutoSize = true;
            this.RedigeraKursText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedigeraKursText.Location = new System.Drawing.Point(51, 35);
            this.RedigeraKursText.Name = "RedigeraKursText";
            this.RedigeraKursText.Size = new System.Drawing.Size(183, 16);
            this.RedigeraKursText.TabIndex = 1;
            this.RedigeraKursText.Text = "Välj kurs som skall redigeras:";
            // 
            // RedigeraKursKnapp
            // 
            this.RedigeraKursKnapp.Location = new System.Drawing.Point(263, 173);
            this.RedigeraKursKnapp.Name = "RedigeraKursKnapp";
            this.RedigeraKursKnapp.Size = new System.Drawing.Size(75, 23);
            this.RedigeraKursKnapp.TabIndex = 2;
            this.RedigeraKursKnapp.Text = "Redigera";
            this.RedigeraKursKnapp.UseVisualStyleBackColor = true;
            this.RedigeraKursKnapp.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaBortKursKnapp
            // 
            this.TaBortKursKnapp.Location = new System.Drawing.Point(172, 173);
            this.TaBortKursKnapp.Name = "TaBortKursKnapp";
            this.TaBortKursKnapp.Size = new System.Drawing.Size(75, 23);
            this.TaBortKursKnapp.TabIndex = 3;
            this.TaBortKursKnapp.Text = "Ta bort";
            this.TaBortKursKnapp.UseVisualStyleBackColor = true;
            this.TaBortKursKnapp.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 4;
            // 
            // _RedigeraKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TaBortKursKnapp);
            this.Controls.Add(this.RedigeraKursKnapp);
            this.Controls.Add(this.RedigeraKursText);
            this.Controls.Add(this.VisaAllaKurserListBox);
            this.Name = "_RedigeraKurs";
            this.Text = "RedigeraKurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VisaAllaKurserListBox;
        private System.Windows.Forms.Label RedigeraKursText;
        private System.Windows.Forms.Button RedigeraKursKnapp;
        private System.Windows.Forms.Button TaBortKursKnapp;
        private System.Windows.Forms.TextBox textBox1;
    }
}