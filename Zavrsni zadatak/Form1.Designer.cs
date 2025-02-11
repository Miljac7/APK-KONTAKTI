namespace Zavrsni_zadatak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtOpis = new TextBox();
            label5 = new Label();
            btnDodajKontakt = new Button();
            pictureBox1 = new PictureBox();
            btnPrikaziKontakte = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(43, 111);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 1;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(43, 159);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 2;
            label2.Text = "Prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(43, 204);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(43, 249);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 4;
            label4.Text = "Telefon";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(131, 116);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(184, 27);
            txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(131, 159);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(184, 27);
            txtPrezime.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(131, 246);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(184, 27);
            txtTelefon.TabIndex = 9;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(43, 345);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(272, 88);
            txtOpis.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(174, 295);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 11;
            label5.Text = "Opis";
            label5.Click += label5_Click;
            // 
            // btnDodajKontakt
            // 
            btnDodajKontakt.BackColor = Color.LightBlue;
            btnDodajKontakt.Font = new Font("Segoe UI", 12F);
            btnDodajKontakt.Location = new Point(43, 47);
            btnDodajKontakt.Name = "btnDodajKontakt";
            btnDodajKontakt.Size = new Size(181, 41);
            btnDodajKontakt.TabIndex = 12;
            btnDodajKontakt.Text = "Dodaj Kontakt";
            btnDodajKontakt.UseVisualStyleBackColor = false;
            btnDodajKontakt.Click += btnDodajKontakt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(409, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(492, 245);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnPrikaziKontakte
            // 
            btnPrikaziKontakte.BackColor = Color.LightBlue;
            btnPrikaziKontakte.Font = new Font("Segoe UI", 15F);
            btnPrikaziKontakte.Location = new Point(675, 366);
            btnPrikaziKontakte.Name = "btnPrikaziKontakte";
            btnPrikaziKontakte.Size = new Size(211, 67);
            btnPrikaziKontakte.TabIndex = 14;
            btnPrikaziKontakte.Text = "Kontakti";
            btnPrikaziKontakte.UseVisualStyleBackColor = false;
            btnPrikaziKontakte.Click += btnPrikaziKontakte_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(421, 381);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Ne";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(421, 346);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 24);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Da";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(336, 345);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 17;
            label6.Text = "Favorit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 157, 28);
            ClientSize = new Size(913, 491);
            Controls.Add(label6);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnPrikaziKontakte);
            Controls.Add(pictureBox1);
            Controls.Add(btnDodajKontakt);
            Controls.Add(label5);
            Controls.Add(txtOpis);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtOpis;
        private Label label5;
        private Button btnDodajKontakt;
        private PictureBox pictureBox1;
        private Button btnPrikaziKontakte;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label6;
    }
}
