namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    partial class CurrentSubjectTest
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
            lblSubject = new Label();
            lblCorrectAnswer = new Label();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubject.Location = new Point(3, 15);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(276, 36);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "SENTENCE STRUCTURE";
            lblSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorrectAnswer
            // 
            lblCorrectAnswer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorrectAnswer.Location = new Point(13, 51);
            lblCorrectAnswer.Name = "lblCorrectAnswer";
            lblCorrectAnswer.Size = new Size(257, 28);
            lblCorrectAnswer.TabIndex = 1;
            lblCorrectAnswer.Text = "Total Correct Answers: ";
            lblCorrectAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentSubjectTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            Controls.Add(lblCorrectAnswer);
            Controls.Add(lblSubject);
            Name = "CurrentSubjectTest";
            Size = new Size(282, 94);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSubject;
        private Label lblCorrectAnswer;
    }
}
