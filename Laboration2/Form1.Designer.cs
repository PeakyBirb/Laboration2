namespace Laboration2
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SkapaKurs
            // 
            this.SkapaKurs.BackColor = System.Drawing.Color.Yellow;
            this.SkapaKurs.Location = new System.Drawing.Point(61, 167);
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
            this.VälkommenKnapp.Location = new System.Drawing.Point(35, 68);
            this.VälkommenKnapp.Name = "VälkommenKnapp";
            this.VälkommenKnapp.Size = new System.Drawing.Size(611, 37);
            this.VälkommenKnapp.TabIndex = 1;
            this.VälkommenKnapp.Text = "Välkommen admin! Vad vill du göra idag?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(275, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Skapa kurs";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 338);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

