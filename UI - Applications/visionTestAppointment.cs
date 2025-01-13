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
        private int _localDrivingLicenseApplicationID;

        public frmVisionTestAppointment(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            Console.WriteLine($"LocalDrivingLicenseApplicationID received in frmVisionTestAppointment: {_localDrivingLicenseApplicationID}");
        }


        private void visionTestAppointment_Load(object sender, EventArgs e)
        {

            ctrlLicenceApplicationInfo ctrl1 = new ctrlLicenceApplicationInfo(_localDrivingLicenseApplicationID);
            this.Controls.Add(ctrl1);

        }
    }
}
