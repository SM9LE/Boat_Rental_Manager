
namespace Boat_Rental
{
    partial class FormListBoats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListBoats));
            this.button_Leave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lvBoat = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar_boats = new System.Windows.Forms.TextBox();
            this.searchBar_label = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Leave
            // 
            this.button_Leave.Location = new System.Drawing.Point(487, 533);
            this.button_Leave.Name = "button_Leave";
            this.button_Leave.Size = new System.Drawing.Size(248, 31);
            this.button_Leave.TabIndex = 65;
            this.button_Leave.Text = "Quitter";
            this.button_Leave.UseVisualStyleBackColor = true;
            this.button_Leave.Click += new System.EventHandler(this.button_Leave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // lvBoat
            // 
            this.lvBoat.FullRowSelect = true;
            this.lvBoat.GridLines = true;
            this.lvBoat.HideSelection = false;
            this.lvBoat.Location = new System.Drawing.Point(13, 94);
            this.lvBoat.Name = "lvBoat";
            this.lvBoat.Size = new System.Drawing.Size(1181, 411);
            this.lvBoat.TabIndex = 68;
            this.lvBoat.UseCompatibleStateImageBehavior = false;
            this.lvBoat.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(515, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 69;
            this.label1.Text = "Liste des bateaux";
            // 
            // searchBar_boats
            // 
            this.searchBar_boats.Location = new System.Drawing.Point(917, 66);
            this.searchBar_boats.Name = "searchBar_boats";
            this.searchBar_boats.Size = new System.Drawing.Size(276, 23);
            this.searchBar_boats.TabIndex = 70;
            // 
            // searchBar_label
            // 
            this.searchBar_label.AutoSize = true;
            this.searchBar_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar_label.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBar_label.Location = new System.Drawing.Point(963, 38);
            this.searchBar_label.Name = "searchBar_label";
            this.searchBar_label.Size = new System.Drawing.Size(193, 23);
            this.searchBar_label.TabIndex = 73;
            this.searchBar_label.Text = "Rechercher par licence :";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(826, 66);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 74;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FormListBoats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1205, 576);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar_label);
            this.Controls.Add(this.searchBar_boats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBoat);
            this.Controls.Add(this.button_Leave);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormListBoats";
            this.Text = "Liste des bateaux";
            this.Load += new System.EventHandler(this.FormListBoats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Leave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView lvBoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar_boats;
        private System.Windows.Forms.Label searchBar_label;
        private System.Windows.Forms.Button searchButton;
    }
}