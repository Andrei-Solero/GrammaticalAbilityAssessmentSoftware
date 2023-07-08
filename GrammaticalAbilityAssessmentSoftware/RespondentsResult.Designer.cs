namespace GrammaticalAbilityAssessmentSoftware
{
    partial class RespondentsResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespondentsResult));
            mainPanel = new Panel();
            leftPanel = new Panel();
            btnPrevious = new Button();
            imageList1 = new ImageList(components);
            btnRefresh = new Button();
            partsPanel = new FlowLayoutPanel();
            userProfilePanel = new Panel();
            lblLeastSubject = new Label();
            label2 = new Label();
            lblMostSubject = new Label();
            label1 = new Label();
            lblUser = new Label();
            leftPanel.SuspendLayout();
            userProfilePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(322, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(3);
            mainPanel.Size = new Size(699, 551);
            mainPanel.TabIndex = 4;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(btnPrevious);
            leftPanel.Controls.Add(btnRefresh);
            leftPanel.Controls.Add(partsPanel);
            leftPanel.Controls.Add(userProfilePanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(5);
            leftPanel.Size = new Size(322, 551);
            leftPanel.TabIndex = 3;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LawnGreen;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.ImageIndex = 5;
            btnPrevious.ImageList = imageList1;
            btnPrevious.Location = new Point(61, 162);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(134, 36);
            btnPrevious.TabIndex = 16;
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
            btnRefresh.Location = new Point(201, 162);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(113, 36);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // partsPanel
            // 
            partsPanel.AutoScroll = true;
            partsPanel.BackColor = Color.White;
            partsPanel.Dock = DockStyle.Bottom;
            partsPanel.FlowDirection = FlowDirection.TopDown;
            partsPanel.Location = new Point(5, 204);
            partsPanel.Name = "partsPanel";
            partsPanel.Size = new Size(312, 342);
            partsPanel.TabIndex = 1;
            partsPanel.WrapContents = false;
            // 
            // userProfilePanel
            // 
            userProfilePanel.BackColor = Color.LightSeaGreen;
            userProfilePanel.Controls.Add(lblLeastSubject);
            userProfilePanel.Controls.Add(label2);
            userProfilePanel.Controls.Add(lblMostSubject);
            userProfilePanel.Controls.Add(label1);
            userProfilePanel.Controls.Add(lblUser);
            userProfilePanel.Dock = DockStyle.Top;
            userProfilePanel.Location = new Point(5, 5);
            userProfilePanel.Margin = new Padding(5);
            userProfilePanel.Name = "userProfilePanel";
            userProfilePanel.Size = new Size(312, 149);
            userProfilePanel.TabIndex = 0;
            // 
            // lblLeastSubject
            // 
            lblLeastSubject.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLeastSubject.Location = new Point(130, 104);
            lblLeastSubject.Name = "lblLeastSubject";
            lblLeastSubject.Size = new Size(166, 36);
            lblLeastSubject.TabIndex = 11;
            lblLeastSubject.Text = "-";
            lblLeastSubject.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 104);
            label2.Name = "label2";
            label2.Size = new Size(120, 36);
            label2.TabIndex = 10;
            label2.Text = "Subject with the Least Errors:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMostSubject
            // 
            lblMostSubject.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMostSubject.Location = new Point(130, 68);
            lblMostSubject.Name = "lblMostSubject";
            lblMostSubject.Size = new Size(166, 36);
            lblMostSubject.TabIndex = 8;
            lblMostSubject.Text = "-";
            lblMostSubject.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 68);
            label1.Name = "label1";
            label1.Size = new Size(120, 36);
            label1.TabIndex = 6;
            label1.Text = "Subject with the Most Errors:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(7, 4);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(5);
            lblUser.Size = new Size(302, 64);
            lblUser.TabIndex = 2;
            lblUser.Text = "respondents name";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RespondentsResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 551);
            Controls.Add(mainPanel);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RespondentsResult";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += RespondentsResult_FormClosed;
            leftPanel.ResumeLayout(false);
            userProfilePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel leftPanel;
        private FlowLayoutPanel partsPanel;
        private Panel userProfilePanel;
        private ImageList imageList1;
        private Label lblUser;
        private Label lblLeastSubject;
        private Label label2;
        private Label lblMostSubject;
        private Label label1;
        private Button btnRefresh;
        private Button btnPrevious;
    }
}