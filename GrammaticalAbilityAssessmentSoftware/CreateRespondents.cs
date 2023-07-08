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

namespace GrammaticalAbilityAssessmentSoftware
{
    public partial class CreateRespondents : Form
    {
        private readonly SelectRole role;
        RespondentController respondentController;
        public CreateRespondents(SelectRole role)
        {
            InitializeComponent();

            respondentController = new RespondentController();
            this.role = role;
        }

        private void btnSaveRespondents_Click(object sender, EventArgs e)
        {
            Respondent respondent = new Respondent
            {
                Name = txtName.Text
            };

            respondentController.AddRespondent(respondent);

            respondent.ID = respondentController.NewCreatedRespondentID;

            this.Hide();
            this.txtName.Text = "";
            QuizForm quizForm = new QuizForm(respondent, this);
            quizForm.Show();
        }

        private void CreateRespondents_FormClosed(object sender, FormClosedEventArgs e)
        {
            role.Show();
        }
    }
}
