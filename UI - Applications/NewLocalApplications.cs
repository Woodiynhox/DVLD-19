using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_Layer___Applications;
using PeopleManagBusinessLayer;

namespace UI___Applications
{
    public partial class frmNewLocalApplications : Form
    {
        string _username;
        clsUsers _user;
        int _personID;
        public frmNewLocalApplications(string username)
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

        private void _FillClassesInComboBox()
        {
            // Get data from the Logic Layer
            DataTable dtClasses = clsBL_localDrivingApplications.GetAllClasses();

            // Debug: Verify that LicenseClassID and ClassName exist in the DataTable
            foreach (DataColumn column in dtClasses.Columns)
            {
                Console.WriteLine($"Column: {column.ColumnName}");
            }

            // Bind the ComboBox to the DataTable
            cbLicencesClasses.DataSource = dtClasses;
            cbLicencesClasses.DisplayMember = "ClassName";   // What the user sees
            cbLicencesClasses.ValueMember = "LicenseClassID"; // What the program uses
        }



        private void NewLocalApplications_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToString();
            _FillClassesInComboBox();
            cbLicencesClasses.SelectedIndex = 0;
            lblCreatedBy.Text = _user.username;
            

        }



        private void lblApplicationDate_Click(object sender, EventArgs e)
        {
            // lblApplicationDate.Text = DateTime.Now.ToString();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Convert lblApplicationDate.Text to a DateTime object
            DateTime applicationDate = DateTime.Parse(lblApplicationDate.Text);
            int applicationFees = Convert.ToInt32(lblApplicationFees.Text);
            int licenseClassID = Convert.ToInt32(cbLicencesClasses.SelectedValue);

            Console.WriteLine($"LicenseClassID Selected: {licenseClassID}");



            // Call AddNewApplication with the DateTime object
            if (clsBL_localDrivingApplications.AddNewApplication(applicationDate, licenseClassID, applicationFees ,_user.Id, _personID))
            {
                MessageBox.Show("Application saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
