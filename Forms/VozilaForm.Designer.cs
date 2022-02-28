
namespace Vatrogasna_stanica.Forms
{
    partial class VozilaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VozilaForm));
            this.comboBoxTipoviVozila = new System.Windows.Forms.ComboBox();
            this.btnDeleteVozilo = new System.Windows.Forms.Button();
            this.btnUpdateVozilo = new System.Windows.Forms.Button();
            this.btnAddVozilo = new System.Windows.Forms.Button();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.textBoxRegBroj = new System.Windows.Forms.TextBox();
            this.lblRegBroj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewVozila = new System.Windows.Forms.ListView();
            this.columnHeaderRegistarskiBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipVozila = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipoviVozila
            // 
            this.comboBoxTipoviVozila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTipoviVozila.FormattingEnabled = true;
            this.comboBoxTipoviVozila.Location = new System.Drawing.Point(438, 396);
            this.comboBoxTipoviVozila.Name = "comboBoxTipoviVozila";
            this.comboBoxTipoviVozila.Size = new System.Drawing.Size(142, 21);
            this.comboBoxTipoviVozila.TabIndex = 33;
            // 
            // btnDeleteVozilo
            // 
            this.btnDeleteVozilo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteVozilo.Location = new System.Drawing.Point(550, 438);
            this.btnDeleteVozilo.Name = "btnDeleteVozilo";
            this.btnDeleteVozilo.Size = new System.Drawing.Size(83, 36);
            this.btnDeleteVozilo.TabIndex = 32;
            this.btnDeleteVozilo.Text = "Izbriši vozilo";
            this.btnDeleteVozilo.UseVisualStyleBackColor = true;
            this.btnDeleteVozilo.Click += new System.EventHandler(this.btnDeleteVozilo_Click);
            // 
            // btnUpdateVozilo
            // 
            this.btnUpdateVozilo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateVozilo.Location = new System.Drawing.Point(428, 438);
            this.btnUpdateVozilo.Name = "btnUpdateVozilo";
            this.btnUpdateVozilo.Size = new System.Drawing.Size(103, 36);
            this.btnUpdateVozilo.TabIndex = 31;
            this.btnUpdateVozilo.Text = "Ažuriraj podatke o vozilu";
            this.btnUpdateVozilo.UseVisualStyleBackColor = true;
            this.btnUpdateVozilo.Click += new System.EventHandler(this.btnUpdateVozilo_Click);
            // 
            // btnAddVozilo
            // 
            this.btnAddVozilo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddVozilo.Location = new System.Drawing.Point(324, 438);
            this.btnAddVozilo.Name = "btnAddVozilo";
            this.btnAddVozilo.Size = new System.Drawing.Size(83, 36);
            this.btnAddVozilo.TabIndex = 30;
            this.btnAddVozilo.Text = "Dodaj vozilo";
            this.btnAddVozilo.UseVisualStyleBackColor = true;
            this.btnAddVozilo.Click += new System.EventHandler(this.btnAddVozilo_Click);
            // 
            // lblJmbg
            // 
            this.lblJmbg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(377, 396);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(59, 13);
            this.lblJmbg.TabIndex = 24;
            this.lblJmbg.Text = "Tip vozila *";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMarka.Location = new System.Drawing.Point(480, 362);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarka.TabIndex = 23;
            // 
            // lblMarka
            // 
            this.lblMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(377, 365);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(44, 13);
            this.lblMarka.TabIndex = 22;
            this.lblMarka.Text = "Marka *";
            // 
            // textBoxRegBroj
            // 
            this.textBoxRegBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRegBroj.Location = new System.Drawing.Point(480, 330);
            this.textBoxRegBroj.Name = "textBoxRegBroj";
            this.textBoxRegBroj.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegBroj.TabIndex = 21;
            // 
            // lblRegBroj
            // 
            this.lblRegBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegBroj.AutoSize = true;
            this.lblRegBroj.Location = new System.Drawing.Point(377, 333);
            this.lblRegBroj.Name = "lblRegBroj";
            this.lblRegBroj.Size = new System.Drawing.Size(86, 13);
            this.lblRegBroj.TabIndex = 20;
            this.lblRegBroj.Text = "Registarski broj *";
            this.lblRegBroj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Evidencija vozila";
            // 
            // listViewVozila
            // 
            this.listViewVozila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRegistarskiBroj,
            this.columnHeaderMarka,
            this.columnHeaderTipVozila});
            this.listViewVozila.FullRowSelect = true;
            this.listViewVozila.GridLines = true;
            this.listViewVozila.HideSelection = false;
            this.listViewVozila.Location = new System.Drawing.Point(254, 109);
            this.listViewVozila.Name = "listViewVozila";
            this.listViewVozila.Size = new System.Drawing.Size(460, 200);
            this.listViewVozila.TabIndex = 18;
            this.listViewVozila.UseCompatibleStateImageBehavior = false;
            this.listViewVozila.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRegistarskiBroj
            // 
            this.columnHeaderRegistarskiBroj.Text = "Registarski broj";
            this.columnHeaderRegistarskiBroj.Width = 154;
            // 
            // columnHeaderMarka
            // 
            this.columnHeaderMarka.Text = "Marka";
            this.columnHeaderMarka.Width = 131;
            // 
            // columnHeaderTipVozila
            // 
            this.columnHeaderTipVozila.Text = "Tip vozila";
            this.columnHeaderTipVozila.Width = 146;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Vozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 626);
            this.Controls.Add(this.comboBoxTipoviVozila);
            this.Controls.Add(this.btnDeleteVozilo);
            this.Controls.Add(this.btnUpdateVozilo);
            this.Controls.Add(this.btnAddVozilo);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.textBoxRegBroj);
            this.Controls.Add(this.lblRegBroj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewVozila);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vozila";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.Vozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTipoviVozila;
        private System.Windows.Forms.Button btnDeleteVozilo;
        private System.Windows.Forms.Button btnUpdateVozilo;
        private System.Windows.Forms.Button btnAddVozilo;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox textBoxRegBroj;
        private System.Windows.Forms.Label lblRegBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewVozila;
        private System.Windows.Forms.ColumnHeader columnHeaderRegistarskiBroj;
        private System.Windows.Forms.ColumnHeader columnHeaderMarka;
        private System.Windows.Forms.ColumnHeader columnHeaderTipVozila;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}