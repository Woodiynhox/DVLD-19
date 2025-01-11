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
using PeopleManagBusinessLayer;

namespace PresentationLayer
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            dgvAllUsers.DataSource = clsUsers.GetAllUsers();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }
    }
}
