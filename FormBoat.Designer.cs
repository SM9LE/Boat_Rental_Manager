
namespace Boat_Rental
{
    partial class FormBoat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoat));
            this.label1 = new System.Windows.Forms.Label();
            this.CreateCommand = new System.Windows.Forms.Label();
            this.BoatDescription_label = new System.Windows.Forms.Label();
            this.Rented_label = new System.Windows.Forms.Label();
            this.BoatPrice_label = new System.Windows.Forms.Label();
            this.BoatType_label = new System.Windows.Forms.Label();
            this.BoatSlot_label = new System.Windows.Forms.Label();
            this.BoatLicense_label = new System.Windows.Forms.Label();
            this.BoatName_label = new System.Windows.Forms.Label();
            this.NameBoat = new System.Windows.Forms.TextBox();
            this.LicenseBoat = new System.Windows.Forms.TextBox();
            this.SlotBoat = new System.Windows.Forms.TextBox();
            this.DescriptionBoat = new System.Windows.Forms.TextBox();
            this.TypeBoat = new System.Windows.Forms.ComboBox();
            this.PriceBoat = new System.Windows.Forms.TextBox();
            this.RentedBoat = new System.Windows.Forms.CheckBox();
            this.AddBoat = new System.Windows.Forms.Button();
            this.DeleteBoat = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.Button();
            this.UpdateBoat = new System.Windows.Forms.Button();
            this.RefreshText = new System.Windows.Forms.Button();
            this.lvFormBoat = new System.Windows.Forms.ListView();
            this.BoatTypeId_label = new System.Windows.Forms.Label();
            this.idBoat = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(919, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 67;
            this.label1.Text = "Liste des bateaux";
            // 
            // CreateCommand
            // 
            this.CreateCommand.AutoSize = true;
            this.CreateCommand.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateCommand.Location = new System.Drawing.Point(214, 58);
            this.CreateCommand.Name = "CreateCommand";
            this.CreateCommand.Size = new System.Drawing.Size(177, 32);
            this.CreateCommand.TabIndex = 66;
            this.CreateCommand.Text = "Créer un bateau";
            // 
            // BoatDescription_label
            // 
            this.BoatDescription_label.AutoSize = true;
            this.BoatDescription_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatDescription_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatDescription_label.Location = new System.Drawing.Point(23, 292);
            this.BoatDescription_label.Name = "BoatDescription_label";
            this.BoatDescription_label.Size = new System.Drawing.Size(186, 23);
            this.BoatDescription_label.TabIndex = 91;
            this.BoatDescription_label.Text = "Description du bateau :";
            // 
            // Rented_label
            // 
            this.Rented_label.AutoSize = true;
            this.Rented_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rented_label.ForeColor = System.Drawing.SystemColors.Control;
            this.Rented_label.Location = new System.Drawing.Point(40, 460);
            this.Rented_label.Name = "Rented_label";
            this.Rented_label.Size = new System.Drawing.Size(155, 23);
            this.Rented_label.TabIndex = 90;
            this.Rented_label.Text = "Location en cours :";
            // 
            // BoatPrice_label
            // 
            this.BoatPrice_label.AutoSize = true;
            this.BoatPrice_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatPrice_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatPrice_label.Location = new System.Drawing.Point(7, 412);
            this.BoatPrice_label.Name = "BoatPrice_label";
            this.BoatPrice_label.Size = new System.Drawing.Size(230, 23);
            this.BoatPrice_label.TabIndex = 89;
            this.BoatPrice_label.Text = "Prix du bateau à la location :";
            // 
            // BoatType_label
            // 
            this.BoatType_label.AutoSize = true;
            this.BoatType_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatType_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatType_label.Location = new System.Drawing.Point(50, 361);
            this.BoatType_label.Name = "BoatType_label";
            this.BoatType_label.Size = new System.Drawing.Size(145, 23);
            this.BoatType_label.TabIndex = 88;
            this.BoatType_label.Text = "Type de bateau :  ";
            // 
            // BoatSlot_label
            // 
            this.BoatSlot_label.AutoSize = true;
            this.BoatSlot_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatSlot_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatSlot_label.Location = new System.Drawing.Point(40, 218);
            this.BoatSlot_label.Name = "BoatSlot_label";
            this.BoatSlot_label.Size = new System.Drawing.Size(155, 23);
            this.BoatSlot_label.TabIndex = 86;
            this.BoatSlot_label.Text = "Places disponibles :";
            // 
            // BoatLicense_label
            // 
            this.BoatLicense_label.AutoSize = true;
            this.BoatLicense_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatLicense_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatLicense_label.Location = new System.Drawing.Point(44, 174);
            this.BoatLicense_label.Name = "BoatLicense_label";
            this.BoatLicense_label.Size = new System.Drawing.Size(151, 23);
            this.BoatLicense_label.TabIndex = 85;
            this.BoatLicense_label.Text = "Plaque du bateau :";
            // 
            // BoatName_label
            // 
            this.BoatName_label.AutoSize = true;
            this.BoatName_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatName_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatName_label.Location = new System.Drawing.Point(48, 121);
            this.BoatName_label.Name = "BoatName_label";
            this.BoatName_label.Size = new System.Drawing.Size(136, 23);
            this.BoatName_label.TabIndex = 84;
            this.BoatName_label.Text = "Nom du bateau :";
            // 
            // NameBoat
            // 
            this.NameBoat.Location = new System.Drawing.Point(246, 121);
            this.NameBoat.Name = "NameBoat";
            this.NameBoat.PlaceholderText = "La belle Alice";
            this.NameBoat.Size = new System.Drawing.Size(145, 23);
            this.NameBoat.TabIndex = 92;
            this.NameBoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LicenseBoat
            // 
            this.LicenseBoat.Location = new System.Drawing.Point(246, 177);
            this.LicenseBoat.Name = "LicenseBoat";
            this.LicenseBoat.PlaceholderText = "4l1C3";
            this.LicenseBoat.Size = new System.Drawing.Size(145, 23);
            this.LicenseBoat.TabIndex = 93;
            this.LicenseBoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SlotBoat
            // 
            this.SlotBoat.Location = new System.Drawing.Point(246, 221);
            this.SlotBoat.Name = "SlotBoat";
            this.SlotBoat.PlaceholderText = "10";
            this.SlotBoat.Size = new System.Drawing.Size(145, 23);
            this.SlotBoat.TabIndex = 94;
            this.SlotBoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DescriptionBoat
            // 
            this.DescriptionBoat.Location = new System.Drawing.Point(231, 266);
            this.DescriptionBoat.Multiline = true;
            this.DescriptionBoat.Name = "DescriptionBoat";
            this.DescriptionBoat.PlaceholderText = "Très bon bateau faisant penser à Snowpiercer";
            this.DescriptionBoat.Size = new System.Drawing.Size(213, 68);
            this.DescriptionBoat.TabIndex = 95;
            this.DescriptionBoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeBoat
            // 
            this.TypeBoat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBoat.FormattingEnabled = true;
            this.TypeBoat.Location = new System.Drawing.Point(246, 364);
            this.TypeBoat.Name = "TypeBoat";
            this.TypeBoat.Size = new System.Drawing.Size(145, 23);
            this.TypeBoat.TabIndex = 96;
            this.TypeBoat.SelectedIndexChanged += new System.EventHandler(this.TypeBoat_SelectedIndexChanged);
            // 
            // PriceBoat
            // 
            this.PriceBoat.Location = new System.Drawing.Point(246, 412);
            this.PriceBoat.Name = "PriceBoat";
            this.PriceBoat.PlaceholderText = "999999999";
            this.PriceBoat.Size = new System.Drawing.Size(145, 23);
            this.PriceBoat.TabIndex = 97;
            this.PriceBoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RentedBoat
            // 
            this.RentedBoat.AutoSize = true;
            this.RentedBoat.Location = new System.Drawing.Point(312, 467);
            this.RentedBoat.Name = "RentedBoat";
            this.RentedBoat.Size = new System.Drawing.Size(15, 14);
            this.RentedBoat.TabIndex = 98;
            this.RentedBoat.UseVisualStyleBackColor = true;
            // 
            // AddBoat
            // 
            this.AddBoat.Location = new System.Drawing.Point(89, 515);
            this.AddBoat.Name = "AddBoat";
            this.AddBoat.Size = new System.Drawing.Size(169, 41);
            this.AddBoat.TabIndex = 100;
            this.AddBoat.Text = "Ajouter un bateau";
            this.AddBoat.UseVisualStyleBackColor = true;
            this.AddBoat.Click += new System.EventHandler(this.AddBoat_Click);
            // 
            // DeleteBoat
            // 
            this.DeleteBoat.Location = new System.Drawing.Point(303, 515);
            this.DeleteBoat.Name = "DeleteBoat";
            this.DeleteBoat.Size = new System.Drawing.Size(169, 41);
            this.DeleteBoat.TabIndex = 101;
            this.DeleteBoat.Text = "Supprimer un bateau";
            this.DeleteBoat.UseVisualStyleBackColor = true;
            this.DeleteBoat.Click += new System.EventHandler(this.DeleteBoat_Click);
            // 
            // Leave
            // 
            this.Leave.Location = new System.Drawing.Point(572, 640);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(258, 42);
            this.Leave.TabIndex = 104;
            this.Leave.Text = "Quitter";
            this.Leave.UseVisualStyleBackColor = true;
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // UpdateBoat
            // 
            this.UpdateBoat.Location = new System.Drawing.Point(89, 576);
            this.UpdateBoat.Name = "UpdateBoat";
            this.UpdateBoat.Size = new System.Drawing.Size(169, 41);
            this.UpdateBoat.TabIndex = 105;
            this.UpdateBoat.Text = "Modifier un bateau";
            this.UpdateBoat.UseVisualStyleBackColor = true;
            this.UpdateBoat.Click += new System.EventHandler(this.UpdateBoat_Click);
            // 
            // RefreshText
            // 
            this.RefreshText.Location = new System.Drawing.Point(303, 576);
            this.RefreshText.Name = "RefreshText";
            this.RefreshText.Size = new System.Drawing.Size(169, 41);
            this.RefreshText.TabIndex = 106;
            this.RefreshText.Text = "Réinitialiser";
            this.RefreshText.UseVisualStyleBackColor = true;
            this.RefreshText.Click += new System.EventHandler(this.RefreshText_Click);
            // 
            // lvFormBoat
            // 
            this.lvFormBoat.FullRowSelect = true;
            this.lvFormBoat.GridLines = true;
            this.lvFormBoat.HideSelection = false;
            this.lvFormBoat.LabelWrap = false;
            this.lvFormBoat.Location = new System.Drawing.Point(601, 109);
            this.lvFormBoat.Name = "lvFormBoat";
            this.lvFormBoat.Size = new System.Drawing.Size(810, 365);
            this.lvFormBoat.TabIndex = 107;
            this.lvFormBoat.UseCompatibleStateImageBehavior = false;
            this.lvFormBoat.View = System.Windows.Forms.View.Details;
            this.lvFormBoat.DoubleClick += new System.EventHandler(this.lvFormBoat_DoubleClick);
            // 
            // BoatTypeId_label
            // 
            this.BoatTypeId_label.AutoSize = true;
            this.BoatTypeId_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatTypeId_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatTypeId_label.Location = new System.Drawing.Point(408, 361);
            this.BoatTypeId_label.Name = "BoatTypeId_label";
            this.BoatTypeId_label.Size = new System.Drawing.Size(36, 23);
            this.BoatTypeId_label.TabIndex = 108;
            this.BoatTypeId_label.Text = "Id :";
            // 
            // idBoat
            // 
            this.idBoat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idBoat.Enabled = false;
            this.idBoat.FormattingEnabled = true;
            this.idBoat.Location = new System.Drawing.Point(450, 361);
            this.idBoat.Name = "idBoat";
            this.idBoat.Size = new System.Drawing.Size(65, 23);
            this.idBoat.TabIndex = 109;
            this.idBoat.SelectedIndexChanged += new System.EventHandler(this.idBoat_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 112;
            this.pictureBox2.TabStop = false;
            // 
            // FormBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1454, 707);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.idBoat);
            this.Controls.Add(this.BoatTypeId_label);
            this.Controls.Add(this.lvFormBoat);
            this.Controls.Add(this.RefreshText);
            this.Controls.Add(this.UpdateBoat);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.DeleteBoat);
            this.Controls.Add(this.AddBoat);
            this.Controls.Add(this.RentedBoat);
            this.Controls.Add(this.PriceBoat);
            this.Controls.Add(this.TypeBoat);
            this.Controls.Add(this.DescriptionBoat);
            this.Controls.Add(this.SlotBoat);
            this.Controls.Add(this.LicenseBoat);
            this.Controls.Add(this.NameBoat);
            this.Controls.Add(this.BoatDescription_label);
            this.Controls.Add(this.Rented_label);
            this.Controls.Add(this.BoatPrice_label);
            this.Controls.Add(this.BoatType_label);
            this.Controls.Add(this.BoatSlot_label);
            this.Controls.Add(this.BoatLicense_label);
            this.Controls.Add(this.BoatName_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateCommand);
            this.Name = "FormBoat";
            this.Text = "Gestion des bateaux";
            this.Load += new System.EventHandler(this.FormBoat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CreateCommand;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label boatName;
        private System.Windows.Forms.Label idCommandPerson;
        private System.Windows.Forms.Label nameCommand;
        private System.Windows.Forms.TextBox NameBoat;
        private System.Windows.Forms.TextBox LicenseBoat;
        private System.Windows.Forms.TextBox SlotBoat;
        private System.Windows.Forms.TextBox DescriptionBoat;
        private System.Windows.Forms.ComboBox TypeBoat;
        private System.Windows.Forms.TextBox PriceBoat;
        private System.Windows.Forms.CheckBox RentedBoat;
        private System.Windows.Forms.Button AddBoat;
        private System.Windows.Forms.Button DeleteBoat;
        private System.Windows.Forms.Button Leave;
        private System.Windows.Forms.Button UpdateBoat;
        private System.Windows.Forms.Button RefreshText;
        private System.Windows.Forms.ListView lvFormBoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idBoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BoatDescription_label;
        private System.Windows.Forms.Label Rented_label;
        private System.Windows.Forms.Label BoatPrice_label;
        private System.Windows.Forms.Label BoatType_label;
        private System.Windows.Forms.Label BoatSlot_label;
        private System.Windows.Forms.Label BoatLicense_label;
        private System.Windows.Forms.Label BoatName_label;
        private System.Windows.Forms.Label BoatTypeId_label;
    }
}