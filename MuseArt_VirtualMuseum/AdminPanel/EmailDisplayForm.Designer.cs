namespace MuseArt_VirtualMuseum.AdminPanel
{
    partial class EmailDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailDisplayForm));
            this.emailLbl = new System.Windows.Forms.Label();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnWindowClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.completeBtn = new FontAwesome.Sharp.IconButton();
            this.pricelLbl = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.SenderLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLbl.Location = new System.Drawing.Point(103, 66);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(175, 20);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "agaamert@outlook.com";
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectLbl.Location = new System.Drawing.Point(103, 102);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(67, 21);
            this.subjectLbl.TabIndex = 2;
            this.subjectLbl.Text = "Subject";
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.Moccasin;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Location = new System.Drawing.Point(36, 151);
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(499, 383);
            this.messageBox.TabIndex = 3;
            this.messageBox.Text = "";
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(200, 15);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(181, 23);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Inbox";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelTop.Controls.Add(this.btnWindowClose);
            this.panelTop.Controls.Add(this.titleLbl);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(573, 51);
            this.panelTop.TabIndex = 23;
            // 
            // btnWindowClose
            // 
            this.btnWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowClose.FlatAppearance.BorderSize = 0;
            this.btnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowClose.Font = new System.Drawing.Font("Omnes Med", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWindowClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowClose.Location = new System.Drawing.Point(538, 8);
            this.btnWindowClose.Name = "btnWindowClose";
            this.btnWindowClose.Size = new System.Drawing.Size(26, 26);
            this.btnWindowClose.TabIndex = 3;
            this.btnWindowClose.Text = "X";
            this.btnWindowClose.UseVisualStyleBackColor = true;
            this.btnWindowClose.Click += new System.EventHandler(this.btnWindowClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.completeBtn);
            this.panel1.Controls.Add(this.pricelLbl);
            this.panel1.Controls.Add(this.totalText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 48);
            this.panel1.TabIndex = 24;
            // 
            // completeBtn
            // 
            this.completeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.completeBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.completeBtn.FlatAppearance.BorderSize = 0;
            this.completeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.completeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.completeBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.completeBtn.IconColor = System.Drawing.SystemColors.Control;
            this.completeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.completeBtn.IconSize = 25;
            this.completeBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.completeBtn.Location = new System.Drawing.Point(1598, 6);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.completeBtn.Size = new System.Drawing.Size(113, 38);
            this.completeBtn.TabIndex = 2;
            this.completeBtn.Text = "Checkout";
            this.completeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.completeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.completeBtn.UseVisualStyleBackColor = false;
            // 
            // pricelLbl
            // 
            this.pricelLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pricelLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricelLbl.Location = new System.Drawing.Point(1466, 15);
            this.pricelLbl.Name = "pricelLbl";
            this.pricelLbl.Size = new System.Drawing.Size(126, 25);
            this.pricelLbl.TabIndex = 1;
            this.pricelLbl.Text = "00.00€";
            this.pricelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalText
            // 
            this.totalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalText.AutoSize = true;
            this.totalText.Location = new System.Drawing.Point(1560, 2);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(32, 15);
            this.totalText.TabIndex = 0;
            this.totalText.Text = "Total";
            // 
            // SenderLbl
            // 
            this.SenderLbl.AutoSize = true;
            this.SenderLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SenderLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SenderLbl.Location = new System.Drawing.Point(36, 66);
            this.SenderLbl.Name = "SenderLbl";
            this.SenderLbl.Size = new System.Drawing.Size(46, 20);
            this.SenderLbl.TabIndex = 25;
            this.SenderLbl.Text = "from:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(36, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "subject:";
            // 
            // EmailDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(573, 615);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SenderLbl);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.subjectLbl);
            this.Controls.Add(this.emailLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EmailDisplayForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label emailLbl;
        private Label subjectLbl;
        private RichTextBox messageBox;
        private Label titleLbl;
        private Panel panelTop;
        private Button btnWindowClose;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton completeBtn;
        private Label pricelLbl;
        private Label totalText;
        private Label SenderLbl;
        private Label label1;
    }
}