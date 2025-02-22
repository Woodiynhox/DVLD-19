using Logic_Layer___Applications;
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
    public partial class frmVisionTestAppointment : Form
    {
        int _ApplicationID;
        clsBL_localDrivingApplications _clsL_D_A;
        //string _createdBy;


        public frmVisionTestAppointment(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _ApplicationID = localDrivingLicenseApplicationID;

           // _createdBy = CreatedBy;
          
        }

        private void _RefreshTestTypes()
        {
            dgvAppointments.DataSource = clsBL_localDrivingApplications.getAllAppointment();
        }


        private void visionTestAppointment_Load(object sender, EventArgs e)
        {
            //List all the Appointments.
            _RefreshTestTypes();

            _clsL_D_A = clsBL_localDrivingApplications.GetApplicationInfoByApplicationID(_ApplicationID);
            Console.WriteLine($"Loading data for _ApplicationID: {_ApplicationID}"); // Log here

            if (_clsL_D_A != null)
            {
                lblAppID.Text = _clsL_D_A.ApplicationID.ToString();
                lblAppliedClass.Text = _clsL_D_A.AppliedFor;
                lblPassedTests.Text = _clsL_D_A.PassedTests.ToString();
                lblIDBasicInfo.Text = _clsL_D_A.PersonID.ToString();
                lblStatusBasicInfo.Text = _clsL_D_A.ApplicationStatus.ToString() == "1" ? "New" : _clsL_D_A.ApplicationStatus.ToString() == "2" ? "Cancel" : "Completed"; 
                lblTypeBasicInfo.Text = "New Local Driving Licence Service";
                lblApplicantNameBasicInfo.Text = $"{_clsL_D_A.FirstName} {_clsL_D_A.SecondName} {_clsL_D_A.ThirdName} {_clsL_D_A.LastName}";
                lblDateBasicInfo.Text = _clsL_D_A.ApplicationDate.ToShortDateString();
             //   lblStatusBasicInfo.Text = _clsL_D_A.LastStatusDate.ToShortDateString();
                lblCreatedByBasicInfo.Text = _clsL_D_A.CreatedBy;
                lblStatusDateBasicInfo.Text = _clsL_D_A.LastStatusDate.ToShortDateString();
                lblFeesBasicInfo.Text = "15";
            }
            else
            {
                MessageBox.Show("No data found.");
            }

        }

        private void pbNewAppointment_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest(1, _clsL_D_A.ApplicationID, _clsL_D_A.ApplicationDate, _clsL_D_A.CreatedBy);
            frm.ShowDialog();
        }
    }
}
