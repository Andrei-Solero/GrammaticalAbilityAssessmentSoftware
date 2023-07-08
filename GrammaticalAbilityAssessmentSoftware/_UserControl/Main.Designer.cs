namespace GrammaticalAbilityAssessmentSoftware._UserControl
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            lblNumberOfQuestion = new Label();
            lblWeight = new Label();
            btnEdit = new Button();
            imageList1 = new ImageList(components);
            btnDelete = new Button();
            lblCode = new Label();
            lblLevel = new Label();
            lblPartsTitle = new Label();
            listQA = new FlowLayoutPanel();
            label1 = new Label();
            btnCreateNewQuestion = new Button();
            btnDeleteAllQuestions = new Button();
            lblInstruction = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(lblInstruction);
            panel1.Controls.Add(lblNumberOfQuestion);
            panel1.Controls.Add(lblWeight);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(lblCode);
            panel1.Controls.Add(lblLevel);
            panel1.Controls.Add(lblPartsTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 141);
            panel1.TabIndex = 0;
            // 
            // lblNumberOfQuestion
            // 
            lblNumberOfQuestion.Location = new Point(162, 63);
            lblNumberOfQuestion.Name = "lblNumberOfQuestion";
            lblNumberOfQuestion.Size = new Size(199, 23);
            lblNumberOfQuestion.TabIndex = 6;
            lblNumberOfQuestion.Text = "Weight";
            lblNumberOfQuestion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWeight
            // 
            lblWeight.Location = new Point(18, 109);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(138, 23);
            lblWeight.TabIndex = 5;
            lblWeight.Text = "Weight";
            lblWeight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.ImageKey = "edit.png";
            btnEdit.ImageList = imageList1;
            btnEdit.Location = new Point(484, 97);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 35);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Subject";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "delete.png");
            imageList1.Images.SetKeyName(1, "edit.png");
            imageList1.Images.SetKeyName(2, "plus.png");
            imageList1.Images.SetKeyName(3, "page.png");
            imageList1.Images.SetKeyName(4, "alert.png");
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.ImageIndex = 0;
            btnDelete.ImageList = imageList1;
            btnDelete.Location = new Point(598, 97);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Subject";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCode
            // 
            lblCode.Location = new Point(18, 86);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(138, 23);
            lblCode.TabIndex = 2;
            lblCode.Text = "Code";
            lblCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLevel
            // 
            lblLevel.Location = new Point(18, 63);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(138, 23);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "Level";
            lblLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPartsTitle
            // 
            lblPartsTitle.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartsTitle.Location = new Point(18, 0);
            lblPartsTitle.Name = "lblPartsTitle";
            lblPartsTitle.Size = new Size(578, 63);
            lblPartsTitle.TabIndex = 0;
            lblPartsTitle.Text = "- - -";
            lblPartsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listQA
            // 
            listQA.AutoScroll = true;
            listQA.Dock = DockStyle.Bottom;
            listQA.Location = new Point(5, 222);
            listQA.Name = "listQA";
            listQA.Size = new Size(722, 418);
            listQA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 149);
            label1.Name = "label1";
            label1.Size = new Size(336, 30);
            label1.TabIndex = 2;
            label1.Text = "Questions and Answer Keys";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCreateNewQuestion
            // 
            btnCreateNewQuestion.BackColor = Color.White;
            btnCreateNewQuestion.Cursor = Cursors.Hand;
            btnCreateNewQuestion.FlatStyle = FlatStyle.Flat;
            btnCreateNewQuestion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateNewQuestion.ImageKey = "page.png";
            btnCreateNewQuestion.ImageList = imageList1;
            btnCreateNewQuestion.Location = new Point(8, 182);
            btnCreateNewQuestion.Name = "btnCreateNewQuestion";
            btnCreateNewQuestion.Size = new Size(153, 34);
            btnCreateNewQuestion.TabIndex = 4;
            btnCreateNewQuestion.Text = "Create New Question";
            btnCreateNewQuestion.TextAlign = ContentAlignment.MiddleRight;
            btnCreateNewQuestion.UseVisualStyleBackColor = false;
            btnCreateNewQuestion.Click += btnCreateNewQuestion_Click;
            // 
            // btnDeleteAllQuestions
            // 
            btnDeleteAllQuestions.BackColor = Color.White;
            btnDeleteAllQuestions.Cursor = Cursors.Hand;
            btnDeleteAllQuestions.FlatStyle = FlatStyle.Flat;
            btnDeleteAllQuestions.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAllQuestions.ImageKey = "alert.png";
            btnDeleteAllQuestions.ImageList = imageList1;
            btnDeleteAllQuestions.Location = new Point(167, 182);
            btnDeleteAllQuestions.Name = "btnDeleteAllQuestions";
            btnDeleteAllQuestions.Size = new Size(153, 34);
            btnDeleteAllQuestions.TabIndex = 5;
            btnDeleteAllQuestions.Text = "Delete All Questions";
            btnDeleteAllQuestions.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteAllQuestions.UseVisualStyleBackColor = false;
            btnDeleteAllQuestions.Click += btnDeleteAllQuestions_Click;
            // 
            // lblInstruction
            // 
            lblInstruction.Location = new Point(162, 86);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(316, 46);
            lblInstruction.TabIndex = 7;
            lblInstruction.Text = "Instruction";
            lblInstruction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnDeleteAllQuestions);
            Controls.Add(btnCreateNewQuestion);
            Controls.Add(label1);
            Controls.Add(listQA);
            Controls.Add(panel1);
            Name = "Main";
            Padding = new Padding(5);
            Size = new Size(732, 645);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblPartsTitle;
        private Label lblCode;
        private Label lblLevel;
        private Button btnEdit;
        private Button btnDelete;
        private FlowLayoutPanel listQA;
        private Label label1;
        private Button btnCreateNewQuestion;
        private Label lblWeight;
        private ImageList imageList1;
        private Label lblNumberOfQuestion;
        private Button btnDeleteAllQuestions;
        private Label lblInstruction;
    }
}
