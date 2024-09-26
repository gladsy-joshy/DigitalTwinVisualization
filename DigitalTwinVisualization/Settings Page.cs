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
    public partial class frmSettingsPage : Form
    {
        public frmSettingsPage()
        {
            InitializeComponent();
        }

        private void frmSettingsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
