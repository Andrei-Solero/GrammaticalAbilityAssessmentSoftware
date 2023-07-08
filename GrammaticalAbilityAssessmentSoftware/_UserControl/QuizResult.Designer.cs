namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    partial class QuizResult
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
            lblSubjectHeader = new Label();
            scoreBoard = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            lblGPL = new Label();
            lblGPA = new Label();
            lblGPS = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            quizFormPanel = new FlowLayoutPanel();
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
            userProfilePanel.Controls.Add(lblSubjectHeader);
            userProfilePanel.Location = new Point(16, 7);
            userProfilePanel.Margin = new Padding(0);
            userProfilePanel.Name = "userProfilePanel";
            userProfilePanel.Size = new Size(415, 59);
            userProfilePanel.TabIndex = 19;
            // 
            // lblSubjectHeader
            // 
            lblSubjectHeader.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubjectHeader.Location = new Point(-2, 0);
            lblSubjectHeader.Name = "lblSubjectHeader";
            lblSubjectHeader.Size = new Size(399, 59);
            lblSubjectHeader.TabIndex = 1;
            lblSubjectHeader.Text = "subject";
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
            scoreBoard.Location = new Point(464, 24);
            scoreBoard.Name = "scoreBoard";
            scoreBoard.ReadOnly = true;
            scoreBoard.RowHeadersVisible = false;
            scoreBoard.RowTemplate.Height = 25;
            scoreBoard.Size = new Size(200, 323);
            scoreBoard.TabIndex = 20;
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
            panel1.Location = new Point(443, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 179);
            panel1.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblGPL);
            panel3.Controls.Add(lblGPA);
            panel3.Controls.Add(lblGPS);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(130, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(115, 179);
            panel3.TabIndex = 5;
            // 
            // lblGPL
            // 
            lblGPL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGPL.Location = new Point(3, 120);
            lblGPL.Name = "lblGPL";
            lblGPL.Size = new Size(105, 52);
            lblGPL.TabIndex = 3;
            lblGPL.Text = "ADVANCED HIGH";
            lblGPL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGPA
            // 
            lblGPA.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGPA.Location = new Point(3, 68);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(105, 40);
            lblGPA.TabIndex = 2;
            lblGPA.Text = "- ";
            lblGPA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGPS
            // 
            lblGPS.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGPS.Location = new Point(5, 11);
            lblGPS.Name = "lblGPS";
            lblGPS.Size = new Size(105, 40);
            lblGPS.TabIndex = 1;
            lblGPS.Text = "- ";
            lblGPS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 179);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 126);
            label2.Name = "label2";
            label2.Size = new Size(105, 40);
            label2.TabIndex = 2;
            label2.Text = "Grammar Profiency Level";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 69);
            label3.Name = "label3";
            label3.Size = new Size(123, 40);
            label3.TabIndex = 1;
            label3.Text = "Grammar Profiency Average";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 12);
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
            quizFormPanel.Location = new Point(16, 73);
            quizFormPanel.Margin = new Padding(0);
            quizFormPanel.Name = "quizFormPanel";
            quizFormPanel.Size = new Size(415, 459);
            quizFormPanel.TabIndex = 22;
            quizFormPanel.WrapContents = false;
            // 
            // QuizResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userProfilePanel);
            Controls.Add(scoreBoard);
            Controls.Add(panel1);
            Controls.Add(quizFormPanel);
            Name = "QuizResult";
            Size = new Size(699, 551);
            userProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scoreBoard).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel userProfilePanel;
        private Label lblSubjectHeader;
        private DataGridView scoreBoard;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private FlowLayoutPanel quizFormPanel;
        private Label lblGPS;
        private Label label2;
        private Label lblGPL;
        private Label lblGPA;
    }
}
