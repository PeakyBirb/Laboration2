﻿namespace Laboration2
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
            this.SkapaKurs = new System.Windows.Forms.Button();
            this.VälkommenKnapp = new System.Windows.Forms.Label();
            this.RedigeraKurs = new System.Windows.Forms.Button();
            this.TilldelaLab = new System.Windows.Forms.Button();
            this.BetygsättLab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SkapaKurs
            // 
            this.SkapaKurs.BackColor = System.Drawing.Color.Yellow;
            this.SkapaKurs.Location = new System.Drawing.Point(110, 131);
            this.SkapaKurs.Name = "SkapaKurs";
            this.SkapaKurs.Size = new System.Drawing.Size(130, 78);
            this.SkapaKurs.TabIndex = 0;
            this.SkapaKurs.Text = "Skapa kurs";
            this.SkapaKurs.UseVisualStyleBackColor = false;
            this.SkapaKurs.Click += new System.EventHandler(this.button1_Click);
            // 
            // VälkommenKnapp
            // 
            this.VälkommenKnapp.AutoSize = true;
            this.VälkommenKnapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VälkommenKnapp.Location = new System.Drawing.Point(35, 55);
            this.VälkommenKnapp.Name = "VälkommenKnapp";
            this.VälkommenKnapp.Size = new System.Drawing.Size(611, 37);
            this.VälkommenKnapp.TabIndex = 1;
            this.VälkommenKnapp.Text = "Välkommen admin! Vad vill du göra idag?";
            // 
            // RedigeraKurs
            // 
            this.RedigeraKurs.BackColor = System.Drawing.Color.Yellow;
            this.RedigeraKurs.Location = new System.Drawing.Point(110, 232);
            this.RedigeraKurs.Name = "RedigeraKurs";
            this.RedigeraKurs.Size = new System.Drawing.Size(130, 78);
            this.RedigeraKurs.TabIndex = 2;
            this.RedigeraKurs.Text = "Redigera kurs";
            this.RedigeraKurs.UseVisualStyleBackColor = false;
            // 
            // TilldelaLab
            // 
            this.TilldelaLab.BackColor = System.Drawing.Color.Yellow;
            this.TilldelaLab.Location = new System.Drawing.Point(110, 333);
            this.TilldelaLab.Name = "TilldelaLab";
            this.TilldelaLab.Size = new System.Drawing.Size(130, 78);
            this.TilldelaLab.TabIndex = 3;
            this.TilldelaLab.Text = "Tilldela lab. uppgift till kurs";
            this.TilldelaLab.UseVisualStyleBackColor = false;
            // 
            // BetygsättLab
            // 
            this.BetygsättLab.BackColor = System.Drawing.Color.Yellow;
            this.BetygsättLab.Location = new System.Drawing.Point(398, 131);
            this.BetygsättLab.Name = "BetygsättLab";
            this.BetygsättLab.Size = new System.Drawing.Size(130, 78);
            this.BetygsättLab.TabIndex = 4;
            this.BetygsättLab.Text = "Tilldela lab. uppgift till kurs";
            this.BetygsättLab.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 423);
            this.Controls.Add(this.BetygsättLab);
            this.Controls.Add(this.TilldelaLab);
            this.Controls.Add(this.RedigeraKurs);
            this.Controls.Add(this.VälkommenKnapp);
            this.Controls.Add(this.SkapaKurs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SkapaKurs;
        private System.Windows.Forms.Label VälkommenKnapp;
        private System.Windows.Forms.Button RedigeraKurs;
        private System.Windows.Forms.Button TilldelaLab;
        private System.Windows.Forms.Button BetygsättLab;
    }
}
