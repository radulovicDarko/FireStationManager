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
    public partial class VozilaForm : Form
    {
        private readonly VoziloRepo voziloRepo;
        private readonly TipVozilaRepo tipVozilaRepo;
        public VozilaForm()
        {
            InitializeComponent();
            voziloRepo = new VoziloRepo();
            tipVozilaRepo = new TipVozilaRepo();
        }

        private void Vozila_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void FillData()
        {
            List<Vozilo> vozila = voziloRepo.GetVozila();

            List<TipVozila> tipoviVozila = tipVozilaRepo.GetTipoviVozila();
            foreach (TipVozila tipVozila in tipoviVozila)
                comboBoxTipoviVozila.Items.Add(tipVozila.naziv);
            comboBoxTipoviVozila.SelectedIndex = 0;

            listViewVozila.Items.Clear();
            foreach (Vozilo v in vozila)
                listViewVozila.Items.Add(new ListViewItem(new[] { v.registarskiBroj, v.marka, v.tipVozila }));
        }

        private void btnAddVozilo_Click(object sender, EventArgs e)
        {
            int count = 0;
            //ime
            if (String.IsNullOrEmpty(textBoxRegBroj.Text))
            {
                textBoxRegBroj.Focus();
                errorProvider.SetError(textBoxRegBroj, "Unesite registarski broj!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxRegBroj, null);
            }

            //prezime
            if (String.IsNullOrEmpty(textBoxMarka.Text))
            {
                textBoxMarka.Focus();
                errorProvider.SetError(textBoxMarka, "Unesite marku!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxMarka, null);
            }

            if (count > 0)
                return;
            else
            {
                Vozilo v = new Vozilo
                {
                    registarskiBroj = textBoxRegBroj.Text,
                    marka = textBoxMarka.Text,
                    tipVozila = comboBoxTipoviVozila.SelectedItem.ToString()
                };

                if (voziloRepo.InsertVozilo(v))
                    MessageBox.Show("Vozilo sa registarskim brojem " + v.registarskiBroj + " uspesno je dodato u evidenciju!");
                else
                    MessageBox.Show("Proverite podatke!");

                ClearData();
                FillData();
            }
        }

        private void ClearData()
        {
            textBoxRegBroj.Text = "";
            textBoxMarka.Text = "";
            comboBoxTipoviVozila.SelectedIndex = 0;
        }

        private void btnDeleteVozilo_Click(object sender, EventArgs e)
        {

            try
            {
                if (voziloRepo.DeleteVozilo(listViewVozila.SelectedItems[0].SubItems[0].Text))
                    MessageBox.Show("Vozilo sa registarskim brojem " + listViewVozila.SelectedItems[0].SubItems[0].Text + " uspesno je izbrisano iz evidencije!");

                ClearData();
                FillData();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite vozilo!");
            }
        }

        private void btnUpdateVozilo_Click(object sender, EventArgs e)
        {
            int count = 0;
            //ime
            if (String.IsNullOrEmpty(textBoxRegBroj.Text))
            {
                textBoxRegBroj.Focus();
                errorProvider.SetError(textBoxRegBroj, "Unesite registarski broj!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxRegBroj, null);
            }

            //prezime
            if (String.IsNullOrEmpty(textBoxMarka.Text))
            {
                textBoxMarka.Focus();
                errorProvider.SetError(textBoxMarka, "Unesite marku!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxMarka, null);
            }

            if (count > 0)
                return;
            else
            {
                Vozilo vozilo = new Vozilo
                {
                    registarskiBroj = textBoxRegBroj.Text,
                    marka = textBoxMarka.Text,
                    tipVozila = comboBoxTipoviVozila.SelectedItem.ToString()
                };

                try
                {
                    if (voziloRepo.UpdateVozilo(vozilo, listViewVozila.SelectedItems[0].SubItems[0].Text))
                        MessageBox.Show("Podaci o vozilu sa registarskim brojem " + vozilo.registarskiBroj + " su uspesno azurirani!");

                    ClearData();
                    FillData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Izaberite vozilo!");
                }
            }
        }
    }
}

