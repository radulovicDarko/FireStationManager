
namespace Vatrogasna_stanica.Forms
{
    partial class PrijaveForm
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
            this.textBoxDojavio = new System.Windows.Forms.TextBox();
            this.labelDojavio = new System.Windows.Forms.Label();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.labelNapomena = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.btnDeletePrijava = new System.Windows.Forms.Button();
            this.btnUpdatePrijavi = new System.Windows.Forms.Button();
            this.btnAddPrijava = new System.Windows.Forms.Button();
            this.textBoxDatumProvere = new System.Windows.Forms.TextBox();
            this.lblDatumProvere = new System.Windows.Forms.Label();
            this.textBoxBroj = new System.Windows.Forms.TextBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDogadjaji = new System.Windows.Forms.ListView();
            this.columnHeaderBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatumProvere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderImePrezimeDojavio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNapomena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRadnik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSifraDogadjaja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRadnik = new System.Windows.Forms.Label();
            this.comboBoxRadnici = new System.Windows.Forms.ComboBox();
            this.lblDogadjaj = new System.Windows.Forms.Label();
            this.comboBoxDogadjaji = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxDojavio
            // 
            this.textBoxDojavio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDojavio.Location = new System.Drawing.Point(332, 471);
            this.textBoxDojavio.Name = "textBoxDojavio";
            this.textBoxDojavio.Size = new System.Drawing.Size(100, 20);
            this.textBoxDojavio.TabIndex = 68;
            // 
            // labelDojavio
            // 
            this.labelDojavio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDojavio.AutoSize = true;
            this.labelDojavio.Location = new System.Drawing.Point(229, 474);
            this.labelDojavio.Name = "labelDojavio";
            this.labelDojavio.Size = new System.Drawing.Size(50, 13);
            this.labelDojavio.TabIndex = 67;
            this.labelDojavio.Text = "Dojavio *";
            this.labelDojavio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNapomena.Location = new System.Drawing.Point(350, 510);
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(400, 20);
            this.textBoxNapomena.TabIndex = 66;
            // 
            // labelNapomena
            // 
            this.labelNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNapomena.AutoSize = true;
            this.labelNapomena.Location = new System.Drawing.Point(278, 513);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(66, 13);
            this.labelNapomena.TabIndex = 65;
            this.labelNapomena.Text = "Napomena *";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTelefon.Location = new System.Drawing.Point(608, 410);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 64;
            // 
            // labelTelefon
            // 
            this.labelTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(505, 413);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(50, 13);
            this.labelTelefon.TabIndex = 63;
            this.labelTelefon.Text = "Telefon *";
            this.labelTelefon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeletePrijava
            // 
            this.btnDeletePrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletePrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePrijava.Location = new System.Drawing.Point(548, 559);
            this.btnDeletePrijava.Name = "btnDeletePrijava";
            this.btnDeletePrijava.Size = new System.Drawing.Size(83, 36);
            this.btnDeletePrijava.TabIndex = 62;
            this.btnDeletePrijava.Text = "Izbriši prijavu";
            this.btnDeletePrijava.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePrijavi
            // 
            this.btnUpdatePrijavi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdatePrijavi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePrijavi.Location = new System.Drawing.Point(426, 559);
            this.btnUpdatePrijavi.Name = "btnUpdatePrijavi";
            this.btnUpdatePrijavi.Size = new System.Drawing.Size(103, 36);
            this.btnUpdatePrijavi.TabIndex = 61;
            this.btnUpdatePrijavi.Text = "Ažuriraj podatke o prijavi";
            this.btnUpdatePrijavi.UseVisualStyleBackColor = true;
            // 
            // btnAddPrijava
            // 
            this.btnAddPrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPrijava.Location = new System.Drawing.Point(322, 559);
            this.btnAddPrijava.Name = "btnAddPrijava";
            this.btnAddPrijava.Size = new System.Drawing.Size(83, 36);
            this.btnAddPrijava.TabIndex = 60;
            this.btnAddPrijava.Text = "Dodaj prijavu";
            this.btnAddPrijava.UseVisualStyleBackColor = true;
            // 
            // textBoxDatumProvere
            // 
            this.textBoxDatumProvere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDatumProvere.Location = new System.Drawing.Point(332, 439);
            this.textBoxDatumProvere.Name = "textBoxDatumProvere";
            this.textBoxDatumProvere.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatumProvere.TabIndex = 59;
            // 
            // lblDatumProvere
            // 
            this.lblDatumProvere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumProvere.AutoSize = true;
            this.lblDatumProvere.Location = new System.Drawing.Point(229, 442);
            this.lblDatumProvere.Name = "lblDatumProvere";
            this.lblDatumProvere.Size = new System.Drawing.Size(84, 13);
            this.lblDatumProvere.TabIndex = 58;
            this.lblDatumProvere.Text = "Datum provere *";
            // 
            // textBoxBroj
            // 
            this.textBoxBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBroj.Location = new System.Drawing.Point(332, 407);
            this.textBoxBroj.Name = "textBoxBroj";
            this.textBoxBroj.Size = new System.Drawing.Size(100, 20);
            this.textBoxBroj.TabIndex = 57;
            // 
            // lblBroj
            // 
            this.lblBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(229, 410);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(32, 13);
            this.lblBroj.TabIndex = 56;
            this.lblBroj.Text = "Broj *";
            this.lblBroj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 47);
            this.label1.TabIndex = 55;
            this.label1.Text = "Evidencija prijava dogadjaja";
            // 
            // listViewDogadjaji
            // 
            this.listViewDogadjaji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewDogadjaji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBroj,
            this.columnHeaderDatumProvere,
            this.columnHeaderImePrezimeDojavio,
            this.columnHeaderTelefon,
            this.columnHeaderNapomena,
            this.columnHeaderRadnik,
            this.columnHeaderSifraDogadjaja});
            this.listViewDogadjaji.FullRowSelect = true;
            this.listViewDogadjaji.GridLines = true;
            this.listViewDogadjaji.HideSelection = false;
            this.listViewDogadjaji.Location = new System.Drawing.Point(120, 159);
            this.listViewDogadjaji.Name = "listViewDogadjaji";
            this.listViewDogadjaji.Size = new System.Drawing.Size(741, 219);
            this.listViewDogadjaji.TabIndex = 54;
            this.listViewDogadjaji.UseCompatibleStateImageBehavior = false;
            this.listViewDogadjaji.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBroj
            // 
            this.columnHeaderBroj.Text = "Broj";
            this.columnHeaderBroj.Width = 39;
            // 
            // columnHeaderDatumProvere
            // 
            this.columnHeaderDatumProvere.Text = "Datum provere";
            this.columnHeaderDatumProvere.Width = 89;
            // 
            // columnHeaderImePrezimeDojavio
            // 
            this.columnHeaderImePrezimeDojavio.Text = "Dojavio";
            this.columnHeaderImePrezimeDojavio.Width = 85;
            // 
            // columnHeaderTelefon
            // 
            this.columnHeaderTelefon.Text = "Telefon";
            this.columnHeaderTelefon.Width = 79;
            // 
            // columnHeaderNapomena
            // 
            this.columnHeaderNapomena.Text = "Napomena";
            this.columnHeaderNapomena.Width = 248;
            // 
            // columnHeaderRadnik
            // 
            this.columnHeaderRadnik.Text = "Radnik";
            this.columnHeaderRadnik.Width = 111;
            // 
            // columnHeaderSifraDogadjaja
            // 
            this.columnHeaderSifraDogadjaja.Text = "Sifra dogadjaja";
            this.columnHeaderSifraDogadjaja.Width = 83;
            // 
            // lblRadnik
            // 
            this.lblRadnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(505, 445);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(48, 13);
            this.lblRadnik.TabIndex = 70;
            this.lblRadnik.Text = "Radnik *";
            // 
            // comboBoxRadnici
            // 
            this.comboBoxRadnici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRadnici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRadnici.FormattingEnabled = true;
            this.comboBoxRadnici.Location = new System.Drawing.Point(608, 442);
            this.comboBoxRadnici.Name = "comboBoxRadnici";
            this.comboBoxRadnici.Size = new System.Drawing.Size(142, 21);
            this.comboBoxRadnici.TabIndex = 69;
            // 
            // lblDogadjaj
            // 
            this.lblDogadjaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDogadjaj.AutoSize = true;
            this.lblDogadjaj.Location = new System.Drawing.Point(506, 477);
            this.lblDogadjaj.Name = "lblDogadjaj";
            this.lblDogadjaj.Size = new System.Drawing.Size(56, 13);
            this.lblDogadjaj.TabIndex = 72;
            this.lblDogadjaj.Text = "Dogadjaj *";
            // 
            // comboBoxDogadjaji
            // 
            this.comboBoxDogadjaji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDogadjaji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDogadjaji.FormattingEnabled = true;
            this.comboBoxDogadjaji.Location = new System.Drawing.Point(608, 474);
            this.comboBoxDogadjaji.Name = "comboBoxDogadjaji";
            this.comboBoxDogadjaji.Size = new System.Drawing.Size(142, 21);
            this.comboBoxDogadjaji.TabIndex = 71;
            // 
            // PrijaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 626);
            this.Controls.Add(this.lblDogadjaj);
            this.Controls.Add(this.comboBoxDogadjaji);
            this.Controls.Add(this.lblRadnik);
            this.Controls.Add(this.comboBoxRadnici);
            this.Controls.Add(this.textBoxDojavio);
            this.Controls.Add(this.labelDojavio);
            this.Controls.Add(this.textBoxNapomena);
            this.Controls.Add(this.labelNapomena);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.btnDeletePrijava);
            this.Controls.Add(this.btnUpdatePrijavi);
            this.Controls.Add(this.btnAddPrijava);
            this.Controls.Add(this.textBoxDatumProvere);
            this.Controls.Add(this.lblDatumProvere);
            this.Controls.Add(this.textBoxBroj);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDogadjaji);
            this.Name = "PrijaveForm";
            this.Text = "PrijaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDojavio;
        private System.Windows.Forms.Label labelDojavio;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Button btnDeletePrijava;
        private System.Windows.Forms.Button btnUpdatePrijavi;
        private System.Windows.Forms.Button btnAddPrijava;
        private System.Windows.Forms.TextBox textBoxDatumProvere;
        private System.Windows.Forms.Label lblDatumProvere;
        private System.Windows.Forms.TextBox textBoxBroj;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewDogadjaji;
        private System.Windows.Forms.ColumnHeader columnHeaderBroj;
        private System.Windows.Forms.ColumnHeader columnHeaderDatumProvere;
        private System.Windows.Forms.ColumnHeader columnHeaderImePrezimeDojavio;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.ColumnHeader columnHeaderNapomena;
        private System.Windows.Forms.ColumnHeader columnHeaderRadnik;
        private System.Windows.Forms.ColumnHeader columnHeaderSifraDogadjaja;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.ComboBox comboBoxRadnici;
        private System.Windows.Forms.Label lblDogadjaj;
        private System.Windows.Forms.ComboBox comboBoxDogadjaji;
    }
}