﻿using Logic_Layer___Applications;
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

namespace UI___Applications
{
    public partial class frmLocalDrivingLicenceApp : Form
    {


        string _username;
       



        public frmLocalDrivingLicenceApp()
        {
            InitializeComponent();
        }

        public frmLocalDrivingLicenceApp(string username)
        {
            InitializeComponent();
            _username = username;


        }


        private void _RefreshTestTypes()
        {
            dgvLocalDrivingLicenceApplications.DataSource = clsBL_localDrivingApplications.GetAllLocalDrivingApplications();
        }

        private void LocalDrivingLicenceApp_Load(object sender, EventArgs e)
        {
            _RefreshTestTypes();
        }

        private void dgvLocalDrivingLicenceApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewLocalApplications frm = new frmNewLocalApplications(_username);
            frm.ShowDialog();
        }
    }
}