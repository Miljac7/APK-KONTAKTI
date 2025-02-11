using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_zadatak
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void listBoxKontakti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void DodajKontakt(string kontakt)
        {

            listBoxKontakti.Items.Add(kontakt);
    

        }

    

            private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzbrisiKontakt_Click(object sender, EventArgs e)
        {
            if (listBoxKontakti.SelectedItem != null)
            {
                // Ukloni odabrani kontakt iz ListBox-a
                listBoxKontakti.Items.Remove(listBoxKontakti.SelectedItem);
                MessageBox.Show("Kontakt je izbrisan!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Molimo odaberite kontakt za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
