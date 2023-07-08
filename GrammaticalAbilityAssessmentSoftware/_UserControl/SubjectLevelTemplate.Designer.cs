namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    partial class SubjectLevelTemplate
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
            lblPartsTitle = new Label();
            lblNoQuestionsCode = new Label();
            SuspendLayout();
            // 
            // lblPartsTitle
            // 
            lblPartsTitle.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPartsTitle.Location = new Point(3, 5);
            lblPartsTitle.Name = "lblPartsTitle";
            lblPartsTitle.Size = new Size(279, 56);
            lblPartsTitle.TabIndex = 0;
            lblPartsTitle.Text = "label1";
            lblPartsTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblPartsTitle.Click += lblPartsTitle_Click;
            // 
            // lblNoQuestionsCode
            // 
            lblNoQuestionsCode.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoQuestionsCode.Location = new Point(3, 61);
            lblNoQuestionsCode.Name = "lblNoQuestionsCode";
            lblNoQuestionsCode.Size = new Size(279, 32);
            lblNoQuestionsCode.TabIndex = 1;
            lblNoQuestionsCode.Text = "label2";
            lblNoQuestionsCode.TextAlign = ContentAlignment.MiddleCenter;
            lblNoQuestionsCode.Click += lblNoQuestionsCode_Click;
            // 
            // SubjectLevelTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblNoQuestionsCode);
            Controls.Add(lblPartsTitle);
            Cursor = Cursors.Hand;
            Name = "SubjectLevelTemplate";
            Size = new Size(285, 99);
            Click += SubjectLevelTemplate_Click;
            ResumeLayout(false);
        }

        #endregion

        private Label lblPartsTitle;
        private Label lblNoQuestionsCode;
    }
}
