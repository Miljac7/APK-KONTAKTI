using System.Text.RegularExpressions;

namespace Zavrsni_zadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajKontakt_Click(object sender, EventArgs e)
        {
            // provjera upisanih polja
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Ime i telefon su obavezni!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(txtTelefon.Text, @"^\d+$"))
            {
                MessageBox.Show("Telefon može sadržavati samo brojeve!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validacija email adrese (mora završavati s @gmail.com)
            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email mora završavati s @gmail.com!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kreiranje kontakta
            string kontakt = $"{txtIme.Text} {txtPrezime.Text} - {txtEmail.Text} - {txtTelefon.Text} - {txtOpis.Text}";

            // Dodavanje kontakta u ListBox na Form2
            Form2 form2 = new Form2();
            form2.DodajKontakt(kontakt);
            form2.Show();

            txtIme.Clear();
            txtPrezime.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            txtOpis.Clear();
        }

        private void btnPrikaziKontakte_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
