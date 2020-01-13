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
            this.KursnamnText = new System.Windows.Forms.Label();
            this.StartdatumText = new System.Windows.Forms.Label();
            this.Slutdatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VisaAllaKurserListBox
            // 
            this.VisaAllaKurserListBox.FormattingEnabled = true;
            this.VisaAllaKurserListBox.Location = new System.Drawing.Point(54, 72);
            this.VisaAllaKurserListBox.Name = "VisaAllaKurserListBox";
            this.VisaAllaKurserListBox.Size = new System.Drawing.Size(284, 95);
            this.VisaAllaKurserListBox.TabIndex = 0;
            this.VisaAllaKurserListBox.SelectedIndexChanged += new System.EventHandler(this.VisaAllaKurserListBox_SelectedIndexChanged);
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
            this.TaBortKursKnapp.Click += new System.EventHandler(this.TaBortKnapp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 4;
            // 
            // KursnamnText
            // 
            this.KursnamnText.AutoSize = true;
            this.KursnamnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KursnamnText.Location = new System.Drawing.Point(51, 238);
            this.KursnamnText.Name = "KursnamnText";
            this.KursnamnText.Size = new System.Drawing.Size(70, 16);
            this.KursnamnText.TabIndex = 5;
            this.KursnamnText.Text = "Kursnamn:";
            // 
            // StartdatumText
            // 
            this.StartdatumText.AutoSize = true;
            this.StartdatumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartdatumText.Location = new System.Drawing.Point(51, 296);
            this.StartdatumText.Name = "StartdatumText";
            this.StartdatumText.Size = new System.Drawing.Size(75, 16);
            this.StartdatumText.TabIndex = 6;
            this.StartdatumText.Text = "Startdatum:";
            // 
            // Slutdatum
            // 
            this.Slutdatum.AutoSize = true;
            this.Slutdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slutdatum.Location = new System.Drawing.Point(51, 337);
            this.Slutdatum.Name = "Slutdatum";
            this.Slutdatum.Size = new System.Drawing.Size(70, 16);
            this.Slutdatum.TabIndex = 7;
            this.Slutdatum.Text = "Slutdatum:";
            // 
            // _RedigeraKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Slutdatum);
            this.Controls.Add(this.StartdatumText);
            this.Controls.Add(this.KursnamnText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TaBortKursKnapp);
            this.Controls.Add(this.RedigeraKursKnapp);
            this.Controls.Add(this.RedigeraKursText);
            this.Controls.Add(this.VisaAllaKurserListBox);
            this.Name = "_RedigeraKurs";
            this.Text = "RedigeraKurs";
            this.Load += new System.EventHandler(this._RedigeraKurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VisaAllaKurserListBox;
        private System.Windows.Forms.Label RedigeraKursText;
        private System.Windows.Forms.Button RedigeraKursKnapp;
        private System.Windows.Forms.Button TaBortKursKnapp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label KursnamnText;
        private System.Windows.Forms.Label StartdatumText;
        private System.Windows.Forms.Label Slutdatum;
    }
}