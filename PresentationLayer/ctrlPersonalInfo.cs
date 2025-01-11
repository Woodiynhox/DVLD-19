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
using PeopleManagBusinessLayer;

namespace PresentationLayer
{
    public partial class ctrlPersonalInfo : UserControl
    {
        clsPeople _Person;
        int _personID;

        public ctrlPersonalInfo()
        {
            InitializeComponent();
        }

        public ctrlPersonalInfo(int personID)
        {
            InitializeComponent();
            _personID = personID;
        }

        public void InitializeData(int personID)
        {
            _personID = personID;
            _LoadData();
        }

        private void _LoadData()
        {
            _Person = clsPeople.Find(_personID);

            if (_Person == null)
            {
                MessageBox.Show($"No person found with ID = {_personID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblPersonID.Text += " " + _personID.ToString() ?? "N/A";
            lblFullName.Text = $"{_Person.FirstName} {_Person.SecondName} {_Person.ThirdName} {_Person.LastName}";
            lblNationalNum.Text = _Person.NationalNo ?? "N/A";
            lblDOB.Text = _Person.DateOfBirth.ToString("d");
            lblGender.Text = _Person.Gender ?? "N/A";
            lblPhone.Text = _Person.Phone ?? "N/A";
            lblEmail.Text = _Person.Email ?? "N/A";
            lblAddress.Text = _Person.Address ?? "N/A";

            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                try
                {
                    pbImage.Load(_Person.ImagePath);
                }
                catch
                {
                    MessageBox.Show("Failed to load the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Add functionality here if required, or leave it empty for now.
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Add functionality here if required, or leave it empty for now.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Add functionality here if required, or leave it empty for now.
        }

        private void ctrlPersonalInfo_Load(object sender, EventArgs e)
        {
            // If _LoadData() should not run automatically on load, leave this empty.
            // Otherwise, you can call _LoadData() here if needed:
            // _LoadData();
        }

    }
}
