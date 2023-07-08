namespace GrammaticalAbilityAssessmentSoftware
{
    partial class CreateRespondents
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textLine = new Panel();
            txtName = new TextBox();
            label1 = new Label();
            btnSaveRespondents = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 97);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_management;
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 30, 30);
            label4.Location = new Point(71, 9);
            label4.Name = "label4";
            label4.Size = new Size(273, 72);
            label4.TabIndex = 10;
            label4.Text = "Grammatical Assessment";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textLine
            // 
            textLine.BackColor = Color.FromArgb(64, 64, 64);
            textLine.Location = new Point(20, 189);
            textLine.Name = "textLine";
            textLine.Size = new Size(326, 1);
            textLine.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(20, 150);
            txtName.Name = "txtName";
            txtName.Size = new Size(327, 40);
            txtName.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 30, 30);
            label1.Location = new Point(21, 117);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 19;
            label1.Text = "Enter your Name:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveRespondents
            // 
            btnSaveRespondents.BackColor = Color.DeepSkyBlue;
            btnSaveRespondents.Cursor = Cursors.Hand;
            btnSaveRespondents.FlatStyle = FlatStyle.Flat;
            btnSaveRespondents.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveRespondents.ForeColor = Color.White;
            btnSaveRespondents.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveRespondents.ImageKey = "diskette.png";
            btnSaveRespondents.Location = new Point(79, 208);
            btnSaveRespondents.Name = "btnSaveRespondents";
            btnSaveRespondents.Size = new Size(206, 52);
            btnSaveRespondents.TabIndex = 20;
            btnSaveRespondents.Text = "Take the assessment!";
            btnSaveRespondents.UseVisualStyleBackColor = false;
            btnSaveRespondents.Click += btnSaveRespondents_Click;
            // 
            // CreateRespondents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 290);
            Controls.Add(btnSaveRespondents);
            Controls.Add(label1);
            Controls.Add(textLine);
            Controls.Add(txtName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CreateRespondents";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += CreateRespondents_FormClosed;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel textLine;
        private TextBox txtName;
        private Label label1;
        private Button btnSaveRespondents;
    }
}