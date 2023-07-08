namespace GrammaticalAbilityAssessmentSoftware
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            leftPanel = new Panel();
            partsPanel = new FlowLayoutPanel();
            userProfilePanel = new Panel();
            lblUser = new Label();
            imageList1 = new ImageList(components);
            mainPanel = new Panel();
            leftPanel.SuspendLayout();
            userProfilePanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(partsPanel);
            leftPanel.Controls.Add(userProfilePanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(5);
            leftPanel.Size = new Size(322, 494);
            leftPanel.TabIndex = 3;
            // 
            // partsPanel
            // 
            partsPanel.AutoScroll = true;
            partsPanel.Dock = DockStyle.Bottom;
            partsPanel.FlowDirection = FlowDirection.TopDown;
            partsPanel.Location = new Point(5, 72);
            partsPanel.Name = "partsPanel";
            partsPanel.Size = new Size(312, 417);
            partsPanel.TabIndex = 1;
            partsPanel.WrapContents = false;
            // 
            // userProfilePanel
            // 
            userProfilePanel.BackColor = Color.LightSeaGreen;
            userProfilePanel.Controls.Add(lblUser);
            userProfilePanel.Dock = DockStyle.Top;
            userProfilePanel.Location = new Point(5, 5);
            userProfilePanel.Margin = new Padding(5);
            userProfilePanel.Name = "userProfilePanel";
            userProfilePanel.Size = new Size(312, 59);
            userProfilePanel.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(31, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(251, 31);
            lblUser.TabIndex = 1;
            lblUser.Text = "Paulin, Eric";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
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
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(322, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(699, 494);
            mainPanel.TabIndex = 5;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1021, 494);
            Controls.Add(mainPanel);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "QuizForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += QuizForm_FormClosed;
            leftPanel.ResumeLayout(false);
            userProfilePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel userProfilePanel;
        private Label lblUser;
        private ImageList imageList1;
        private Panel mainPanel;
        private FlowLayoutPanel partsPanel;
    }
}