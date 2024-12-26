using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer; // Adjust based on the namespace of AddEditPerson


namespace DVLD___Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMngPeople MngPeopleForm = new frmMngPeople ();
            MngPeopleForm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
