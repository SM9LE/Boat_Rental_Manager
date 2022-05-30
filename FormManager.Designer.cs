
namespace Boat_Rental
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_AdminAccount = new System.Windows.Forms.Button();
            this.button_BoatStock = new System.Windows.Forms.Button();
            this.button_CustomerList = new System.Windows.Forms.Button();
            this.button_CommandList = new System.Windows.Forms.Button();
            this.button_AddConsumer = new System.Windows.Forms.Button();
            this.button_AddCommand = new System.Windows.Forms.Button();
            this.button_Leave = new System.Windows.Forms.Button();
            this.boatLists = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(655, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Base de données administrateur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-123, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(144, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Gestionnaire de locations";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // button_AdminAccount
            // 
            this.button_AdminAccount.Location = new System.Drawing.Point(153, 193);
            this.button_AdminAccount.Name = "button_AdminAccount";
            this.button_AdminAccount.Size = new System.Drawing.Size(248, 31);
            this.button_AdminAccount.TabIndex = 47;
            this.button_AdminAccount.Text = "Gérer les comptes administrateurs";
            this.button_AdminAccount.UseVisualStyleBackColor = true;
            this.button_AdminAccount.Click += new System.EventHandler(this.button_AdminAccount_Click);
            // 
            // button_BoatStock
            // 
            this.button_BoatStock.Location = new System.Drawing.Point(153, 257);
            this.button_BoatStock.Name = "button_BoatStock";
            this.button_BoatStock.Size = new System.Drawing.Size(248, 31);
            this.button_BoatStock.TabIndex = 48;
            this.button_BoatStock.Text = "Gérer le stock de bateaux";
            this.button_BoatStock.UseVisualStyleBackColor = true;
            this.button_BoatStock.Click += new System.EventHandler(this.button_BoatStock_Click);
            // 
            // button_CustomerList
            // 
            this.button_CustomerList.Location = new System.Drawing.Point(705, 233);
            this.button_CustomerList.Name = "button_CustomerList";
            this.button_CustomerList.Size = new System.Drawing.Size(248, 31);
            this.button_CustomerList.TabIndex = 50;
            this.button_CustomerList.Text = "Liste des clients";
            this.button_CustomerList.UseVisualStyleBackColor = true;
            this.button_CustomerList.Click += new System.EventHandler(this.button_CustomerList_Click);
            // 
            // button_CommandList
            // 
            this.button_CommandList.Location = new System.Drawing.Point(705, 361);
            this.button_CommandList.Name = "button_CommandList";
            this.button_CommandList.Size = new System.Drawing.Size(248, 31);
            this.button_CommandList.TabIndex = 51;
            this.button_CommandList.Text = "Liste des commandes";
            this.button_CommandList.UseVisualStyleBackColor = true;
            this.button_CommandList.Click += new System.EventHandler(this.button_CommandList_Click);
            // 
            // button_AddConsumer
            // 
            this.button_AddConsumer.Location = new System.Drawing.Point(153, 321);
            this.button_AddConsumer.Name = "button_AddConsumer";
            this.button_AddConsumer.Size = new System.Drawing.Size(248, 31);
            this.button_AddConsumer.TabIndex = 52;
            this.button_AddConsumer.Text = "Gérer les clients";
            this.button_AddConsumer.UseVisualStyleBackColor = true;
            this.button_AddConsumer.Click += new System.EventHandler(this.button_AddConsumer_Click);
            // 
            // button_AddCommand
            // 
            this.button_AddCommand.Location = new System.Drawing.Point(153, 384);
            this.button_AddCommand.Name = "button_AddCommand";
            this.button_AddCommand.Size = new System.Drawing.Size(248, 31);
            this.button_AddCommand.TabIndex = 53;
            this.button_AddCommand.Text = "Gérer les commandes";
            this.button_AddCommand.UseVisualStyleBackColor = true;
            this.button_AddCommand.Click += new System.EventHandler(this.button_AddCommand_Click);
            // 
            // button_Leave
            // 
            this.button_Leave.Location = new System.Drawing.Point(416, 509);
            this.button_Leave.Name = "button_Leave";
            this.button_Leave.Size = new System.Drawing.Size(248, 31);
            this.button_Leave.TabIndex = 54;
            this.button_Leave.Text = "Quitter";
            this.button_Leave.UseVisualStyleBackColor = true;
            this.button_Leave.Click += new System.EventHandler(this.button_Leave_Click);
            // 
            // boatLists
            // 
            this.boatLists.Location = new System.Drawing.Point(705, 299);
            this.boatLists.Name = "boatLists";
            this.boatLists.Size = new System.Drawing.Size(248, 31);
            this.boatLists.TabIndex = 55;
            this.boatLists.Text = "Liste des bateaux";
            this.boatLists.UseVisualStyleBackColor = true;
            this.boatLists.Click += new System.EventHandler(this.boatLists_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1084, 579);
            this.Controls.Add(this.boatLists);
            this.Controls.Add(this.button_Leave);
            this.Controls.Add(this.button_AddCommand);
            this.Controls.Add(this.button_AddConsumer);
            this.Controls.Add(this.button_CommandList);
            this.Controls.Add(this.button_CustomerList);
            this.Controls.Add(this.button_BoatStock);
            this.Controls.Add(this.button_AdminAccount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Name = "FormManager";
            this.Text = "Menu principal super-administrateur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_AdminAccount;
        private System.Windows.Forms.Button button_BoatStock;
        private System.Windows.Forms.Button button_CustomerList;
        private System.Windows.Forms.Button button_CommandList;
        private System.Windows.Forms.Button button_AddConsumer;
        private System.Windows.Forms.Button button_AddCommand;
        private System.Windows.Forms.Button button_Leave;
        private System.Windows.Forms.Button boatLists;
    }
}