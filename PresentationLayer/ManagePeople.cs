using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManagBusinessLayer;

namespace PresentationLayer
{
    public partial class frmMngPeople : Form
    {
        public frmMngPeople()
        {
            InitializeComponent();
        }


        private void _RefreshContactsList()
        {
            dgvAllPeople.DataSource = clsPeople.GetAllPeople();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            _RefreshContactsList();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dgvAllPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addEditForm = new frmAddEditPerson(-1);
            addEditForm.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshContactsList();
        }
    }
}
