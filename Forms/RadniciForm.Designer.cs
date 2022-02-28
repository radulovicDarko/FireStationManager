
namespace Vatrogasna_stanica.Forms
{
    partial class RadniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadniciForm));
            this.listViewRadnici = new System.Windows.Forms.ListView();
            this.columnHeaderIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJmbg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNazivRadnogMesta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.textBoxJmbg = new System.Windows.Forms.TextBox();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxRadnaMesta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewRadnici
            // 
            this.listViewRadnici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewRadnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIme,
            this.columnHeaderPrezime,
            this.columnHeaderJmbg,
            this.columnHeaderAdresa,
            this.columnHeaderTelefon,
            this.columnHeaderNazivRadnogMesta});
            this.listViewRadnici.FullRowSelect = true;
            this.listViewRadnici.GridLines = true;
            this.listViewRadnici.HideSelection = false;
            this.listViewRadnici.Location = new System.Drawing.Point(137, 110);
            this.listViewRadnici.Name = "listViewRadnici";
            this.listViewRadnici.Size = new System.Drawing.Size(686, 232);
            this.listViewRadnici.TabIndex = 0;
            this.listViewRadnici.UseCompatibleStateImageBehavior = false;
            this.listViewRadnici.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderIme
            // 
            this.columnHeaderIme.Text = "Ime";
            this.columnHeaderIme.Width = 115;
            // 
            // columnHeaderPrezime
            // 
            this.columnHeaderPrezime.Text = "Prezime";
            this.columnHeaderPrezime.Width = 112;
            // 
            // columnHeaderJmbg
            // 
            this.columnHeaderJmbg.Text = "JMBG";
            this.columnHeaderJmbg.Width = 117;
            // 
            // columnHeaderAdresa
            // 
            this.columnHeaderAdresa.Text = "Adresa";
            this.columnHeaderAdresa.Width = 114;
            // 
            // columnHeaderTelefon
            // 
            this.columnHeaderTelefon.Text = "Telefon";
            this.columnHeaderTelefon.Width = 105;
            // 
            // columnHeaderNazivRadnogMesta
            // 
            this.columnHeaderNazivRadnogMesta.Text = "Radno mesto";
            this.columnHeaderNazivRadnogMesta.Width = 119;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evidencija radnika";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(281, 387);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(31, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime *";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIme.Location = new System.Drawing.Point(342, 384);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrezime.Location = new System.Drawing.Point(342, 419);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 5;
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(281, 422);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(51, 13);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime *";
            // 
            // textBoxJmbg
            // 
            this.textBoxJmbg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxJmbg.Location = new System.Drawing.Point(342, 454);
            this.textBoxJmbg.Name = "textBoxJmbg";
            this.textBoxJmbg.Size = new System.Drawing.Size(100, 20);
            this.textBoxJmbg.TabIndex = 7;
            // 
            // lblJmbg
            // 
            this.lblJmbg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(281, 457);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(43, 13);
            this.lblJmbg.TabIndex = 6;
            this.lblJmbg.Text = "JMBG *";
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdresa.Location = new System.Drawing.Point(342, 489);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresa.TabIndex = 9;
            // 
            // lblAdresa
            // 
            this.lblAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(281, 492);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(47, 13);
            this.lblAdresa.TabIndex = 8;
            this.lblAdresa.Text = "Adresa *";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTelefon.Location = new System.Drawing.Point(342, 522);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 11;
            // 
            // lblTelefon
            // 
            this.lblTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(281, 525);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(50, 13);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Telefon *";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(499, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Dodaj radnika";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(499, 438);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 51);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Ažuriraj podatke o radniku";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(499, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Izbriši radnika";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxRadnaMesta
            // 
            this.comboBoxRadnaMesta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRadnaMesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRadnaMesta.FormattingEnabled = true;
            this.comboBoxRadnaMesta.Location = new System.Drawing.Point(365, 559);
            this.comboBoxRadnaMesta.Name = "comboBoxRadnaMesta";
            this.comboBoxRadnaMesta.Size = new System.Drawing.Size(142, 21);
            this.comboBoxRadnaMesta.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Radno mesto *";
            // 
            // Radnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRadnaMesta);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.textBoxJmbg);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewRadnici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Radnici";
            this.Text = "Radnici";
            this.Load += new System.EventHandler(this.Radnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRadnici;
        private System.Windows.Forms.ColumnHeader columnHeaderIme;
        private System.Windows.Forms.ColumnHeader columnHeaderPrezime;
        private System.Windows.Forms.ColumnHeader columnHeaderJmbg;
        private System.Windows.Forms.ColumnHeader columnHeaderAdresa;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox textBoxJmbg;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader columnHeaderNazivRadnogMesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRadnaMesta;
    }
}