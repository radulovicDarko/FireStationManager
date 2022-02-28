using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vatrogasna_stanica.Models;
using Vatrogasna_stanica.Repos;

namespace Vatrogasna_stanica.Forms
{
    public partial class OpremaForm : Form
    {
        private readonly OpremaRepo opremaRepo;
        private readonly TipOpremeRepo tipOpremeRepo;
        public OpremaForm()
        {
            InitializeComponent();
            opremaRepo = new OpremaRepo();
            tipOpremeRepo = new TipOpremeRepo();
        }

        private void Oprema_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnAddOprema_Click(object sender, EventArgs e)
        {
            int count = 0;
            //fabricki broj
            if (String.IsNullOrEmpty(textBoxFabrickiBroj.Text))
            {
                textBoxFabrickiBroj.Focus();
                errorProvider.SetError(textBoxFabrickiBroj, "Unesite fabricki broj!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxFabrickiBroj, null);
            }

            //masa
            if (String.IsNullOrEmpty(textBoxMasa.Text))
            {
                textBoxMasa.Focus();
                errorProvider.SetError(textBoxMasa, "Unesite masu!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxMasa, null);
            }

            //datum proizvodnje
            if (String.IsNullOrEmpty(textBoxDatumProizvodnje.Text))
            {
                textBoxDatumProizvodnje.Focus();
                errorProvider.SetError(textBoxDatumProizvodnje, "Unesite datum proizvodnje!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxDatumProizvodnje, null);
            }

            //naziv proizvodjaca
            if (String.IsNullOrEmpty(textBoxNazivProizvodjaca.Text))
            {
                textBoxNazivProizvodjaca.Focus();
                errorProvider.SetError(textBoxNazivProizvodjaca, "Unesite naziv proizvodjaca!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxNazivProizvodjaca, null);
            }

            if (count > 0)
                return;
            else
            {
                Oprema oprema = new Oprema
                {
                    fabrickiBroj = textBoxFabrickiBroj.Text,
                    masa = Convert.ToInt32(textBoxMasa.Text),
                    datumProizvodnje = Convert.ToDateTime(textBoxDatumProizvodnje.Text),
                    nazivProizvodjaca = textBoxNazivProizvodjaca.Text,
                    sifraOpreme = tipOpremeRepo.GetTipoviOpreme().Where(x => x.naziv == comboBoxTipoviOpreme.SelectedItem.ToString()).FirstOrDefault().sifra
                };

                if (opremaRepo.InsertOprema(oprema))
                    MessageBox.Show("Oprema sa fabrickim brojem " + oprema.fabrickiBroj + " uspesno je dodata u evidenciju!");
                else
                    MessageBox.Show("Proverite podatke!");

                ClearData();
                FillData();
            }
        }

        private void btnUpdateOprema_Click(object sender, EventArgs e)
        {
            int count = 0;
            //fabricki broj
            if (String.IsNullOrEmpty(textBoxFabrickiBroj.Text))
            {
                textBoxFabrickiBroj.Focus();
                errorProvider.SetError(textBoxFabrickiBroj, "Unesite fabricki broj!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxFabrickiBroj, null);
            }

            //masa
            if (String.IsNullOrEmpty(textBoxMasa.Text))
            {
                textBoxMasa.Focus();
                errorProvider.SetError(textBoxMasa, "Unesite masu!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxMasa, null);
            }

            //datum proizvodnje
            if (String.IsNullOrEmpty(textBoxDatumProizvodnje.Text))
            {
                textBoxDatumProizvodnje.Focus();
                errorProvider.SetError(textBoxDatumProizvodnje, "Unesite datum proizvodnje!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxDatumProizvodnje, null);
            }

            //naziv proizvodjaca
            if (String.IsNullOrEmpty(textBoxNazivProizvodjaca.Text))
            {
                textBoxNazivProizvodjaca.Focus();
                errorProvider.SetError(textBoxNazivProizvodjaca, "Unesite naziv proizvodjaca!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxNazivProizvodjaca, null);
            }

            if (count > 0)
                return;
            else
            {
                Oprema oprema = new Oprema
                {
                    fabrickiBroj = textBoxFabrickiBroj.Text,
                    masa = Convert.ToInt32(textBoxMasa.Text),
                    datumProizvodnje = Convert.ToDateTime(textBoxDatumProizvodnje.Text),
                    nazivProizvodjaca = textBoxNazivProizvodjaca.Text,
                    sifraOpreme = tipOpremeRepo.GetTipoviOpreme().Where(x => x.naziv == comboBoxTipoviOpreme.SelectedItem.ToString()).FirstOrDefault().sifra
                };

                try
                {
                    if (opremaRepo.UpdateOprema(oprema, listViewOprema.SelectedItems[0].SubItems[0].Text))
                        MessageBox.Show("Podaci o opremi sa fabrickim brojem " + oprema.fabrickiBroj + " su uspesno azurirani!");

                    ClearData();
                    FillData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Izaberite opremu!");
                }
            }
        }

        private void btnDeleteOprema_Click(object sender, EventArgs e)
        {
            try
            {
                if (opremaRepo.DeleteOprema(listViewOprema.SelectedItems[0].SubItems[0].Text))
                    MessageBox.Show("Oprema sa fabrickim brojem " + listViewOprema.SelectedItems[0].SubItems[0].Text + " uspesno je izbrisana iz evidencije!");

                ClearData();
                FillData();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite opremu!");
            }

        }

        private void FillData()
        {
            List<Oprema> oprema = opremaRepo.GetOprema();

            List<TipOpreme> tipoviOpreme = tipOpremeRepo.GetTipoviOpreme();
            foreach (TipOpreme tipOpreme in tipoviOpreme)
                comboBoxTipoviOpreme.Items.Add(tipOpreme.naziv);
            comboBoxTipoviOpreme.SelectedIndex = 0;

            listViewOprema.Items.Clear();
            foreach (Oprema o in oprema)
                listViewOprema.Items.Add(new ListViewItem(new[] { o.fabrickiBroj, o.masa.ToString(), o.datumProizvodnje.ToString(), o.nazivProizvodjaca, tipOpremeRepo.GetTipoviOpreme().Where(x => x.naziv == comboBoxTipoviOpreme.SelectedItem.ToString()).FirstOrDefault().sifra.ToString() }));
        }

        private void ClearData()
        {
            textBoxFabrickiBroj.Text = "";
            textBoxMasa.Text = "";
            textBoxDatumProizvodnje.Text = "";
            textBoxNazivProizvodjaca.Text = "";
            comboBoxTipoviOpreme.SelectedIndex = 0;
        }
    }
}
