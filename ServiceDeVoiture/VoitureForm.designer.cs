namespace ServiceDeVoitureNS
{
    partial class VoitureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoitureForm));
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VoitureMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aproposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.prixLabel = new System.Windows.Forms.Label();
            this.prixLLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.marqueComboBox = new System.Windows.Forms.ComboBox();
            this.nomMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.paiementDuLLabel = new System.Windows.Forms.Label();
            this.paiementDuLabel = new System.Windows.Forms.Label();
            this.dateReservationLabel = new System.Windows.Forms.Label();
            this.adresseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.marqueLabel = new System.Windows.Forms.Label();
            this.villeLabel = new System.Windows.Forms.Label();
            this.villeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.consommationComboBox = new System.Windows.Forms.ComboBox();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.provinceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.voiturePrefereLabel = new System.Windows.Forms.Label();
            this.paiementLabel = new System.Windows.Forms.Label();
            this.voiturePrefereComboBox = new System.Windows.Forms.ComboBox();
            this.modePaiementComboBox = new System.Windows.Forms.ComboBox();
            this.codePostalLabel = new System.Windows.Forms.Label();
            this.codePostalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.consommationLabel = new System.Windows.Forms.Label();
            this.voitureGroupBox = new System.Windows.Forms.GroupBox();
            this.reservationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enregistrerButton = new System.Windows.Forms.Button();
            this.quitterButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.VoitureMenuStrip.SuspendLayout();
            this.clientGroupBox.SuspendLayout();
            this.voitureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(337, 188);
            this.telephoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(94, 22);
            this.telephoneMaskedTextBox.TabIndex = 11;
            this.telephoneMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // VoitureMenuStrip
            // 
            this.VoitureMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.VoitureMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.VoitureMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.VoitureMenuStrip.Name = "VoitureMenuStrip";
            this.VoitureMenuStrip.Size = new System.Drawing.Size(1124, 28);
            this.VoitureMenuStrip.TabIndex = 2;
            this.VoitureMenuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterButton_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aproposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aproposDeToolStripMenuItem
            // 
            this.aproposDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aproposDeToolStripMenuItem.Image")));
            this.aproposDeToolStripMenuItem.Name = "aproposDeToolStripMenuItem";
            this.aproposDeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.aproposDeToolStripMenuItem.Text = "A &propos de...";
            this.aproposDeToolStripMenuItem.Click += new System.EventHandler(this.aproposDeToolStripMenuItem_Click);
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(222, 191);
            this.telephoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(84, 17);
            this.telephoneLabel.TabIndex = 10;
            this.telephoneLabel.Text = "&Téléphone :";
            // 
            // prixLabel
            // 
            this.prixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prixLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prixLabel.Location = new System.Drawing.Point(315, 57);
            this.prixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(310, 31);
            this.prixLabel.TabIndex = 5;
            this.prixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prixLLabel
            // 
            this.prixLLabel.AutoSize = true;
            this.prixLLabel.Location = new System.Drawing.Point(366, 28);
            this.prixLLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prixLLabel.Name = "prixLLabel";
            this.prixLLabel.Size = new System.Drawing.Size(31, 17);
            this.prixLLabel.TabIndex = 4;
            this.prixLLabel.Text = "Prix";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(6, 42);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(45, 17);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "&Nom :";
            // 
            // marqueComboBox
            // 
            this.marqueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marqueComboBox.FormattingEnabled = true;
            this.marqueComboBox.Location = new System.Drawing.Point(182, 57);
            this.marqueComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.marqueComboBox.Name = "marqueComboBox";
            this.marqueComboBox.Size = new System.Drawing.Size(112, 24);
            this.marqueComboBox.TabIndex = 3;
            this.marqueComboBox.SelectedIndexChanged += new System.EventHandler(this.ConsoMarque_SelectedIndexChanged);
            // 
            // nomMaskedTextBox
            // 
            this.nomMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomMaskedTextBox.Location = new System.Drawing.Point(135, 42);
            this.nomMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomMaskedTextBox.Name = "nomMaskedTextBox";
            this.nomMaskedTextBox.Size = new System.Drawing.Size(296, 22);
            this.nomMaskedTextBox.TabIndex = 1;
            this.nomMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(6, 76);
            this.adresseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(68, 17);
            this.adresseLabel.TabIndex = 2;
            this.adresseLabel.Text = "&Adresse :";
            // 
            // paiementDuLLabel
            // 
            this.paiementDuLLabel.AutoSize = true;
            this.paiementDuLLabel.Location = new System.Drawing.Point(7, 158);
            this.paiementDuLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paiementDuLLabel.Name = "paiementDuLLabel";
            this.paiementDuLLabel.Size = new System.Drawing.Size(114, 17);
            this.paiementDuLLabel.TabIndex = 8;
            this.paiementDuLLabel.Text = "Paiement dû le : ";
            // 
            // paiementDuLabel
            // 
            this.paiementDuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paiementDuLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paiementDuLabel.Location = new System.Drawing.Point(182, 153);
            this.paiementDuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paiementDuLabel.Name = "paiementDuLabel";
            this.paiementDuLabel.Size = new System.Drawing.Size(277, 31);
            this.paiementDuLabel.TabIndex = 9;
            // 
            // dateReservationLabel
            // 
            this.dateReservationLabel.AutoSize = true;
            this.dateReservationLabel.Location = new System.Drawing.Point(6, 111);
            this.dateReservationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateReservationLabel.Name = "dateReservationLabel";
            this.dateReservationLabel.Size = new System.Drawing.Size(141, 17);
            this.dateReservationLabel.TabIndex = 6;
            this.dateReservationLabel.Text = "Da&te de reservation: ";
            // 
            // adresseMaskedTextBox
            // 
            this.adresseMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adresseMaskedTextBox.Location = new System.Drawing.Point(135, 76);
            this.adresseMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adresseMaskedTextBox.Name = "adresseMaskedTextBox";
            this.adresseMaskedTextBox.Size = new System.Drawing.Size(296, 22);
            this.adresseMaskedTextBox.TabIndex = 3;
            this.adresseMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // marqueLabel
            // 
            this.marqueLabel.AutoSize = true;
            this.marqueLabel.Location = new System.Drawing.Point(178, 28);
            this.marqueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.marqueLabel.Name = "marqueLabel";
            this.marqueLabel.Size = new System.Drawing.Size(56, 17);
            this.marqueLabel.TabIndex = 2;
            this.marqueLabel.Text = "&Marque";
            // 
            // villeLabel
            // 
            this.villeLabel.AutoSize = true;
            this.villeLabel.Location = new System.Drawing.Point(6, 113);
            this.villeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.villeLabel.Name = "villeLabel";
            this.villeLabel.Size = new System.Drawing.Size(42, 17);
            this.villeLabel.TabIndex = 4;
            this.villeLabel.Text = "&Ville :";
            // 
            // villeMaskedTextBox
            // 
            this.villeMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.villeMaskedTextBox.Location = new System.Drawing.Point(135, 113);
            this.villeMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.villeMaskedTextBox.Name = "villeMaskedTextBox";
            this.villeMaskedTextBox.Size = new System.Drawing.Size(296, 22);
            this.villeMaskedTextBox.TabIndex = 5;
            this.villeMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Location = new System.Drawing.Point(6, 148);
            this.provinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(63, 17);
            this.provinceLabel.TabIndex = 6;
            this.provinceLabel.Text = "&Province";
            // 
            // consommationComboBox
            // 
            this.consommationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consommationComboBox.FormattingEnabled = true;
            this.consommationComboBox.Location = new System.Drawing.Point(7, 57);
            this.consommationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.consommationComboBox.Name = "consommationComboBox";
            this.consommationComboBox.Size = new System.Drawing.Size(151, 24);
            this.consommationComboBox.TabIndex = 1;
            this.consommationComboBox.SelectedIndexChanged += new System.EventHandler(this.ConsoMarque_SelectedIndexChanged);
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientGroupBox.Controls.Add(this.provinceMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.voiturePrefereLabel);
            this.clientGroupBox.Controls.Add(this.paiementLabel);
            this.clientGroupBox.Controls.Add(this.voiturePrefereComboBox);
            this.clientGroupBox.Controls.Add(this.modePaiementComboBox);
            this.clientGroupBox.Controls.Add(this.telephoneLabel);
            this.clientGroupBox.Controls.Add(this.telephoneMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.nomLabel);
            this.clientGroupBox.Controls.Add(this.nomMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.adresseLabel);
            this.clientGroupBox.Controls.Add(this.adresseMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.villeLabel);
            this.clientGroupBox.Controls.Add(this.villeMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.provinceLabel);
            this.clientGroupBox.Controls.Add(this.codePostalLabel);
            this.clientGroupBox.Controls.Add(this.codePostalMaskedTextBox);
            this.clientGroupBox.Location = new System.Drawing.Point(13, 230);
            this.clientGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.clientGroupBox.Size = new System.Drawing.Size(439, 338);
            this.clientGroupBox.TabIndex = 0;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Client";
            // 
            // provinceMaskedTextBox
            // 
            this.provinceMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.provinceMaskedTextBox.Location = new System.Drawing.Point(135, 151);
            this.provinceMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.provinceMaskedTextBox.Name = "provinceMaskedTextBox";
            this.provinceMaskedTextBox.Size = new System.Drawing.Size(296, 22);
            this.provinceMaskedTextBox.TabIndex = 7;
            this.provinceMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // voiturePrefereLabel
            // 
            this.voiturePrefereLabel.AutoSize = true;
            this.voiturePrefereLabel.Location = new System.Drawing.Point(9, 301);
            this.voiturePrefereLabel.Name = "voiturePrefereLabel";
            this.voiturePrefereLabel.Size = new System.Drawing.Size(119, 17);
            this.voiturePrefereLabel.TabIndex = 15;
            this.voiturePrefereLabel.Text = "Voiture préférée :";
            // 
            // paiementLabel
            // 
            this.paiementLabel.AutoSize = true;
            this.paiementLabel.Location = new System.Drawing.Point(9, 254);
            this.paiementLabel.Name = "paiementLabel";
            this.paiementLabel.Size = new System.Drawing.Size(133, 17);
            this.paiementLabel.TabIndex = 14;
            this.paiementLabel.Text = "Mode de paiement: ";
            // 
            // voiturePrefereComboBox
            // 
            this.voiturePrefereComboBox.FormattingEnabled = true;
            this.voiturePrefereComboBox.Location = new System.Drawing.Point(159, 294);
            this.voiturePrefereComboBox.Name = "voiturePrefereComboBox";
            this.voiturePrefereComboBox.Size = new System.Drawing.Size(272, 24);
            this.voiturePrefereComboBox.TabIndex = 13;
            // 
            // modePaiementComboBox
            // 
            this.modePaiementComboBox.FormattingEnabled = true;
            this.modePaiementComboBox.Location = new System.Drawing.Point(159, 248);
            this.modePaiementComboBox.Name = "modePaiementComboBox";
            this.modePaiementComboBox.Size = new System.Drawing.Size(272, 24);
            this.modePaiementComboBox.TabIndex = 12;
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Location = new System.Drawing.Point(6, 188);
            this.codePostalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(92, 17);
            this.codePostalLabel.TabIndex = 8;
            this.codePostalLabel.Text = "&Code Postal :";
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(135, 188);
            this.codePostalMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(79, 22);
            this.codePostalMaskedTextBox.TabIndex = 9;
            this.codePostalMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // consommationLabel
            // 
            this.consommationLabel.Location = new System.Drawing.Point(4, 26);
            this.consommationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.consommationLabel.Name = "consommationLabel";
            this.consommationLabel.Size = new System.Drawing.Size(131, 24);
            this.consommationLabel.TabIndex = 0;
            this.consommationLabel.Text = "&Consommation";
            // 
            // voitureGroupBox
            // 
            this.voitureGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voitureGroupBox.Controls.Add(this.reservationDateTimePicker);
            this.voitureGroupBox.Controls.Add(this.consommationLabel);
            this.voitureGroupBox.Controls.Add(this.consommationComboBox);
            this.voitureGroupBox.Controls.Add(this.marqueLabel);
            this.voitureGroupBox.Controls.Add(this.marqueComboBox);
            this.voitureGroupBox.Controls.Add(this.prixLLabel);
            this.voitureGroupBox.Controls.Add(this.prixLabel);
            this.voitureGroupBox.Controls.Add(this.paiementDuLLabel);
            this.voitureGroupBox.Controls.Add(this.paiementDuLabel);
            this.voitureGroupBox.Controls.Add(this.dateReservationLabel);
            this.voitureGroupBox.Location = new System.Drawing.Point(479, 230);
            this.voitureGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.voitureGroupBox.Name = "voitureGroupBox";
            this.voitureGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.voitureGroupBox.Size = new System.Drawing.Size(642, 237);
            this.voitureGroupBox.TabIndex = 1;
            this.voitureGroupBox.TabStop = false;
            this.voitureGroupBox.Text = "Voiture";
            // 
            // reservationDateTimePicker
            // 
            this.reservationDateTimePicker.Location = new System.Drawing.Point(181, 113);
            this.reservationDateTimePicker.Name = "reservationDateTimePicker";
            this.reservationDateTimePicker.Size = new System.Drawing.Size(278, 22);
            this.reservationDateTimePicker.TabIndex = 10;
            this.reservationDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.reservationDateTimePicker_Validating);
            // 
            // enregistrerButton
            // 
            this.enregistrerButton.Location = new System.Drawing.Point(479, 478);
            this.enregistrerButton.Name = "enregistrerButton";
            this.enregistrerButton.Size = new System.Drawing.Size(262, 90);
            this.enregistrerButton.TabIndex = 12;
            this.enregistrerButton.Text = "Enregistrer";
            this.enregistrerButton.UseVisualStyleBackColor = true;
            this.enregistrerButton.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterButton
            // 
            this.quitterButton.Location = new System.Drawing.Point(794, 478);
            this.quitterButton.Name = "quitterButton";
            this.quitterButton.Size = new System.Drawing.Size(263, 90);
            this.quitterButton.TabIndex = 13;
            this.quitterButton.Text = "Quitter";
            this.quitterButton.UseVisualStyleBackColor = true;
            this.quitterButton.Click += new System.EventHandler(this.quitterButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::ServiceDeVoitureNS.Properties.Resources.Logo;
            this.logoPictureBox.Location = new System.Drawing.Point(197, 28);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(750, 195);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 11;
            this.logoPictureBox.TabStop = false;
            // 
            // VoitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 596);
            this.Controls.Add(this.quitterButton);
            this.Controls.Add(this.enregistrerButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.VoitureMenuStrip);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.voitureGroupBox);
            this.Name = "VoitureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service de voiture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VoitureForm_FormClosed);
            this.Load += new System.EventHandler(this.VoitureForm_Load);
            this.VoitureMenuStrip.ResumeLayout(false);
            this.VoitureMenuStrip.PerformLayout();
            this.clientGroupBox.ResumeLayout(false);
            this.clientGroupBox.PerformLayout();
            this.voitureGroupBox.ResumeLayout(false);
            this.voitureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.MenuStrip VoitureMenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        internal System.Windows.Forms.Label telephoneLabel;
        internal System.Windows.Forms.Label prixLabel;
        internal System.Windows.Forms.Label prixLLabel;
        internal System.Windows.Forms.Label nomLabel;
        internal System.Windows.Forms.ComboBox marqueComboBox;
        internal System.Windows.Forms.MaskedTextBox nomMaskedTextBox;
        internal System.Windows.Forms.Label adresseLabel;
        internal System.Windows.Forms.Label paiementDuLLabel;
        internal System.Windows.Forms.Label paiementDuLabel;
        internal System.Windows.Forms.Label dateReservationLabel;
        internal System.Windows.Forms.MaskedTextBox adresseMaskedTextBox;
        internal System.Windows.Forms.Label marqueLabel;
        internal System.Windows.Forms.Label villeLabel;
        internal System.Windows.Forms.MaskedTextBox villeMaskedTextBox;
        internal System.Windows.Forms.Label provinceLabel;
        internal System.Windows.Forms.ComboBox consommationComboBox;
        internal System.Windows.Forms.GroupBox clientGroupBox;
        internal System.Windows.Forms.Label codePostalLabel;
        internal System.Windows.Forms.MaskedTextBox codePostalMaskedTextBox;
        internal System.Windows.Forms.Label consommationLabel;
        internal System.Windows.Forms.GroupBox voitureGroupBox;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker reservationDateTimePicker;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button enregistrerButton;
        private System.Windows.Forms.Button quitterButton;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aproposDeToolStripMenuItem;
        private System.Windows.Forms.Label voiturePrefereLabel;
        private System.Windows.Forms.Label paiementLabel;
        private System.Windows.Forms.ComboBox voiturePrefereComboBox;
        private System.Windows.Forms.ComboBox modePaiementComboBox;
        internal System.Windows.Forms.MaskedTextBox provinceMaskedTextBox;
    }
}

