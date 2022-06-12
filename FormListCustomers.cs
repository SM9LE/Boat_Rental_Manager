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
    public partial class FormListCustomers : Form
    {
        CustomerManager CustomerManager;

        public FormListCustomers()
        {
            InitializeComponent();
            CustomerManager = new CustomerManager();
        }

        // Fonction permettant de recharger la listview
        private void Refresh(List<Customer> list)
        {
            lvListCustomers.Columns.Clear();
            // Ajout des colonnes
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_Id", Text = "Identifiant", Width = 100 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_Prenom", Text = "Prenom", Width = 150 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_Nom", Text = "Nom", Width = 150 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_Age", Text = "Age", Width = 150 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_email", Text = "Email", Width = 300 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_license", Text = "Permis de conduire", Width = 200 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_isrented", Text = "Location en cours ?", Width = 130 });

            lvListCustomers.Items.Clear();

            foreach (Customer customer in list)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                    {
                        customer.IdCustomer.ToString(),
                        customer.FirstNameCustomer.ToString(),
                        customer.LastNameCustomer.ToString(),
                        customer.AgeCustomer.ToString(),
                        customer.MailCustomer.ToString(),
                        customer.BoatLicenseCustomer ? "Permis B" : "Ne possède pas le permis",
                        customer.HasRentedCustomer ? "Oui" : "Non"
                    });
                lvi.Tag = customer;
                lvListCustomers.Items.Add(lvi);
            }
        }

        // Fonction permettant de charger la page à l'ouverture

        private void FormListCustomers_Load(object sender, EventArgs e)
        {
            Refresh(CustomerManager.GetCustomers());
        }

        // Bouton permettant de quitter la page

        private void button_Leave_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void searchButton_customers_Click(object sender, EventArgs e)
        {
           /* if (string.IsNullOrEmpty(searchBar_laabel.Text))
            {
                Refresh(CustomerManager.GetCustomers());
                return;
            }*/
            Refresh(CustomerManager.FindCustomersByRent());
        }

        private void searchBar_customer_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBar_laabel_Click(object sender, EventArgs e)
        {

        }
    }
}

