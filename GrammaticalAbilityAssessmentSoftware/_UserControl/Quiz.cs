using GAASBusinessLogicLibrary._Models;
using GrammaticalAbilityAssessmentSoftware._Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    public partial class Quiz : UserControl
    {
        BindingSource bs = new BindingSource();
        SubjectController? subjectController;
        RespondentController respondentController;
        ComputationController computationController;

        int subjectCounter = 0;
        int correctCounter = 0;
        int incorrectCounter = 0;

        SubjectLevel currentSubject;
        Respondent respondent;

        QuestionAnswerForm qaForm;
        QuizForm mainQuiz;

        public Quiz(QuizForm mainQuiz, Respondent respondent)
        {
            InitializeComponent();
            subjectController = new SubjectController();
            respondentController = new RespondentController();
            computationController = new ComputationController();

            this.mainQuiz = mainQuiz;
            this.respondent = respondent;

            var subjects = LoadSubjects();
            this.currentSubject = subjects[subjectCounter];

            LoadQuestionOrderBySubject();

            this.lblSubjectHeader.Text = subjects[subjectCounter].Parts.ToUpper();
            this.lblIntruction.Text = subjects[subjectCounter].Instruction;
        }

        private List<SubjectLevel> LoadSubjects()
        {
            var subjects = subjectController.GetSubjectLevel();

            scoreBoard.RowCount = subjects.Count;
            for (int i = 0; i < subjects.Count; i++)
            {
                scoreBoard.Rows[i].Cells[0].Value = subjects[i].Code;
            }

            return subjects;
        }

        private void LoadQuestionOrderBySubject()
        {
            var sortedSubjects = subjectController.GetSortedSubjectQuestions(currentSubject);

            quizFormPanel.Controls.Clear();
            foreach (var qa in sortedSubjects.QuestionAnswer)
            {
                qaForm = new QuestionAnswerForm(qa);
                quizFormPanel.Controls.Add(qaForm);
            }
        }

        private void SaveAnswersAndResult(string userAnswer, string result, int counter)
        {
            this.respondent.UserAnswer = new QA { Answer = userAnswer };
            var sortedSubjects = subjectController.GetSortedSubjectQuestions(currentSubject);

            respondentController.SubmitAnswers(this.respondent, sortedSubjects, result, counter);
        }

        private void SaveFrequencyOfError(int FrequenceOfError)
        {
            respondentController.SubmitFrequencyOfError(this.respondent, currentSubject, FrequenceOfError);
        }

        public void LoadGrammarProficiencyResult()
        {
            ResultController resultController = new ResultController();
            string questionCount = "";

            var finalResult = resultController.FinalResult(this.respondent, out questionCount);
            this.lblGPS.Text = $"{finalResult.GrammarProficiencyScore} / {questionCount}";
            this.lblGPL.Text = finalResult.GrammarProficiencyLevel;
        }


        public void LoadFrequencyErrorByRespondent()
        {
            ResultController resultController = new ResultController();
            SubjectLevelTemplate template;
            var subjectLevels = resultController.FreqErrorCountByRespondent(this.respondent);

            scoreBoard.Rows.Clear();
            scoreBoard.RowCount = subjectLevels.Count;
            for (int i = 0; i < subjectLevels.Count; i++)
            {
                scoreBoard.Rows[i].Cells[0].Value = subjectLevels[i].Code;
                scoreBoard.Rows[i].Cells[1].Value = subjectLevels[i].ErrorCount;
                scoreBoard.Rows[i].Cells[2].Value = subjectLevels[i].TransmutedError;
            }
        }

        int counter = 0;
        int questionCounter = 0;

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            bool isCompleted = true;
            if (btnSubmitAnswer.Text == "Submit Answers")
            {
                foreach (QuestionAnswerForm qaForm in quizFormPanel.Controls)
                {
                    if (qaForm.txtAnswer.Text != "")
                    {
                        var results = subjectController.CheckAnswer(qaForm.Answer);
                        if (results == false)
                        {
                            incorrectCounter++;
                            qaForm.txtAnswer.ForeColor = Color.Red;
                            SaveAnswersAndResult(qaForm.txtAnswer.Text, "Incorrect", this.counter);
                        }
                        else
                        {
                            correctCounter++;
                            qaForm.txtAnswer.ForeColor = Color.Green;
                            SaveAnswersAndResult(qaForm.txtAnswer.Text, "Correct", this.counter);
                        }

                        counter++;
                    }
                    else
                    {
                        lblWarning.Visible = true;
                        qaForm.txtAnswer.BackColor = Color.Yellow;
                        isCompleted = false;
                    }
                }

                if (isCompleted == true)
                {
                    SaveFrequencyOfError(incorrectCounter);
                    mainQuiz.LoadSubjects(lblSubjectHeader.Text, correctCounter.ToString());
                    btnSubmitAnswer.Text = "Go to Next Level";
                    correctCounter = 0;
                    incorrectCounter = 0;
                }
            }
            else
            {
                this.counter = 0;
                btnSubmitAnswer.Text = "Submit Answers";
                correctCounter = 0;
                incorrectCounter = 0;

                var subjects = subjectController.GetSubjectLevel();

                if (subjectCounter == subjects.Count - 1)
                {
                    MessageBox.Show("Congratulations! You have answered all the questions.", "Next Respondents", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    createNewRespondents.Visible = true;

                    computationController.Compute(respondent.ID, true, null);
                    computationController.ComputeProficiency(respondent);

                    LoadFrequencyErrorByRespondent();
                    LoadGrammarProficiencyResult();
                }
                else
                {
                    subjectCounter++;
                    this.currentSubject = subjects[subjectCounter];
                    LoadQuestionOrderBySubject();
                    this.lblSubjectHeader.Text = subjects[subjectCounter].Parts.ToUpper();
                }
            }
        }

        private void createNewRespondents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainQuiz.CloseWindow();
        }
    }
}
