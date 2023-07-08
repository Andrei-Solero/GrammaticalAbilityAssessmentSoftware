using GAASBusinessLogicLibrary._Models;
using GrammaticalAbilityAssessmentSoftware._Controller;
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
    public partial class QuestionAnswer : UserControl
    {
        private QA questionAnswer;
        private SubjectController subjectController;
        Main mainForm;
        public QuestionAnswer(QA questionAnswer, Main mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            this.questionAnswer = questionAnswer;
            txtQuestion.Text = this.questionAnswer.Question;
            txtAnswer.Text = this.questionAnswer.Answer;
            questionNumber.Value = this.questionAnswer.QuestionNumber;
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (btnEditQuestion.Text == "Edit Question")
            {
                txtQuestion.ReadOnly = false;
                txtAnswer.ReadOnly = false;
                btnEditQuestion.Text = "Save Changes";
                btnEditQuestion.ImageIndex = 2;
            }
            else
            {
                txtQuestion.ReadOnly = true;
                txtAnswer.ReadOnly = true;
                btnEditQuestion.Text = "Edit Question";
                btnEditQuestion.ImageIndex = 1;

                QA editedQuestion = new QA
                {
                    Question = txtQuestion.Text,
                    Answer = txtAnswer.Text,
                    ID = questionAnswer.ID,
                    QuestionNumber = (int)questionNumber.Value
                };

                subjectController = new SubjectController();
                subjectController.ModifyQuestion(editedQuestion);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure you want to delete this Question?", "Delete Question", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (delete == DialogResult.Yes)
            {
                SubjectController subjectController = new SubjectController();
                subjectController.DeleteQuestion(this.questionAnswer);

                this.mainForm.LoadQuestionAnswer();
            }
        }
    }
}
