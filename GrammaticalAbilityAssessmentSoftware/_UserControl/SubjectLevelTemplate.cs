using GAASBusinessLogicLibrary._Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    public partial class SubjectLevelTemplate : UserControl
    {
        private SubjectLevel? subjectLevel;
        private readonly RespondentsResult resultMain;
        private AdminAccess? adminForm;
        public SubjectLevelTemplate(SubjectLevel subject, AdminAccess adminForm)
        {
            InitializeComponent();
            this.subjectLevel = subject;
            this.adminForm = adminForm;

            lblPartsTitle.Text = subject.Parts;
            lblNoQuestionsCode.Text = $"Weight: {this.subjectLevel.Weight} | Level: {this.subjectLevel.Level} | Code: {this.subjectLevel.Code}";
        }

        public SubjectLevelTemplate(SubjectLevel subject, RespondentsResult resultMain, int freqErrorCount)
        {
            InitializeComponent();
            this.subjectLevel = subject;
            this.resultMain = resultMain;
            lblPartsTitle.Text = subject.Parts;
            lblNoQuestionsCode.Text = $"Frequency of Errors: {freqErrorCount}";
        }

        public SubjectLevelTemplate(SubjectLevel subject)
        {
            InitializeComponent();
            this.subjectLevel = subject;

            lblPartsTitle.Text = subject.Parts;
            lblNoQuestionsCode.Text = $"Weight: {this.subjectLevel.Weight} | Level: {this.subjectLevel.Level} | Code: {this.subjectLevel.Code}";
        }

        private void lblPartsTitle_Click(object sender, EventArgs e)
        {
            if (adminForm != null)
            {
                adminForm.LoadSubjectDetails(subjectLevel);
            }

            if (resultMain != null)
            {
                resultMain.LoadSubjectDetails(subjectLevel);
            }
        }

        private void lblNoQuestionsCode_Click(object sender, EventArgs e)
        {
            if (adminForm != null)
            {
                adminForm.LoadSubjectDetails(subjectLevel);
            }

            if (resultMain != null)
            {
                resultMain.LoadSubjectDetails(subjectLevel);
            }
        }

        private void SubjectLevelTemplate_Click(object sender, EventArgs e)
        {
            if (adminForm != null)
            {
                adminForm.LoadSubjectDetails(subjectLevel);
            }

            if (resultMain != null)
            {
                resultMain.LoadSubjectDetails(subjectLevel);
            }
        }
    }
}
