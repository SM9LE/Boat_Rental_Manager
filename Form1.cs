using Boat_Rental.Manager;
using Boat_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boat_Rental
{
    public partial class Form1 : Form
    {
        public bool Authentified = false;
        public bool SuperAdmin = false;
        MemberManager MemberManager;
        public Form1()
        {
            InitializeComponent();
            MemberManager = new MemberManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member member = MemberManager.FindAMemberByLogin(username.Text);

            if (member is null || member.PasswordMember != password.Text)
            {
                MessageBox.Show("Identifiant incorrect ou mot de passe incorrect");
                return;
            }
            else if (member.LoginMember == username.Text && member.PasswordMember == password.Text)
            {
                SuperAdmin = true;
                Close();
            }
            else
            {
                Authentified = true;
                Close();
            }
        }
        // showdialog

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            SuperAdmin = false;
            Authentified = false;
        }
    }
}
