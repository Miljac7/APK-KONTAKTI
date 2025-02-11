namespace Zavrsni_zadatak
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
            listBoxKontakti = new ListBox();
            btnIzbrisiKontakt = new Button();
            btnUrediKontakt = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxKontakti
            // 
            listBoxKontakti.BackColor = Color.LightBlue;
            listBoxKontakti.Font = new Font("Segoe UI", 13F);
            listBoxKontakti.FormattingEnabled = true;
            listBoxKontakti.ItemHeight = 30;
            listBoxKontakti.Location = new Point(51, 63);
            listBoxKontakti.Name = "listBoxKontakti";
            listBoxKontakti.Size = new Size(1245, 574);
            listBoxKontakti.TabIndex = 0;
            listBoxKontakti.SelectedIndexChanged += listBoxKontakti_SelectedIndexChanged;
            // 
            // btnIzbrisiKontakt
            // 
            btnIzbrisiKontakt.BackColor = Color.LightBlue;
            btnIzbrisiKontakt.Font = new Font("Segoe UI", 12F);
            btnIzbrisiKontakt.Location = new Point(1114, 644);
            btnIzbrisiKontakt.Name = "btnIzbrisiKontakt";
            btnIzbrisiKontakt.Size = new Size(165, 42);
            btnIzbrisiKontakt.TabIndex = 1;
            btnIzbrisiKontakt.Text = "Izbrisi Kontakt";
            btnIzbrisiKontakt.UseVisualStyleBackColor = false;
            btnIzbrisiKontakt.Click += btnIzbrisiKontakt_Click;
            // 
            // btnUrediKontakt
            // 
            btnUrediKontakt.BackColor = Color.LightBlue;
            btnUrediKontakt.Font = new Font("Segoe UI", 12F);
            btnUrediKontakt.Location = new Point(926, 644);
            btnUrediKontakt.Name = "btnUrediKontakt";
            btnUrediKontakt.Size = new Size(165, 42);
            btnUrediKontakt.TabIndex = 2;
            btnUrediKontakt.Text = "Uredi Kontakt";
            btnUrediKontakt.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightBlue;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(51, 644);
            button3.Name = "button3";
            button3.Size = new Size(165, 42);
            button3.TabIndex = 3;
            button3.Text = "Povratak";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(578, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 46);
            label1.TabIndex = 4;
            label1.Text = "Kontakti";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 157, 28);
            ClientSize = new Size(1340, 698);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(btnUrediKontakt);
            Controls.Add(btnIzbrisiKontakt);
            Controls.Add(listBoxKontakti);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxKontakti;
        private Button btnIzbrisiKontakt;
        private Button btnUrediKontakt;
        private Button button3;
        private Label label1;
    }
}