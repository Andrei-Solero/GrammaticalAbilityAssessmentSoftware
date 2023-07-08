namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    partial class Quiz
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            userProfilePanel = new Panel();
            lblIntruction = new Label();
            lblSubjectHeader = new Label();
            scoreBoard = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            quizFormPanel = new FlowLayoutPanel();
            btnSubmitAnswer = new Button();
            lblWarning = new Label();
            createNewRespondents = new LinkLabel();
            label2 = new Label();
            lblGPS = new Label();
            lblGPL = new Label();
            userProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scoreBoard).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // userProfilePanel
            // 
            userProfilePanel.BackColor = Color.LightSeaGreen;
            userProfilePanel.Controls.Add(lblIntruction);
            userProfilePanel.Controls.Add(lblSubjectHeader);
            userProfilePanel.Location = new Point(5, 5);
            userProfilePanel.Margin = new Padding(0);
            userProfilePanel.Name = "userProfilePanel";
            userProfilePanel.Size = new Size(415, 66);
            userProfilePanel.TabIndex = 1;
            // 
            // lblIntruction
            // 
            lblIntruction.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIntruction.Location = new Point(8, 0);
            lblIntruction.Name = "lblIntruction";
            lblIntruction.Size = new Size(399, 41);
            lblIntruction.TabIndex = 2;
            lblIntruction.Text = "Instruction for each level goes here";
            lblIntruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubjectHeader
            // 
            lblSubjectHeader.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubjectHeader.Location = new Point(8, 41);
            lblSubjectHeader.Name = "lblSubjectHeader";
            lblSubjectHeader.Size = new Size(399, 25);
            lblSubjectHeader.TabIndex = 1;
            lblSubjectHeader.Text = "Sentence Structure";
            lblSubjectHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreBoard
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            scoreBoard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            scoreBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            scoreBoard.BackgroundColor = Color.White;
            scoreBoard.BorderStyle = BorderStyle.None;
            scoreBoard.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            scoreBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            scoreBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scoreBoard.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            scoreBoard.DefaultCellStyle = dataGridViewCellStyle3;
            scoreBoard.EnableHeadersVisualStyles = false;
            scoreBoard.Location = new Point(459, 19);
            scoreBoard.Name = "scoreBoard";
            scoreBoard.ReadOnly = true;
            scoreBoard.RowHeadersVisible = false;
            scoreBoard.RowTemplate.Height = 25;
            scoreBoard.Size = new Size(200, 281);
            scoreBoard.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "WORD CLASS";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "FREQ. OF ERRORS";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "TRANS MUTED ERRORS";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(449, 306);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 110);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblGPL);
            panel3.Controls.Add(lblGPS);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(114, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(108, 110);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(114, 110);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(105, 40);
            label3.TabIndex = 1;
            label3.Text = "Grammar Profiency Level";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 40);
            label1.TabIndex = 0;
            label1.Text = "Grammar Profiency Score";
            // 
            // quizFormPanel
            // 
            quizFormPanel.AutoScroll = true;
            quizFormPanel.BorderStyle = BorderStyle.FixedSingle;
            quizFormPanel.FlowDirection = FlowDirection.TopDown;
            quizFormPanel.Location = new Point(5, 84);
            quizFormPanel.Margin = new Padding(0);
            quizFormPanel.Name = "quizFormPanel";
            quizFormPanel.Size = new Size(415, 366);
            quizFormPanel.TabIndex = 4;
            quizFormPanel.WrapContents = false;
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.BackColor = Color.DeepSkyBlue;
            btnSubmitAnswer.Cursor = Cursors.Hand;
            btnSubmitAnswer.FlatStyle = FlatStyle.Flat;
            btnSubmitAnswer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitAnswer.ForeColor = Color.White;
            btnSubmitAnswer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmitAnswer.ImageKey = "diskette.png";
            btnSubmitAnswer.Location = new Point(8, 452);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(213, 34);
            btnSubmitAnswer.TabIndex = 16;
            btnSubmitAnswer.Text = "Submit Answers";
            btnSubmitAnswer.UseVisualStyleBackColor = false;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // lblWarning
            // 
            lblWarning.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.FromArgb(0, 0, 192);
            lblWarning.Location = new Point(227, 452);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(193, 34);
            lblWarning.TabIndex = 17;
            lblWarning.Text = "Please answer all the questions provided.";
            lblWarning.Visible = false;
            // 
            // createNewRespondents
            // 
            createNewRespondents.AutoSize = true;
            createNewRespondents.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createNewRespondents.Location = new Point(546, 458);
            createNewRespondents.Name = "createNewRespondents";
            createNewRespondents.Size = new Size(125, 21);
            createNewRespondents.TabIndex = 18;
            createNewRespondents.TabStop = true;
            createNewRespondents.Text = "New Respondent";
            createNewRespondents.Visible = false;
            createNewRespondents.LinkClicked += createNewRespondents_LinkClicked;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(449, 419);
            label2.Name = "label2";
            label2.Size = new Size(222, 34);
            label2.TabIndex = 19;
            label2.Text = "Note: Results are computed after you completed the test.";
            label2.Visible = false;
            // 
            // lblGPS
            // 
            lblGPS.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGPS.Location = new Point(1, 8);
            lblGPS.Name = "lblGPS";
            lblGPS.Size = new Size(105, 40);
            lblGPS.TabIndex = 2;
            lblGPS.Text = "- ";
            lblGPS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGPL
            // 
            lblGPL.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGPL.Location = new Point(1, 59);
            lblGPL.Name = "lblGPL";
            lblGPL.Size = new Size(105, 40);
            lblGPL.TabIndex = 3;
            lblGPL.Text = "- ";
            lblGPL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(createNewRespondents);
            Controls.Add(lblWarning);
            Controls.Add(btnSubmitAnswer);
            Controls.Add(quizFormPanel);
            Controls.Add(panel1);
            Controls.Add(scoreBoard);
            Controls.Add(userProfilePanel);
            Name = "Quiz";
            Padding = new Padding(5);
            Size = new Size(699, 494);
            userProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scoreBoard).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel userProfilePanel;
        private Label lblSubjectHeader;
        private DataGridView scoreBoard;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private FlowLayoutPanel quizFormPanel;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Button btnSubmitAnswer;
        private Label lblWarning;
        private LinkLabel createNewRespondents;
        private Label lblIntruction;
        private Label label2;
        private Label lblGPL;
        private Label lblGPS;
    }
}
