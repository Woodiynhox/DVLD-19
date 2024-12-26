using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManagBusinessLayer;

namespace PresentationLayer
{
    public partial class frmAddEditPerson : Form
    { 
        
        
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPeople _Person;


        public frmAddEditPerson(int personID)
        {
            InitializeComponent();

            _PersonID = personID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsPeople.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                cbCountry.Items.Add(row["CountryName"]);

            }

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _LoadData()
        {

            _FillCountriesInComoboBox();
            cbCountry.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                // lblMode.Text = "Add New Contact";
                _Person = new clsPeople();
                return;
            }

            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _Person);
                this.Close();

                return;
            }


            lblMode.Text = "Edit PERSON";
             tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;
            tbNationalNo.Text = _Person.NationalNo;
            _Person.DateOfBirth = dateDOB.Value;
            _Person.Gender = rbFemale.Checked ? rbFemale.Text : rbMale.Text;
            tbPhone.Text = _Person.Phone;
            tbEmail.Text = _Person.Email;
           
            tbAddress.Text = _Person.Address;

            if (_Person.ImagePath != "")
            {
                pbImage.Load(_Person.ImagePath);
            }

            //llRemoveImage.Visible = (_Contact.ImagePath != "");

            //this will select the country in the combobox.
       //     cbCountry.SelectedIndex = cbCountry.FindString(clsPeople.Find(_Person.CountryID).CountryID.ToString());




        }


        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            clsCountry selectedCountry = clsCountry.FindCountry(cbCountry.Text);
            if (selectedCountry == null)
            {
                MessageBox.Show("Invalid Country selected. Please select a valid Country.");
                return;
            }

            int CountryID = selectedCountry.CountryID;
            //Console.WriteLine($"Selected CountryID: {CountryID}");


            _Person.FirstName = tbFirstName.Text;
            _Person.SecondName = tbSecondName.Text;
            _Person.ThirdName = tbThirdName.Text;
            _Person.LastName = tbLastName.Text;
            _Person.NationalNo = tbNationalNo.Text;
            _Person.DateOfBirth = dateDOB.Value;
            _Person.Gender = rbFemale.Checked ? rbFemale.Text : rbMale.Text;
            _Person.Phone = tbPhone.Text;
            _Person.Email = tbEmail.Text;
            _Person.CountryID  = CountryID;
            _Person.Address = tbAddress.Text;

            if (pbImage.ImageLocation != null)
                _Person.ImagePath = pbImage.ImageLocation;
            else
                _Person.ImagePath = "";

            
            if (_Person.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;
            lblMode.Text = "Edit Person";
            lblPersonID.Text = _Person.ID.ToString();
        }

        private void lblOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pbImage.Load(selectedFilePath);
                // ...
            }
        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {


            if (clsPeople.isNationalUsed(_Person.NationalNo))
            {
                e.Cancel = true;
                tbNationalNo.Focus();
                errorProvider1.SetError(tbNationalNo, "National Number is NOT valid!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNo, "");
            }
        }
        private void tbNationalNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
