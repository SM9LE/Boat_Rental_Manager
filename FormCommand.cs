using Boat_Rental.Manager;
using Boat_Rental.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Boat_Rental
{
    public partial class FormCommand : Form
    {
        CommandManager commandManager;

        CustomerManager CustomerManager = new CustomerManager();
        private Command command;
        BoatManager BoatManager = new BoatManager();
        DateTime now;

        public FormCommand()
        {
            commandManager = new CommandManager();
            InitializeComponent();
            // Formatage des deux date time picker
            dateDeb.CustomFormat = "dd-MM-yyyy tt H:mm:ss";
            dateFin.CustomFormat = "dd-MM-yyyy tt H:mm:ss";
            now = DateTime.Now;
        }

        // Fonction Refresh() permettant de rafraîchir la listview

        private void Refresh()
        {
            lvCommand.Columns.Clear();
            // Ajout des colonnes
            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_id", Text = "Identifiant Commande", Width = 90 });
            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_DateStart", Text = "Date et heure de début", Width = 120 });
            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_DateEnd", Text = "Date et heure de fin", Width = 120 });
            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_HasPaiedDeposit", Text = "Caution", Width = 90 });

    /*      Ajout deux colonnes : Commande sur plusieurs jours donc prix évolutif & nombre de jours total de la commande
            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_MontantTotal", Text = "Montant TTC", Width = 100 });
            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_NbrJour", Text = "Nombre de jours total de la commande", Width = 100 }); */

            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_MontantTotal", Text = "Montant TTC", Width = 100 });
            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_Name_Customer", Text = "Nom du client", Width = 120 });
            lvCommand.Columns.Add(new ColumnHeader() { Name = "command_Name_Boat", Text = "Nom du bateau", Width = 120 });

            lvCommand.Items.Clear();

            foreach (Command command in commandManager.ListCommands())
            {
            /*  PERMET DE PRENDRE QUE LES DERNIERES COMMANDES qui ont lieu ce mois   
                 if (command.DateEndCommand.Date.Day > now.Day && command.DateEndCommand.Date.Month == now.Month)
                 {
                 }
            */
                // Création de l'élément à ajouter au ListView
                ListViewItem lvi = new ListViewItem(new string[] {
                    command.IdCommand.ToString(),
                    command.DateStartCommand.ToString(),
                    command.DateEndCommand.ToString(),
                    command.HasPaiedDepositCommand ? "Caution payé" : "Caution non payé",

   /*               Ajout des lignes sur les deux colonnes : Le TTC et la différence des jours pour connaitre le nombre total de jours de la commande
                    command.PriceCommand + "€",
                    Convert.ToInt32(command.DateEndCommand.Date.Day - command.DateStartCommand.Date.Day).ToString(), */

                    command.IdBoatNavigation.PriceBoat*1.2 + "€",
                    command.IdCustomerNavigation.FirstNameCustomer + " " + command.IdCustomerNavigation.LastNameCustomer,
                    command.IdBoatNavigation.NameBoat.ToString() });
                    lvi.Tag = command;
                    lvCommand.Items.Add(lvi);
            }
        }

        // Les comboBox changent lors du double clic sur une commande dans la listview

        private void lvCommand_DoubleClick_1(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvCommand.SelectedItems;
            if (selected.Count == 1)
            {
                command = selected[0].Tag as Command;

                listeNom.SelectedItem = command.IdCustomerNavigation.FirstNameCustomer + command.IdCustomerNavigation.LastNameCustomer;
                listeIdentifiant.SelectedItem = command.IdCustomerNavigation.IdCustomer;
                listeBateau.SelectedItem = command.IdBoatNavigation.NameBoat;
                priceBoat.Text = command.IdBoatNavigation.PriceBoat.ToString();
            /*    montantTTC_text.Text = command.PriceCommand.ToString();          Permet l'ajout au double clic du montant TTC         */
                dateDeb.Text = command.DateStartCommand.ToString();
                dateFin.Text = command.DateEndCommand.ToString();
                boolPaied.Checked = command.HasPaiedDepositCommand;
            }
        }

        // Fonction permettant de mettre la listview en place au démarrage de la page

        private void FormCommand_Load_1(object sender, EventArgs e)
        {
            // Objectif : Initialiser ton data source
            // Premiere étape : Recuperer tes données (Utilise le Select si tu veux recuperer des elements précis, en l'occurence le nom et prénom)
            // Deuxieme etape : convertir le résultat en liste
            listeNom.DataSource = CustomerManager.GetCustomers().Select(x => x.FirstNameCustomer + " " + x.LastNameCustomer).ToList();
            listeIdentifiant.DataSource = CustomerManager.GetCustomers().Select(x => x.IdCustomer).ToList();
            listeBateau.DataSource = BoatManager.ListBoat().Select(x => x.NameBoat).ToList();
            idBoat.DataSource = BoatManager.ListBoat().Select(x => x.IdBoat).ToList();
            Refresh();
        }

        // Rendre le changement de nom de la personne dépendant de son identifiant

        private void listeNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeNom.SelectedIndex < 0)
                return;
            if (listeIdentifiant.SelectedIndex < 0)
                return;
            listeIdentifiant.SelectedIndex = listeNom.SelectedIndex;

            /* Permet de récupérer l'info si le client a le permis
            
            permisGuy.Checked = CustomerManager.GetCustomers()[listeNom.SelectedIndex].BoatLicenseCustomer;
            */
        }

        // Rendre le changement d'identifiant de la personne dépendant du nom de la personne

        private void listeIdentifiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeIdentifiant.SelectedIndex < 0)
                return;
            if (listeNom.SelectedIndex < 0)
                return;
            listeNom.SelectedIndex = listeIdentifiant.SelectedIndex;
        }

        // Rendre le prix et l'identifiant du bateau dépendant du nom

        private void listeBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeBateau.SelectedIndex < 0)
                return;
            priceBoat.Text = BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat.ToString();
            montantTTC_text.Text = (Convert.ToDouble(BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat) * 1.2).ToString();
            if (idBoat.SelectedIndex < 0)
                return;
            idBoat.SelectedIndex = listeBateau.SelectedIndex;
         
        /* Permet de récupérer l'info si le bateau est un bateau à permis
          
          permisBoat.Checked = BoatManager.ListBoat()[listeBateau.SelectedIndex].IsPermisBoat; */
        }

        // Rendre dépendant l'identifiant du bateau avec son nom

        private void idBoat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idBoat.SelectedIndex < 0)
                return;
            listeBateau.SelectedIndex = idBoat.SelectedIndex;   
        }

        // Ajout d'une commande via le bouton ajouter

        private void button_Add_Click(object sender, EventArgs e)
        {
            Command verify = commandManager.FindACommandByIDCustomerAndDate(Convert.ToInt32(listeIdentifiant.Text), Convert.ToDateTime(dateDeb.Value.Date));
            Command boat = commandManager.FindACommandByBoatID(Convert.ToInt32(idBoat.Text), dateDeb.Value.Date);
            if (verify != null)
            {
                MessageBox.Show("Impossible  d'ajouter la commande car l'utilisateur en a déjà une en cours aujourd'hui.");
            }
            else if (dateDeb.Value.Date > dateFin.Value.Date)
            {
                MessageBox.Show("Erreur lors de l'ajout, la date de fin de location ne peut pas être plus tôt que la date de début.");
            }
            else if (dateDeb.Value.Date != now.Date)
            {
                MessageBox.Show("Erreur de l'ajout, impossible d'ajouter une commande à une date plus vieille que la date actuelle");
            }
            else if (boat != null)
            {
                MessageBox.Show("Impossible d'ajouter la commande car le bateau est déjà pris pour aujourd'hui.");
            }
        /*    else if (!permisGuy.Checked && permisBoat.Checked)
            {
                MessageBox.Show("Impossible de réserver un bateau nécessitant le permis si le client ne le possède pas.");
            }
        */
            else
            {
                Command command = new Command(dateDeb.Value, dateFin.Value, boolPaied.Checked, /* BASE DE DONNEES COMMANDE PLUSIEURS JOURS Convert.ToDouble(montantTTC_text.Text), */ Convert.ToInt32(listeIdentifiant.Text), Convert.ToInt32(idBoat.Text));
                commandManager.AddACommand(command);
                MessageBox.Show("Commande ajoutée");
                Refresh();
            }
        }

        // Suppression d'une commande

        private void button_Delete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvCommand.SelectedItems;
            if (selected.Count == 1)
            {
                command = selected[0].Tag as Command;
                commandManager.DeleteACommand(command);
                MessageBox.Show("Commande supprimée");
                Refresh();
            }
            else
            {
                MessageBox.Show("Impossible de supprimer une commande");
            }
        }

        // Modification d'une commande

        private void button_Update_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvCommand.SelectedItems;
            if (selected.Count == 1)
            {
                if (listeIdentifiant.Text != command.IdCustomer.ToString())
                {
                    MessageBox.Show("Vous ne pouvez pas changer le client concerné par cette commande.");
                }
                else if (Convert.ToDateTime(dateDeb.Value.Date) > Convert.ToDateTime(dateFin.Value.Date))
                {
                    MessageBox.Show("Erreur lors de la modification, la date de fin de location ne peut pas être plus tôt que la date de début.");
                }
                else if (dateDeb.Value.Date != DateTime.Now.Date)
                {
                    MessageBox.Show("Erreur de la modification, impossible de modifier cette commande à une date plus vieille que la date actuelle");
                }
                else if (listeBateau.Text != command.IdBoatNavigation.NameBoat)
                {
                    MessageBox.Show("Impossible de modifier la commande car ce n'est pas le bateau réservé pour la journée.");
                }
                else
                {
                    command.DateStartCommand = dateDeb.Value;
                    command.DateEndCommand = dateFin.Value;
                    command.IdBoat = Convert.ToInt32(idBoat.Text);
                    command.IdBoatNavigation.NameBoat = listeBateau.Text;
                    command.HasPaiedDepositCommand = boolPaied.Checked;
          /*        Ajout cette valeur en base de données
                    command.PriceCommand = Convert.ToDouble(montantTTC_text.Text); */
                    commandManager.EditACommand(command);
                    MessageBox.Show("Commande modifiée.");
                }
                Refresh();
            }
        }

        // Bouton permettant de quitter la page

        private void button_Reset_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateFin_ValueChanged(object sender, EventArgs e)
        {

        /*  Ne sert que pour créer une commande sur plusieurs jours, cela évolue le prix 
           
            if ((Convert.ToInt32(dateFin.Value.Date.Day) - Convert.ToInt32(dateDeb.Value.Date.Day)) <= 1)
            {
                priceBoat.Text = BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat.ToString();
                montantTTC_text.Text = (Convert.ToDouble(priceBoat.Text) * 1.2).ToString();
            }
            else if ((Convert.ToInt32(dateFin.Value.Date.Day) - Convert.ToInt32(dateDeb.Value.Date.Day)) == 2)
            {
                priceBoat.Text = BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat.ToString();
                priceBoat.Text = (Convert.ToDouble(priceBoat.Text) * 1.2).ToString();
                montantTTC_text.Text = (Convert.ToDouble(priceBoat.Text) * 1.2).ToString();
            }
            else if ((Convert.ToInt32(dateFin.Value.Date.Day) - Convert.ToInt32(dateDeb.Value.Date.Day)) >= 3 && (Convert.ToInt32(dateFin.Value.Date.Day) - Convert.ToInt32(dateDeb.Value.Date.Day)) < 6)
            {
                priceBoat.Text = BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat.ToString();
                priceBoat.Text = (Convert.ToDouble(priceBoat.Text) * 1.4).ToString();
                montantTTC_text.Text = (Convert.ToDouble(priceBoat.Text) * 1.2).ToString();
            }
            else if ((Convert.ToInt32(dateFin.Value.Date.Day) - Convert.ToInt32(dateDeb.Value.Date.Day)) == 6)
            {
                priceBoat.Text = BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat.ToString();
                priceBoat.Text = (Convert.ToDouble(priceBoat.Text) * 1.8).ToString();
                montantTTC_text.Text = (Convert.ToDouble(priceBoat.Text) * 1.2).ToString();
            }
            else if ((Convert.ToInt32(dateFin.Value.Date.Day) - Convert.ToInt32(dateDeb.Value.Date.Day)) == 7)
            {
                priceBoat.Text = BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat.ToString();
                priceBoat.Text = (Convert.ToDouble(priceBoat.Text) * 2).ToString();
                montantTTC_text.Text = (Convert.ToDouble(priceBoat.Text) * 1.2).ToString();
            }
            else if ((Convert.ToInt32(dateFin.Value.Date.Day) - Convert.ToInt32(dateDeb.Value.Date.Day)) >= 8)
            {
                priceBoat.Text = BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat.ToString();
                priceBoat.Text = (Convert.ToDouble(priceBoat.Text) * 2.6).ToString();
                montantTTC_text.Text = (Convert.ToDouble(priceBoat.Text) * 1.2).ToString();
            }
            else
            {
                priceBoat.Text = BoatManager.ListBoat()[listeBateau.SelectedIndex].PriceBoat.ToString();
                montantTTC_text.Text = (Convert.ToDouble(priceBoat.Text) * 1.2).ToString();
            }
        */
        }
    }
}
