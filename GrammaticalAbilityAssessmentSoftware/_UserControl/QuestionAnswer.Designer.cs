namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    partial class QuestionAnswer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionAnswer));
            label2 = new Label();
            panel1 = new Panel();
            txtQuestion = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtAnswer = new TextBox();
            btnEditQuestion = new Button();
            imageList1 = new ImageList(components);
            btnDelete = new Button();
            questionNumber = new NumericUpDown();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)questionNumber).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Question:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtQuestion);
            panel1.Location = new Point(80, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 82);
            panel1.TabIndex = 4;
            // 
            // txtQuestion
            // 
            txtQuestion.BorderStyle = BorderStyle.None;
            txtQuestion.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.Location = new Point(3, 3);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ReadOnly = true;
            txtQuestion.ScrollBars = ScrollBars.Vertical;
            txtQuestion.Size = new Size(336, 77);
            txtQuestion.TabIndex = 0;
            txtQuestion.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(431, 8);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 5;
            label1.Text = "Key:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtAnswer);
            panel2.Location = new Point(466, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 82);
            panel2.TabIndex = 6;
            // 
            // txtAnswer
            // 
            txtAnswer.BorderStyle = BorderStyle.None;
            txtAnswer.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnswer.Location = new Point(3, 3);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.ScrollBars = ScrollBars.Vertical;
            txtAnswer.Size = new Size(206, 72);
            txtAnswer.TabIndex = 0;
            txtAnswer.Text = "-";
            // 
            // btnEditQuestion
            // 
            btnEditQuestion.Cursor = Cursors.Hand;
            btnEditQuestion.FlatStyle = FlatStyle.Flat;
            btnEditQuestion.ForeColor = Color.Black;
            btnEditQuestion.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditQuestion.ImageIndex = 1;
            btnEditQuestion.ImageList = imageList1;
            btnEditQuestion.Location = new Point(431, 91);
            btnEditQuestion.Name = "btnEditQuestion";
            btnEditQuestion.Size = new Size(116, 35);
            btnEditQuestion.TabIndex = 8;
            btnEditQuestion.Text = "Edit Question";
            btnEditQuestion.TextAlign = ContentAlignment.MiddleRight;
            btnEditQuestion.UseVisualStyleBackColor = true;
            btnEditQuestion.Click += btnEditQuestion_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "eraser.png");
            imageList1.Images.SetKeyName(1, "edit (1).png");
            imageList1.Images.SetKeyName(2, "diskette.png");
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Black;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.ImageKey = "eraser.png";
            btnDelete.ImageList = imageList1;
            btnDelete.Location = new Point(553, 91);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Question";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // questionNumber
            // 
            questionNumber.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            questionNumber.Location = new Point(247, 91);
            questionNumber.Name = "questionNumber";
            questionNumber.Size = new Size(97, 33);
            questionNumber.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(81, 93);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 22;
            label5.Text = "Question Number:";
            // 
            // QuestionAnswer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(questionNumber);
            Controls.Add(label5);
            Controls.Add(btnEditQuestion);
            Controls.Add(btnDelete);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "QuestionAnswer";
            Size = new Size(698, 138);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)questionNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private TextBox txtQuestion;
        private Label label1;
        private Panel panel2;
        private TextBox txtAnswer;
        private Button btnEditQuestion;
        private Button btnDelete;
        private ImageList imageList1;
        private NumericUpDown questionNumber;
        private Label label5;
    }
}
