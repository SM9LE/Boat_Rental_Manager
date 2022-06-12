
namespace Boat_Rental
{
    partial class FormBoatType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoatType));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BoatTypeName_label = new System.Windows.Forms.Label();
            this.NameBoatType = new System.Windows.Forms.TextBox();
            this.CreateCommand = new System.Windows.Forms.Label();
            this.RefreshText = new System.Windows.Forms.Button();
            this.UpdateBoatType = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.Button();
            this.AddBoatType = new System.Windows.Forms.Button();
            this.lvFormBoatType = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // BoatTypeName_label
            // 
            this.BoatTypeName_label.AutoSize = true;
            this.BoatTypeName_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatTypeName_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatTypeName_label.Location = new System.Drawing.Point(12, 166);
            this.BoatTypeName_label.Name = "BoatTypeName_label";
            this.BoatTypeName_label.Size = new System.Drawing.Size(195, 23);
            this.BoatTypeName_label.TabIndex = 85;
            this.BoatTypeName_label.Text = "Nom du type de bateau :";
            // 
            // NameBoatType
            // 
            this.NameBoatType.Location = new System.Drawing.Point(233, 166);
            this.NameBoatType.Name = "NameBoatType";
            this.NameBoatType.PlaceholderText = "Kayaks";
            this.NameBoatType.Size = new System.Drawing.Size(145, 23);
            this.NameBoatType.TabIndex = 94;
            this.NameBoatType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateCommand
            // 
            this.CreateCommand.AutoSize = true;
            this.CreateCommand.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateCommand.Location = new System.Drawing.Point(138, 76);
            this.CreateCommand.Name = "CreateCommand";
            this.CreateCommand.Size = new System.Drawing.Size(257, 32);
            this.CreateCommand.TabIndex = 93;
            this.CreateCommand.Text = "Créer un type de bateau";
            // 
            // RefreshText
            // 
            this.RefreshText.Location = new System.Drawing.Point(166, 352);
            this.RefreshText.Name = "RefreshText";
            this.RefreshText.Size = new System.Drawing.Size(169, 41);
            this.RefreshText.TabIndex = 111;
            this.RefreshText.Text = "Réinitialiser";
            this.RefreshText.UseVisualStyleBackColor = true;
            // 
            // UpdateBoatType
            // 
            this.UpdateBoatType.Location = new System.Drawing.Point(272, 279);
            this.UpdateBoatType.Name = "UpdateBoatType";
            this.UpdateBoatType.Size = new System.Drawing.Size(169, 41);
            this.UpdateBoatType.TabIndex = 110;
            this.UpdateBoatType.Text = "Modifier un type de bateau";
            this.UpdateBoatType.UseVisualStyleBackColor = true;
            this.UpdateBoatType.Click += new System.EventHandler(this.UpdateBoatType_Click);
            // 
            // Leave
            // 
            this.Leave.Location = new System.Drawing.Point(434, 478);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(258, 42);
            this.Leave.TabIndex = 109;
            this.Leave.Text = "Quitter";
            this.Leave.UseVisualStyleBackColor = true;
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // AddBoatType
            // 
            this.AddBoatType.Location = new System.Drawing.Point(66, 279);
            this.AddBoatType.Name = "AddBoatType";
            this.AddBoatType.Size = new System.Drawing.Size(169, 41);
            this.AddBoatType.TabIndex = 107;
            this.AddBoatType.Text = "Ajouter un type de bateau ";
            this.AddBoatType.UseVisualStyleBackColor = true;
            this.AddBoatType.Click += new System.EventHandler(this.AddBoatType_Click);
            // 
            // lvFormBoatType
            // 
            this.lvFormBoatType.FullRowSelect = true;
            this.lvFormBoatType.GridLines = true;
            this.lvFormBoatType.HideSelection = false;
            this.lvFormBoatType.LabelWrap = false;
            this.lvFormBoatType.Location = new System.Drawing.Point(690, 130);
            this.lvFormBoatType.Name = "lvFormBoatType";
            this.lvFormBoatType.Size = new System.Drawing.Size(464, 263);
            this.lvFormBoatType.TabIndex = 113;
            this.lvFormBoatType.UseCompatibleStateImageBehavior = false;
            this.lvFormBoatType.View = System.Windows.Forms.View.Details;
            this.lvFormBoatType.DoubleClick += new System.EventHandler(this.lvFormBoatType_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(846, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 112;
            this.label1.Text = "Liste des bateaux";
            // 
            // FormBoatType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1229, 571);
            this.Controls.Add(this.lvFormBoatType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshText);
            this.Controls.Add(this.UpdateBoatType);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.AddBoatType);
            this.Controls.Add(this.NameBoatType);
            this.Controls.Add(this.CreateCommand);
            this.Controls.Add(this.BoatTypeName_label);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormBoatType";
            this.Text = "Gestion du type de bateau";
            this.Load += new System.EventHandler(this.FormBoatType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BoatTypeName_label;
        private System.Windows.Forms.TextBox NameBoatType;
        private System.Windows.Forms.Label CreateCommand;
        private System.Windows.Forms.Button RefreshText;
        private System.Windows.Forms.Button UpdateBoatType;
        private System.Windows.Forms.Button Leave;
        private System.Windows.Forms.Button AddBoatType;
        private System.Windows.Forms.ListView lvFormBoatType;
        private System.Windows.Forms.Label label1;
    }
}