using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Boat_Rental
{
    public partial class FormManager : Form
    {
        public bool AddMember = false;
        public bool AddBoat = false;
        public bool AddCustomer = false;
        public bool AddCommand = false;
        public bool CustomersList = false;
        public bool CommandList = false;
        public bool BoatList = false;

        public FormManager()
        {
            InitializeComponent();
        }
        private void button_AdminAccount_Click(object sender, EventArgs e)
        {
            AddMember = true;
            FormMember member = new FormMember();
            member.ShowDialog();
        }

        private void button_BoatStock_Click(object sender, EventArgs e) 
        {
            AddBoat = true;
            FormBoat boat = new FormBoat();
            boat.ShowDialog();
        }

        private void button_AddConsumer_Click(object sender, EventArgs e)
        {
            AddCustomer = true;
            FormCustomer customer = new FormCustomer();
            customer.ShowDialog();
        }

        private void button_AddCommand_Click(object sender, EventArgs e)
        {
            AddCommand = true;
            FormCommand commands = new FormCommand();
            commands.ShowDialog();
        }
        private void button_CustomerList_Click(object sender, EventArgs e)
        {
            CustomersList = true;
            FormListCustomers listcustomers = new FormListCustomers();
            listcustomers.ShowDialog();
        }
        private void button_CommandList_Click(object sender, EventArgs e)
        {
            CommandList = true;
            FormListCommands listcommands = new FormListCommands();
            listcommands.ShowDialog();
        }
        private void boatLists_Click(object sender, EventArgs e)
        {
            BoatList = true;
            FormListBoats boatStock = new FormListBoats();
            boatStock.ShowDialog();
        }
        private void button_Leave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
