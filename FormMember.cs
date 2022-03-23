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
    public partial class FormMember : Form
    {
        public bool customerList = false;
        MemberManager MemberManager;
        public FormMember()
        {
            InitializeComponent();
            MemberManager = new MemberManager();
            LoadChallenge();
            comboBox1.SelectedIndex = 0;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
                Member verify = MemberManager.FindAMemberByLogin(login.Text);

                if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show("Impossible d'ajouter un Administrateur car vous n'avez pas remplis tous les champs");
                }
                else if (verify != null)
                {
                    MessageBox.Show("Vous ne pouvez créer deux administrateurs avec le même login.");
                }
                else if (password.Text != confirmPassword.Text)
                {
                    MessageBox.Show("Les champs de mot de passe sont différents.");
                }
                else
                {
                    Member member = new Member(login.Text, password.Text);
                    MemberManager.AddAMember(member);
                    MessageBox.Show("Administrateur ajouté !");
                    LoadChallenge();
                }
        }
        private void LoadChallenge()
        {
            memberList.Items.Clear();

            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    memberList.Items.AddRange(MemberManager.GetMember().Select(member => member.LoginMember ).ToArray());
                    break;
                case 1:
                    memberList.Items.AddRange(MemberManager.GetMember().Select(member => member.PasswordMember).ToArray());
                    break;
                case 2:
                    memberList.Items.AddRange(MemberManager.GetMember().Select(member => member.IdMember.ToString()).ToArray());
                    break;
            }
        }

        private Member SelectedMember;

        private void memberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberList.SelectedItem != null)
            {
                var split = memberList.SelectedItem.ToString().Split(':');
                switch(comboBox1.SelectedIndex)
                {
                    case 0:
                        SelectedMember = MemberManager.FindAMemberByLogin(memberList.SelectedItem.ToString());
                        break;
                    case 1:
                        
                        break;
                    case 2:
                        SelectedMember = MemberManager.FindAMemberByID(int.Parse(memberList.SelectedItem.ToString()));
                        break;
                }
             
                if (SelectedMember != null)
                {
                    login.Text = SelectedMember.LoginMember;
                    password.Text = SelectedMember.PasswordMember;
                    confirmPassword.Text = SelectedMember.PasswordMember;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (memberList.SelectedItem != null)
            {
                if (login.Text != SelectedMember.LoginMember)
                {
                    MessageBox.Show("Vous ne pouvez pas changer le nom d'utilisateur de cet administrateur.");
                }
                else if (password.Text != confirmPassword.Text)
                {
                    MessageBox.Show("Les champs de mot de passe sont différents.");
                }
                else
                {
                    SelectedMember.PasswordMember = password.Text;
                    MemberManager.EditAMember(SelectedMember);
                    login.Text = "";
                    password.Text = "";
                    confirmPassword.Text = "";
                    LoadChallenge();
                    MessageBox.Show("Administrateur modifié !");
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (memberList.SelectedItem != null)
            {
                MemberManager.DeleteAMember(SelectedMember);
                login.Text = "";
                password.Text = "";
                confirmPassword.Text = "";
                LoadChallenge();
                MessageBox.Show("Administrateur supprimé !");
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            login.Text = "";
            password.Text = "";
            confirmPassword.Text = "";
            LoadChallenge();
        }

        // Lorsque l'utilisateur change le type de recherche
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChallenge();
        }
    }
}
