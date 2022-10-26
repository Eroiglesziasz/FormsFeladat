namespace hazifeladat
{
    partial class Feladat
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
            this.azonosito = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.szuletett = new System.Windows.Forms.DateTimePicker();
            this.holszuletett = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gomb = new System.Windows.Forms.Button();
            this.nyelv = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.azonosito)).BeginInit();
            this.SuspendLayout();
            // 
            // azonosito
            // 
            this.azonosito.Location = new System.Drawing.Point(125, 25);
            this.azonosito.Name = "azonosito";
            this.azonosito.Size = new System.Drawing.Size(120, 20);
            this.azonosito.TabIndex = 0;
            this.azonosito.ValueChanged += new System.EventHandler(this.azonosito_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azonositó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(71, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(124, 51);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(120, 20);
            this.nev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(61, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nyelv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mikor született:";
            // 
            // szuletett
            // 
            this.szuletett.Location = new System.Drawing.Point(124, 77);
            this.szuletett.Name = "szuletett";
            this.szuletett.Size = new System.Drawing.Size(120, 20);
            this.szuletett.TabIndex = 6;
            // 
            // holszuletett
            // 
            this.holszuletett.FormattingEnabled = true;
            this.holszuletett.Items.AddRange(new object[] {
            "Kecskemét",
            "Pécs",
            "Békéscsaba",
            "Miskolc",
            "Szeged",
            "Székesfehérvár",
            "Győr",
            "Budapest",
            "Debrecen",
            "Egyéb"});
            this.holszuletett.Location = new System.Drawing.Point(124, 103);
            this.holszuletett.Name = "holszuletett";
            this.holszuletett.Size = new System.Drawing.Size(121, 21);
            this.holszuletett.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(28, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hol született:";
            // 
            // gomb
            // 
            this.gomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gomb.Location = new System.Drawing.Point(124, 187);
            this.gomb.Name = "gomb";
            this.gomb.Size = new System.Drawing.Size(141, 65);
            this.gomb.TabIndex = 10;
            this.gomb.Text = "Parancsgomb";
            this.gomb.UseVisualStyleBackColor = true;
            this.gomb.Click += new System.EventHandler(this.gomb_Click);
            // 
            // nyelv
            // 
            this.nyelv.FormattingEnabled = true;
            this.nyelv.Items.AddRange(new object[] {
            "Angol",
            "Német",
            "Francia",
            "Olasz"});
            this.nyelv.Location = new System.Drawing.Point(124, 130);
            this.nyelv.Name = "nyelv";
            this.nyelv.Size = new System.Drawing.Size(121, 21);
            this.nyelv.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(297, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kilepes
            // 
            this.kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.kilepes.Location = new System.Drawing.Point(297, 302);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(75, 23);
            this.kilepes.TabIndex = 13;
            this.kilepes.Text = "Kilépés";
            this.kilepes.UseVisualStyleBackColor = true;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // Feladat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 377);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nyelv);
            this.Controls.Add(this.gomb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.holszuletett);
            this.Controls.Add(this.szuletett);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.azonosito);
            this.Name = "Feladat";
            this.Text = "Feladat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.azonosito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown azonosito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker szuletett;
        private System.Windows.Forms.ComboBox holszuletett;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button gomb;
        private System.Windows.Forms.ComboBox nyelv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kilepes;
    }
}

