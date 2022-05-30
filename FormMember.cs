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
        MemberManager MemberManager;
        private Member member;

        public FormMember()
        {
            InitializeComponent();
            MemberManager = new MemberManager();
        }

        // Fonction permettant de rafraichir la listview à chaque requête

        private void Refresh()
        {
            list_member.Columns.Clear();
            list_member.Columns.Add(new ColumnHeader() { Name = "ID", Text = "ID", Width = 150 });
            list_member.Columns.Add(new ColumnHeader() { Name = "Login", Text = "Login", Width = 150 });
            list_member.Columns.Add(new ColumnHeader() { Name = "Mot de passe", Text = "Mot de passe", Width = 150 });

            list_member.Items.Clear();

            foreach (Member member in MemberManager.ListMember())
            {
                ListViewItem lvi = new ListViewItem(new string[]
                    {
                        member.IdMember.ToString(),
                        member.LoginMember.ToString(),
                        member.PasswordMember.ToString()
                    });
                lvi.Tag = member;
                list_member.Items.Add(lvi);
            }
            login.Text = "";
            password.Text = "";
            confirmPassword.Text = "";
        }

        // Charge la listview au démarrage

        private void FormMember_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        // Récupération du login et du mdp de l'utilisateur double cliqué sur la listview

        private void list_member_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_member.SelectedItems;
            if (selected.Count == 1)
            {
                member = selected[0].Tag as Member;

                login.Text = member.LoginMember;
                password.Text = member.PasswordMember;
                confirmPassword.Text = member.PasswordMember;
            }
        }

        // Bouton d'ajout d'un administrateur

        private void button_Add_Click(object sender, EventArgs e)
        {
            Member verify = MemberManager.FindAMemberByLogin(login.Text);

            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Impossible d'ajouter un administrateur car vous n'avez pas remplis tous les champs");
            }
            else if (verify != null)
            {
                MessageBox.Show("Vous ne pouvez pas créer deux administrateurs avec le même login.");
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
                Refresh();
            }
        }

        // Bouton de suppression d'un administrateur

        private void button_Delete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_member.SelectedItems;
            if (selected.Count == 1)
            {
                member = selected[0].Tag as Member;
                MemberManager.DeleteAMember(member);
                MessageBox.Show("Administrateur supprimé");
                login.Text = "";
                password.Text = "";
                confirmPassword.Text = "";
                Refresh();
            }
            else
            {
                MessageBox.Show("Impossible de supprimer l'administrateur");
            }
        }

        // Bouton permettant la modification d'un administrateur

        private void button_Update_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_member.SelectedItems;
            if (selected.Count == 1)
            {
                if (login.Text != member.LoginMember)
                {
                    MessageBox.Show("Vous ne pouvez pas changer le login de l'administrateur.");
                }
                else if (password.Text != confirmPassword.Text)
                {
                    MessageBox.Show("Les mots de passes sont différents.");
                }
                else
                {
                    member.PasswordMember = password.Text.ToString();
                    MemberManager.EditAMember(member);
                    MessageBox.Show("Administrateur modifié.");
                }
                Refresh();
            }
        }

        // Bouton permettant de réinitialiser les textbox

        private void button_Reset_Click(object sender, EventArgs e)
        {
            login.Text = "";
            password.Text = "";
            confirmPassword.Text = "";
            Refresh();
        }

        // Bouton permettant de quitter la page

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
