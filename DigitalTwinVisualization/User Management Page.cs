using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalTwinVisualization
{
    public partial class frmUserManagementPage : Form
    {
        public frmUserManagementPage()
        {
            InitializeComponent();
        }
        private NewUser newuser = new NewUser();
        private Edit edit = new Edit();


        private void frmUserManagementPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            newuser.MdiParent = MyConfig.frmHomeDashboard;
            newuser.Show();
            newuser.Activate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit.MdiParent = MyConfig.frmHomeDashboard;
            edit.Show();
            edit.Activate();
        }
    }
}
