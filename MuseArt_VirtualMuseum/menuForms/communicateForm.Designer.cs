namespace MuseArt_VirtualMuseum.menuForms
{
    partial class communicateForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendBtn = new FontAwesome.Sharp.IconButton();
            this.textText = new System.Windows.Forms.Label();
            this.messageTB = new System.Windows.Forms.RichTextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SubjectTBox = new System.Windows.Forms.TextBox();
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.NameErrorLbl = new System.Windows.Forms.Label();
            this.SubjectErrorLbl = new System.Windows.Forms.Label();
            this.EmailErrorLbl = new System.Windows.Forms.Label();
            this.MsgErrorLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.MsgErrorLbl);
            this.panel1.Controls.Add(this.EmailErrorLbl);
            this.panel1.Controls.Add(this.SubjectErrorLbl);
            this.panel1.Controls.Add(this.NameErrorLbl);
            this.panel1.Controls.Add(this.SubjectTBox);
            this.panel1.Controls.Add(this.SubjectLbl);
            this.panel1.Controls.Add(this.sendBtn);
            this.panel1.Controls.Add(this.textText);
            this.panel1.Controls.Add(this.messageTB);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 684);
            this.panel1.TabIndex = 15;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sendBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.sendBtn.IconColor = System.Drawing.SystemColors.Control;
            this.sendBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sendBtn.IconSize = 25;
            this.sendBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sendBtn.Location = new System.Drawing.Point(619, 531);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.sendBtn.Size = new System.Drawing.Size(120, 38);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send Email";
            this.sendBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            this.sendBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendBtn_KeyPress);
            // 
            // textText
            // 
            this.textText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textText.AutoSize = true;
            this.textText.Location = new System.Drawing.Point(410, 349);
            this.textText.Name = "textText";
            this.textText.Size = new System.Drawing.Size(53, 15);
            this.textText.TabIndex = 6;
            this.textText.Text = "Message";
            // 
            // messageTB
            // 
            this.messageTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.messageTB.Location = new System.Drawing.Point(410, 370);
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(329, 139);
            this.messageTB.TabIndex = 4;
            this.messageTB.Text = "";
            // 
            // emailText
            // 
            this.emailText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailText.Location = new System.Drawing.Point(407, 309);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(332, 23);
            this.emailText.TabIndex = 3;
            // 
            // emailLbl
            // 
            this.emailLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(407, 287);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(36, 15);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email";
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameText.Location = new System.Drawing.Point(407, 197);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(332, 23);
            this.nameText.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(407, 175);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 15);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Full Name";
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(407, 118);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(227, 30);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Communicate with us";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1169, 46);
            this.panelTop.TabIndex = 16;
            // 
            // SubjectTBox
            // 
            this.SubjectTBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubjectTBox.Location = new System.Drawing.Point(407, 255);
            this.SubjectTBox.Name = "SubjectTBox";
            this.SubjectTBox.Size = new System.Drawing.Size(332, 23);
            this.SubjectTBox.TabIndex = 2;
            // 
            // SubjectLbl
            // 
            this.SubjectLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Location = new System.Drawing.Point(407, 233);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(46, 15);
            this.SubjectLbl.TabIndex = 34;
            this.SubjectLbl.Text = "Subject";
            // 
            // NameErrorLbl
            // 
            this.NameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameErrorLbl.AutoSize = true;
            this.NameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLbl.Location = new System.Drawing.Point(474, 175);
            this.NameErrorLbl.Name = "NameErrorLbl";
            this.NameErrorLbl.Size = new System.Drawing.Size(96, 15);
            this.NameErrorLbl.TabIndex = 36;
            this.NameErrorLbl.Text = "* Name is invalid";
            // 
            // SubjectErrorLbl
            // 
            this.SubjectErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubjectErrorLbl.AutoSize = true;
            this.SubjectErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.SubjectErrorLbl.Location = new System.Drawing.Point(459, 233);
            this.SubjectErrorLbl.Name = "SubjectErrorLbl";
            this.SubjectErrorLbl.Size = new System.Drawing.Size(103, 15);
            this.SubjectErrorLbl.TabIndex = 37;
            this.SubjectErrorLbl.Text = "* Subject is invalid";
            // 
            // EmailErrorLbl
            // 
            this.EmailErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailErrorLbl.AutoSize = true;
            this.EmailErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.EmailErrorLbl.Location = new System.Drawing.Point(449, 287);
            this.EmailErrorLbl.Name = "EmailErrorLbl";
            this.EmailErrorLbl.Size = new System.Drawing.Size(93, 15);
            this.EmailErrorLbl.TabIndex = 38;
            this.EmailErrorLbl.Text = "* Email is invalid";
            // 
            // MsgErrorLbl
            // 
            this.MsgErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgErrorLbl.AutoSize = true;
            this.MsgErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.MsgErrorLbl.Location = new System.Drawing.Point(469, 349);
            this.MsgErrorLbl.Name = "MsgErrorLbl";
            this.MsgErrorLbl.Size = new System.Drawing.Size(110, 15);
            this.MsgErrorLbl.TabIndex = 39;
            this.MsgErrorLbl.Text = "* Message is invalid";
            // 
            // communicateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 684);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Name = "communicateForm";
            this.Text = "talkForm";
            this.Load += new System.EventHandler(this.communicateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label textText;
        private RichTextBox messageTB;
        private TextBox emailText;
        private Label emailLbl;
        private TextBox nameText;
        private Label nameLbl;
        private Label titleLbl;
        private FontAwesome.Sharp.IconButton sendBtn;
        private Panel panelTop;
        private TextBox SubjectTBox;
        private Label SubjectLbl;
        private Label EmailErrorLbl;
        private Label SubjectErrorLbl;
        private Label NameErrorLbl;
        private Label MsgErrorLbl;
    }
}