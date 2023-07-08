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
    public partial class QuestionAnswerCreation : Form
    {
        private SubjectLevel subject;
        private Main mainForm;
        public QuestionAnswerCreation(SubjectLevel subject, Main mainForm)
        {
            InitializeComponent();

            this.subject = subject;
            this.mainForm = mainForm;

            lblCategory.Text = this.subject.Parts.ToString();
        }

        public QuestionAnswerCreation(SubjectLevel subject)
        {
            InitializeComponent();

            this.subject = subject;

            lblCategory.Text = this.subject.Parts.ToString();
        }

        private void btnSaveQA_Click(object sender, EventArgs e)
        {
            SubjectController subjectController = new SubjectController();
            this.subject.QuestionAnswer.Add(new QA
            {
                Question = txtQuestion.Text,
                Answer = txtAnswer.Text,
                QuestionNumber = (int)questionNumber.Value
            });

            subjectController.AddQuestion(subject);
            mainForm.LoadQuestionAnswer();
            this.Close();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            SubjectController subjectController = new SubjectController();

            this.subject.QuestionAnswer.Add(new QA
            {
                Question = txtQuestion.Text,
                Answer = txtAnswer.Text,
                QuestionNumber = (int)questionNumber.Value
            });

            txtAnswer.Text = "";
            txtQuestion.Text = "";
            txtQuestion.Focus();

            subjectController.AddQuestion(subject);
            mainForm.LoadQuestionAnswer();

            this.subject.QuestionAnswer.Clear();
        }
    }
}
