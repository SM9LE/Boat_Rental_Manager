
namespace Boat_Rental
{
    partial class FormMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.list_member = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(309, 275);
            this.confirmPassword.Multiline = true;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(127, 23);
            this.confirmPassword.TabIndex = 44;
            this.confirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(53, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Confirmer le mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(107, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(760, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "Liste des administrateurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(135, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Login";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(70, 346);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(173, 41);
            this.button_Add.TabIndex = 39;
            this.button_Add.Text = "Ajouter un administrateur";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(309, 219);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PlaceholderText = "Exemple : Pa$$w0rd";
            this.password.Size = new System.Drawing.Size(127, 23);
            this.password.TabIndex = 38;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(309, 152);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.PlaceholderText = "Exemple : Michel";
            this.login.Size = new System.Drawing.Size(127, 23);
            this.login.TabIndex = 37;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(146, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 32);
            this.label4.TabIndex = 36;
            this.label4.Text = "Création d\'administrateurs";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(70, 414);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(173, 41);
            this.button_Update.TabIndex = 45;
            this.button_Update.Text = "Modifier un administrateur";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(309, 346);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(173, 41);
            this.button_Delete.TabIndex = 46;
            this.button_Delete.Text = "Supprimer un administrateur";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(309, 414);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(173, 41);
            this.button_Reset.TabIndex = 47;
            this.button_Reset.Text = "Réinitialiser";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // list_member
            // 
            this.list_member.FullRowSelect = true;
            this.list_member.GridLines = true;
            this.list_member.HideSelection = false;
            this.list_member.Location = new System.Drawing.Point(647, 121);
            this.list_member.Name = "list_member";
            this.list_member.Size = new System.Drawing.Size(475, 344);
            this.list_member.TabIndex = 51;
            this.list_member.UseCompatibleStateImageBehavior = false;
            this.list_member.View = System.Windows.Forms.View.Details;
            this.list_member.DoubleClick += new System.EventHandler(this.list_member_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 33);
            this.button2.TabIndex = 52;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1134, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.list_member);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label4);
            this.Name = "FormMember";
            this.Text = "Gestion des administrateurs";
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView list_member;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Leave;
        private System.Windows.Forms.Button button2;
    }
}