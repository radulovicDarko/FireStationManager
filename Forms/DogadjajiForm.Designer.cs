
namespace Vatrogasna_stanica.Forms
{
    partial class DogadjajiForm
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
            this.btnDeleteDogadjaj = new System.Windows.Forms.Button();
            this.btnUpdateDogadjaj = new System.Windows.Forms.Button();
            this.btnAddDogadjaj = new System.Windows.Forms.Button();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDogadjaji = new System.Windows.Forms.ListView();
            this.columnHeaderSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVelicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUgrozenostLjudiDogadjaja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxVelicina = new System.Windows.Forms.TextBox();
            this.labelVelicina = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.textBoxMesto = new System.Windows.Forms.TextBox();
            this.labelMesto = new System.Windows.Forms.Label();
            this.textBoxUgrozenost = new System.Windows.Forms.TextBox();
            this.labelUgrozenost = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteDogadjaj
            // 
            this.btnDeleteDogadjaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteDogadjaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteDogadjaj.Location = new System.Drawing.Point(545, 482);
            this.btnDeleteDogadjaj.Name = "btnDeleteDogadjaj";
            this.btnDeleteDogadjaj.Size = new System.Drawing.Size(83, 36);
            this.btnDeleteDogadjaj.TabIndex = 43;
            this.btnDeleteDogadjaj.Text = "Izbriši dogadjaj";
            this.btnDeleteDogadjaj.UseVisualStyleBackColor = true;
            this.btnDeleteDogadjaj.Click += new System.EventHandler(this.btnDeleteDogadjaj_Click);
            // 
            // btnUpdateDogadjaj
            // 
            this.btnUpdateDogadjaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateDogadjaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateDogadjaj.Location = new System.Drawing.Point(423, 482);
            this.btnUpdateDogadjaj.Name = "btnUpdateDogadjaj";
            this.btnUpdateDogadjaj.Size = new System.Drawing.Size(103, 36);
            this.btnUpdateDogadjaj.TabIndex = 42;
            this.btnUpdateDogadjaj.Text = "Ažuriraj podatke o dogadjaju";
            this.btnUpdateDogadjaj.UseVisualStyleBackColor = true;
            this.btnUpdateDogadjaj.Click += new System.EventHandler(this.btnUpdateDogadjaj_Click);
            // 
            // btnAddDogadjaj
            // 
            this.btnAddDogadjaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDogadjaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDogadjaj.Location = new System.Drawing.Point(319, 482);
            this.btnAddDogadjaj.Name = "btnAddDogadjaj";
            this.btnAddDogadjaj.Size = new System.Drawing.Size(83, 36);
            this.btnAddDogadjaj.TabIndex = 41;
            this.btnAddDogadjaj.Text = "Dodaj dogadjaj";
            this.btnAddDogadjaj.UseVisualStyleBackColor = true;
            this.btnAddDogadjaj.Click += new System.EventHandler(this.btnAddDogadjaj_Click);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOpis.Location = new System.Drawing.Point(331, 404);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(100, 20);
            this.textBoxOpis.TabIndex = 39;
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(228, 407);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(35, 13);
            this.lblOpis.TabIndex = 38;
            this.lblOpis.Text = "Opis *";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSifra.Location = new System.Drawing.Point(331, 372);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifra.TabIndex = 37;
            // 
            // lblSifra
            // 
            this.lblSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(228, 375);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(35, 13);
            this.lblSifra.TabIndex = 36;
            this.lblSifra.Text = "Sifra *";
            this.lblSifra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 47);
            this.label1.TabIndex = 35;
            this.label1.Text = "Evidencija dogadjaja";
            // 
            // listViewDogadjaji
            // 
            this.listViewDogadjaji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewDogadjaji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSifra,
            this.columnHeaderOpis,
            this.columnHeaderMesto,
            this.columnHeaderAdresa,
            this.columnHeaderVelicina,
            this.columnHeaderUgrozenostLjudiDogadjaja});
            this.listViewDogadjaji.FullRowSelect = true;
            this.listViewDogadjaji.GridLines = true;
            this.listViewDogadjaji.HideSelection = false;
            this.listViewDogadjaji.Location = new System.Drawing.Point(111, 125);
            this.listViewDogadjaji.Name = "listViewDogadjaji";
            this.listViewDogadjaji.Size = new System.Drawing.Size(741, 219);
            this.listViewDogadjaji.TabIndex = 34;
            this.listViewDogadjaji.UseCompatibleStateImageBehavior = false;
            this.listViewDogadjaji.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSifra
            // 
            this.columnHeaderSifra.Text = "Sifra";
            this.columnHeaderSifra.Width = 40;
            // 
            // columnHeaderOpis
            // 
            this.columnHeaderOpis.Text = "Opis";
            this.columnHeaderOpis.Width = 230;
            // 
            // columnHeaderMesto
            // 
            this.columnHeaderMesto.Text = "Mesto";
            this.columnHeaderMesto.Width = 83;
            // 
            // columnHeaderAdresa
            // 
            this.columnHeaderAdresa.Text = "Adresa";
            this.columnHeaderAdresa.Width = 103;
            // 
            // columnHeaderVelicina
            // 
            this.columnHeaderVelicina.Text = "Velicina";
            this.columnHeaderVelicina.Width = 97;
            // 
            // columnHeaderUgrozenostLjudiDogadjaja
            // 
            this.columnHeaderUgrozenostLjudiDogadjaja.Text = "Ugrozenost ljudi i dogadjaja";
            this.columnHeaderUgrozenostLjudiDogadjaja.Width = 153;
            // 
            // textBoxVelicina
            // 
            this.textBoxVelicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxVelicina.Location = new System.Drawing.Point(607, 407);
            this.textBoxVelicina.Name = "textBoxVelicina";
            this.textBoxVelicina.Size = new System.Drawing.Size(100, 20);
            this.textBoxVelicina.TabIndex = 47;
            // 
            // labelVelicina
            // 
            this.labelVelicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVelicina.AutoSize = true;
            this.labelVelicina.Location = new System.Drawing.Point(504, 410);
            this.labelVelicina.Name = "labelVelicina";
            this.labelVelicina.Size = new System.Drawing.Size(51, 13);
            this.labelVelicina.TabIndex = 46;
            this.labelVelicina.Text = "Velicina *";
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdresa.Location = new System.Drawing.Point(607, 375);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresa.TabIndex = 45;
            // 
            // labelAdresa
            // 
            this.labelAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(504, 378);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(47, 13);
            this.labelAdresa.TabIndex = 44;
            this.labelAdresa.Text = "Adresa *";
            this.labelAdresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxMesto
            // 
            this.textBoxMesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMesto.Location = new System.Drawing.Point(331, 436);
            this.textBoxMesto.Name = "textBoxMesto";
            this.textBoxMesto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMesto.TabIndex = 49;
            // 
            // labelMesto
            // 
            this.labelMesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMesto.AutoSize = true;
            this.labelMesto.Location = new System.Drawing.Point(228, 439);
            this.labelMesto.Name = "labelMesto";
            this.labelMesto.Size = new System.Drawing.Size(43, 13);
            this.labelMesto.TabIndex = 48;
            this.labelMesto.Text = "Mesto *";
            this.labelMesto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUgrozenost
            // 
            this.textBoxUgrozenost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUgrozenost.Location = new System.Drawing.Point(607, 439);
            this.textBoxUgrozenost.Name = "textBoxUgrozenost";
            this.textBoxUgrozenost.Size = new System.Drawing.Size(100, 20);
            this.textBoxUgrozenost.TabIndex = 53;
            // 
            // labelUgrozenost
            // 
            this.labelUgrozenost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUgrozenost.AutoSize = true;
            this.labelUgrozenost.Location = new System.Drawing.Point(504, 442);
            this.labelUgrozenost.Name = "labelUgrozenost";
            this.labelUgrozenost.Size = new System.Drawing.Size(89, 13);
            this.labelUgrozenost.TabIndex = 52;
            this.labelUgrozenost.Text = "Ugrozenost ljudi *";
            this.labelUgrozenost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DogadjajiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 626);
            this.Controls.Add(this.textBoxUgrozenost);
            this.Controls.Add(this.labelUgrozenost);
            this.Controls.Add(this.textBoxMesto);
            this.Controls.Add(this.labelMesto);
            this.Controls.Add(this.textBoxVelicina);
            this.Controls.Add(this.labelVelicina);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.btnDeleteDogadjaj);
            this.Controls.Add(this.btnUpdateDogadjaj);
            this.Controls.Add(this.btnAddDogadjaj);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDogadjaji);
            this.Name = "DogadjajiForm";
            this.Text = "Dogadjaji";
            this.Load += new System.EventHandler(this.Dogadjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteDogadjaj;
        private System.Windows.Forms.Button btnUpdateDogadjaj;
        private System.Windows.Forms.Button btnAddDogadjaj;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewDogadjaji;
        private System.Windows.Forms.ColumnHeader columnHeaderSifra;
        private System.Windows.Forms.ColumnHeader columnHeaderOpis;
        private System.Windows.Forms.ColumnHeader columnHeaderMesto;
        private System.Windows.Forms.ColumnHeader columnHeaderAdresa;
        private System.Windows.Forms.ColumnHeader columnHeaderVelicina;
        private System.Windows.Forms.ColumnHeader columnHeaderUgrozenostLjudiDogadjaja;
        private System.Windows.Forms.TextBox textBoxVelicina;
        private System.Windows.Forms.Label labelVelicina;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox textBoxMesto;
        private System.Windows.Forms.Label labelMesto;
        private System.Windows.Forms.TextBox textBoxUgrozenost;
        private System.Windows.Forms.Label labelUgrozenost;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}