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
    public partial class QuizResult : UserControl
    {
        private readonly RespondentsResult resultForm;
        private readonly SubjectLevel subject;
        private readonly Respondent respondent;
        private ResultController resultController;

        public QuizResult(RespondentsResult resultForm, SubjectLevel subject, Respondent respondent)
        {
            InitializeComponent();
            this.resultForm = resultForm;
            this.subject = subject;
            this.respondent = respondent;

            this.lblSubjectHeader.Text = $"Quiz result for subject {this.subject.Parts}";

            LoadRespondentsQuizResult();
            LoadFrequencyErrorByRespondent();
            LoadGrammarProficiencyResult();
        }

        public void LoadFrequencyErrorByRespondent()
        {
            ResultController resultController = new ResultController();
            SubjectLevelTemplate template;
            var subjectLevels = resultController.FreqErrorCountByRespondent(this.respondent);

            scoreBoard.RowCount = subjectLevels.Count;
            for (int i = 0; i < subjectLevels.Count; i++)
            {
                scoreBoard.Rows[i].Cells[0].Value = subjectLevels[i].Code;
                scoreBoard.Rows[i].Cells[1].Value = subjectLevels[i].ErrorCount;
                scoreBoard.Rows[i].Cells[2].Value = subjectLevels[i].TransmutedError;
            }
        }

        public void LoadRespondentsQuizResult()
        {
            resultController = new ResultController();
            var results = resultController.RespondentResult(this.respondent, this.subject);
            QuizAnswerFormWithResult resultForm;

            quizFormPanel.Controls.Clear();
            foreach (var result in results.Subject.QuestionAnswer)
            {
                resultForm = new QuizAnswerFormWithResult(result, this.respondent);
                quizFormPanel.Controls.Add(resultForm);
            }
        }

        public void LoadGrammarProficiencyResult()
        {
            resultController = new ResultController();
            string questionCount = "";

            var finalResult = resultController.FinalResult(this.respondent, out questionCount);
            this.lblGPS.Text = $"{finalResult.GrammarProficiencyScore} / {questionCount}";
            this.lblGPA.Text = finalResult.GrammarProficiencyAverage;
            this.lblGPL.Text = finalResult.GrammarProficiencyLevel;
        }

    }
}
