using PeopleManagBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if ((tbUsername.Text.ToString() == string.Empty || tbPassword.Text.ToString() == string.Empty))
            {
                MessageBox.Show("Empty Username/Password!", "Empty Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }





            if (clsUsers.IsValidUser(tbUsername.Text.ToString(), tbPassword.Text.ToString()))
            {

                 if (clsUsers.isActiveUser(tbUsername.Text.ToString())) { 
            
                                frmMain frmMain = new frmMain(tbUsername.Text.ToString());
                                frmMain.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Your Username Isnt Active, Contact Your IT department", "Activation Needed!");
                }

            } else
            {
                MessageBox.Show("Wrong Username/Password!", "Wrong Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }



        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); // Triggers the Login button click event
                e.Handled = true; // Prevents further handling of the Enter key
                e.SuppressKeyPress = true; // Suppresses the beep sound
            }
        }
    }
}
