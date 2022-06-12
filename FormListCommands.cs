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
    public partial class FormListCommands : Form
    {
        CommandManager commandManager;
        public FormListCommands()
        {
            InitializeComponent();
            commandManager = new CommandManager();
        }

        // Fonction permettant de charger le tableau

        private void Refresh(List<Command> list)
        {
            lvListCommands.Columns.Clear();
            // Ajout des colonnes
            lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_id", Text = "Identifiant Commande", Width = 200 });
            lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_DateEnd", Text = "Date et heure de début", Width = 150 });
            lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_DateEnd", Text = "Date et heure de fin", Width = 150 });
            lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_HasPaiedDeposit", Text = "Caution", Width = 200 });
            lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_MontantTotal", Text = "Montant Total", Width = 150 });
            lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_Name_Customer", Text = "Nom du client", Width = 150 });
            lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_Name_Boat", Text = "Nom du bateau", Width = 150 });

            lvListCommands.Items.Clear();

            foreach (Command command in list)
            {
                // Création de l'élément à ajouter au ListView
                ListViewItem lvi = new ListViewItem(new string[] {
                    command.IdCommand.ToString(),
                    command.DateStartCommand.ToString(),
                    command.DateEndCommand.ToString(),
                    command.HasPaiedDepositCommand ? "Caution payé" : "Caution non payé",
                    command.IdBoatNavigation.PriceBoat*1.2 + "€",
                    command.IdCustomerNavigation.FirstNameCustomer + " " + command.IdCustomerNavigation.LastNameCustomer,
                    command.IdBoatNavigation.NameBoat.ToString() });
                lvi.Tag = command;
                lvListCommands.Items.Add(lvi);
            }
        }

        // Chargement de la listview au lancement de la page
        private void FormListCommands_Load(object sender, EventArgs e)
        {
            Refresh(commandManager.ListCommands());
        }

        // Bouton permettant de quitter la page

        private void button_Leave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_command_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchButton_command.Text))
            {
                Refresh(commandManager.ListCommands());
                return;
            }
            // Utilisation de la nouvelle liste
            Refresh(commandManager.FindACommandByCustomerName(searchBar_commands.Text));
        }

        private void search_top1_Click(object sender, EventArgs e)
        {
            Refresh(commandManager.top1());
        }
    }
}
