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
    public partial class RespondentsResult : Form
    {
        private readonly Respondent respondent;
        private readonly Respondents respondentForm;
        private readonly SubjectLevel subject;

        public RespondentsResult(Respondent respondent, Respondents respondentForm)
        {
            InitializeComponent();
            this.respondent = respondent;
            this.respondentForm = respondentForm;
            this.subject = subject;

            this.lblUser.Text = this.respondent.Name;
            Load();
        }

        private void Load()
        {
            LoadSubjectsWithFreqError();
        }

        public void LoadSubjectsWithFreqError()
        {
            ResultController resultController = new ResultController();
            SubjectLevelTemplate template;
            var subjectLevels = resultController.FreqErrorCountByRespondent(this.respondent);

            partsPanel.Controls.Clear();
            mainPanel.Controls.Clear();
            foreach (var subjectLevel in subjectLevels)
            {
                partsPanel.Controls.Add(template = new SubjectLevelTemplate(subjectLevel, this, subjectLevel.ErrorCount));
            }

            subjectLevels.Sort((x, y) => x.ErrorCount.CompareTo(y.ErrorCount));
            lblLeastSubject.Text = subjectLevels[0].Parts.ToString();
            // TODO: Add when there are multiple subjects with same error count, fix the new respondents logic 
            lblMostSubject.Text = subjectLevels[subjectLevels.Count - 1].Parts.ToString();
        }

        public void LoadSubjectDetails(SubjectLevel subject)
        {
            QuizResult quizResult = new QuizResult(this, subject, this.respondent);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(quizResult);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void RespondentsResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            respondentForm.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            respondentForm.Show();
        }
    }
}
