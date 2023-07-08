using GAASBusinessLogicLibrary._Models;
using GrammaticalAbilityAssessmentSoftware._Controller;

namespace GrammaticalAbilityAssessmentSoftware
{
    public partial class Respondents : Form
    {
        private readonly ResultController resultController;
        private readonly RespondentController respondentController;
        private readonly ComputationController computationController;
        private readonly AdminAccess adminForm;

        public Respondents(AdminAccess adminForm)
        {
            InitializeComponent();

            resultController = new ResultController();
            respondentController = new RespondentController();
            computationController = new ComputationController();

            LoadRespondents();
            LoadMostErrors();
            this.adminForm = adminForm;
        }

        private void LoadMostErrors()
        {
            try
            {
                var errorsCount = resultController.FreqErrorCount();

                lblMostSubject.Text = errorsCount[0].Parts;
                lblMostCount.Text = errorsCount[0].ErrorCount.ToString();

                lblLeastSubject.Text = errorsCount[errorsCount.Count - 1].Parts;
                lblLeastCount.Text = errorsCount[errorsCount.Count - 1].ErrorCount.ToString();

                listResult.RowCount = errorsCount.Count;
                for (int i = 0; i < errorsCount.Count; i++)
                {
                    listResult.Rows[i].Cells[0].Value = errorsCount[i].Parts;
                    listResult.Rows[i].Cells[0].Tag = errorsCount[i].LevelID;
                    listResult.Rows[i].Cells[1].Value = errorsCount[i].ErrorCount;
                }
            }
            catch
            {
                MessageBox.Show(this, "Unable to compute the frequencies of error since no tests have been submitted.", "Frequencies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadRespondents()
        {
            var respondents = resultController.GetRespondentsByResults();
            ListViewItem lv = new ListViewItem();

            listRespondents.Items.Clear();
            foreach (var respondent in respondents)
            {
                lv = listRespondents.Items.Add("");
                if (respondent.TransmutedError == 0)
                    lv.SubItems.Add($"{Helper.FormatName(respondent.Name)} | TFE: {respondent.TotalFrequencyOfError}");
                else
                    lv.SubItems.Add($"{Helper.FormatName(respondent.Name)} | TFE: {respondent.TotalFrequencyOfError} | TTE: {respondent.TransmutedError}");

                lv.Tag = respondent.ID.ToString();
            }
        }

        private void listRespondents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Respondent respondent = new Respondent
            {
                ID = Convert.ToInt32(listRespondents.SelectedItems[0].Tag),
                Name = listRespondents.SelectedItems[0].SubItems[1].Text
            };

            RespondentsResult result = new RespondentsResult(respondent, this);
            result.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRespondents();
            LoadMostErrors();
        }

        private void listResult_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var errorsCount = resultController.FreqErrorCount();

            var editWeight = errorsCount.Find(item => item.LevelID.Equals(listResult.SelectedCells[0].Tag));
            PartsCreation editWeights = new PartsCreation(editWeight);
            editWeights.ShowDialog();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Make sure you inserted the correct weights for each subjects.\nProceed to compute?", "Proceed to Compute", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                foreach (var respondent in listRespondents.Items)
                {
                    ListViewItem lv = (ListViewItem)respondent;
                    computationController.Compute(Convert.ToInt32(lv.Tag), true, null);
                }

                computationController.ComputeProficiency(null);
                MessageBox.Show("Grammar Proficieny computed!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm.Show();
        }

        private void btnDeleteRespondent_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure you want to delete all the test result for this respondent?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                Respondent respondent = new Respondent
                {
                    ID = int.Parse(listRespondents.SelectedItems[0].Tag.ToString())
                };
                respondentController.RemoveRespondent(respondent);

                MessageBox.Show("Respondent Deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRespondents();
                LoadMostErrors();
            }
            
        }
    }
}
