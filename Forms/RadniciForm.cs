using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vatrogasna_stanica.Models;
using Vatrogasna_stanica.Repos;

namespace Vatrogasna_stanica.Forms
{
    public partial class RadniciForm : Form
    {
        private readonly RadnikRepo radnikRepo;
        private readonly RadnoMestoRepo radnoMestoRepo;
        public RadniciForm()
        {
            InitializeComponent();
            radnikRepo = new RadnikRepo();
            radnoMestoRepo = new RadnoMestoRepo();
        }

        private void Radnici_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            List<Radnik> radnici = radnikRepo.GetRadnici();

            List<RadnoMesto> radnaMesta = radnoMestoRepo.GetRadnaMesta();
            foreach (RadnoMesto radnoMesto in radnaMesta)
                comboBoxRadnaMesta.Items.Add(radnoMesto.naziv);
            comboBoxRadnaMesta.SelectedIndex = 0;

            listViewRadnici.Items.Clear();
            foreach (Radnik r in radnici)
                listViewRadnici.Items.Add(new ListViewItem(new[] { r.ime, r.prezime, r.jmbg, r.adresa, r.telefon, r.nazivRadnogMesta }));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            //ime
            if (String.IsNullOrEmpty(textBoxIme.Text))
            {
                textBoxIme.Focus();
                errorProvider.SetError(textBoxIme, "Unesite ime!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxIme, null);
            }

            //prezime
            if (String.IsNullOrEmpty(textBoxPrezime.Text))
            {
                textBoxPrezime.Focus();
                errorProvider.SetError(textBoxPrezime, "Unesite prezime!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxPrezime, null);
            }

            //jmbg
            if (String.IsNullOrEmpty(textBoxJmbg.Text))
            {
                textBoxJmbg.Focus();
                errorProvider.SetError(textBoxJmbg, "Unesite JMBG!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxJmbg, null);
            }

            //adresa
            if (String.IsNullOrEmpty(textBoxAdresa.Text))
            {
                textBoxAdresa.Focus();
                errorProvider.SetError(textBoxAdresa, "Unesite adresu!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxAdresa, null);
            }

            //telefon
            if (String.IsNullOrEmpty(textBoxTelefon.Text))
            {
                textBoxTelefon.Focus();
                errorProvider.SetError(textBoxTelefon, "Unesite telefon!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxTelefon, null);
            }

            if (count > 0)
                return;
            else
            {
                Radnik radnik = new Radnik {
                    ime = textBoxIme.Text,
                    prezime = textBoxPrezime.Text,
                    jmbg = textBoxJmbg.Text,
                    telefon = textBoxTelefon.Text,
                    adresa = textBoxAdresa.Text,
                    nazivRadnogMesta = comboBoxRadnaMesta.SelectedItem.ToString()
                };

                if (radnikRepo.InsertRadnik(radnik))
                    MessageBox.Show("Radnik " + radnik.ime + " uspesno dodat u evidenciju!");
                else
                    MessageBox.Show("Proverite podatke!");

                ClearData();
                FillData();
            }
        }

        private void ClearData()
        {
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxJmbg.Text = "";
            textBoxAdresa.Text = "";
            textBoxTelefon.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (radnikRepo.DeleteRadnik(listViewRadnici.SelectedItems[0].SubItems[2].Text))
                    MessageBox.Show("Radnik " + listViewRadnici.SelectedItems[0].SubItems[1].Text + " uspesno izbrisan iz evidencije!");
                
                ClearData();
                FillData();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite radnika!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int count = 0;
            //ime
            if (String.IsNullOrEmpty(textBoxIme.Text))
            {
                textBoxIme.Focus();
                errorProvider.SetError(textBoxIme, "Unesite ime!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxIme, null);
            }

            //prezime
            if (String.IsNullOrEmpty(textBoxPrezime.Text))
            {
                textBoxPrezime.Focus();
                errorProvider.SetError(textBoxPrezime, "Unesite prezime!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxPrezime, null);
            }

            //jmbg
            if (String.IsNullOrEmpty(textBoxJmbg.Text))
            {
                textBoxJmbg.Focus();
                errorProvider.SetError(textBoxJmbg, "Unesite JMBG!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxJmbg, null);
            }

            //adresa
            if (String.IsNullOrEmpty(textBoxAdresa.Text))
            {
                textBoxAdresa.Focus();
                errorProvider.SetError(textBoxAdresa, "Unesite adresu!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxAdresa, null);
            }

            //telefon
            if (String.IsNullOrEmpty(textBoxTelefon.Text))
            {
                textBoxTelefon.Focus();
                errorProvider.SetError(textBoxTelefon, "Unesite telefon!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxTelefon, null);
            }

            if (count > 0)
                return;
            else
            {
                Radnik radnik = new Radnik
                {
                    ime = textBoxIme.Text,
                    prezime = textBoxPrezime.Text,
                    jmbg = textBoxJmbg.Text,
                    telefon = textBoxTelefon.Text,
                    adresa = textBoxAdresa.Text,
                    nazivRadnogMesta = comboBoxRadnaMesta.SelectedItem.ToString()
                };

                try
                {
                    if (radnikRepo.UpdateRadnik(radnik,listViewRadnici.SelectedItems[0].SubItems[2].Text))
                    MessageBox.Show("Podaci o radniku " + radnik.ime + " su uspesno azurirani!");

                    ClearData();
                    FillData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Izaberite radnika!");
                }
            }
        }
    }
}
 