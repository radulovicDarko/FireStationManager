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
    public partial class DogadjajiForm : Form
    {
        private readonly DogadjajRepo dogadjajRepo;
        public DogadjajiForm()
        {
            InitializeComponent();
            dogadjajRepo = new DogadjajRepo();
        }

        private void FillData()
        {
            List<Dogadjaj> dogadjaji = dogadjajRepo.GetDogadjaji();

            listViewDogadjaji.Items.Clear();
            foreach (Dogadjaj d in dogadjaji)
                listViewDogadjaji.Items.Add(new ListViewItem(new[] { d.sifra.ToString(), d.opis, d.mesto, d.adresa, d.velicina, d.ugrozenostLjudiDogadjaja}));
        }

        private void ClearData()
        {
            textBoxSifra.Text = "";
            textBoxOpis.Text = "";
            textBoxMesto.Text = "";
            textBoxAdresa.Text = "";
            textBoxVelicina.Text = "";
            textBoxUgrozenost.Text = "";
        }

        private void btnAddDogadjaj_Click(object sender, EventArgs e)
        {
            int count = 0;
            //sifra
            if (String.IsNullOrEmpty(textBoxSifra.Text))
            {
                textBoxSifra.Focus();
                errorProvider.SetError(textBoxSifra, "Unesite sifru!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxSifra, null);
            }
            //opis
            if (String.IsNullOrEmpty(textBoxOpis.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxOpis, "Unesite opis!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxOpis, null);
            }
            //mesto
            if (String.IsNullOrEmpty(textBoxMesto.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxMesto, "Unesite mesto!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxMesto, null);
            }
            //adresa
            if (String.IsNullOrEmpty(textBoxAdresa.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxAdresa, "Unesite adresu!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxAdresa, null);
            }
            //velicina
            if (String.IsNullOrEmpty(textBoxVelicina.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxVelicina, "Unesite velicinu dogadjaja!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxVelicina, null);
            }
            //ugrozenost ljudi i dogadjaja
            if (String.IsNullOrEmpty(textBoxUgrozenost.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxUgrozenost, "Unesite ugrozenost ljudi i dogadjaja!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxUgrozenost, null);
            }

            if (count > 0)
                return;
            else
            {
                Dogadjaj d = new Dogadjaj
                {
                    sifra = Convert.ToInt32(textBoxSifra.Text),
                    opis = textBoxOpis.Text,
                    mesto = textBoxMesto.Text,
                    adresa = textBoxAdresa.Text,
                    velicina = textBoxVelicina.Text,
                    ugrozenostLjudiDogadjaja = textBoxUgrozenost.Text
                };

                if (dogadjajRepo.InsertDogadjaj(d))
                    MessageBox.Show("Dogadjaj sa sifrom " + d.sifra + " uspesno je dodat u evidenciju!");
                else
                    MessageBox.Show("Proverite podatke!");

                ClearData();
                FillData();
            }
        }

        private void btnUpdateDogadjaj_Click(object sender, EventArgs e)
        {
            int count = 0;
            //sifra
            if (String.IsNullOrEmpty(textBoxSifra.Text))
            {
                textBoxSifra.Focus();
                errorProvider.SetError(textBoxSifra, "Unesite sifru!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxSifra, null);
            }
            //opis
            if (String.IsNullOrEmpty(textBoxOpis.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxOpis, "Unesite opis!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxOpis, null);
            }
            //mesto
            if (String.IsNullOrEmpty(textBoxMesto.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxMesto, "Unesite mesto!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxMesto, null);
            }
            //adresa
            if (String.IsNullOrEmpty(textBoxAdresa.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxAdresa, "Unesite adresu!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxAdresa, null);
            }
            //velicina
            if (String.IsNullOrEmpty(textBoxVelicina.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxVelicina, "Unesite velicinu dogadjaja!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxVelicina, null);
            }
            //ugrozenost ljudi i dogadjaja
            if (String.IsNullOrEmpty(textBoxUgrozenost.Text))
            {
                textBoxOpis.Focus();
                errorProvider.SetError(textBoxUgrozenost, "Unesite ugrozenost ljudi i dogadjaja!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxUgrozenost, null);
            }

            if (count > 0)
                return;
            else
            {
                Dogadjaj dogadjaj = new Dogadjaj
                {
                    sifra = Convert.ToInt32(textBoxSifra.Text),
                    opis = textBoxOpis.Text,
                    mesto = textBoxMesto.Text,
                    adresa = textBoxAdresa.Text,
                    velicina = textBoxVelicina.Text,
                    ugrozenostLjudiDogadjaja = textBoxUgrozenost.Text
                };

                try
                {
                    if (dogadjajRepo.UpdateDogadjaj(dogadjaj, listViewDogadjaji.SelectedItems[0].SubItems[0].Text))
                        MessageBox.Show("Podaci o dogadjaju sa sifrom " + dogadjaj.sifra + " su uspesno azurirani!");

                    ClearData();
                    FillData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Izaberite dogadjaj!");
                }
            }
        }

        private void btnDeleteDogadjaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (dogadjajRepo.DeleteDogadjaj(Convert.ToInt32(listViewDogadjaji.SelectedItems[0].SubItems[0].Text)))
                    MessageBox.Show("Dogadjaj sa sifrom " + listViewDogadjaji.SelectedItems[0].SubItems[0].Text + " uspesno je izbrisan iz evidencije!");

                ClearData();
                FillData();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite dogadjaj!");
            }
        }

        private void Dogadjaji_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
