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
    public partial class CurrentSubjectTest : UserControl
    {
        private readonly string subject;
        private readonly string correctAnswerCount;

        public CurrentSubjectTest(string subject, string correctAnswerCount)
        {
            InitializeComponent();
            this.subject = subject;
            this.correctAnswerCount = correctAnswerCount;

            this.lblCorrectAnswer.Text = $"Total Correct Answers: {this.correctAnswerCount}";
            this.lblSubject.Text = this.subject;
        }
    }
}
