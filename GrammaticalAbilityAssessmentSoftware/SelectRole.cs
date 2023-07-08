using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrammaticalAbilityAssessmentSoftware
{
    public partial class SelectRole : Form
    {
        public SelectRole()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.btnAdmin.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnAdmin.Visible = true;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == "ericpaulin")
            {
                this.Hide();
                this.txtPin.Text = "";
                this.btnAdmin.Visible = true;
                AdminAccess admin = new AdminAccess(this);
                admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid Pin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRespondents_Click(object sender, EventArgs e)
        {
            CreateRespondents respForm = new CreateRespondents(this);
            respForm.Show();
            this.Hide();
        }
    }
}
