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
    public partial class frmHomeDashboard : Form
    {
        public frmHomeDashboard()
        {
            InitializeComponent();
            MyConfig.frmHomeDashboard = this;
        }

        private frmDigitalTwinCreationPage frmDigitalTwinCreation = new frmDigitalTwinCreationPage();
        private frmSimulationManagementPage frmSimulationManagementPage = new frmSimulationManagementPage();    
        private frmPerfrmformanceAnalysisPage frmPerfrmformanceAnalyser = new frmPerfrmformanceAnalysisPage();  
        private frmDesignIterationPage frmDesignIterationPage = new frmDesignIterationPage();   
        private frmDataManagementPage frmDataManagementPage = new frmDataManagementPage();
        private frmCollaborationPage frmCollaborationPage = new frmCollaborationPage();
        private frmUserManagementPage frmUserManagementPage = new frmUserManagementPage();
        private frmSettingsPage frmSettingsPage = new frmSettingsPage();    
        private frmHelpandSupportPage frmHelpandSupportPage = new frmHelpandSupportPage();
        private frmFeedbackPage frmFeedbackPage = new frmFeedbackPage();
      

        private void mnusimulationManagementPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSimulationManagementPage.MdiParent = this;
            frmSimulationManagementPage.Show();
            frmSimulationManagementPage.Activate();

        }

        private void mnuperformanceAnalysisPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfrmformanceAnalyser.MdiParent = this;
            frmPerfrmformanceAnalyser.Show();
            frmPerfrmformanceAnalyser.Activate();
        }

        private void mnudesignIterationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesignIterationPage.MdiParent = this;
            frmDesignIterationPage.Show();
            frmDesignIterationPage.Activate();
        }

        private void mnudataManagementPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataManagementPage.MdiParent = this;
            frmDataManagementPage.Show();
            frmDataManagementPage.Activate();
        }

        private void mnucollaborationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCollaborationPage.MdiParent = this;
            frmCollaborationPage.Show();
            frmCollaborationPage.Activate();
        }

        private void mnuuserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagementPage.MdiParent = this;
            frmUserManagementPage.Show();
            frmUserManagementPage.Activate();
        }

        private void mnusettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettingsPage.MdiParent = this;
            frmSettingsPage.Show();
            frmSettingsPage.Activate();
        }

        private void mnuhelpAndSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpandSupportPage.MdiParent = this;
            frmHelpandSupportPage.Show();
            frmHelpandSupportPage.Activate();
        }

        private void mnufeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeedbackPage.MdiParent = this;
            frmFeedbackPage.Show();
            frmFeedbackPage.Activate();
        }

        private void mnuDigitalTwinCreationPage_Click(object sender, EventArgs e)
        {
            frmDigitalTwinCreation.MdiParent = this;
            frmDigitalTwinCreation.Show();
            frmDigitalTwinCreation.Activate();
        }
    }
}
