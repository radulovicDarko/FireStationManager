
namespace Vatrogasna_stanica.Forms
{
    partial class OpremaForm
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
            this.lblTipOpreme = new System.Windows.Forms.Label();
            this.comboBoxTipoviOpreme = new System.Windows.Forms.ComboBox();
            this.btnDeleteOprema = new System.Windows.Forms.Button();
            this.btnUpdateOprema = new System.Windows.Forms.Button();
            this.btnAddOprema = new System.Windows.Forms.Button();
            this.textBoxNazivProizvodjaca = new System.Windows.Forms.TextBox();
            this.lblNazivProizvodjaca = new System.Windows.Forms.Label();
            this.textBoxDatumProizvodnje = new System.Windows.Forms.TextBox();
            this.lblDatumProizvodnje = new System.Windows.Forms.Label();
            this.textBoxMasa = new System.Windows.Forms.TextBox();
            this.lblMasa = new System.Windows.Forms.Label();
            this.textBoxFabrickiBroj = new System.Windows.Forms.TextBox();
            this.lblFabrickiBroj = new System.Windows.Forms.Label();
            this.lblOpreme = new System.Windows.Forms.Label();
            this.listViewOprema = new System.Windows.Forms.ListView();
            this.columnHeaderFabrickiBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMasa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatumProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNazivProizvodjaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipOpreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipOpreme
            // 
            this.lblTipOpreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipOpreme.AutoSize = true;
            this.lblTipOpreme.Location = new System.Drawing.Point(283, 501);
            this.lblTipOpreme.Name = "lblTipOpreme";
            this.lblTipOpreme.Size = new System.Drawing.Size(67, 13);
            this.lblTipOpreme.TabIndex = 34;
            this.lblTipOpreme.Text = "Tip opreme *";
            // 
            // comboBoxTipoviOpreme
            // 
            this.comboBoxTipoviOpreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTipoviOpreme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoviOpreme.FormattingEnabled = true;
            this.comboBoxTipoviOpreme.Location = new System.Drawing.Point(368, 498);
            this.comboBoxTipoviOpreme.Name = "comboBoxTipoviOpreme";
            this.comboBoxTipoviOpreme.Size = new System.Drawing.Size(142, 21);
            this.comboBoxTipoviOpreme.TabIndex = 33;
            // 
            // btnDeleteOprema
            // 
            this.btnDeleteOprema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteOprema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteOprema.Location = new System.Drawing.Point(543, 477);
            this.btnDeleteOprema.Name = "btnDeleteOprema";
            this.btnDeleteOprema.Size = new System.Drawing.Size(113, 36);
            this.btnDeleteOprema.TabIndex = 32;
            this.btnDeleteOprema.Text = "Izbriši opremu";
            this.btnDeleteOprema.UseVisualStyleBackColor = true;
            this.btnDeleteOprema.Click += new System.EventHandler(this.btnDeleteOprema_Click);
            // 
            // btnUpdateOprema
            // 
            this.btnUpdateOprema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateOprema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateOprema.Location = new System.Drawing.Point(543, 411);
            this.btnUpdateOprema.Name = "btnUpdateOprema";
            this.btnUpdateOprema.Size = new System.Drawing.Size(113, 51);
            this.btnUpdateOprema.TabIndex = 31;
            this.btnUpdateOprema.Text = "Ažuriraj podatke o opremi";
            this.btnUpdateOprema.UseVisualStyleBackColor = true;
            this.btnUpdateOprema.Click += new System.EventHandler(this.btnUpdateOprema_Click);
            // 
            // btnAddOprema
            // 
            this.btnAddOprema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOprema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOprema.Location = new System.Drawing.Point(543, 361);
            this.btnAddOprema.Name = "btnAddOprema";
            this.btnAddOprema.Size = new System.Drawing.Size(113, 36);
            this.btnAddOprema.TabIndex = 30;
            this.btnAddOprema.Text = "Dodaj opremu";
            this.btnAddOprema.UseVisualStyleBackColor = true;
            this.btnAddOprema.Click += new System.EventHandler(this.btnAddOprema_Click);
            // 
            // textBoxNazivProizvodjaca
            // 
            this.textBoxNazivProizvodjaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNazivProizvodjaca.Location = new System.Drawing.Point(410, 463);
            this.textBoxNazivProizvodjaca.Name = "textBoxNazivProizvodjaca";
            this.textBoxNazivProizvodjaca.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivProizvodjaca.TabIndex = 27;
            // 
            // lblNazivProizvodjaca
            // 
            this.lblNazivProizvodjaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNazivProizvodjaca.AutoSize = true;
            this.lblNazivProizvodjaca.Location = new System.Drawing.Point(283, 466);
            this.lblNazivProizvodjaca.Name = "lblNazivProizvodjaca";
            this.lblNazivProizvodjaca.Size = new System.Drawing.Size(104, 13);
            this.lblNazivProizvodjaca.TabIndex = 26;
            this.lblNazivProizvodjaca.Text = "Naziv proizvodjaca *";
            // 
            // textBoxDatumProizvodnje
            // 
            this.textBoxDatumProizvodnje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDatumProizvodnje.Location = new System.Drawing.Point(410, 428);
            this.textBoxDatumProizvodnje.Name = "textBoxDatumProizvodnje";
            this.textBoxDatumProizvodnje.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatumProizvodnje.TabIndex = 25;
            // 
            // lblDatumProizvodnje
            // 
            this.lblDatumProizvodnje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumProizvodnje.AutoSize = true;
            this.lblDatumProizvodnje.Location = new System.Drawing.Point(283, 431);
            this.lblDatumProizvodnje.Name = "lblDatumProizvodnje";
            this.lblDatumProizvodnje.Size = new System.Drawing.Size(102, 13);
            this.lblDatumProizvodnje.TabIndex = 24;
            this.lblDatumProizvodnje.Text = "Datum proizvodnje *";
            // 
            // textBoxMasa
            // 
            this.textBoxMasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMasa.Location = new System.Drawing.Point(410, 393);
            this.textBoxMasa.Name = "textBoxMasa";
            this.textBoxMasa.Size = new System.Drawing.Size(100, 20);
            this.textBoxMasa.TabIndex = 23;
            // 
            // lblMasa
            // 
            this.lblMasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMasa.AutoSize = true;
            this.lblMasa.Location = new System.Drawing.Point(283, 396);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(40, 13);
            this.lblMasa.TabIndex = 22;
            this.lblMasa.Text = "Masa *";
            // 
            // textBoxFabrickiBroj
            // 
            this.textBoxFabrickiBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFabrickiBroj.Location = new System.Drawing.Point(410, 358);
            this.textBoxFabrickiBroj.Name = "textBoxFabrickiBroj";
            this.textBoxFabrickiBroj.Size = new System.Drawing.Size(100, 20);
            this.textBoxFabrickiBroj.TabIndex = 21;
            // 
            // lblFabrickiBroj
            // 
            this.lblFabrickiBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFabrickiBroj.AutoSize = true;
            this.lblFabrickiBroj.Location = new System.Drawing.Point(283, 361);
            this.lblFabrickiBroj.Name = "lblFabrickiBroj";
            this.lblFabrickiBroj.Size = new System.Drawing.Size(71, 13);
            this.lblFabrickiBroj.TabIndex = 20;
            this.lblFabrickiBroj.Text = "Fabricki broj *";
            // 
            // lblOpreme
            // 
            this.lblOpreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpreme.AutoSize = true;
            this.lblOpreme.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpreme.Location = new System.Drawing.Point(336, 41);
            this.lblOpreme.Name = "lblOpreme";
            this.lblOpreme.Size = new System.Drawing.Size(271, 47);
            this.lblOpreme.TabIndex = 19;
            this.lblOpreme.Text = "Evidencija opreme";
            // 
            // listViewOprema
            // 
            this.listViewOprema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewOprema.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFabrickiBroj,
            this.columnHeaderMasa,
            this.columnHeaderDatumProizvodnje,
            this.columnHeaderNazivProizvodjaca,
            this.columnHeaderTipOpreme});
            this.listViewOprema.FullRowSelect = true;
            this.listViewOprema.GridLines = true;
            this.listViewOprema.HideSelection = false;
            this.listViewOprema.Location = new System.Drawing.Point(193, 116);
            this.listViewOprema.Name = "listViewOprema";
            this.listViewOprema.Size = new System.Drawing.Size(562, 207);
            this.listViewOprema.TabIndex = 18;
            this.listViewOprema.UseCompatibleStateImageBehavior = false;
            this.listViewOprema.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFabrickiBroj
            // 
            this.columnHeaderFabrickiBroj.Text = "Fabricki broj";
            this.columnHeaderFabrickiBroj.Width = 100;
            // 
            // columnHeaderMasa
            // 
            this.columnHeaderMasa.Text = "Masa [kg]";
            this.columnHeaderMasa.Width = 84;
            // 
            // columnHeaderDatumProizvodnje
            // 
            this.columnHeaderDatumProizvodnje.Text = "Datum proizvodnje";
            this.columnHeaderDatumProizvodnje.Width = 138;
            // 
            // columnHeaderNazivProizvodjaca
            // 
            this.columnHeaderNazivProizvodjaca.Text = "Naziv proizvodjaca";
            this.columnHeaderNazivProizvodjaca.Width = 120;
            // 
            // columnHeaderTipOpreme
            // 
            this.columnHeaderTipOpreme.Text = "Tip opreme";
            this.columnHeaderTipOpreme.Width = 114;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OpremaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 626);
            this.Controls.Add(this.lblTipOpreme);
            this.Controls.Add(this.comboBoxTipoviOpreme);
            this.Controls.Add(this.btnDeleteOprema);
            this.Controls.Add(this.btnUpdateOprema);
            this.Controls.Add(this.btnAddOprema);
            this.Controls.Add(this.textBoxNazivProizvodjaca);
            this.Controls.Add(this.lblNazivProizvodjaca);
            this.Controls.Add(this.textBoxDatumProizvodnje);
            this.Controls.Add(this.lblDatumProizvodnje);
            this.Controls.Add(this.textBoxMasa);
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.textBoxFabrickiBroj);
            this.Controls.Add(this.lblFabrickiBroj);
            this.Controls.Add(this.lblOpreme);
            this.Controls.Add(this.listViewOprema);
            this.Name = "OpremaForm";
            this.Text = "Oprema";
            this.Load += new System.EventHandler(this.Oprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipOpreme;
        private System.Windows.Forms.ComboBox comboBoxTipoviOpreme;
        private System.Windows.Forms.Button btnDeleteOprema;
        private System.Windows.Forms.Button btnUpdateOprema;
        private System.Windows.Forms.Button btnAddOprema;
        private System.Windows.Forms.TextBox textBoxNazivProizvodjaca;
        private System.Windows.Forms.Label lblNazivProizvodjaca;
        private System.Windows.Forms.TextBox textBoxDatumProizvodnje;
        private System.Windows.Forms.Label lblDatumProizvodnje;
        private System.Windows.Forms.TextBox textBoxMasa;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.TextBox textBoxFabrickiBroj;
        private System.Windows.Forms.Label lblFabrickiBroj;
        private System.Windows.Forms.Label lblOpreme;
        private System.Windows.Forms.ListView listViewOprema;
        private System.Windows.Forms.ColumnHeader columnHeaderFabrickiBroj;
        private System.Windows.Forms.ColumnHeader columnHeaderMasa;
        private System.Windows.Forms.ColumnHeader columnHeaderDatumProizvodnje;
        private System.Windows.Forms.ColumnHeader columnHeaderNazivProizvodjaca;
        private System.Windows.Forms.ColumnHeader columnHeaderTipOpreme;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}