namespace GrammaticalAbilityAssessmentSoftware
{
    partial class Respondents
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Respondents));
            panel1 = new Panel();
            btnCompute = new Button();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            listRespondents = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label4 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            lblSelectedSubject = new Label();
            listResult = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            lblLeastSubject = new Label();
            panel8 = new Panel();
            label8 = new Label();
            lblLeastCount = new Label();
            panel6 = new Panel();
            label2 = new Label();
            lblMostSubject = new Label();
            panel9 = new Panel();
            label3 = new Label();
            lblMostCount = new Label();
            panel3 = new Panel();
            label1 = new Label();
            userProfilePanel = new Panel();
            btnPrevious = new Button();
            imageList1 = new ImageList(components);
            btnRefresh = new Button();
            pictureBox1 = new PictureBox();
            lblUser = new Label();
            btnDeleteRespondent = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listResult).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            userProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteRespondent);
            panel1.Controls.Add(btnCompute);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(listRespondents);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(userProfilePanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(1158, 523);
            panel1.TabIndex = 0;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.DeepSkyBlue;
            btnCompute.Cursor = Cursors.Hand;
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompute.ForeColor = Color.White;
            btnCompute.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompute.ImageKey = "diskette.png";
            btnCompute.Location = new Point(22, 470);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(383, 45);
            btnCompute.TabIndex = 24;
            btnCompute.Text = "Compute Grammar Profiency Score and Level";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(50, 50, 50);
            label11.Location = new Point(222, 428);
            label11.Name = "label11";
            label11.Size = new Size(183, 38);
            label11.TabIndex = 17;
            label11.Text = "&GFL - Grammar Proficiency Level";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(50, 50, 50);
            label12.Location = new Point(22, 428);
            label12.Name = "label12";
            label12.Size = new Size(194, 38);
            label12.TabIndex = 16;
            label12.Text = "&GFS - Grammar Proficiency Score";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(50, 50, 50);
            label10.Location = new Point(222, 412);
            label10.Name = "label10";
            label10.Size = new Size(183, 16);
            label10.TabIndex = 15;
            label10.Text = "&TTE - Total Transmuted Error";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(50, 50, 50);
            label9.Location = new Point(22, 412);
            label9.Name = "label9";
            label9.Size = new Size(192, 16);
            label9.TabIndex = 14;
            label9.Text = "&TFE - Total Frequency of Error";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(12, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(401, 50);
            panel4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(117, 7);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 2;
            label6.Text = "Respondents";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listRespondents
            // 
            listRespondents.Activation = ItemActivation.TwoClick;
            listRespondents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listRespondents.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listRespondents.FullRowSelect = true;
            listRespondents.GridLines = true;
            listRespondents.HeaderStyle = ColumnHeaderStyle.None;
            listRespondents.Location = new Point(12, 112);
            listRespondents.Name = "listRespondents";
            listRespondents.Size = new Size(401, 246);
            listRespondents.TabIndex = 12;
            listRespondents.UseCompatibleStateImageBehavior = false;
            listRespondents.View = View.Details;
            listRespondents.MouseDoubleClick += listRespondents_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 397;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(12, 395);
            label4.Name = "label4";
            label4.Size = new Size(297, 15);
            label4.TabIndex = 11;
            label4.Text = "Double-click the respondent's name to view their result.";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(419, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 453);
            panel2.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblSelectedSubject);
            panel5.Controls.Add(listResult);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(lblLeastSubject);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(lblMostSubject);
            panel5.Controls.Add(panel9);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(723, 401);
            panel5.TabIndex = 3;
            // 
            // lblSelectedSubject
            // 
            lblSelectedSubject.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedSubject.ForeColor = Color.FromArgb(0, 0, 192);
            lblSelectedSubject.Location = new Point(482, 300);
            lblSelectedSubject.Name = "lblSelectedSubject";
            lblSelectedSubject.Size = new Size(200, 54);
            lblSelectedSubject.TabIndex = 26;
            lblSelectedSubject.Text = "Double click subject to edit it's weight. (Recomputation of results is required when editing weights)";
            lblSelectedSubject.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listResult
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Gray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            listResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            listResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listResult.BackgroundColor = Color.White;
            listResult.BorderStyle = BorderStyle.None;
            listResult.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            listResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            listResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listResult.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            listResult.DefaultCellStyle = dataGridViewCellStyle6;
            listResult.EnableHeadersVisualStyles = false;
            listResult.Location = new Point(482, 15);
            listResult.Name = "listResult";
            listResult.ReadOnly = true;
            listResult.RowHeadersVisible = false;
            listResult.RowTemplate.Height = 25;
            listResult.Size = new Size(200, 301);
            listResult.TabIndex = 24;
            listResult.CellContentDoubleClick += listResult_CellContentDoubleClick;
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
            // label7
            // 
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(40, 328);
            label7.Name = "label7";
            label7.Size = new Size(421, 36);
            label7.TabIndex = 23;
            label7.Text = "The 'Total Frequency of Errors' are the sum of all the respondent's errors from the test results.\r\n";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DodgerBlue;
            panel7.Controls.Add(label5);
            panel7.Location = new Point(197, 283);
            panel7.Name = "panel7";
            panel7.Size = new Size(245, 33);
            panel7.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 8);
            label5.Name = "label5";
            label5.Size = new Size(226, 17);
            label5.TabIndex = 10;
            label5.Text = "Subject with least frequency errors";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLeastSubject
            // 
            lblLeastSubject.BackColor = Color.Transparent;
            lblLeastSubject.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblLeastSubject.Location = new Point(197, 176);
            lblLeastSubject.Name = "lblLeastSubject";
            lblLeastSubject.Size = new Size(245, 104);
            lblLeastSubject.TabIndex = 20;
            lblLeastSubject.Text = "- - - ";
            lblLeastSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DodgerBlue;
            panel8.Controls.Add(label8);
            panel8.Controls.Add(lblLeastCount);
            panel8.Location = new Point(40, 176);
            panel8.Name = "panel8";
            panel8.Size = new Size(157, 140);
            panel8.TabIndex = 21;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 91);
            label8.Name = "label8";
            label8.Size = new Size(133, 43);
            label8.TabIndex = 10;
            label8.Text = "Total Frequency of Errors";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLeastCount
            // 
            lblLeastCount.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblLeastCount.ForeColor = Color.White;
            lblLeastCount.Location = new Point(12, 12);
            lblLeastCount.Name = "lblLeastCount";
            lblLeastCount.Size = new Size(133, 80);
            lblLeastCount.TabIndex = 1;
            lblLeastCount.Text = "0";
            lblLeastCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SlateGray;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(197, 122);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 33);
            panel6.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 8);
            label2.Name = "label2";
            label2.Size = new Size(228, 17);
            label2.TabIndex = 10;
            label2.Text = "Subject with most frequency errors";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMostSubject
            // 
            lblMostSubject.BackColor = Color.Transparent;
            lblMostSubject.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblMostSubject.Location = new Point(197, 15);
            lblMostSubject.Name = "lblMostSubject";
            lblMostSubject.Size = new Size(245, 104);
            lblMostSubject.TabIndex = 17;
            lblMostSubject.Text = "- - - ";
            lblMostSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.SlateGray;
            panel9.Controls.Add(label3);
            panel9.Controls.Add(lblMostCount);
            panel9.Location = new Point(40, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(157, 140);
            panel9.TabIndex = 18;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(133, 43);
            label3.TabIndex = 10;
            label3.Text = "Total Frequency of Errors";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMostCount
            // 
            lblMostCount.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblMostCount.ForeColor = Color.White;
            lblMostCount.Location = new Point(12, 12);
            lblMostCount.Name = "lblMostCount";
            lblMostCount.Size = new Size(133, 80);
            lblMostCount.TabIndex = 1;
            lblMostCount.Text = "0";
            lblMostCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(723, 48);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 1;
            label1.Text = "Frequence of Errors Summary";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userProfilePanel
            // 
            userProfilePanel.BackColor = Color.LightSeaGreen;
            userProfilePanel.Controls.Add(btnPrevious);
            userProfilePanel.Controls.Add(btnRefresh);
            userProfilePanel.Controls.Add(pictureBox1);
            userProfilePanel.Controls.Add(lblUser);
            userProfilePanel.Location = new Point(8, 8);
            userProfilePanel.Name = "userProfilePanel";
            userProfilePanel.Size = new Size(1136, 48);
            userProfilePanel.TabIndex = 1;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LawnGreen;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.ImageIndex = 5;
            btnPrevious.ImageList = imageList1;
            btnPrevious.Location = new Point(999, 6);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(134, 36);
            btnPrevious.TabIndex = 15;
            btnPrevious.Text = "Previous window";
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "delete.png");
            imageList1.Images.SetKeyName(1, "edit.png");
            imageList1.Images.SetKeyName(2, "plus.png");
            imageList1.Images.SetKeyName(3, "file.png");
            imageList1.Images.SetKeyName(4, "refresh.png");
            imageList1.Images.SetKeyName(5, "undo.png");
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LawnGreen;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.ImageIndex = 4;
            btnRefresh.ImageList = imageList1;
            btnRefresh.Location = new Point(880, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(113, 36);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.human;
            pictureBox1.Location = new Point(13, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(74, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(362, 30);
            lblUser.TabIndex = 1;
            lblUser.Text = "Respondents Data and Result";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDeleteRespondent
            // 
            btnDeleteRespondent.BackColor = Color.Red;
            btnDeleteRespondent.FlatStyle = FlatStyle.Flat;
            btnDeleteRespondent.ForeColor = Color.White;
            btnDeleteRespondent.Location = new Point(12, 364);
            btnDeleteRespondent.Name = "btnDeleteRespondent";
            btnDeleteRespondent.Size = new Size(184, 28);
            btnDeleteRespondent.TabIndex = 25;
            btnDeleteRespondent.Text = "Delete Selected Respondent";
            btnDeleteRespondent.UseVisualStyleBackColor = false;
            btnDeleteRespondent.Click += btnDeleteRespondent_Click;
            // 
            // Respondents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1158, 523);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Respondents";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listResult).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            userProfilePanel.ResumeLayout(false);
            userProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel userProfilePanel;
        private Label lblUser;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Panel panel4;
        private Label label6;
        private ListView listRespondents;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private PictureBox pictureBox1;
        private Panel panel5;
        private DataGridView listResult;
        private Label label7;
        private Panel panel7;
        private Label label5;
        private Label lblLeastSubject;
        private Panel panel8;
        private Label label8;
        private Label lblLeastCount;
        private Panel panel6;
        private Label label2;
        private Label lblMostSubject;
        private Panel panel9;
        private Label label3;
        private Label lblMostCount;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnRefresh;
        private ImageList imageList1;
        private Label lblSelectedSubject;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnCompute;
        private Button btnPrevious;
        private Button btnDeleteRespondent;
    }
}