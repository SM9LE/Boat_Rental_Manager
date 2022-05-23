using Boat_Rental.Manager;
using Boat_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Boat_Rental
{
    public partial class FormBoat : Form
    {
        public bool customerList = false;
        BoatManager boatManager;
        private Boat boat;
        public FormBoat()
        {
            boatManager = new BoatManager();
            boatManager.InitializeTimer();
            InitializeComponent();
        }

        private void FormBoat_Load(object sender, EventArgs e)
        {
            lvBoat.Columns.Clear();
            // Ajout des colonnes
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_id", Text = "Id", Width = 30 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_name", Text = "Nom", Width = 120 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_license", Text = "License", Width = 100 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_slot", Text = "Slot", Width = 80 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_description", Text = "Description", Width = 120 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_isRented", Text = "Loue", Width = 120 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_isEmptyFuel", Text = "Plein", Width = 120 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_type", Text = "Type", Width = 120 });

            lvBoat.Items.Clear();

            foreach (Boat boat in boatManager.ListBoat())
            {
                // Création de l'élément à ajouter au ListView
                ListViewItem lvi = new ListViewItem(new string[] { 
                    boat.IdBoat.ToString(), 
                    boat.NameBoat.ToString(), 
                    boat.DescriptionBoat.ToString(), 
                    boat.SlotBoat.ToString(), 
                    boat.DescriptionBoat.ToString(), 
                    boat.IsRentedBoat ? "Non disponible" : "Disponible", 
                    boat.IsEmptyFuelBoat.ToString(), 
                    boat.IdBoatType.ToString() });
                lvi.Tag = boat;
                lvBoat.Items.Add(lvi);
            }
        }

        private void lvBoat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Leave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
