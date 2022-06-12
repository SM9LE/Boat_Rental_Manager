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
    public partial class FormBoatType : Form
    {
        private Boattype boattype;
        BoatTypeManager BoattypeManager;

        public FormBoatType()
        {
            InitializeComponent();
            BoattypeManager = new BoatTypeManager();
        }

        // Fonction permettant de rafraichir la listview quand on effectue un ajout, une suppression ou une modification

        private void Refresh()
        {
            lvFormBoatType.Columns.Clear();
            // Ajout des colonnes
            lvFormBoatType.Columns.Add(new ColumnHeader() { Name = "boattype_id", Text = "Id", Width = 100 });
            lvFormBoatType.Columns.Add(new ColumnHeader() { Name = "boattype_name", Text = "Nom", Width = 120 });

            lvFormBoatType.Items.Clear();

            foreach (Boattype boattype in BoattypeManager.ListBoattype())
            {
                // Création de l'élément à ajouter au ListView
                ListViewItem lvi = new ListViewItem(new string[] {
                    boattype.IdBoatType.ToString(),
                    boattype.TypeBoatType.ToString()});
                lvi.Tag = boattype;
                lvFormBoatType.Items.Add(lvi);
            }
            NameBoatType.Text = "";
        }

        // Fonction autorisant le double click

        private void lvFormBoatType_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvFormBoatType.SelectedItems;
            if (selected.Count == 1)
            {
                boattype = selected[0].Tag as Boattype;

                NameBoatType.Text = boattype.TypeBoatType;
            }
        }

        // Chargement de la listview au démarrage de la page

        private void FormBoatType_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        // Fonction permettant l'ajout d'un nouveau type de bateau

        private void AddBoatType_Click(object sender, EventArgs e)
        {
            Boattype verify = BoattypeManager.FindABoatTypeByType(NameBoatType.Text);

            if (verify != null)
            {
                MessageBox.Show("Erreur lors de l'ajout, ce type de bateau existe déjà");
            }
            else
            {
                Boattype boattype = new Boattype(NameBoatType.Text);
                BoattypeManager.AddABoatType(boattype);
                MessageBox.Show("Type de bateau ajouté");
                Refresh();
            }
        }

        // Fonction permettant de modifier un type de bateau (son nom)

        private void UpdateBoatType_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvFormBoatType.SelectedItems;
            if (selected.Count == 1)
            {
                boattype.TypeBoatType = NameBoatType.Text;
                BoattypeManager.EditABoatType(boattype);
                MessageBox.Show("Type de bateau modifié !");
            }
            Refresh();
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
