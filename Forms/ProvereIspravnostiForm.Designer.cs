
namespace Vatrogasna_stanica.Forms
{
    partial class ProvereIspravnostiForm
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
            this.components = new System.ComponentModel.Container();
            this.textBoxOcenaIspravnosti = new System.Windows.Forms.TextBox();
            this.labelOcenaIspravnosti = new System.Windows.Forms.Label();
            this.btnDeleteProvera = new System.Windows.Forms.Button();
            this.btnUpdateProvera = new System.Windows.Forms.Button();
            this.btnAddProvera = new System.Windows.Forms.Button();
            this.textBoxDatumKontrolisanja = new System.Windows.Forms.TextBox();
            this.lblDatumKontrolisanja = new System.Windows.Forms.Label();
            this.textBoxEvidencijskiBroj = new System.Windows.Forms.TextBox();
            this.lblEvidencijskiBroj = new System.Windows.Forms.Label();
            this.labelProvereIspravnosti = new System.Windows.Forms.Label();
            this.listViewProvereIspravnosti = new System.Windows.Forms.ListView();
            this.columnHeaderEvidencijskiBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatumKontrolisanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOcenaIspravnosti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFabrickiBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderImeRadnika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatumIstekaKontrole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFabrickiBroj = new System.Windows.Forms.Label();
            this.comboBoxOprema = new System.Windows.Forms.ComboBox();
            this.labelKontrolisao = new System.Windows.Forms.Label();
            this.comboBoxKontrolisao = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOcenaIspravnosti
            // 
            this.textBoxOcenaIspravnosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOcenaIspravnosti.Location = new System.Drawing.Point(441, 418);
            this.textBoxOcenaIspravnosti.Name = "textBoxOcenaIspravnosti";
            this.textBoxOcenaIspravnosti.Size = new System.Drawing.Size(100, 20);
            this.textBoxOcenaIspravnosti.TabIndex = 68;
            // 
            // labelOcenaIspravnosti
            // 
            this.labelOcenaIspravnosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOcenaIspravnosti.AutoSize = true;
            this.labelOcenaIspravnosti.Location = new System.Drawing.Point(316, 421);
            this.labelOcenaIspravnosti.Name = "labelOcenaIspravnosti";
            this.labelOcenaIspravnosti.Size = new System.Drawing.Size(99, 13);
            this.labelOcenaIspravnosti.TabIndex = 67;
            this.labelOcenaIspravnosti.Text = "Ocena ispravnosti *";
            this.labelOcenaIspravnosti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteProvera
            // 
            this.btnDeleteProvera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteProvera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProvera.Location = new System.Drawing.Point(586, 469);
            this.btnDeleteProvera.Name = "btnDeleteProvera";
            this.btnDeleteProvera.Size = new System.Drawing.Size(83, 36);
            this.btnDeleteProvera.TabIndex = 62;
            this.btnDeleteProvera.Text = "Izbriši proveru";
            this.btnDeleteProvera.UseVisualStyleBackColor = true;
            this.btnDeleteProvera.Click += new System.EventHandler(this.btnDeleteProvera_Click);
            // 
            // btnUpdateProvera
            // 
            this.btnUpdateProvera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateProvera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateProvera.Location = new System.Drawing.Point(577, 413);
            this.btnUpdateProvera.Name = "btnUpdateProvera";
            this.btnUpdateProvera.Size = new System.Drawing.Size(103, 45);
            this.btnUpdateProvera.TabIndex = 61;
            this.btnUpdateProvera.Text = "Ažuriraj podatke o proveri";
            this.btnUpdateProvera.UseVisualStyleBackColor = true;
            this.btnUpdateProvera.Click += new System.EventHandler(this.btnUpdateProvera_Click);
            // 
            // btnAddProvera
            // 
            this.btnAddProvera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProvera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProvera.Location = new System.Drawing.Point(586, 366);
            this.btnAddProvera.Name = "btnAddProvera";
            this.btnAddProvera.Size = new System.Drawing.Size(83, 36);
            this.btnAddProvera.TabIndex = 60;
            this.btnAddProvera.Text = "Dodaj proveru";
            this.btnAddProvera.UseVisualStyleBackColor = true;
            this.btnAddProvera.Click += new System.EventHandler(this.btnAddProvera_Click);
            // 
            // textBoxDatumKontrolisanja
            // 
            this.textBoxDatumKontrolisanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDatumKontrolisanja.Location = new System.Drawing.Point(441, 386);
            this.textBoxDatumKontrolisanja.Name = "textBoxDatumKontrolisanja";
            this.textBoxDatumKontrolisanja.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatumKontrolisanja.TabIndex = 59;
            // 
            // lblDatumKontrolisanja
            // 
            this.lblDatumKontrolisanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumKontrolisanja.AutoSize = true;
            this.lblDatumKontrolisanja.Location = new System.Drawing.Point(316, 389);
            this.lblDatumKontrolisanja.Name = "lblDatumKontrolisanja";
            this.lblDatumKontrolisanja.Size = new System.Drawing.Size(107, 13);
            this.lblDatumKontrolisanja.TabIndex = 58;
            this.lblDatumKontrolisanja.Text = "Datum kontrolisanja *";
            // 
            // textBoxEvidencijskiBroj
            // 
            this.textBoxEvidencijskiBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEvidencijskiBroj.Location = new System.Drawing.Point(441, 354);
            this.textBoxEvidencijskiBroj.Name = "textBoxEvidencijskiBroj";
            this.textBoxEvidencijskiBroj.Size = new System.Drawing.Size(100, 20);
            this.textBoxEvidencijskiBroj.TabIndex = 57;
            // 
            // lblEvidencijskiBroj
            // 
            this.lblEvidencijskiBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEvidencijskiBroj.AutoSize = true;
            this.lblEvidencijskiBroj.Location = new System.Drawing.Point(316, 357);
            this.lblEvidencijskiBroj.Name = "lblEvidencijskiBroj";
            this.lblEvidencijskiBroj.Size = new System.Drawing.Size(90, 13);
            this.lblEvidencijskiBroj.TabIndex = 56;
            this.lblEvidencijskiBroj.Text = "Evidencijski broj *";
            this.lblEvidencijskiBroj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelProvereIspravnosti
            // 
            this.labelProvereIspravnosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProvereIspravnosti.AutoSize = true;
            this.labelProvereIspravnosti.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvereIspravnosti.Location = new System.Drawing.Point(268, 39);
            this.labelProvereIspravnosti.Name = "labelProvereIspravnosti";
            this.labelProvereIspravnosti.Size = new System.Drawing.Size(431, 47);
            this.labelProvereIspravnosti.TabIndex = 55;
            this.labelProvereIspravnosti.Text = "Evidencija provera ispravnosti";
            // 
            // listViewProvereIspravnosti
            // 
            this.listViewProvereIspravnosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewProvereIspravnosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEvidencijskiBroj,
            this.columnHeaderDatumKontrolisanja,
            this.columnHeaderOcenaIspravnosti,
            this.columnHeaderFabrickiBroj,
            this.columnHeaderImeRadnika,
            this.columnHeaderDatumIstekaKontrole});
            this.listViewProvereIspravnosti.FullRowSelect = true;
            this.listViewProvereIspravnosti.GridLines = true;
            this.listViewProvereIspravnosti.HideSelection = false;
            this.listViewProvereIspravnosti.Location = new System.Drawing.Point(142, 126);
            this.listViewProvereIspravnosti.Name = "listViewProvereIspravnosti";
            this.listViewProvereIspravnosti.Size = new System.Drawing.Size(685, 203);
            this.listViewProvereIspravnosti.TabIndex = 54;
            this.listViewProvereIspravnosti.UseCompatibleStateImageBehavior = false;
            this.listViewProvereIspravnosti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderEvidencijskiBroj
            // 
            this.columnHeaderEvidencijskiBroj.Text = "Evidencijski broj";
            this.columnHeaderEvidencijskiBroj.Width = 97;
            // 
            // columnHeaderDatumKontrolisanja
            // 
            this.columnHeaderDatumKontrolisanja.Text = "Datum kontrolisanja";
            this.columnHeaderDatumKontrolisanja.Width = 107;
            // 
            // columnHeaderOcenaIspravnosti
            // 
            this.columnHeaderOcenaIspravnosti.Text = "Ocena ispravnosti";
            this.columnHeaderOcenaIspravnosti.Width = 112;
            // 
            // columnHeaderFabrickiBroj
            // 
            this.columnHeaderFabrickiBroj.Text = "Fabricki broj opreme";
            this.columnHeaderFabrickiBroj.Width = 121;
            // 
            // columnHeaderImeRadnika
            // 
            this.columnHeaderImeRadnika.Text = "Kontrolisao";
            this.columnHeaderImeRadnika.Width = 120;
            // 
            // columnHeaderDatumIstekaKontrole
            // 
            this.columnHeaderDatumIstekaKontrole.Text = "Datum isteka kontrole";
            this.columnHeaderDatumIstekaKontrole.Width = 123;
            // 
            // lblFabrickiBroj
            // 
            this.lblFabrickiBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFabrickiBroj.AutoSize = true;
            this.lblFabrickiBroj.Location = new System.Drawing.Point(316, 456);
            this.lblFabrickiBroj.Name = "lblFabrickiBroj";
            this.lblFabrickiBroj.Size = new System.Drawing.Size(51, 13);
            this.lblFabrickiBroj.TabIndex = 70;
            this.lblFabrickiBroj.Text = "Oprema *";
            // 
            // comboBoxOprema
            // 
            this.comboBoxOprema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOprema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOprema.FormattingEnabled = true;
            this.comboBoxOprema.Location = new System.Drawing.Point(399, 453);
            this.comboBoxOprema.Name = "comboBoxOprema";
            this.comboBoxOprema.Size = new System.Drawing.Size(142, 21);
            this.comboBoxOprema.TabIndex = 69;
            // 
            // labelKontrolisao
            // 
            this.labelKontrolisao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKontrolisao.AutoSize = true;
            this.labelKontrolisao.Location = new System.Drawing.Point(316, 492);
            this.labelKontrolisao.Name = "labelKontrolisao";
            this.labelKontrolisao.Size = new System.Drawing.Size(66, 13);
            this.labelKontrolisao.TabIndex = 72;
            this.labelKontrolisao.Text = "Kontrolisao *";
            // 
            // comboBoxKontrolisao
            // 
            this.comboBoxKontrolisao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxKontrolisao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKontrolisao.FormattingEnabled = true;
            this.comboBoxKontrolisao.Location = new System.Drawing.Point(399, 489);
            this.comboBoxKontrolisao.Name = "comboBoxKontrolisao";
            this.comboBoxKontrolisao.Size = new System.Drawing.Size(142, 21);
            this.comboBoxKontrolisao.TabIndex = 71;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProvereIspravnostiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 626);
            this.Controls.Add(this.labelKontrolisao);
            this.Controls.Add(this.comboBoxKontrolisao);
            this.Controls.Add(this.lblFabrickiBroj);
            this.Controls.Add(this.comboBoxOprema);
            this.Controls.Add(this.textBoxOcenaIspravnosti);
            this.Controls.Add(this.labelOcenaIspravnosti);
            this.Controls.Add(this.btnDeleteProvera);
            this.Controls.Add(this.btnUpdateProvera);
            this.Controls.Add(this.btnAddProvera);
            this.Controls.Add(this.textBoxDatumKontrolisanja);
            this.Controls.Add(this.lblDatumKontrolisanja);
            this.Controls.Add(this.textBoxEvidencijskiBroj);
            this.Controls.Add(this.lblEvidencijskiBroj);
            this.Controls.Add(this.labelProvereIspravnosti);
            this.Controls.Add(this.listViewProvereIspravnosti);
            this.Name = "ProvereIspravnostiForm";
            this.Text = "ProvereIspravnostiForm";
            this.Load += new System.EventHandler(this.ProvereIspravnostiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxOcenaIspravnosti;
        private System.Windows.Forms.Label labelOcenaIspravnosti;
        private System.Windows.Forms.Button btnDeleteProvera;
        private System.Windows.Forms.Button btnUpdateProvera;
        private System.Windows.Forms.Button btnAddProvera;
        private System.Windows.Forms.TextBox textBoxDatumKontrolisanja;
        private System.Windows.Forms.Label lblDatumKontrolisanja;
        private System.Windows.Forms.TextBox textBoxEvidencijskiBroj;
        private System.Windows.Forms.Label lblEvidencijskiBroj;
        private System.Windows.Forms.Label labelProvereIspravnosti;
        private System.Windows.Forms.ListView listViewProvereIspravnosti;
        private System.Windows.Forms.ColumnHeader columnHeaderEvidencijskiBroj;
        private System.Windows.Forms.ColumnHeader columnHeaderDatumKontrolisanja;
        private System.Windows.Forms.ColumnHeader columnHeaderOcenaIspravnosti;
        private System.Windows.Forms.ColumnHeader columnHeaderFabrickiBroj;
        private System.Windows.Forms.ColumnHeader columnHeaderImeRadnika;
        private System.Windows.Forms.Label lblFabrickiBroj;
        private System.Windows.Forms.ComboBox comboBoxOprema;
        private System.Windows.Forms.Label labelKontrolisao;
        private System.Windows.Forms.ComboBox comboBoxKontrolisao;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader columnHeaderDatumIstekaKontrole;
    }
}