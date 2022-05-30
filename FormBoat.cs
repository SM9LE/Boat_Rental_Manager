using Boat_Rental.Manager;
using Boat_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Boat_Rental
{
    public partial class FormBoat : Form
    {
        private Boat boat;
        BoatManager BoatManager;

        public FormBoat()
        {
            InitializeComponent();
            BoatManager = new BoatManager();
        }

        // Classe permettant de rafraichir la listview à chaque requête

        private void Refresh()
        {
            lvFormBoat.Columns.Clear();
            // Ajout des colonnes
            lvFormBoat.Columns.Add(new ColumnHeader() { Name = "boat_id", Text = "Id", Width = 30 });
            lvFormBoat.Columns.Add(new ColumnHeader() { Name = "boat_name", Text = "Nom", Width = 120 });
            lvFormBoat.Columns.Add(new ColumnHeader() { Name = "boat_license", Text = "License", Width = 100 });
            lvFormBoat.Columns.Add(new ColumnHeader() { Name = "boat_slot", Text = "Slot", Width = 40 });
            lvFormBoat.Columns.Add(new ColumnHeader() { Name = "boat_description", Text = "Description", Width = 190 });
            lvFormBoat.Columns.Add(new ColumnHeader() { Name = "boat_price", Text = "Prix HT", Width = 100 });
            lvFormBoat.Columns.Add(new ColumnHeader() { Name = "boat_isRented", Text = "Loue", Width = 90 });
            lvFormBoat.Columns.Add(new ColumnHeader() { Name = "boat_type", Text = "Type", Width = 160 });

            lvFormBoat.Items.Clear();

            foreach (Boat boat in BoatManager.ListBoat())
            {
                // Création de l'élément à ajouter au ListView
                ListViewItem lvi = new ListViewItem(new string[] {
                    boat.IdBoat.ToString(),
                    boat.NameBoat.ToString(),
                    boat.LicenseBoat.ToString(),
                    boat.SlotBoat.ToString(),
                    boat.DescriptionBoat.ToString(),
                    boat.PriceBoat.ToString(),
                    boat.IsRentedBoat ? "Non disponible" : "Disponible",
                    boat.IdBoatTypeNavigation.TypeBoatType });
                lvi.Tag = boat;
                lvFormBoat.Items.Add(lvi);
            }
            NameBoat.Text = "";
            LicenseBoat.Text = "";
            SlotBoat.Text = "";
            PriceBoat.Text = "";
            DescriptionBoat.Text = "";
            RentedBoat.Checked = false;
            idBoat.Text = "";    
        }

        // Sélection d'un bateau dans la combobox dont l'id est égal au nom

        private void TypeBoat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeBoat.SelectedIndex < 0)
                return;
            if (idBoat.SelectedIndex < 0)
                return;
            idBoat.SelectedIndex = TypeBoat.SelectedIndex;
        }

        // Sélection d'un id de bateau dans la combobox dont le nom est égal à l'id

        private void idBoat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idBoat.SelectedIndex < 0)
                return;
            TypeBoat.SelectedIndex = idBoat.SelectedIndex;
        }

        // Chargement de la listview

        private void FormBoat_Load(object sender, EventArgs e)
        {
            // Récupération du nom pour la combobox
            TypeBoat.DataSource = BoatManager.ListBoat().Select(x => x.IdBoatTypeNavigation.TypeBoatType).Distinct().ToList();
            idBoat.DataSource = BoatManager.ListBoat().Select(x => x.IdBoatTypeNavigation.IdBoatType).Distinct().ToList();
            Refresh();
        }

        // Evènement double clique permettant de remplir toutes les cases

        private void lvFormBoat_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvFormBoat.SelectedItems;
            if (selected.Count == 1)
            {
                boat = selected[0].Tag as Boat;

                NameBoat.Text = boat.NameBoat;
                LicenseBoat.Text = boat.LicenseBoat;
                SlotBoat.Text = boat.SlotBoat.ToString();
                DescriptionBoat.Text = boat.DescriptionBoat;
                PriceBoat.Text = boat.PriceBoat.ToString();
                idBoat.Text = boat.IdBoatType.ToString();
                RentedBoat.Checked = boat.IsRentedBoat;
            }
        }

        // Ajout  d'un bateau 

        private void AddBoat_Click(object sender, EventArgs e)
        {
            Boat verify = BoatManager.FindABoatByLicense(LicenseBoat.Text);
            if (verify == null)
            {
                Boat boat = new Boat(NameBoat.Text.ToString(), LicenseBoat.Text, Convert.ToInt32(SlotBoat.Text), DescriptionBoat.Text.ToString(), Convert.ToDouble(PriceBoat.Text), RentedBoat.Checked, Convert.ToInt32(idBoat.SelectedValue));
                BoatManager.AddABoat(boat);
                MessageBox.Show("Bateau ajouté");
                Refresh();
            }
            // ajout de Regex tels que "nameboat" = Lettres seulement et SlotBoat = chiffre uniquement
            else if (NameBoat.Text == null || LicenseBoat.Text is null || DescriptionBoat.Text is null || PriceBoat is null)
            {
                MessageBox.Show("Erreur lors de l'ajout du bateau, vérifiez les champs.");
            }
            else if (Regex.IsMatch(LicenseBoat.Text, "[0-9]"))  
            {
                MessageBox.Show("Erreur lors de l'ajout du bateau, mettez au moins 1 chiffre dans la plaque");

            }
            else if (Regex.IsMatch(SlotBoat.Text, "[0-9]"))
            {
                MessageBox.Show("Erreur lors de l'ajout du bateau, mettez au moins 1 chiffre dans la plaque");

            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du bateau, sa plaque est déjà prise.");
            }
        }

        // Suppression d'un bateau

        private void DeleteBoat_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvFormBoat.SelectedItems;
            if (selected.Count == 1)
            {
                boat = selected[0].Tag as Boat;
                BoatManager.DeleteABoat(boat);
                MessageBox.Show("Bateau supprimé");
                Refresh();
            }
            else
            {
                MessageBox.Show("Impossible de supprimer un bateau");
            }
        }

        // Modification d'un bateau

        private void UpdateBoat_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvFormBoat.SelectedItems;
            if (selected.Count == 1)
            {
                if (boat.NameBoat != NameBoat.Text)
                {
                    MessageBox.Show("Vous ne pouvez pas changer le nom du bateau");
                }
                else if (boat.SlotBoat.ToString() != SlotBoat.Text)
                {
                    MessageBox.Show("Les places sur le bateau ne peuvent pas être différentes.");
                }
                else if (boat.IdBoatTypeNavigation.IdBoatType != Convert.ToInt32(idBoat.Text))
                {
                    MessageBox.Show("Vous ne pouvez pas changer le type de ce bateau.");
                }
                else
                {
                    boat.LicenseBoat = LicenseBoat.Text;
                    boat.DescriptionBoat = DescriptionBoat.Text;
                    boat.PriceBoat = Convert.ToDouble(PriceBoat.Text);
                    boat.IsRentedBoat = RentedBoat.Checked;
                    BoatManager.EditABoat(boat);
                    MessageBox.Show("Bateau modifié !");
                }
                Refresh();
            }
        }

        // Bouton rafraichir les textbox

        private void RefreshText_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        //  Bouton Quitter

        private void Leave_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
