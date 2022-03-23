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
            birthDate.Text = "";
            mailAdress.Text = "";
            Adress.Text = "";
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

            if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text) || string.IsNullOrEmpty(birthDate.Text) || string.IsNullOrEmpty(mailAdress.Text) || string.IsNullOrEmpty(Adress.Text) || string.IsNullOrEmpty(boatLicense.Text) || string.IsNullOrEmpty(hasRented.Text))
            {
                MessageBox.Show("Impossible d'ajouter un Client car vous n'avez pas remplis tous les champs");
            }
            else if (verify != null)
            {
                MessageBox.Show("Un client possède déjà un compte avec cet adresse mail. Impossible de créer ce client.");
            }
            else if (!birthDate.Text.Contains("-"))
            {
                MessageBox.Show("Remplissez le champ 'Date anniversaire' avec la bonne syntaxe");
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
                Customer customer = new Customer(firstName.Text, lastName.Text, DateTime.Parse(birthDate.Text), mailAdress.Text, Adress.Text, Convert.ToBoolean(boatLicense.Text), Convert.ToBoolean(hasRented));
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
                birthDate.Text = SelectedCustomer.AgeCustomer.ToString();
                mailAdress.Text = SelectedCustomer.MailCustomer;
                Adress.Text = SelectedCustomer.AdressCustomer;
                boatLicense.Text = SelectedCustomer.BoatLicenseCustomer.ToString();
                hasRented.Text = SelectedCustomer.HasRentedCustomer.ToString();
            }
        }

        // Lorsque l'utilisateur change le type de recherche       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                LoadChallenge();
        }
    }
}
