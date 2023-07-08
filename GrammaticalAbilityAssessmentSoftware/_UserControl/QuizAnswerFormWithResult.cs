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
    public partial class QuizAnswerFormWithResult : UserControl
    {
        private readonly QA answerResult;
        private readonly Respondent respondent;

        public QuizAnswerFormWithResult(QA answerResult, Respondent respondent)
        {
            InitializeComponent();
            this.answerResult = answerResult;
            this.respondent = respondent;

            this.txtAnswer.Text = this.answerResult.Answer;
            this.txtQuestion.Text = this.answerResult.Question;

            if (this.answerResult.Result == "Correct")
            {
                this.txtAnswer.ForeColor = Color.Green;
                this.image.ImageIndex = 0;
            }
            else
            {
                this.txtAnswer.ForeColor = Color.Red;
                this.image.ImageIndex = 1;
            }
        }
    }
}
