namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    partial class QuestionAnswerForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtQuestion = new TextBox();
            label1 = new Label();
            textLine = new Panel();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.BorderStyle = BorderStyle.FixedSingle;
            txtQuestion.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.Location = new Point(3, 3);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ReadOnly = true;
            txtQuestion.ScrollBars = ScrollBars.Vertical;
            txtQuestion.Size = new Size(383, 159);
            txtQuestion.TabIndex = 0;
            txtQuestion.Text = "Test Question for noun";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 185);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 1;
            label1.Text = "Your Answer:";
            // 
            // textLine
            // 
            textLine.BackColor = Color.FromArgb(64, 64, 64);
            textLine.Location = new Point(115, 210);
            textLine.Name = "textLine";
            textLine.Size = new Size(235, 1);
            textLine.TabIndex = 18;
            // 
            // txtAnswer
            // 
            txtAnswer.BorderStyle = BorderStyle.None;
            txtAnswer.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnswer.Location = new Point(114, 177);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(236, 30);
            txtAnswer.TabIndex = 17;
            txtAnswer.Text = "test answer";
            // 
            // QuestionAnswerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textLine);
            Controls.Add(txtAnswer);
            Controls.Add(label1);
            Controls.Add(txtQuestion);
            Name = "QuestionAnswerForm";
            Size = new Size(389, 230);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion;
        private Label label1;
        private Panel textLine;
        public TextBox txtAnswer;
    }
}
