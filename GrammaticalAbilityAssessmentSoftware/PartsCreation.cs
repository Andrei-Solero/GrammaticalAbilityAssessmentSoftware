using GAASBusinessLogicLibrary._Models;
using GrammaticalAbilityAssessmentSoftware._Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrammaticalAbilityAssessmentSoftware
{
    public partial class PartsCreation : Form
    {
        private AdminAccess adminForm;
        private bool IsEdit;
        private SubjectLevel? subjectData;
        private readonly FrequencyErrorCount subjectDataWithFrequencyError;

        public PartsCreation(AdminAccess adminForm)
        {
            InitializeComponent();

            this.adminForm = adminForm;
        }

        public PartsCreation(AdminAccess adminForm, SubjectLevel subjectData, bool IsEdit)
        {
            InitializeComponent();

            this.adminForm = adminForm;
            this.IsEdit = IsEdit;
            this.subjectData = subjectData;

            txtTitle.Text = this.subjectData.Parts;
            txtCode.Text = this.subjectData.Code;
            txtLevel.Text = this.subjectData.Level;
            numWeight.Value = decimal.Parse(this.subjectData.Weight.ToString());
            txtInstruction.Text = this.subjectData.Instruction;

            if (this.IsEdit == true)
            {
                lblHeader.Text = "Edit Subject";
                btnSaveParts.Text = "Update";
            }
        }

        bool UpdateWeightsOnly;

        public PartsCreation(SubjectLevel subjectData)
        {
            InitializeComponent();

            this.IsEdit = true;
            this.subjectData = subjectData;
            this.UpdateWeightsOnly = true;

            txtTitle.Text = this.subjectData.Parts;
            txtCode.Text = this.subjectData.Code;
            txtLevel.Text = this.subjectData.Level;
            numWeight.Value = decimal.Parse(this.subjectData.Weight.ToString());
            txtInstruction.Text = this.subjectData.Instruction;

            if (this.IsEdit == true)
            {
                lblHeader.Text = "Edit Subject";
                btnSaveParts.Text = "Update";
            }
        }

        private void SaveData()
        {
            if (IsEdit == false)
            {
                SubjectLevel newSubject = new SubjectLevel
                {
                    Code = txtCode.Text,
                    Level = txtLevel.Text,
                    Parts = txtTitle.Text,
                    Weight = numWeight.Value,
                    Instruction = txtInstruction.Text
                };

                SubjectController subjectController = new SubjectController();
                subjectController.AddLevel(newSubject);

                adminForm.LoadSubjects();
                QuestionAnswerCreation createQuestionForm = new QuestionAnswerCreation(newSubject);
                createQuestionForm.ShowDialog();
                this.Dispose();
            }
            else
            {
                SubjectLevel newSubject = new SubjectLevel
                {
                    Code = txtCode.Text,
                    Level = txtLevel.Text,
                    Parts = txtTitle.Text,
                    Weight = numWeight.Value,
                    Instruction = txtInstruction.Text,
                    LevelID = this.subjectData.LevelID
                };

                SubjectController subjectController = new SubjectController();
                subjectController.UpdateLevel(newSubject);

                if (this.UpdateWeightsOnly != true)
                    adminForm.LoadSubjects();

                this.Close();
            }
        }

        private void btnSaveParts_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtLevel.Text == "" || txtTitle.Text == "")
            {
                MessageBox.Show("Please input all the required fields.", "Invalid Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numWeight.Value < 1)
            {
                DialogResult weights = MessageBox.Show("The inputted weight is less than 0. Are you sure you want to save?", "Subject Weight", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (weights == DialogResult.Yes)
                {
                    SaveData();
                }
            }
            else
            {
                SaveData();
            }
        }
    }
}
