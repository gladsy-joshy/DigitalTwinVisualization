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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        private User user = new User { Name = "", Email = "", Password = "", Role = "" };
        private bool IsNew { get; set; } = true;
        private string SaveActionText { get => (IsNew ? "Create Contact" : "Update Contact"); }
        private IRepo repo = new ListMemoryRepo();

        private void DoNewUser()
        {
            //new user object
            user = new User { Name = "", Email = "", Password = "", Role = "" };
            //object to UIs
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            txtRole.Text = user.Role;
            //new mode out of edit & new modes
            IsNew = true;
            btnCreate.Text = SaveActionText;
            txtEmail.Enabled = IsNew;
            //
            txtName.Focus();
        }
        private void DoCreate()
        {
            var result = MessageBox.Show(text: "Are you sure to create?",
                                         caption: "Confirm",
                                         buttons: MessageBoxButtons.YesNo,
                                         icon: MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            //UIs to object
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            //db create in CRUD
            repo.Create(user);
            //
            result = MessageBox.Show(text: "Created Successfully",
                                     caption: "Alert",
                                     buttons: MessageBoxButtons.OK,
                                     icon: MessageBoxIcon.Information);
            //Refresh the form 1. refresh list 2. referesh form (new contact mode)
            DoNewUser();
        }

       

        private void New_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            DoCreate();

        }
    }
}
