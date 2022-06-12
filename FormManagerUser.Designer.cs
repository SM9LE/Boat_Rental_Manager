
namespace Boat_Rental
{
    partial class FormManagerUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerUser));
            this.button_AddCommand = new System.Windows.Forms.Button();
            this.button_AddConsumer = new System.Windows.Forms.Button();
            this.button_CommandList = new System.Windows.Forms.Button();
            this.button_CustomerList = new System.Windows.Forms.Button();
            this.button_BoatStock = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddCommand
            // 
            this.button_AddCommand.Location = new System.Drawing.Point(152, 343);
            this.button_AddCommand.Name = "button_AddCommand";
            this.button_AddCommand.Size = new System.Drawing.Size(248, 31);
            this.button_AddCommand.TabIndex = 62;
            this.button_AddCommand.Text = "Gérer les commandes";
            this.button_AddCommand.UseVisualStyleBackColor = true;
            // 
            // button_AddConsumer
            // 
            this.button_AddConsumer.Location = new System.Drawing.Point(152, 280);
            this.button_AddConsumer.Name = "button_AddConsumer";
            this.button_AddConsumer.Size = new System.Drawing.Size(248, 31);
            this.button_AddConsumer.TabIndex = 61;
            this.button_AddConsumer.Text = "Gérer les clients";
            this.button_AddConsumer.UseVisualStyleBackColor = true;
            // 
            // button_CommandList
            // 
            this.button_CommandList.Location = new System.Drawing.Point(688, 321);
            this.button_CommandList.Name = "button_CommandList";
            this.button_CommandList.Size = new System.Drawing.Size(248, 31);
            this.button_CommandList.TabIndex = 60;
            this.button_CommandList.Text = "Liste des commandes";
            this.button_CommandList.UseVisualStyleBackColor = true;
            // 
            // button_CustomerList
            // 
            this.button_CustomerList.Location = new System.Drawing.Point(688, 257);
            this.button_CustomerList.Name = "button_CustomerList";
            this.button_CustomerList.Size = new System.Drawing.Size(248, 31);
            this.button_CustomerList.TabIndex = 59;
            this.button_CustomerList.Text = "Liste des clients";
            this.button_CustomerList.UseVisualStyleBackColor = true;
            // 
            // button_BoatStock
            // 
            this.button_BoatStock.Location = new System.Drawing.Point(152, 216);
            this.button_BoatStock.Name = "button_BoatStock";
            this.button_BoatStock.Size = new System.Drawing.Size(248, 31);
            this.button_BoatStock.TabIndex = 58;
            this.button_BoatStock.Text = "Gérer le stock de bateaux";
            this.button_BoatStock.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(728, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Relation client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(89, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 32);
            this.label4.TabIndex = 54;
            this.label4.Text = "Création / Suppression / Modification";
            // 
            // FormManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1092, 577);
            this.Controls.Add(this.button_AddCommand);
            this.Controls.Add(this.button_AddConsumer);
            this.Controls.Add(this.button_CommandList);
            this.Controls.Add(this.button_CustomerList);
            this.Controls.Add(this.button_BoatStock);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "FormManagerUser";
            this.Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddCommand;
        private System.Windows.Forms.Button button_AddConsumer;
        private System.Windows.Forms.Button button_CommandList;
        private System.Windows.Forms.Button button_CustomerList;
        private System.Windows.Forms.Button button_BoatStock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}