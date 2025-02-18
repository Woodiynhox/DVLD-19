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


        public frmVisionTestAppointment(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _ApplicationID = localDrivingLicenseApplicationID;
          
        }


        private void visionTestAppointment_Load(object sender, EventArgs e)
        {
            _clsL_D_A = clsBL_localDrivingApplications.GetApplicationInfoByApplicationID(_ApplicationID);
            Console.WriteLine($"Loading data for _ApplicationID: {_ApplicationID}"); // Log here

            if (_clsL_D_A != null)
            {
                lblAppID.Text = _clsL_D_A.ApplicationID.ToString();
                lblAppliedClass.Text = _clsL_D_A.AppliedFor;
                lblPassedTests.Text = _clsL_D_A.PassedTests.ToString();
                lblIDBasicInfo.Text = _clsL_D_A.PersonID.ToString();
                lblStatusBasicInfo.Text = _clsL_D_A.ApplicationStatus.ToString();
                lblTypeBasicInfo.Text = "New Local Driving Licence Service";
                lblApplicantNameBasicInfo.Text = $"{_clsL_D_A.FirstName} {_clsL_D_A.SecondName} {_clsL_D_A.ThirdName} {_clsL_D_A.LastName}";
                lblDateBasicInfo.Text = _clsL_D_A.ApplicationDate.ToShortDateString();
                lblStatusBasicInfo.Text = _clsL_D_A.LastStatusDate.ToShortDateString();
                lblCreatedByBasicInfo.Text = _clsL_D_A.CreatedBy;
            }
            else
            {
                MessageBox.Show("No data found.");
            }

        }
    }
}
