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
    public partial class QuizForm : Form
    {
        private Quiz quizzes;
        private Respondent respondent;
        CreateRespondents createRespondentsForm;
        public QuizForm(Respondent respondent, CreateRespondents createRespondentsForm)
        {
            InitializeComponent();

            this.respondent = respondent;
            this.createRespondentsForm = createRespondentsForm;

            this.lblUser.Text = this.respondent.Name;

            //LoadSubjects();
            quizzes = new Quiz(this, this.respondent);
            mainPanel.Controls.Add(quizzes);
        }

        public void CloseWindow()
        {
            createRespondentsForm.Show();
            this.Dispose();
        }

        public void LoadSubjects(string currentSubject, string correctAnswerCount)
        {
            CurrentSubjectTest subject;

            partsPanel.Controls.Add(subject = new CurrentSubjectTest(currentSubject, correctAnswerCount));
        }

        private void QuizForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createRespondentsForm.Show();
        }
    }
}
