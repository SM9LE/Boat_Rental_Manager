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
        public FormCustomer()
        {
            InitializeComponent();
            CustomerManager = new CustomerManager();
            LoadChallenge();
            comboBox1.SelectedIndex = 0;
        }
        private void LoadChallenge()
        {
            customerList.Items.Clear();
            firstName.Text = "";
            lastName.Text = "";
            mailAdress.Text = "";
            boatLicense.Text = "";
            hasRented.Text = "";

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    customerList.Items.AddRange(CustomerManager.GetCustomers().Select(member => member.FirstNameCustomer).ToArray());
                    break;
                case 1:
                    customerList.Items.AddRange(CustomerManager.GetCustomers().Select(member => member.LastNameCustomer).ToArray());
                    break;
                case 2:
                    customerList.Items.AddRange(CustomerManager.GetCustomers().Select(member => member.IdCustomer.ToString()).ToArray());
                    break;
            }
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            Customer verify = CustomerManager.FindACustomerByMail(mailAdress.Text);

            if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text) || string.IsNullOrEmpty(mailAdress.Text) || string.IsNullOrEmpty(boatLicense.Text) || string.IsNullOrEmpty(hasRented.Text))
            {
                MessageBox.Show("Impossible d'ajouter un Client car vous n'avez pas remplis tous les champs");
            }
            else if (verify != null)
            {
                MessageBox.Show("Un client possède déjà un compte avec cet adresse mail. Impossible de créer ce client.");
            }
            else if (!mailAdress.Text.Contains('@'))
            {
                MessageBox.Show("Ce n'est pas une vraie adresse mail");
            }
            else
            {
                if (boatLicense.Text == "true" || boatLicense.Text == "false")
                {
                    Convert.ToBoolean(boatLicense.Text);
                }
                Customer customer = new Customer(firstName.Text, lastName.Text, DateTime.Parse(date_naissance.Text), mailAdress.Text, Convert.ToBoolean(boatLicense.Text), Convert.ToBoolean(hasRented));
                CustomerManager.AddACustomer(customer);
                MessageBox.Show("Client ajouté !");
                LoadChallenge();
            }
        }
        private Customer SelectedCustomer;
        private void customerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var split = customerList.SelectedItem.ToString().Split(':');
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    SelectedCustomer = CustomerManager.FindACustomerByMail(customerList.SelectedItem.ToString());
                    break;
                case 1:

                    break;
                case 2:
                    SelectedCustomer = CustomerManager.FindACustomerByID(int.Parse(customerList.SelectedItem.ToString()));
                    break;
            }

            if (SelectedCustomer != null)
            {
                firstName.Text = SelectedCustomer.FirstNameCustomer;
                lastName.Text = SelectedCustomer.LastNameCustomer;
                mailAdress.Text = SelectedCustomer.MailCustomer;
                boatLicense.Text = SelectedCustomer.BoatLicenseCustomer.ToString();
                hasRented.Text = SelectedCustomer.HasRentedCustomer.ToString();
            }
        }

        // Lorsque l'utilisateur change le type de recherche       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                LoadChallenge();
        }

        private void list_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            list_customer.Columns.Clear();
            list_customer.Columns.Add(new ColumnHeader() { Name = "ID", Text = "ID", Width = 10 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "Prenom", Text = "Prenom", Width = 30 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 30 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "Age", Text = "Age", Width = 30 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "Email", Text = "Email", Width = 30 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "License", Text = "License bateau", Width = 10 });
            list_customer.Columns.Add(new ColumnHeader() { Name = "Caution", Text = "Caution", Width = 10 });

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
                        customer.BoatLicenseCustomer.ToString(),
                        customer.HasRentedCustomer.ToString()
                    });
                lvi.Tag = customer;
                list_customer.Items.Add(lvi);
            }
        }
        private void list_member_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_customer.SelectedItems;
            if (selected.Count == 1)
            {
                customer = selected[0].Tag as Customer;

                firstName.Text = customer.FirstNameCustomer;
                lastName.Text = customer.LastNameCustomer;
            }
        }
    }
}
