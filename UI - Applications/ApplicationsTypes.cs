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
    public partial class frmApplicationsTypes : Form
    {
        public frmApplicationsTypes()
        {
            InitializeComponent();
        }

        private void _RefreshApplicationsTypes()
        {
            dgvManageApplicationsTypes.DataSource = clsApplicationsTypes.GetAllApplicationsTypes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblManage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmApplicationsTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationsTypes();
        }

        private void dgvManageApplicationsTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
