﻿namespace Laboration2
{
    partial class Form2
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
            this.VäljStudenterText = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.KursnamnText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KlarKnapp = new System.Windows.Forms.Button();
            this.StartdatumText = new System.Windows.Forms.Label();
            this.StartdatumVäljare = new System.Windows.Forms.DateTimePicker();
            this.SlutdatumVäljare = new System.Windows.Forms.DateTimePicker();
            this.Slutdatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VäljStudenterText
            // 
            this.VäljStudenterText.AutoSize = true;
            this.VäljStudenterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VäljStudenterText.Location = new System.Drawing.Point(40, 253);
            this.VäljStudenterText.Name = "VäljStudenterText";
            this.VäljStudenterText.Size = new System.Drawing.Size(252, 16);
            this.VäljStudenterText.TabIndex = 0;
            this.VäljStudenterText.Text = "Välj vilka studenter som ska ingå i kursen";
            this.VäljStudenterText.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 295);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(293, 95);
            this.listBox1.TabIndex = 1;
            // 
            // KursnamnText
            // 
            this.KursnamnText.AutoSize = true;
            this.KursnamnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KursnamnText.Location = new System.Drawing.Point(41, 55);
            this.KursnamnText.Name = "KursnamnText";
            this.KursnamnText.Size = new System.Drawing.Size(67, 16);
            this.KursnamnText.TabIndex = 0;
            this.KursnamnText.Text = "Kursnamn";
            this.KursnamnText.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // KlarKnapp
            // 
            this.KlarKnapp.Location = new System.Drawing.Point(652, 367);
            this.KlarKnapp.Name = "KlarKnapp";
            this.KlarKnapp.Size = new System.Drawing.Size(75, 23);
            this.KlarKnapp.TabIndex = 3;
            this.KlarKnapp.Text = "Klar";
            this.KlarKnapp.UseVisualStyleBackColor = true;
            // 
            // StartdatumText
            // 
            this.StartdatumText.AutoSize = true;
            this.StartdatumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartdatumText.Location = new System.Drawing.Point(41, 121);
            this.StartdatumText.Name = "StartdatumText";
            this.StartdatumText.Size = new System.Drawing.Size(72, 16);
            this.StartdatumText.TabIndex = 0;
            this.StartdatumText.Text = "Startdatum";
            this.StartdatumText.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartdatumVäljare
            // 
            this.StartdatumVäljare.Location = new System.Drawing.Point(137, 117);
            this.StartdatumVäljare.Name = "StartdatumVäljare";
            this.StartdatumVäljare.Size = new System.Drawing.Size(200, 20);
            this.StartdatumVäljare.TabIndex = 4;
            // 
            // SlutdatumVäljare
            // 
            this.SlutdatumVäljare.Location = new System.Drawing.Point(137, 161);
            this.SlutdatumVäljare.Name = "SlutdatumVäljare";
            this.SlutdatumVäljare.Size = new System.Drawing.Size(200, 20);
            this.SlutdatumVäljare.TabIndex = 4;
            // 
            // Slutdatum
            // 
            this.Slutdatum.AutoSize = true;
            this.Slutdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slutdatum.Location = new System.Drawing.Point(41, 165);
            this.Slutdatum.Name = "Slutdatum";
            this.Slutdatum.Size = new System.Drawing.Size(67, 16);
            this.Slutdatum.TabIndex = 0;
            this.Slutdatum.Text = "Slutdatum";
            this.Slutdatum.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 446);
            this.Controls.Add(this.SlutdatumVäljare);
            this.Controls.Add(this.StartdatumVäljare);
            this.Controls.Add(this.KlarKnapp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Slutdatum);
            this.Controls.Add(this.StartdatumText);
            this.Controls.Add(this.KursnamnText);
            this.Controls.Add(this.VäljStudenterText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VäljStudenterText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label KursnamnText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button KlarKnapp;
        private System.Windows.Forms.Label StartdatumText;
        private System.Windows.Forms.DateTimePicker StartdatumVäljare;
        private System.Windows.Forms.DateTimePicker SlutdatumVäljare;
        private System.Windows.Forms.Label Slutdatum;
    }
}