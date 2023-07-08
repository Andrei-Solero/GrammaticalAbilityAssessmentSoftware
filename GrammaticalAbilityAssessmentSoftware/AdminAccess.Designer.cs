namespace GrammaticalAbilityAssessmentSoftware
{
    partial class AdminAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccess));
            leftPanel = new Panel();
            btnCreateNewLevel = new Button();
            imageList1 = new ImageList(components);
            label1 = new Label();
            partsPanel = new FlowLayoutPanel();
            userProfilePanel = new Panel();
            btnRespondents = new Button();
            label2 = new Label();
            adminProfile = new PictureBox();
            mainPanel = new Panel();
            leftPanel.SuspendLayout();
            userProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminProfile).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(btnCreateNewLevel);
            leftPanel.Controls.Add(label1);
            leftPanel.Controls.Add(partsPanel);
            leftPanel.Controls.Add(userProfilePanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(5);
            leftPanel.Size = new Size(322, 645);
            leftPanel.TabIndex = 1;
            // 
            // btnCreateNewLevel
            // 
            btnCreateNewLevel.Cursor = Cursors.Hand;
            btnCreateNewLevel.FlatStyle = FlatStyle.Flat;
            btnCreateNewLevel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateNewLevel.ImageKey = "plus.png";
            btnCreateNewLevel.ImageList = imageList1;
            btnCreateNewLevel.Location = new Point(157, 175);
            btnCreateNewLevel.Name = "btnCreateNewLevel";
            btnCreateNewLevel.Size = new Size(140, 37);
            btnCreateNewLevel.TabIndex = 3;
            btnCreateNewLevel.Text = "Add New Subject";
            btnCreateNewLevel.TextAlign = ContentAlignment.MiddleRight;
            btnCreateNewLevel.UseVisualStyleBackColor = true;
            btnCreateNewLevel.Click += btnCreateNewLevel_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 182);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 2;
            label1.Text = "Parts/Subjects\r\n";
            // 
            // partsPanel
            // 
            partsPanel.AutoScroll = true;
            partsPanel.Dock = DockStyle.Bottom;
            partsPanel.FlowDirection = FlowDirection.TopDown;
            partsPanel.Location = new Point(5, 218);
            partsPanel.Name = "partsPanel";
            partsPanel.Size = new Size(312, 422);
            partsPanel.TabIndex = 1;
            partsPanel.WrapContents = false;
            // 
            // userProfilePanel
            // 
            userProfilePanel.BackColor = Color.LightSeaGreen;
            userProfilePanel.Controls.Add(btnRespondents);
            userProfilePanel.Controls.Add(label2);
            userProfilePanel.Controls.Add(adminProfile);
            userProfilePanel.Dock = DockStyle.Top;
            userProfilePanel.Location = new Point(5, 5);
            userProfilePanel.Margin = new Padding(5);
            userProfilePanel.Name = "userProfilePanel";
            userProfilePanel.Size = new Size(312, 162);
            userProfilePanel.TabIndex = 0;
            // 
            // btnRespondents
            // 
            btnRespondents.BackgroundImage = Properties.Resources.human;
            btnRespondents.BackgroundImageLayout = ImageLayout.Zoom;
            btnRespondents.Cursor = Cursors.Hand;
            btnRespondents.FlatAppearance.BorderSize = 0;
            btnRespondents.FlatStyle = FlatStyle.Flat;
            btnRespondents.Location = new Point(257, 7);
            btnRespondents.Name = "btnRespondents";
            btnRespondents.Size = new Size(52, 47);
            btnRespondents.TabIndex = 0;
            btnRespondents.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRespondents.UseVisualStyleBackColor = true;
            btnRespondents.Click += btnRespondents_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 116);
            label2.Name = "label2";
            label2.Size = new Size(302, 31);
            label2.TabIndex = 1;
            label2.Text = "Paulin, Eric";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adminProfile
            // 
            adminProfile.BackColor = Color.Transparent;
            adminProfile.Image = (Image)resources.GetObject("adminProfile.Image");
            adminProfile.Location = new Point(99, 7);
            adminProfile.Name = "adminProfile";
            adminProfile.Size = new Size(114, 101);
            adminProfile.SizeMode = PictureBoxSizeMode.Zoom;
            adminProfile.TabIndex = 0;
            adminProfile.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(322, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(3);
            mainPanel.Size = new Size(732, 645);
            mainPanel.TabIndex = 2;
            // 
            // AdminAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1054, 645);
            Controls.Add(mainPanel);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AdminAccess";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += AdminAccess_FormClosed;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            userProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Button btnCreateNewLevel;
        private Label label1;
        private FlowLayoutPanel partsPanel;
        private Panel userProfilePanel;
        private PictureBox adminProfile;
        private Panel mainPanel;
        private Label label2;
        private ImageList imageList1;
        private Button btnRespondents;
    }
}