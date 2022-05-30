
namespace Boat_Rental
{
    partial class FormCommand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommand));
            this.lvCommand = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idCommandPerson = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameCommand = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.CreateCommand = new System.Windows.Forms.Label();
            this.boatName = new System.Windows.Forms.Label();
            this.totalCommand = new System.Windows.Forms.Label();
            this.cautionCommand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDeb = new System.Windows.Forms.DateTimePicker();
            this.listeIdentifiant = new System.Windows.Forms.ComboBox();
            this.listeBateau = new System.Windows.Forms.ComboBox();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.priceBoat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idBoat = new System.Windows.Forms.ComboBox();
            this.listeNom = new System.Windows.Forms.ComboBox();
            this.boolPaied = new System.Windows.Forms.CheckBox();
            this.montantTTC_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCommand
            // 
            this.lvCommand.FullRowSelect = true;
            this.lvCommand.GridLines = true;
            this.lvCommand.HideSelection = false;
            this.lvCommand.Location = new System.Drawing.Point(715, 106);
            this.lvCommand.Name = "lvCommand";
            this.lvCommand.Size = new System.Drawing.Size(724, 401);
            this.lvCommand.TabIndex = 66;
            this.lvCommand.UseCompatibleStateImageBehavior = false;
            this.lvCommand.View = System.Windows.Forms.View.Details;
            this.lvCommand.DoubleClick += new System.EventHandler(this.lvCommand_DoubleClick_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(606, 553);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(258, 41);
            this.button_Reset.TabIndex = 63;
            this.button_Reset.Text = "Quitter";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(373, 486);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(173, 41);
            this.button_Delete.TabIndex = 62;
            this.button_Delete.Text = "Supprimer une commande";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(194, 486);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(173, 41);
            this.button_Update.TabIndex = 61;
            this.button_Update.Text = "Modifier une commande";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(42, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 59;
            // 
            // idCommandPerson
            // 
            this.idCommandPerson.AutoSize = true;
            this.idCommandPerson.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idCommandPerson.ForeColor = System.Drawing.SystemColors.Control;
            this.idCommandPerson.Location = new System.Drawing.Point(21, 158);
            this.idCommandPerson.Name = "idCommandPerson";
            this.idCommandPerson.Size = new System.Drawing.Size(215, 23);
            this.idCommandPerson.TabIndex = 58;
            this.idCommandPerson.Text = "Identifiant de la personne :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(980, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 57;
            this.label1.Text = "Liste des commandes";
            // 
            // nameCommand
            // 
            this.nameCommand.AutoSize = true;
            this.nameCommand.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.nameCommand.Location = new System.Drawing.Point(66, 106);
            this.nameCommand.Name = "nameCommand";
            this.nameCommand.Size = new System.Drawing.Size(170, 23);
            this.nameCommand.TabIndex = 56;
            this.nameCommand.Text = "Nom de la personne :";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(15, 486);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(173, 41);
            this.button_Add.TabIndex = 55;
            this.button_Add.Text = "Créer la commande";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // CreateCommand
            // 
            this.CreateCommand.AutoSize = true;
            this.CreateCommand.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateCommand.Location = new System.Drawing.Point(149, 52);
            this.CreateCommand.Name = "CreateCommand";
            this.CreateCommand.Size = new System.Drawing.Size(231, 32);
            this.CreateCommand.TabIndex = 52;
            this.CreateCommand.Text = "Créer une commande";
            // 
            // boatName
            // 
            this.boatName.AutoSize = true;
            this.boatName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boatName.ForeColor = System.Drawing.SystemColors.Control;
            this.boatName.Location = new System.Drawing.Point(66, 208);
            this.boatName.Name = "boatName";
            this.boatName.Size = new System.Drawing.Size(169, 23);
            this.boatName.TabIndex = 67;
            this.boatName.Text = "Sélection du bateau :";
            // 
            // totalCommand
            // 
            this.totalCommand.AutoSize = true;
            this.totalCommand.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.totalCommand.Location = new System.Drawing.Point(15, 437);
            this.totalCommand.Name = "totalCommand";
            this.totalCommand.Size = new System.Drawing.Size(213, 23);
            this.totalCommand.TabIndex = 68;
            this.totalCommand.Text = "Total de la commande HT :";
            // 
            // cautionCommand
            // 
            this.cautionCommand.AutoSize = true;
            this.cautionCommand.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cautionCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.cautionCommand.Location = new System.Drawing.Point(33, 394);
            this.cautionCommand.Name = "cautionCommand";
            this.cautionCommand.Size = new System.Drawing.Size(203, 23);
            this.cautionCommand.TabIndex = 69;
            this.cautionCommand.Text = "Caution réglée sur place :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 71;
            this.label2.Text = "Date et heure du début :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(65, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Date et heure de fin :";
            // 
            // dateDeb
            // 
            this.dateDeb.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateDeb.CustomFormat = "dd-MM-yyyy tt H:mm:ss";
            this.dateDeb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDeb.Location = new System.Drawing.Point(309, 301);
            this.dateDeb.Name = "dateDeb";
            this.dateDeb.Size = new System.Drawing.Size(148, 23);
            this.dateDeb.TabIndex = 74;
            this.dateDeb.Value = new System.DateTime(2022, 5, 30, 0, 0, 0, 0);
            // 
            // listeIdentifiant
            // 
            this.listeIdentifiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeIdentifiant.FormattingEnabled = true;
            this.listeIdentifiant.Location = new System.Drawing.Point(309, 161);
            this.listeIdentifiant.Name = "listeIdentifiant";
            this.listeIdentifiant.Size = new System.Drawing.Size(121, 23);
            this.listeIdentifiant.TabIndex = 76;
            this.listeIdentifiant.SelectedIndexChanged += new System.EventHandler(this.listeIdentifiant_SelectedIndexChanged);
            // 
            // listeBateau
            // 
            this.listeBateau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeBateau.FormattingEnabled = true;
            this.listeBateau.Location = new System.Drawing.Point(309, 211);
            this.listeBateau.Name = "listeBateau";
            this.listeBateau.Size = new System.Drawing.Size(121, 23);
            this.listeBateau.TabIndex = 77;
            this.listeBateau.SelectedIndexChanged += new System.EventHandler(this.listeBateau_SelectedIndexChanged);
            // 
            // dateFin
            // 
            this.dateFin.CustomFormat = "dd-MM-yyyy tt H:mm:ss";
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(309, 351);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(148, 23);
            this.dateFin.TabIndex = 78;
            this.dateFin.Value = new System.DateTime(2022, 5, 30, 0, 0, 0, 0);
            // 
            // priceBoat
            // 
            this.priceBoat.Location = new System.Drawing.Point(309, 437);
            this.priceBoat.Name = "priceBoat";
            this.priceBoat.ReadOnly = true;
            this.priceBoat.Size = new System.Drawing.Size(121, 23);
            this.priceBoat.TabIndex = 81;
            this.priceBoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(66, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 83;
            this.label4.Text = "Identifiant du bateau :";
            // 
            // idBoat
            // 
            this.idBoat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idBoat.FormattingEnabled = true;
            this.idBoat.Location = new System.Drawing.Point(309, 252);
            this.idBoat.Name = "idBoat";
            this.idBoat.Size = new System.Drawing.Size(121, 23);
            this.idBoat.TabIndex = 84;
            this.idBoat.SelectedIndexChanged += new System.EventHandler(this.idBoat_SelectedIndexChanged);
            // 
            // listeNom
            // 
            this.listeNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeNom.FormattingEnabled = true;
            this.listeNom.Location = new System.Drawing.Point(309, 106);
            this.listeNom.Name = "listeNom";
            this.listeNom.Size = new System.Drawing.Size(121, 23);
            this.listeNom.TabIndex = 85;
            this.listeNom.SelectedIndexChanged += new System.EventHandler(this.listeNom_SelectedIndexChanged);
            // 
            // boolPaied
            // 
            this.boolPaied.AutoSize = true;
            this.boolPaied.Location = new System.Drawing.Point(352, 401);
            this.boolPaied.Name = "boolPaied";
            this.boolPaied.Size = new System.Drawing.Size(15, 14);
            this.boolPaied.TabIndex = 86;
            this.boolPaied.UseVisualStyleBackColor = true;
            // 
            // montantTTC_text
            // 
            this.montantTTC_text.Location = new System.Drawing.Point(475, 437);
            this.montantTTC_text.Name = "montantTTC_text";
            this.montantTTC_text.Size = new System.Drawing.Size(100, 23);
            this.montantTTC_text.TabIndex = 87;
            // 
            // FormCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1503, 597);
            this.Controls.Add(this.montantTTC_text);
            this.Controls.Add(this.boolPaied);
            this.Controls.Add(this.listeNom);
            this.Controls.Add(this.idBoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceBoat);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.listeBateau);
            this.Controls.Add(this.listeIdentifiant);
            this.Controls.Add(this.dateDeb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cautionCommand);
            this.Controls.Add(this.totalCommand);
            this.Controls.Add(this.boatName);
            this.Controls.Add(this.lvCommand);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idCommandPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameCommand);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.CreateCommand);
            this.Name = "FormCommand";
            this.Text = "Gestion des commandes";
            this.Load += new System.EventHandler(this.FormCommand_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCommand;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idCommandPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameCommand;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label CreateCommand;
        private System.Windows.Forms.Label boatName;
        private System.Windows.Forms.Label totalCommand;
        private System.Windows.Forms.Label cautionCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDeb;
        private System.Windows.Forms.ComboBox listeIdentifiant;
        private System.Windows.Forms.ComboBox listeBateau;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.TextBox priceBoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idBoat;
        private System.Windows.Forms.ComboBox listeNom;
        private System.Windows.Forms.CheckBox boolPaied;
        private System.Windows.Forms.TextBox montantTTC_text;
    }
}