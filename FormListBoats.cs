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
    public partial class FormListBoats : Form
    {
        public bool customerList = false;
        BoatManager boatManager;
        private Boat boat;
        public FormListBoats()
        {
            boatManager = new BoatManager();
            boatManager.InitializeTimer();
            InitializeComponent();
        }

        private void Refresh(List<Boat> list)
        {
            lvBoat.Columns.Clear();
            // Ajout des colonnes
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_id", Text = "Id", Width = 100 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_name", Text = "Nom", Width = 120 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_license", Text = "License", Width = 100 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_slot", Text = "Places", Width = 90 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_description", Text = "Description", Width = 460 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_isRented", Text = "Loue", Width = 120 });
            lvBoat.Columns.Add(new ColumnHeader() { Name = "boat_type", Text = "Type", Width = 150 });

            lvBoat.Items.Clear();

            foreach (Boat boat in list)
            {
                // Création de l'élément à ajouter au ListView
                ListViewItem lvi = new ListViewItem(new string[] {
                    boat.IdBoat.ToString(),
                    boat.NameBoat.ToString(),
                    boat.LicenseBoat.ToString(),
                    boat.SlotBoat.ToString() + " places",
                    boat.DescriptionBoat.ToString(),
                    boat.IsRentedBoat ? "Non disponible" : "Disponible",
                    boat.IdBoatTypeNavigation.TypeBoatType });
                lvi.Tag = boat;
                lvBoat.Items.Add(lvi);
            }
        }

        // Recharge le formulaire INITIAL au chargement de la page
        
        private void FormListBoats_Load(object sender, EventArgs e)
        {
            Refresh(boatManager.ListBoat());
        }
        private void button_Leave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBar_boats.Text))
            {
                Refresh(boatManager.ListBoat());
                return;
            }

            // Utilisation de la nouvelle liste

            Refresh(boatManager.FindBoatStartByLicense(searchBar_boats.Text));

        }
    }
}
