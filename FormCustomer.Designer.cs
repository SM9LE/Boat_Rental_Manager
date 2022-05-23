
namespace Boat_Rental
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerList = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mailAdress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boatLicense = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hasRented = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.licenseChecked = new System.Windows.Forms.CheckBox();
            this.rentChecked = new System.Windows.Forms.CheckBox();
            this.date_naissance = new System.Windows.Forms.DateTimePicker();
            this.list_customer = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Login",
            "Password",
            "Id"});
            this.comboBox1.Location = new System.Drawing.Point(734, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 23);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.ItemHeight = 15;
            this.customerList.Location = new System.Drawing.Point(734, 126);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(242, 349);
            this.customerList.TabIndex = 64;
            this.customerList.SelectedIndexChanged += new System.EventHandler(this.customerList_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-147, -39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(264, 470);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(173, 41);
            this.button_Reset.TabIndex = 62;
            this.button_Reset.Text = "Réinitialiser";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(25, 470);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(173, 41);
            this.button_Delete.TabIndex = 61;
            this.button_Delete.Text = "Supprimer un client";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(264, 402);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(173, 41);
            this.button_Update.TabIndex = 60;
            this.button_Update.Text = "Modifier un client";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(38, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Date anniversaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(42, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nom de famille";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(757, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 56;
            this.label1.Text = "Liste des clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(72, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Prénom";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(25, 402);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(173, 41);
            this.button_Add.TabIndex = 54;
            this.button_Add.Text = "Ajouter un client";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(187, 147);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "Musk";
            this.lastName.Size = new System.Drawing.Size(218, 23);
            this.lastName.TabIndex = 53;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(187, 100);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "Elon";
            this.firstName.Size = new System.Drawing.Size(218, 23);
            this.firstName.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(122, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 32);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ajouter un client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(53, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "Adresse mail";
            // 
            // mailAdress
            // 
            this.mailAdress.Location = new System.Drawing.Point(187, 233);
            this.mailAdress.Multiline = true;
            this.mailAdress.Name = "mailAdress";
            this.mailAdress.PlaceholderText = "elon.musk@tesla.com";
            this.mailAdress.Size = new System.Drawing.Size(218, 23);
            this.mailAdress.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(47, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 70;
            this.label8.Text = "Permis Bateau";
            // 
            // boatLicense
            // 
            this.boatLicense.Location = new System.Drawing.Point(187, 310);
            this.boatLicense.Multiline = true;
            this.boatLicense.Name = "boatLicense";
            this.boatLicense.PlaceholderText = "Oui";
            this.boatLicense.Size = new System.Drawing.Size(218, 23);
            this.boatLicense.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(37, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "Location en cours";
            // 
            // hasRented
            // 
            this.hasRented.Location = new System.Drawing.Point(187, 350);
            this.hasRented.Multiline = true;
            this.hasRented.Name = "hasRented";
            this.hasRented.PlaceholderText = "Non";
            this.hasRented.Size = new System.Drawing.Size(218, 23);
            this.hasRented.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // licenseChecked
            // 
            this.licenseChecked.AutoSize = true;
            this.licenseChecked.Location = new System.Drawing.Point(422, 317);
            this.licenseChecked.Name = "licenseChecked";
            this.licenseChecked.Size = new System.Drawing.Size(15, 14);
            this.licenseChecked.TabIndex = 75;
            this.licenseChecked.UseVisualStyleBackColor = true;
            // 
            // rentChecked
            // 
            this.rentChecked.AutoSize = true;
            this.rentChecked.Location = new System.Drawing.Point(434, 354);
            this.rentChecked.Name = "rentChecked";
            this.rentChecked.Size = new System.Drawing.Size(15, 14);
            this.rentChecked.TabIndex = 76;
            this.rentChecked.UseVisualStyleBackColor = true;
            // 
            // date_naissance
            // 
            this.date_naissance.CustomFormat = "dd-MM-yyyy";
            this.date_naissance.ImeMode = System.Windows.Forms.ImeMode.On;
            this.date_naissance.Location = new System.Drawing.Point(187, 190);
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_naissance.Size = new System.Drawing.Size(218, 23);
            this.date_naissance.TabIndex = 77;
            this.date_naissance.Value = new System.DateTime(2022, 5, 22, 0, 0, 0, 0);
            // 
            // list_customer
            // 
            this.list_customer.FullRowSelect = true;
            this.list_customer.GridLines = true;
            this.list_customer.HideSelection = false;
            this.list_customer.Location = new System.Drawing.Point(204, 392);
            this.list_customer.Name = "list_customer";
            this.list_customer.Size = new System.Drawing.Size(546, 368);
            this.list_customer.TabIndex = 78;
            this.list_customer.UseCompatibleStateImageBehavior = false;
            this.list_customer.View = System.Windows.Forms.View.Details;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1055, 549);
            this.Controls.Add(this.list_customer);
            this.Controls.Add(this.date_naissance);
            this.Controls.Add(this.rentChecked);
            this.Controls.Add(this.licenseChecked);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hasRented);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boatLicense);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mailAdress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label4);
            this.Name = "FormCustomer";
            this.Text = "Gestionnaire de clients";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox memberList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mailAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boatLicense;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hasRented;
        private System.Windows.Forms.ListBox customerList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox licenseChecked;
        private System.Windows.Forms.CheckBox rentChecked;
        private System.Windows.Forms.DateTimePicker date_naissance;
        private System.Windows.Forms.ListView list_customer;
    }
}