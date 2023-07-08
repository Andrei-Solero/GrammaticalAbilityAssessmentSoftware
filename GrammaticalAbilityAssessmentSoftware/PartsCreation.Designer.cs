namespace GrammaticalAbilityAssessmentSoftware
{
    partial class PartsCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsCreation));
            panel1 = new Panel();
            lblHeader = new Label();
            panel2 = new Panel();
            txtInstruction = new RichTextBox();
            label4 = new Label();
            numWeight = new NumericUpDown();
            label5 = new Label();
            textLine = new Panel();
            btnSaveParts = new Button();
            imageList1 = new ImageList(components);
            txtTitle = new TextBox();
            label3 = new Label();
            txtCode = new TextBox();
            label2 = new Label();
            txtLevel = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 68);
            panel1.TabIndex = 9;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.FromArgb(30, 30, 30);
            lblHeader.Location = new Point(9, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(283, 33);
            lblHeader.TabIndex = 10;
            lblHeader.Text = "Create New Subject";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtInstruction);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numWeight);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textLine);
            panel2.Controls.Add(btnSaveParts);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCode);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtLevel);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 359);
            panel2.TabIndex = 10;
            // 
            // txtInstruction
            // 
            txtInstruction.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInstruction.Location = new Point(13, 151);
            txtInstruction.Name = "txtInstruction";
            txtInstruction.Size = new Size(325, 92);
            txtInstruction.TabIndex = 20;
            txtInstruction.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 131);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 19;
            label4.Text = "Instruction:";
            // 
            // numWeight
            // 
            numWeight.DecimalPlaces = 1;
            numWeight.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numWeight.Location = new Point(74, 249);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(86, 37);
            numWeight.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 269);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 17;
            label5.Text = "Weight:";
            // 
            // textLine
            // 
            textLine.BackColor = Color.FromArgb(64, 64, 64);
            textLine.Location = new Point(13, 116);
            textLine.Name = "textLine";
            textLine.Size = new Size(326, 1);
            textLine.TabIndex = 16;
            // 
            // btnSaveParts
            // 
            btnSaveParts.BackColor = Color.DeepSkyBlue;
            btnSaveParts.Cursor = Cursors.Hand;
            btnSaveParts.FlatStyle = FlatStyle.Flat;
            btnSaveParts.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveParts.ForeColor = Color.White;
            btnSaveParts.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveParts.ImageKey = "diskette.png";
            btnSaveParts.ImageList = imageList1;
            btnSaveParts.Location = new Point(107, 301);
            btnSaveParts.Name = "btnSaveParts";
            btnSaveParts.Size = new Size(137, 42);
            btnSaveParts.TabIndex = 15;
            btnSaveParts.Text = "Save";
            btnSaveParts.UseVisualStyleBackColor = false;
            btnSaveParts.Click += btnSaveParts_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "diskette.png");
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(12, 83);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(327, 30);
            txtTitle.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 63);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 13;
            label3.Text = "Parts Title:";
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.Location = new Point(218, 9);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(121, 37);
            txtCode.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(166, 29);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 11;
            label2.Text = "Code:";
            // 
            // txtLevel
            // 
            txtLevel.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtLevel.Location = new Point(60, 9);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(100, 37);
            txtLevel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 29);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 9;
            label1.Text = "Level:";
            // 
            // PartsCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 427);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PartsCreation";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSaveParts;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtCode;
        private Label label2;
        private TextBox txtLevel;
        private Label label1;
        private Label lblHeader;
        private Panel textLine;
        private NumericUpDown numWeight;
        private Label label5;
        private ImageList imageList1;
        private RichTextBox txtInstruction;
        private Label label4;
    }
}