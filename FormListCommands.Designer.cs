
namespace Boat_Rental
{
    partial class FormListCommands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListCommands));
            this.label1 = new System.Windows.Forms.Label();
            this.lvListCommands = new System.Windows.Forms.ListView();
            this.button_Leave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBar_label = new System.Windows.Forms.Label();
            this.searchButton_command = new System.Windows.Forms.Button();
            this.searchBar_commands = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(495, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 73;
            this.label1.Text = "Liste des commandes";
            // 
            // lvListCommands
            // 
            this.lvListCommands.FullRowSelect = true;
            this.lvListCommands.GridLines = true;
            this.lvListCommands.HideSelection = false;
            this.lvListCommands.Location = new System.Drawing.Point(13, 93);
            this.lvListCommands.Name = "lvListCommands";
            this.lvListCommands.Size = new System.Drawing.Size(1181, 411);
            this.lvListCommands.TabIndex = 72;
            this.lvListCommands.UseCompatibleStateImageBehavior = false;
            this.lvListCommands.View = System.Windows.Forms.View.Details;
            // 
            // button_Leave
            // 
            this.button_Leave.Location = new System.Drawing.Point(487, 533);
            this.button_Leave.Name = "button_Leave";
            this.button_Leave.Size = new System.Drawing.Size(248, 31);
            this.button_Leave.TabIndex = 71;
            this.button_Leave.Text = "Quitter";
            this.button_Leave.UseVisualStyleBackColor = true;
            this.button_Leave.Click += new System.EventHandler(this.button_Leave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-200, -63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // searchBar_label
            // 
            this.searchBar_label.AutoSize = true;
            this.searchBar_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar_label.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBar_label.Location = new System.Drawing.Point(962, 36);
            this.searchBar_label.Name = "searchBar_label";
            this.searchBar_label.Size = new System.Drawing.Size(183, 23);
            this.searchBar_label.TabIndex = 75;
            this.searchBar_label.Text = "Rechercher par client :";
            // 
            // searchButton_command
            // 
            this.searchButton_command.Location = new System.Drawing.Point(821, 64);
            this.searchButton_command.Name = "searchButton_command";
            this.searchButton_command.Size = new System.Drawing.Size(80, 23);
            this.searchButton_command.TabIndex = 76;
            this.searchButton_command.Text = "Rechercher";
            this.searchButton_command.UseVisualStyleBackColor = true;
            this.searchButton_command.Click += new System.EventHandler(this.searchButton_command_Click);
            // 
            // searchBar_commands
            // 
            this.searchBar_commands.Location = new System.Drawing.Point(920, 65);
            this.searchBar_commands.Name = "searchBar_commands";
            this.searchBar_commands.Size = new System.Drawing.Size(274, 23);
            this.searchBar_commands.TabIndex = 77;
            // 
            // FormListCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1206, 575);
            this.Controls.Add(this.searchBar_commands);
            this.Controls.Add(this.searchButton_command);
            this.Controls.Add(this.searchBar_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvListCommands);
            this.Controls.Add(this.button_Leave);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormListCommands";
            this.Text = "Liste des commandes";
            this.Load += new System.EventHandler(this.FormListCommands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvListCommands;
        private System.Windows.Forms.Button button_Leave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label searchBar_label;
        private System.Windows.Forms.Button searchButton_command;
        private System.Windows.Forms.TextBox searchBar_commands;
    }
}