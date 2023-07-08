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
    public partial class Main : UserControl
    {
        private SubjectLevel levelData;
        private AdminAccess adminForm;
        public Main(AdminAccess adminForm, SubjectLevel levelData)
        {
            InitializeComponent();

            this.levelData = levelData;
            this.adminForm = adminForm;

            lblPartsTitle.Text = this.levelData.Parts;
            lblCode.Text = $"Code: {this.levelData.Code.ToString()}";
            lblLevel.Text = $"Level: {this.levelData.Level.ToString()}";
            lblWeight.Text = $"Weight: {this.levelData.Weight.ToString()}";
            lblInstruction.Text = $"Instruction: {this.levelData.Instruction.ToString()}";


            LoadQuestionAnswer();
        }

        public void LoadQuestionAnswer()
        {
            SubjectController subjectController = new SubjectController();
            var listQuestionAnswer = subjectController.GetSubjectQuestions(levelData);
            QuestionAnswer qaForm;

            listQA.Controls.Clear();
            foreach (var qa in listQuestionAnswer.QuestionAnswer)
            {
                qaForm = new QuestionAnswer(qa, this);
                listQA.Controls.Add(qaForm);
            }

            lblNumberOfQuestion.Text = $"Number of Questions: {listQuestionAnswer.QuestionAnswer.Count.ToString()}";
        }

        private void btnCreateNewQuestion_Click(object sender, EventArgs e)
        {
            QuestionAnswerCreation qaForm = new QuestionAnswerCreation(this.levelData, this);
            qaForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PartsCreation createSubject = new PartsCreation(adminForm, this.levelData, true);
            createSubject.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure you want to delete this subject and its questions?", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (delete == DialogResult.Yes)
            {
                SubjectController subjectController = new SubjectController();
                subjectController.DeleteSubjectData(this.levelData);

                adminForm.LoadSubjects();
            }
        }

        private void btnDeleteAllQuestion_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure you want to delete this subject and its questions?", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                SubjectController subjectController = new SubjectController();
                subjectController.DeleteSubjectData(this.levelData);

                adminForm.LoadSubjects();
            }
        }

        private void btnDeleteAllQuestions_Click(object sender, EventArgs e)
        {
            DialogResult deleteAll = MessageBox.Show("Are you sure you want to delete all the questions?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (deleteAll == DialogResult.Yes)
            {
                SubjectController subjectController = new SubjectController();
                subjectController.DeleteAllQuestions(this.levelData);

                LoadQuestionAnswer();
            }
        }
    }
}
