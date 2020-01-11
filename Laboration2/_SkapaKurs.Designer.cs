namespace Laboration2
{
    partial class _SkapaKurs
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
            this.components = new System.ComponentModel.Container();
            this.VäljStudenterText = new System.Windows.Forms.Label();
            this.StudenterListBox = new System.Windows.Forms.ListBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.KursnamnText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KlarKnapp = new System.Windows.Forms.Button();
            this.StartdatumText = new System.Windows.Forms.Label();
            this.StartdatumVäljare = new System.Windows.Forms.DateTimePicker();
            this.SlutdatumVäljare = new System.Windows.Forms.DateTimePicker();
            this.Slutdatum = new System.Windows.Forms.Label();
            this.LärareListBox = new System.Windows.Forms.ListBox();
            this.LärarlagText = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
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
            // StudenterListBox
            // 
            this.StudenterListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personBindingSource, "personID", true));
            this.StudenterListBox.DataSource = this.personBindingSource;
            this.StudenterListBox.DisplayMember = "förnamn";
            this.StudenterListBox.FormattingEnabled = true;
            this.StudenterListBox.Location = new System.Drawing.Point(44, 295);
            this.StudenterListBox.Name = "StudenterListBox";
            this.StudenterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.StudenterListBox.Size = new System.Drawing.Size(293, 95);
            this.StudenterListBox.TabIndex = 1;
            this.StudenterListBox.ValueMember = "efternamn";
            this.StudenterListBox.SelectedIndexChanged += new System.EventHandler(this.StudenterListBox_SelectedIndexChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Laboration2.Person);
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataSource = typeof(Laboration2.Person);
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
            this.KlarKnapp.Location = new System.Drawing.Point(666, 411);
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
            // LärareListBox
            // 
            this.LärareListBox.FormattingEnabled = true;
            this.LärareListBox.Location = new System.Drawing.Point(434, 295);
            this.LärareListBox.Name = "LärareListBox";
            this.LärareListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LärareListBox.Size = new System.Drawing.Size(277, 95);
            this.LärareListBox.TabIndex = 1;
            // 
            // LärarlagText
            // 
            this.LärarlagText.AutoSize = true;
            this.LärarlagText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LärarlagText.Location = new System.Drawing.Point(431, 253);
            this.LärarlagText.Name = "LärarlagText";
            this.LärarlagText.Size = new System.Drawing.Size(248, 16);
            this.LärarlagText.TabIndex = 0;
            this.LärarlagText.Text = "Lärare som undervisar i kursen (lärarlag)";
            this.LärarlagText.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Laboration2.Student);
            // 
            // _SkapaKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 446);
            this.Controls.Add(this.SlutdatumVäljare);
            this.Controls.Add(this.StartdatumVäljare);
            this.Controls.Add(this.KlarKnapp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LärareListBox);
            this.Controls.Add(this.StudenterListBox);
            this.Controls.Add(this.Slutdatum);
            this.Controls.Add(this.StartdatumText);
            this.Controls.Add(this.LärarlagText);
            this.Controls.Add(this.KursnamnText);
            this.Controls.Add(this.VäljStudenterText);
            this.Name = "_SkapaKurs";
            this.Text = "Skapa kurs";
            this.Load += new System.EventHandler(this._SkapaKurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VäljStudenterText;
        private System.Windows.Forms.ListBox StudenterListBox;
        private System.Windows.Forms.Label KursnamnText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button KlarKnapp;
        private System.Windows.Forms.Label StartdatumText;
        private System.Windows.Forms.DateTimePicker StartdatumVäljare;
        private System.Windows.Forms.DateTimePicker SlutdatumVäljare;
        private System.Windows.Forms.Label Slutdatum;
        private System.Windows.Forms.ListBox LärareListBox;
        private System.Windows.Forms.Label LärarlagText;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource1;
    }
}