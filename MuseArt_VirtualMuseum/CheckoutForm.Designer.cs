namespace MuseArt_VirtualMuseum
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.completeBtn = new FontAwesome.Sharp.IconButton();
            this.pricelLbl = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.checkOutPanel = new System.Windows.Forms.Panel();
            this.emailWarningLbl = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submitBtn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DatemaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CvvmaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreditmaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.confirmationPanel = new System.Windows.Forms.Panel();
            this.orderNumberLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxtLbl = new System.Windows.Forms.Label();
            this.orderNumberTxtLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thankyouLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.btnWindowClose = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.checkOutPanel.SuspendLayout();
            this.confirmationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.completeBtn);
            this.panel1.Controls.Add(this.pricelLbl);
            this.panel1.Controls.Add(this.totalText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 48);
            this.panel1.TabIndex = 21;
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
            this.completeBtn.Location = new System.Drawing.Point(1225, 6);
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
            this.pricelLbl.Location = new System.Drawing.Point(1093, 15);
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
            this.totalText.Location = new System.Drawing.Point(1187, 2);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(32, 15);
            this.totalText.TabIndex = 0;
            this.totalText.Text = "Total";
            // 
            // checkOutPanel
            // 
            this.checkOutPanel.BackColor = System.Drawing.SystemColors.Info;
            this.checkOutPanel.Controls.Add(this.emailWarningLbl);
            this.checkOutPanel.Controls.Add(this.emailTextBox);
            this.checkOutPanel.Controls.Add(this.label4);
            this.checkOutPanel.Controls.Add(this.totalLbl);
            this.checkOutPanel.Controls.Add(this.label5);
            this.checkOutPanel.Controls.Add(this.submitBtn);
            this.checkOutPanel.Controls.Add(this.label3);
            this.checkOutPanel.Controls.Add(this.DatemaskedTB);
            this.checkOutPanel.Controls.Add(this.label2);
            this.checkOutPanel.Controls.Add(this.CvvmaskedTB);
            this.checkOutPanel.Controls.Add(this.label1);
            this.checkOutPanel.Controls.Add(this.CreditmaskedTB);
            this.checkOutPanel.Controls.Add(this.NametextBox);
            this.checkOutPanel.Controls.Add(this.nameLbl);
            this.checkOutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkOutPanel.Location = new System.Drawing.Point(0, 51);
            this.checkOutPanel.Name = "checkOutPanel";
            this.checkOutPanel.Size = new System.Drawing.Size(375, 352);
            this.checkOutPanel.TabIndex = 22;
            // 
            // emailWarningLbl
            // 
            this.emailWarningLbl.AutoSize = true;
            this.emailWarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailWarningLbl.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailWarningLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.emailWarningLbl.Location = new System.Drawing.Point(92, 80);
            this.emailWarningLbl.Name = "emailWarningLbl";
            this.emailWarningLbl.Size = new System.Drawing.Size(222, 13);
            this.emailWarningLbl.TabIndex = 37;
            this.emailWarningLbl.Text = "The exhibition copy will be sent to this email address.";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(56, 100);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(255, 23);
            this.emailTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email";
            // 
            // totalLbl
            // 
            this.totalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLbl.Location = new System.Drawing.Point(12, 306);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(115, 25);
            this.totalLbl.TabIndex = 34;
            this.totalLbl.Text = "00.00€";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Total";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.submitBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.submitBtn.IconColor = System.Drawing.SystemColors.Control;
            this.submitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submitBtn.IconSize = 25;
            this.submitBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.submitBtn.Location = new System.Drawing.Point(168, 293);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.submitBtn.Size = new System.Drawing.Size(143, 38);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit Order";
            this.submitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Date";
            // 
            // DatemaskedTB
            // 
            this.DatemaskedTB.Location = new System.Drawing.Point(56, 227);
            this.DatemaskedTB.Mask = "00/0000";
            this.DatemaskedTB.Name = "DatemaskedTB";
            this.DatemaskedTB.Size = new System.Drawing.Size(100, 23);
            this.DatemaskedTB.TabIndex = 4;
            this.DatemaskedTB.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "CVV";
            // 
            // CvvmaskedTB
            // 
            this.CvvmaskedTB.Location = new System.Drawing.Point(211, 227);
            this.CvvmaskedTB.Mask = "000";
            this.CvvmaskedTB.Name = "CvvmaskedTB";
            this.CvvmaskedTB.Size = new System.Drawing.Size(100, 23);
            this.CvvmaskedTB.TabIndex = 5;
            this.CvvmaskedTB.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Credit Card Number";
            // 
            // CreditmaskedTB
            // 
            this.CreditmaskedTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreditmaskedTB.Location = new System.Drawing.Point(53, 156);
            this.CreditmaskedTB.Mask = "0000 0000 0000 0000";
            this.CreditmaskedTB.Name = "CreditmaskedTB";
            this.CreditmaskedTB.Size = new System.Drawing.Size(258, 29);
            this.CreditmaskedTB.TabIndex = 3;
            this.CreditmaskedTB.ValidatingType = typeof(int);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(56, 46);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(255, 23);
            this.NametextBox.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(56, 23);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(112, 15);
            this.nameLbl.TabIndex = 23;
            this.nameLbl.Text = "Name and Surname";
            // 
            // confirmationPanel
            // 
            this.confirmationPanel.BackColor = System.Drawing.SystemColors.Info;
            this.confirmationPanel.Controls.Add(this.orderNumberLbl);
            this.confirmationPanel.Controls.Add(this.emailLbl);
            this.confirmationPanel.Controls.Add(this.emailTxtLbl);
            this.confirmationPanel.Controls.Add(this.orderNumberTxtLbl);
            this.confirmationPanel.Controls.Add(this.label6);
            this.confirmationPanel.Controls.Add(this.pictureBox1);
            this.confirmationPanel.Controls.Add(this.thankyouLbl);
            this.confirmationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmationPanel.Location = new System.Drawing.Point(0, 51);
            this.confirmationPanel.Name = "confirmationPanel";
            this.confirmationPanel.Size = new System.Drawing.Size(375, 352);
            this.confirmationPanel.TabIndex = 23;
            // 
            // orderNumberLbl
            // 
            this.orderNumberLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderNumberLbl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderNumberLbl.Location = new System.Drawing.Point(136, 198);
            this.orderNumberLbl.Name = "orderNumberLbl";
            this.orderNumberLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderNumberLbl.Size = new System.Drawing.Size(117, 22);
            this.orderNumberLbl.TabIndex = 7;
            this.orderNumberLbl.Text = "423874";
            this.orderNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLbl
            // 
            this.emailLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.emailLbl.Location = new System.Drawing.Point(108, 294);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.emailLbl.Size = new System.Drawing.Size(170, 21);
            this.emailLbl.TabIndex = 9;
            this.emailLbl.Text = "email";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTxtLbl
            // 
            this.emailTxtLbl.AutoSize = true;
            this.emailTxtLbl.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxtLbl.Location = new System.Drawing.Point(102, 276);
            this.emailTxtLbl.Name = "emailTxtLbl";
            this.emailTxtLbl.Size = new System.Drawing.Size(182, 15);
            this.emailTxtLbl.TabIndex = 8;
            this.emailTxtLbl.Text = "Your exhibition copy will be sent to";
            // 
            // orderNumberTxtLbl
            // 
            this.orderNumberTxtLbl.AutoSize = true;
            this.orderNumberTxtLbl.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderNumberTxtLbl.Location = new System.Drawing.Point(161, 183);
            this.orderNumberTxtLbl.Name = "orderNumberTxtLbl";
            this.orderNumberTxtLbl.Size = new System.Drawing.Size(65, 13);
            this.orderNumberTxtLbl.TabIndex = 6;
            this.orderNumberTxtLbl.Text = "Order Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(104, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Estimated pick up time: 1h";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // thankyouLbl
            // 
            this.thankyouLbl.AutoSize = true;
            this.thankyouLbl.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thankyouLbl.Location = new System.Drawing.Point(108, 44);
            this.thankyouLbl.Name = "thankyouLbl";
            this.thankyouLbl.Size = new System.Drawing.Size(170, 19);
            this.thankyouLbl.TabIndex = 0;
            this.thankyouLbl.Text = "Thank you for your order!";
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(102, 15);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(181, 23);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Checkout";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWindowClose
            // 
            this.btnWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowClose.FlatAppearance.BorderSize = 0;
            this.btnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowClose.Font = new System.Drawing.Font("Omnes Med", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWindowClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowClose.Location = new System.Drawing.Point(346, 3);
            this.btnWindowClose.Name = "btnWindowClose";
            this.btnWindowClose.Size = new System.Drawing.Size(26, 26);
            this.btnWindowClose.TabIndex = 3;
            this.btnWindowClose.Text = "X";
            this.btnWindowClose.UseVisualStyleBackColor = true;
            this.btnWindowClose.Click += new System.EventHandler(this.btnWindowClose_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelTop.Controls.Add(this.btnWindowClose);
            this.panelTop.Controls.Add(this.titleLbl);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(375, 51);
            this.panelTop.TabIndex = 19;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 451);
            this.ControlBox = false;
            this.Controls.Add(this.checkOutPanel);
            this.Controls.Add(this.confirmationPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.checkOutPanel.ResumeLayout(false);
            this.checkOutPanel.PerformLayout();
            this.confirmationPanel.ResumeLayout(false);
            this.confirmationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton completeBtn;
        private Label pricelLbl;
        private Label totalText;
        private Panel checkOutPanel;
        private Label label3;
        private MaskedTextBox DatemaskedTB;
        private Label label2;
        private MaskedTextBox CvvmaskedTB;
        private Label label1;
        private MaskedTextBox CreditmaskedTB;
        private TextBox NametextBox;
        private Label nameLbl;
        private FontAwesome.Sharp.IconButton submitBtn;
        private Label totalLbl;
        private Label label5;
        private Label label4;
        private TextBox emailTextBox;
        private Panel confirmationPanel;
        private Label label6;
        private PictureBox pictureBox1;
        private Label thankyouLbl;
        private Label orderNumberLbl;
        private Label orderNumberTxtLbl;
        private Label emailLbl;
        private Label emailTxtLbl;
        private Label titleLbl;
        private Button btnWindowClose;
        private Panel panelTop;
        private Label emailWarningLbl;
    }
}