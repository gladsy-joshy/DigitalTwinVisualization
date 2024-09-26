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
    public partial class frmDataManagementPage : Form
    {
        public frmDataManagementPage()
        {
            InitializeComponent();
        }

        private void frmDataManagementPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
