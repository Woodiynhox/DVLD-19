using PeopleManagBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmChangePass : Form
    {
        string _username;
        clsUsers _user;
        int _personID;

        public frmChangePass(string username)
        {
            InitializeComponent();

            _username = username;

            // Initialize _user object
            _user = clsUsers.Find(_username);

            if (_user == null)
            {
                MessageBox.Show($"User with username '{_username}' not found. The form will be closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form immediately
                return;
            }

            // Retrieve PersonID
            _personID = clsUsers.FindPersonIDByUserID(_user.Id);

            if (_personID == -1)
            {
                MessageBox.Show($"No PersonID associated with UserID {_user.Id}. Please check the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if PersonID is not found
                return;
            }
        }


        private void _LoadData()
        {
            // Populate labels with user data
            lblUsername.Text += _user.username;
            lblUserID.Text += $"{_user.Id}";
            lblIsActive.Text += _user.isActive;
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            _LoadData();

            if (_personID != -1)
            {
                ctrlPersonalInfo1.InitializeData(_personID); // Call a method to set data for the control
            }
            else
            {
                MessageBox.Show("Unable to load personal information. No PersonID found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSaveNewPass_Click(object sender, EventArgs e)
        {
            if (clsUsers.saveNewPassword(_username, tbNewPass.Text))
            {
                MessageBox.Show("Password has been updated successfully.", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Problem occurred. Please contact your IT admin or try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCurrentPass_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event for tbCurrentPass
        }

        private void tbCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            // Validate the current password (you can use existing logic here)
            if (!clsUsers.IsValidUser(_user.username, tbCurrentPass.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPass, "Wrong Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCurrentPass, "");
            }
        }

        private void tbRepeatedPass_Validating(object sender, CancelEventArgs e)
        {
            // Validate the repeated password
            if (tbNewPass.Text != tbRepeatedPass.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbRepeatedPass, "Passwords do not match!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbRepeatedPass, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Handle cancel button click
            this.Close();
        }

        private void ctrlPersonalInfo1_Load(object sender, EventArgs e)
        {
            // Handle the load event for ctrlPersonalInfo
            if (_user != null)
            {
                int personID = clsUsers.FindPersonIDByUserID(_user.Id);
                if (personID != -1)
                {
                    ctrlPersonalInfo personalInfo = new ctrlPersonalInfo(personID);
                    Controls.Add(personalInfo);
                }
                else
                {
                    MessageBox.Show("No associated person found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
