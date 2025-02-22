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

namespace UI___Applications
{
    public partial class frmScheduleTest : Form
    {

        int _TestTypeID;
        int _LocalDrivingLicenseApplicationID;
        DateTime _AppointmentDate;
        int _CreatedByUserID;
        string _applicantName;
        string _drivingClass;
        public frmScheduleTest(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, int CreatedByUserID, string FirstName, string lastName, string drivingClass)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _AppointmentDate = AppointmentDate;
            _CreatedByUserID = CreatedByUserID;
            _applicantName = FirstName + " " + lastName;
            _drivingClass = drivingClass;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblDrivingClass_Click(object sender, EventArgs e)
        {

        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            lblDLAppID.Text = _LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _drivingClass.ToString();
            lblFees.Text = "15";
            lbName.Text = _applicantName;

        }

        private void gbVisionTest_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveVisionTest_Click(object sender, EventArgs e)
        {
            if (clsBL_localDrivingApplications.scheduleVisionTest(_TestTypeID, _LocalDrivingLicenseApplicationID, _AppointmentDate, _CreatedByUserID))
            {
                MessageBox.Show("The Test has been placed!", "Saved Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Not Saved!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
