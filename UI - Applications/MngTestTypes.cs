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
    public partial class frmMngTestTypes : Form
    {
        public frmMngTestTypes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void _RefreshTestTypes()
        {
            dgvManageTestTypes.DataSource = clsTestTypes.GetAllTestTypes();
        }


        private void dgvManageTestTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MngTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypes();
        }
    }
}
