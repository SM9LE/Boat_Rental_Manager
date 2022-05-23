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
        public bool CustomerList = false;
        public bool CommandList = false;

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
            FormBoat boatStock = new FormBoat();
            boatStock.ShowDialog();
            
        }

        private void button_AddConsumer_Click(object sender, EventArgs e)
        {
            AddCustomer = true;
            Close();
        }

        private void button_AddCommand_Click(object sender, EventArgs e)
        {
            AddCommand = true;
            Close();
        }
        private void button_CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList = true;
            Close();
        }
        private void button_CommandList_Click(object sender, EventArgs e)
        {
            CommandList = true;
            Close();
        }

        private void button_Leave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
