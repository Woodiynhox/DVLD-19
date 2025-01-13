using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_Layer___Applications;

namespace UI___Applications
{
    public partial class ctrlLicenceApplicationInfo : UserControl
    {
        int _ApplicationID;
        clsBL_localDrivingApplications _clsL_D_A;


        public ctrlLicenceApplicationInfo()
        {
            InitializeComponent(); // This ensures the control initializes properly
        }

        public ctrlLicenceApplicationInfo(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _ApplicationID = localDrivingLicenseApplicationID;
            Console.WriteLine($"Application ID received in UserControl: {_ApplicationID}");
        }

        private void _LoadData()
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

        private void LicenceApplicationInfo_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                _LoadData();
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
