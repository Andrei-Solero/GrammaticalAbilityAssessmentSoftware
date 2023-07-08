using GAASBusinessLogicLibrary._Models;
using GrammaticalAbilityAssessmentSoftware._Controller;
using GrammaticalAbilityAssessmentSoftware._UserControl;
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
    public partial class AdminAccess : Form
    {
        private readonly SelectRole role;

        public AdminAccess(SelectRole role)
        {
            InitializeComponent();
            LoadSubjects();

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, adminProfile.Width - 3, adminProfile.Height - 3);
            Region rg = new Region(gp);
            adminProfile.Region = rg;
            this.role = role;
        }

        public void LoadSubjectDetails(SubjectLevel levelData)
        {
            Main subjectData = new Main(this, levelData);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(subjectData);
        }

        public void LoadSubjects()
        {
            SubjectController subjectController = new SubjectController();
            SubjectLevelTemplate template;
            var subjectLevels = subjectController.GetSubjectLevel();

            partsPanel.Controls.Clear();
            mainPanel.Controls.Clear();
            foreach (var subjectLevel in subjectLevels)
            {
                partsPanel.Controls.Add(template = new SubjectLevelTemplate(subjectLevel, this));
            }
        }

        private void btnCreateNewLevel_Click(object sender, EventArgs e)
        {
            PartsCreation partsCreation = new PartsCreation(this);
            partsCreation.ShowDialog();
        }

        private void btnRespondents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Respondents frmResp = new Respondents(this);
            frmResp.Show();
        }

        private void AdminAccess_FormClosed(object sender, FormClosedEventArgs e)
        {
            role.Show();
        }
    }
}