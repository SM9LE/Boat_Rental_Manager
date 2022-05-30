
namespace Boat_Rental
{
    partial class FormListCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListCustomers));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lvListCustomers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Leave = new System.Windows.Forms.Button();
            this.searchBar_customer = new System.Windows.Forms.TextBox();
            this.searchButton_customers = new System.Windows.Forms.Button();
            this.searchBar_laabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // lvListCustomers
            // 
            this.lvListCustomers.FullRowSelect = true;
            this.lvListCustomers.GridLines = true;
            this.lvListCustomers.HideSelection = false;
            this.lvListCustomers.Location = new System.Drawing.Point(7, 92);
            this.lvListCustomers.Name = "lvListCustomers";
            this.lvListCustomers.Size = new System.Drawing.Size(1187, 411);
            this.lvListCustomers.TabIndex = 69;
            this.lvListCustomers.UseCompatibleStateImageBehavior = false;
            this.lvListCustomers.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(521, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "Liste des clients";
            // 
            // button_Leave
            // 
            this.button_Leave.Location = new System.Drawing.Point(470, 532);
            this.button_Leave.Name = "button_Leave";
            this.button_Leave.Size = new System.Drawing.Size(248, 31);
            this.button_Leave.TabIndex = 80;
            this.button_Leave.Text = "Quitter";
            this.button_Leave.UseVisualStyleBackColor = true;
            this.button_Leave.Click += new System.EventHandler(this.button_Leave_Click);
            // 
            // searchBar_customer
            // 
            this.searchBar_customer.Location = new System.Drawing.Point(919, 59);
            this.searchBar_customer.Name = "searchBar_customer";
            this.searchBar_customer.Size = new System.Drawing.Size(274, 23);
            this.searchBar_customer.TabIndex = 83;
            // 
            // searchButton_customers
            // 
            this.searchButton_customers.Location = new System.Drawing.Point(820, 58);
            this.searchButton_customers.Name = "searchButton_customers";
            this.searchButton_customers.Size = new System.Drawing.Size(80, 23);
            this.searchButton_customers.TabIndex = 82;
            this.searchButton_customers.Text = "Rechercher";
            this.searchButton_customers.UseVisualStyleBackColor = true;
            this.searchButton_customers.Click += new System.EventHandler(this.searchButton_customers_Click);
            // 
            // searchBar_laabel
            // 
            this.searchBar_laabel.AutoSize = true;
            this.searchBar_laabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar_laabel.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBar_laabel.Location = new System.Drawing.Point(961, 30);
            this.searchBar_laabel.Name = "searchBar_laabel";
            this.searchBar_laabel.Size = new System.Drawing.Size(183, 23);
            this.searchBar_laabel.TabIndex = 81;
            this.searchBar_laabel.Text = "Rechercher par client :";
            // 
            // FormListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1206, 575);
            this.Controls.Add(this.searchBar_customer);
            this.Controls.Add(this.searchButton_customers);
            this.Controls.Add(this.searchBar_laabel);
            this.Controls.Add(this.button_Leave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvListCustomers);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormListCustomers";
            this.Text = "Liste des clients";
            this.Load += new System.EventHandler(this.FormListCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView lvListCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Leave;
        private System.Windows.Forms.TextBox searchBar_customer;
        private System.Windows.Forms.Button searchButton_customers;
        private System.Windows.Forms.Label searchBar_laabel;
    }
}