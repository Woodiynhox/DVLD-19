using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer;
using UI___Applications; // Adjust based on the namespace of AddEditPerson


namespace DVLD___Project
{
    public partial class frmMain : Form
    {

        string _username;
        public frmMain(string username)
        {
            InitializeComponent();
            _username = username;
            
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMngPeople MngPeopleForm = new frmMngPeople ();
            MngPeopleForm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create and show the login form before closing all other forms
            frmLogin login = new frmLogin();
            login.Show();

            // Close all open forms except the new login form
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form openForm = Application.OpenForms[i];
                if (openForm != login) 
                {
                    openForm.Close();
                }
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass(_username);
            frm.ShowDialog();
        }

        private void manageApplicationsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationsTypes frm = new frmApplicationsTypes();
            frm.ShowDialog();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMngTestTypes frm = new frmMngTestTypes();
            frm.ShowDialog();
        }

        private void localDrivingLicenceApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenceApp frm = new frmLocalDrivingLicenceApp(_username);
            frm.ShowDialog();
        }
    }
}
