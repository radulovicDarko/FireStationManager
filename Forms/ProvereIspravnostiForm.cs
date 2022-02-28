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
    public partial class ProvereIspravnostiForm : Form
    {
        private readonly ProveraIspravnostiRepo provereIspravnostiRepo;
        private readonly RadnikRepo radnikRepo;
        private readonly OpremaRepo opremaRepo;
        public ProvereIspravnostiForm()
        {
            InitializeComponent();
            provereIspravnostiRepo = new ProveraIspravnostiRepo();
            radnikRepo = new RadnikRepo();
            opremaRepo = new OpremaRepo();
        }

        private void ProvereIspravnostiForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            List<ProveraIspravnosti> provereIspravnosti = provereIspravnostiRepo.GetProvereIspravnosti();

            List<Oprema> oprema = opremaRepo.GetOprema();
            foreach (Oprema o in oprema)
                comboBoxOprema.Items.Add(o.fabrickiBroj);
            comboBoxOprema.SelectedIndex = 0;

            List<Radnik> radnici = radnikRepo.GetRadnici();
            foreach (Radnik r in radnici)
                comboBoxKontrolisao.Items.Add(r.ime + " " + r.prezime);
            comboBoxKontrolisao.SelectedIndex = 0;

            listViewProvereIspravnosti.Items.Clear();
            foreach (ProveraIspravnosti proveraIspravnosti in provereIspravnosti)
                listViewProvereIspravnosti.Items.Add(new ListViewItem(new[] { proveraIspravnosti.evidencijskiBroj.ToString(), proveraIspravnosti.datumKontrolisanja.ToString(), proveraIspravnosti.ocenaIspravnosti, proveraIspravnosti.fabrickiBroj, radnikRepo.GetRadnici().Where(x => x.jmbg == proveraIspravnosti.jmbgRadnika).FirstOrDefault().ime + " " + radnikRepo.GetRadnici().Where(x => x.jmbg == proveraIspravnosti.jmbgRadnika).FirstOrDefault().prezime, proveraIspravnosti.datumIstekaKontrole.ToString() }));
        }

        private void ClearData()
        {
            textBoxEvidencijskiBroj.Text = "";
            textBoxDatumKontrolisanja.Text = "";
            textBoxOcenaIspravnosti.Text = "";
            comboBoxOprema.SelectedIndex = 0;
            comboBoxKontrolisao.SelectedIndex = 0;
        }

        private void btnAddProvera_Click(object sender, EventArgs e)
        {
            int count = 0;
            //evidencijski broj
            if (String.IsNullOrEmpty(textBoxEvidencijskiBroj.Text))
            {
                textBoxEvidencijskiBroj.Focus();
                errorProvider.SetError(textBoxEvidencijskiBroj, "Unesite evidencijski broj!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxEvidencijskiBroj, null);
            }

            //datum kontrolisanja
            if (String.IsNullOrEmpty(textBoxDatumKontrolisanja.Text))
            {
                textBoxDatumKontrolisanja.Focus();
                errorProvider.SetError(textBoxDatumKontrolisanja, "Unesite datum kontrolisanja!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxDatumKontrolisanja, null);
            }

            //ocena ispravnosti
            if (String.IsNullOrEmpty(textBoxOcenaIspravnosti.Text))
            {
                textBoxOcenaIspravnosti.Focus();
                errorProvider.SetError(textBoxOcenaIspravnosti, "Unesite ocenu ispravnosti!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxOcenaIspravnosti, null);
            }

            if (count > 0)
                return;
            else
            {
                string[] imePrezime = comboBoxKontrolisao.SelectedItem.ToString().Split(' ');
                ProveraIspravnosti proveraIspravnosti = new ProveraIspravnosti
                {
                    evidencijskiBroj = Convert.ToInt32(textBoxEvidencijskiBroj.Text),
                    datumKontrolisanja = Convert.ToDateTime(textBoxDatumKontrolisanja.Text),
                    ocenaIspravnosti = textBoxOcenaIspravnosti.Text,
                    fabrickiBroj = comboBoxOprema.SelectedItem.ToString(),
                    jmbgRadnika = radnikRepo.GetRadnici().Where(x => x.ime == imePrezime[0] && x.prezime == imePrezime[1]).FirstOrDefault().jmbg
                };

                if (provereIspravnostiRepo.InsertProveraIspravnosti(proveraIspravnosti))
                    MessageBox.Show("Provera ispravnosti sa evidencijskim brojem " + proveraIspravnosti.evidencijskiBroj + " uspesno je dodata u evidenciju!");
                else
                    MessageBox.Show("Proverite podatke!");

                ClearData();
                FillData();
            }
        }

        private void btnDeleteProvera_Click(object sender, EventArgs e)
        {
            try
            {
                if (provereIspravnostiRepo.DeleteProveraIspravnosti(Convert.ToInt32(listViewProvereIspravnosti.SelectedItems[0].SubItems[0].Text)))
                    MessageBox.Show("Provera ispravnosti sa evidencijskim brojem " + listViewProvereIspravnosti.SelectedItems[0].SubItems[0].Text + " uspesno je izbrisana iz evidencije!");

                ClearData();
                FillData();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite proveru ispravnosti!");
            }
        }

        private void btnUpdateProvera_Click(object sender, EventArgs e)
        {
            int count = 0;
            //evidencijski broj
            if (String.IsNullOrEmpty(textBoxEvidencijskiBroj.Text))
            {
                textBoxEvidencijskiBroj.Focus();
                errorProvider.SetError(textBoxEvidencijskiBroj, "Unesite evidencijski broj!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxEvidencijskiBroj, null);
            }

            //datum kontrolisanja
            if (String.IsNullOrEmpty(textBoxDatumKontrolisanja.Text))
            {
                textBoxDatumKontrolisanja.Focus();
                errorProvider.SetError(textBoxDatumKontrolisanja, "Unesite datum kontrolisanja!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxDatumKontrolisanja, null);
            }

            //ocena ispravnosti
            if (String.IsNullOrEmpty(textBoxOcenaIspravnosti.Text))
            {
                textBoxOcenaIspravnosti.Focus();
                errorProvider.SetError(textBoxOcenaIspravnosti, "Unesite ocenu ispravnosti!");
                count++;
            }
            else
            {
                errorProvider.SetError(textBoxOcenaIspravnosti, null);
            }

            if (count > 0)
                return;
            else
            {
                string[] imePrezime = comboBoxKontrolisao.SelectedItem.ToString().Split(' ');
                ProveraIspravnosti proveraIspravnosti = new ProveraIspravnosti
                {
                    evidencijskiBroj = Convert.ToInt32(textBoxEvidencijskiBroj.Text),
                    datumKontrolisanja = Convert.ToDateTime(textBoxDatumKontrolisanja.Text),
                    ocenaIspravnosti = textBoxOcenaIspravnosti.Text,
                    fabrickiBroj = comboBoxOprema.SelectedItem.ToString(),
                    jmbgRadnika = radnikRepo.GetRadnici().Where(x => x.ime == imePrezime[0] && x.prezime == imePrezime[1]).FirstOrDefault().jmbg
                };

                try
                {
                    if (provereIspravnostiRepo.UpdateProveraIspravnosti(proveraIspravnosti, Convert.ToInt32(listViewProvereIspravnosti.SelectedItems[0].SubItems[0].Text)))
                        MessageBox.Show("Podaci o proveri ispravnosti sa evidencijskim brojem " + proveraIspravnosti.evidencijskiBroj + " su uspesno azurirani!");

                    ClearData();
                    FillData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Izaberite proveru ispravnosti!");
                }
            }
        }
    }
}
