namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    partial class QuizAnswerFormWithResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizAnswerFormWithResult));
            textLine = new Panel();
            txtAnswer = new TextBox();
            label1 = new Label();
            txtQuestion = new TextBox();
            imageList1 = new ImageList(components);
            image = new Button();
            SuspendLayout();
            // 
            // textLine
            // 
            textLine.BackColor = Color.FromArgb(64, 64, 64);
            textLine.Location = new Point(115, 218);
            textLine.Name = "textLine";
            textLine.Size = new Size(229, 1);
            textLine.TabIndex = 22;
            // 
            // txtAnswer
            // 
            txtAnswer.BorderStyle = BorderStyle.None;
            txtAnswer.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnswer.Location = new Point(114, 185);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(230, 30);
            txtAnswer.TabIndex = 21;
            txtAnswer.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 193);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 20;
            label1.Text = "Your Answer:";
            // 
            // txtQuestion
            // 
            txtQuestion.BorderStyle = BorderStyle.FixedSingle;
            txtQuestion.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.Location = new Point(3, 11);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ReadOnly = true;
            txtQuestion.ScrollBars = ScrollBars.Vertical;
            txtQuestion.Size = new Size(383, 159);
            txtQuestion.TabIndex = 19;
            txtQuestion.Text = "- - -";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "accept.png");
            imageList1.Images.SetKeyName(1, "cancel.png");
            // 
            // image
            // 
            image.FlatAppearance.BorderSize = 0;
            image.FlatStyle = FlatStyle.Flat;
            image.ImageList = imageList1;
            image.Location = new Point(343, 185);
            image.Name = "image";
            image.Size = new Size(39, 34);
            image.TabIndex = 23;
            image.UseVisualStyleBackColor = true;
            // 
            // QuizAnswerFormWithResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(image);
            Controls.Add(textLine);
            Controls.Add(txtAnswer);
            Controls.Add(label1);
            Controls.Add(txtQuestion);
            Name = "QuizAnswerFormWithResult";
            Size = new Size(389, 230);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel textLine;
        public TextBox txtAnswer;
        private Label label1;
        private TextBox txtQuestion;
        private ImageList imageList1;
        private Button image;
    }
}
