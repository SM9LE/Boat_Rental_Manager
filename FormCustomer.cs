using Boat_Rental.Manager;
using Boat_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boat_Rental
{
    public partial class FormCustomer : Form
    {
        CustomerManager CustomerManager;
        Customer customer;
        // Déclaration de la journée actuelle
        string date = DateTime.Now.ToString();
        // Déclaration de la valeur âge pour vérifier si l'utilisateur a 18 ans
        int age;
        public FormCustomer()
        {
            InitializeComponent();
            CustomerManager = new CustomerManager();
            date_naissance.CustomFormat = "dd/MM/yyyy";
        }

        // Fonction permettant de Refresh 

        private void Refresh()
        {
            list_customer.Columns.Clear();
            list_customer.Columns.Add(new ColumnHeader() { Name = "customer_Id", Text = "Identifiant", Width = 50 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "customer_Prenom", Text = "Prenom", Width = 90 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "customer_Nom", Text = "Nom", Width = 90 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "customer_Age", Text = "Age", Width = 90 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "customer_email", Text = "Email", Width = 100 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "customer_license", Text = "License bateau", Width = 130 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "customer_isrented", Text = "Location en cours ?", Width = 90 });

            list_customer.Items.Clear();

            foreach (Customer customer in CustomerManager.GetCustomers())
            {
                ListViewItem lvi = new ListViewItem(new string[]
                    {
                        customer.IdCustomer.ToString(),
                        customer.FirstNameCustomer.ToString(),
                        customer.LastNameCustomer.ToString(),
                        customer.AgeCustomer.ToString(),
                        customer.MailCustomer.ToString(),
                        customer.BoatLicenseCustomer ? "Permis bateau" : "Ne possède pas le permis",
                        customer.HasRentedCustomer ? "Oui" : "Non"
                       });
                lvi.Tag = customer;
                list_customer.Items.Add(lvi);
            }
            // Refresh de toutes les valeurs
            firstName.Text = "";
            lastName.Text = "";
            date_naissance.Text = date;
            mailAdress.Text = "";
            licenseChecked.CheckState = 0;
            rentChecked.CheckState = 0;
        }

        // Charge automatiquement au chargement du formulaire le listview

        private void FormCustomer_Load_1(object sender, EventArgs e)
        {
            Refresh();
        }

        // Lorsque l'utilisateur double clic, cela remplit les champs      

        private void list_customer_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_customer.SelectedItems;
            if (selected.Count == 1)
            {
                customer = selected[0].Tag as Customer;

                firstName.Text = customer.FirstNameCustomer;
                lastName.Text = customer.LastNameCustomer;
                date_naissance.Text = customer.AgeCustomer.ToString();
                mailAdress.Text = customer.MailCustomer.ToString();
                licenseChecked.Checked = customer.BoatLicenseCustomer;
                rentChecked.Checked = customer.HasRentedCustomer;
            }
        }

        // Bouton permettant d'ajouter un client

        private void button_Add_Click(object sender, EventArgs e)
        {
            // Vérification si l'utilisateur a moins de 18 ans.
            age = DateTime.Today.Year - date_naissance.Value.Year;

            Customer verify = CustomerManager.FindACustomerByMail(mailAdress.Text);

            if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text) || string.IsNullOrEmpty(mailAdress.Text))
            {
                MessageBox.Show("Impossible d'ajouter un client car vous n'avez pas remplis tous les champs.");
            }
            else if (verify != null)
            {
                MessageBox.Show("Un client possède déjà un compte avec cet adresse mail. Impossible de créer ce client.");
            }
            else if (date_naissance.Value.Date == Convert.ToDateTime(date))
            {
                MessageBox.Show("Impossible d'ajouter l'utilisateur car sa date de naissance est la date actuelle.");
            }
            else if (age < 18)
            {
                MessageBox.Show("Impossible d'ajouter l'utilisateur car il a moins de 18 ans.");

            }
            else if (!mailAdress.Text.Contains('@'))
            {
                MessageBox.Show("Ce n'est pas une adresse mail.");
            }
            else
            {
                Customer customer = new Customer(firstName.Text, lastName.Text, Convert.ToDateTime(date_naissance.Value.Date), mailAdress.Text, licenseChecked.Checked, rentChecked.Checked);
                CustomerManager.AddACustomer(customer);
                MessageBox.Show("Client ajouté.");
                Refresh();
            }
        }

        // Bouton permettant de supprimer un client 

        private void button_Delete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_customer.SelectedItems;
            if (selected.Count == 1)
            {
                customer = selected[0].Tag as Customer;
                CustomerManager.DeleteACustomer(customer);
                MessageBox.Show("Client supprimé.");
                Refresh();
            }
            else
            {
                MessageBox.Show("Impossible de supprimer le client.");
            }
        }

        // Bouton permettant de modifier un client

        private void button_Update_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_customer.SelectedItems;
            if (selected.Count == 1)
            {
                if (firstName.Text != customer.FirstNameCustomer)
                {
                    MessageBox.Show("Vous ne pouvez pas changer le prénom du client.");
                }
                else if (customer.LastNameCustomer != lastName.Text)
                {
                    MessageBox.Show("Vous ne pouvez pas modifier le nom de famille du client.");
                }
                else if (date_naissance.Value.Date != customer.AgeCustomer)
                {
                    MessageBox.Show("Vous ne pouvez pas modifier la date de naissance du client.");
                }
                else if (!mailAdress.Text.Contains('@'))
                {
                    MessageBox.Show("Ce n'est pas une adresse mail.");
                }
                else
                {
                    customer.MailCustomer = mailAdress.Text;
                    customer.HasRentedCustomer = rentChecked.Checked;
                    customer.BoatLicenseCustomer = licenseChecked.Checked;
                    CustomerManager.EditACustomer(customer);
                    MessageBox.Show("Client modifié.");
                }
                Refresh();
            }
        }

        // Bouton permettant de réinitialiser les différentes textbox

        private void button_Reset_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        // Bouton permettant de quitter la page
        private void button_Leave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
