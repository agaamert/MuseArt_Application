namespace MuseArt_VirtualMuseum
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWindowClose = new System.Windows.Forms.Button();
            this.loginAdminLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PwdLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.PwdTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.btnWindowClose);
            this.panelTop.Controls.Add(this.loginAdminLbl);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(357, 51);
            this.panelTop.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnWindowClose
            // 
            this.btnWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowClose.FlatAppearance.BorderSize = 0;
            this.btnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowClose.Font = new System.Drawing.Font("Omnes Med", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWindowClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowClose.Location = new System.Drawing.Point(319, 10);
            this.btnWindowClose.Name = "btnWindowClose";
            this.btnWindowClose.Size = new System.Drawing.Size(26, 26);
            this.btnWindowClose.TabIndex = 3;
            this.btnWindowClose.Text = "X";
            this.btnWindowClose.UseVisualStyleBackColor = true;
            this.btnWindowClose.Click += new System.EventHandler(this.btnWindowClose_Click);
            // 
            // loginAdminLbl
            // 
            this.loginAdminLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginAdminLbl.BackColor = System.Drawing.Color.Transparent;
            this.loginAdminLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginAdminLbl.Location = new System.Drawing.Point(134, 14);
            this.loginAdminLbl.Name = "loginAdminLbl";
            this.loginAdminLbl.Size = new System.Drawing.Size(125, 23);
            this.loginAdminLbl.TabIndex = 0;
            this.loginAdminLbl.Text = "Admin Login";
            this.loginAdminLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 48);
            this.panel1.TabIndex = 24;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.LoginBtn);
            this.panelLogin.Controls.Add(this.PwdLbl);
            this.panelLogin.Controls.Add(this.usernameLbl);
            this.panelLogin.Controls.Add(this.PwdTB);
            this.panelLogin.Controls.Add(this.UsernameTB);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 51);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(357, 259);
            this.panelLogin.TabIndex = 25;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.LoginBtn.Location = new System.Drawing.Point(61, 184);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(236, 42);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PwdLbl
            // 
            this.PwdLbl.AutoSize = true;
            this.PwdLbl.ForeColor = System.Drawing.Color.Gray;
            this.PwdLbl.Location = new System.Drawing.Point(61, 103);
            this.PwdLbl.Name = "PwdLbl";
            this.PwdLbl.Size = new System.Drawing.Size(57, 15);
            this.PwdLbl.TabIndex = 3;
            this.PwdLbl.Text = "Password";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.ForeColor = System.Drawing.Color.Gray;
            this.usernameLbl.Location = new System.Drawing.Point(61, 35);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(60, 15);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username";
            // 
            // PwdTB
            // 
            this.PwdTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PwdTB.Location = new System.Drawing.Point(61, 121);
            this.PwdTB.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.PwdTB.Multiline = true;
            this.PwdTB.Name = "PwdTB";
            this.PwdTB.PasswordChar = '*';
            this.PwdTB.Size = new System.Drawing.Size(236, 37);
            this.PwdTB.TabIndex = 2;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTB.Location = new System.Drawing.Point(61, 54);
            this.UsernameTB.Multiline = true;
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(236, 37);
            this.UsernameTB.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(357, 358);
            this.ControlBox = false;
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTop;
        private Panel panel1;
        private Panel panelLogin;
        private Label PwdLbl;
        private Label usernameLbl;
        private TextBox PwdTB;
        private TextBox UsernameTB;
        private Button LoginBtn;
        private PictureBox pictureBox1;
        private Button btnWindowClose;
        private Label loginAdminLbl;
    }
}