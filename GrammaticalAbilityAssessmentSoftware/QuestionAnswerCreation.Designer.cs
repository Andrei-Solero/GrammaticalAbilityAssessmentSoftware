namespace GrammaticalAbilityAssessmentSoftware
{
    partial class QuestionAnswerCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionAnswerCreation));
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            txtQuestion = new RichTextBox();
            txtAnswer = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            btnSaveQA = new Button();
            imageList1 = new ImageList(components);
            lblCategory = new Label();
            btnSaveAdd = new Button();
            label5 = new Label();
            questionNumber = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)questionNumber).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 87);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 30, 30);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(369, 68);
            label4.TabIndex = 10;
            label4.Text = "Create New Question and Answer Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(27, 170);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 12;
            label1.Text = "Question:";
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.Location = new Point(27, 198);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(390, 129);
            txtQuestion.TabIndex = 13;
            txtQuestion.Text = "";
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer.Location = new Point(27, 377);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(390, 54);
            txtAnswer.TabIndex = 15;
            txtAnswer.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(27, 349);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 14;
            label2.Text = "Answer Key:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(27, 330);
            label3.Name = "label3";
            label3.Size = new Size(286, 15);
            label3.TabIndex = 16;
            label3.Text = "Note: Use mutliple Underscore( _ ) to hide the answer.";
            // 
            // btnSaveQA
            // 
            btnSaveQA.BackColor = Color.DeepSkyBlue;
            btnSaveQA.Cursor = Cursors.Hand;
            btnSaveQA.FlatStyle = FlatStyle.Flat;
            btnSaveQA.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveQA.ForeColor = Color.White;
            btnSaveQA.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveQA.ImageKey = "diskette.png";
            btnSaveQA.ImageList = imageList1;
            btnSaveQA.Location = new Point(241, 448);
            btnSaveQA.Name = "btnSaveQA";
            btnSaveQA.Size = new Size(165, 37);
            btnSaveQA.TabIndex = 17;
            btnSaveQA.Text = "Save One Question";
            btnSaveQA.TextAlign = ContentAlignment.MiddleRight;
            btnSaveQA.UseVisualStyleBackColor = false;
            btnSaveQA.Click += btnSaveQA_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "diskette.png");
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(49, 90);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(346, 30);
            lblCategory.TabIndex = 18;
            lblCategory.Text = "label5";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveAdd
            // 
            btnSaveAdd.BackColor = Color.DeepSkyBlue;
            btnSaveAdd.Cursor = Cursors.Hand;
            btnSaveAdd.FlatStyle = FlatStyle.Flat;
            btnSaveAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveAdd.ForeColor = Color.White;
            btnSaveAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveAdd.ImageKey = "diskette.png";
            btnSaveAdd.ImageList = imageList1;
            btnSaveAdd.Location = new Point(39, 448);
            btnSaveAdd.Name = "btnSaveAdd";
            btnSaveAdd.Size = new Size(190, 37);
            btnSaveAdd.TabIndex = 19;
            btnSaveAdd.Text = "Save and Add Another";
            btnSaveAdd.TextAlign = ContentAlignment.MiddleRight;
            btnSaveAdd.UseVisualStyleBackColor = false;
            btnSaveAdd.Click += btnSaveAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(91, 132);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 20;
            label5.Text = "Question Number:";
            // 
            // questionNumber
            // 
            questionNumber.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            questionNumber.Location = new Point(257, 130);
            questionNumber.Name = "questionNumber";
            questionNumber.Size = new Size(97, 33);
            questionNumber.TabIndex = 21;
            // 
            // QuestionAnswerCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(445, 502);
            Controls.Add(questionNumber);
            Controls.Add(label5);
            Controls.Add(btnSaveAdd);
            Controls.Add(lblCategory);
            Controls.Add(btnSaveQA);
            Controls.Add(label3);
            Controls.Add(txtAnswer);
            Controls.Add(label2);
            Controls.Add(txtQuestion);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "QuestionAnswerCreation";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)questionNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private RichTextBox txtQuestion;
        private RichTextBox txtAnswer;
        private Label label2;
        private Label label3;
        private Button btnSaveQA;
        private Label lblCategory;
        private ImageList imageList1;
        private Button btnSaveAdd;
        private Label label5;
        private NumericUpDown questionNumber;
    }
}