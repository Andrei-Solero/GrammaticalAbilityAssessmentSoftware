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
    public partial class QuestionAnswerForm : UserControl
    {
        QA questionAnswers;
        public QA Answer
        {
            get
            {
                return new QA
                {
                    ID = this.questionAnswers.ID,
                    Question = this.questionAnswers.Question,
                    Answer = this.txtAnswer.Text
                };
            }
        }
        public QuestionAnswerForm(QA questionAnswers)
        {
            InitializeComponent();

            this.questionAnswers = questionAnswers;
            this.txtQuestion.Text = this.questionAnswers.Question;
        }
    }
}
