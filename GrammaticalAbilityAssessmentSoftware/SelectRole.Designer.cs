namespace GrammaticalAbilityAssessmentSoftware
{
    partial class SelectRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectRole));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnAdmin = new Button();
            imageList1 = new ImageList(components);
            label2 = new Label();
            btnCancel = new Button();
            btnVerify = new Button();
            txtPin = new TextBox();
            btnRespondents = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 60);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 12);
            label1.Name = "label1";
            label1.Size = new Size(241, 36);
            label1.TabIndex = 0;
            label1.Text = "Select your Role";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnRespondents);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 203);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdmin);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnVerify);
            panel3.Controls.Add(txtPin);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(216, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 203);
            panel3.TabIndex = 1;
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Left;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.ImageKey = "user-gear.png";
            btnAdmin.ImageList = imageList1;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(216, 203);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Administrator";
            btnAdmin.TextAlign = ContentAlignment.BottomCenter;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "user-gear.png");
            imageList1.Images.SetKeyName(1, "ancestors.png");
            imageList1.Images.SetKeyName(2, "multiply.png");
            imageList1.Images.SetKeyName(3, "verified.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 45);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 3;
            label2.Text = "Enter you Pin:";
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImage = Properties.Resources.multiply;
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ImageIndex = 3;
            btnCancel.Location = new Point(156, 112);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(43, 38);
            btnCancel.TabIndex = 2;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnVerify
            // 
            btnVerify.BackgroundImage = Properties.Resources.verified;
            btnVerify.BackgroundImageLayout = ImageLayout.Zoom;
            btnVerify.FlatAppearance.BorderSize = 0;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.ImageIndex = 3;
            btnVerify.Location = new Point(107, 112);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(43, 38);
            btnVerify.TabIndex = 1;
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // txtPin
            // 
            txtPin.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPin.Location = new Point(16, 69);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(183, 37);
            txtPin.TabIndex = 0;
            // 
            // btnRespondents
            // 
            btnRespondents.Dock = DockStyle.Left;
            btnRespondents.FlatStyle = FlatStyle.Flat;
            btnRespondents.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRespondents.ImageKey = "ancestors.png";
            btnRespondents.ImageList = imageList1;
            btnRespondents.Location = new Point(0, 0);
            btnRespondents.Name = "btnRespondents";
            btnRespondents.Size = new Size(216, 203);
            btnRespondents.TabIndex = 0;
            btnRespondents.Text = "Respondents";
            btnRespondents.TextAlign = ContentAlignment.BottomCenter;
            btnRespondents.UseVisualStyleBackColor = true;
            btnRespondents.Click += btnRespondents_Click;
            // 
            // SelectRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 263);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SelectRole";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ImageList imageList1;
        private Button btnRespondents;
        private Label label1;
        private Panel panel3;
        private Button btnCancel;
        private Button btnVerify;
        private TextBox txtPin;
        private Label label2;
        private Button btnAdmin;
    }
}