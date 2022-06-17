namespace MuseArt_VirtualMuseum
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.InboxFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnWindowMinimize = new System.Windows.Forms.Button();
            this.btnWindowMaximize = new System.Windows.Forms.Button();
            this.btnWindowClose = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LogoutBtn = new FontAwesome.Sharp.IconButton();
            this.InboxBtn = new FontAwesome.Sharp.IconButton();
            this.ExhibitionsBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelDesktop.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Info;
            this.panelDesktop.Controls.Add(this.InboxFlowLayout);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(210, 56);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(959, 628);
            this.panelDesktop.TabIndex = 6;
            // 
            // InboxFlowLayout
            // 
            this.InboxFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InboxFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.InboxFlowLayout.Name = "InboxFlowLayout";
            this.InboxFlowLayout.Size = new System.Drawing.Size(959, 628);
            this.InboxFlowLayout.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelTitleBar.Controls.Add(this.btnWindowMinimize);
            this.panelTitleBar.Controls.Add(this.btnWindowMaximize);
            this.panelTitleBar.Controls.Add(this.btnWindowClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(210, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(959, 56);
            this.panelTitleBar.TabIndex = 5;
            // 
            // btnWindowMinimize
            // 
            this.btnWindowMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowMinimize.FlatAppearance.BorderSize = 0;
            this.btnWindowMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMinimize.Font = new System.Drawing.Font("Boldfinger", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWindowMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowMinimize.Location = new System.Drawing.Point(1631, 4);
            this.btnWindowMinimize.Name = "btnWindowMinimize";
            this.btnWindowMinimize.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnWindowMinimize.Size = new System.Drawing.Size(26, 26);
            this.btnWindowMinimize.TabIndex = 4;
            this.btnWindowMinimize.Text = "_";
            this.btnWindowMinimize.UseVisualStyleBackColor = true;
            // 
            // btnWindowMaximize
            // 
            this.btnWindowMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowMaximize.FlatAppearance.BorderSize = 0;
            this.btnWindowMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMaximize.Font = new System.Drawing.Font("Omnes Med", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWindowMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowMaximize.Location = new System.Drawing.Point(1660, 4);
            this.btnWindowMaximize.Name = "btnWindowMaximize";
            this.btnWindowMaximize.Size = new System.Drawing.Size(26, 26);
            this.btnWindowMaximize.TabIndex = 3;
            this.btnWindowMaximize.Text = "O";
            this.btnWindowMaximize.UseVisualStyleBackColor = true;
            // 
            // btnWindowClose
            // 
            this.btnWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowClose.FlatAppearance.BorderSize = 0;
            this.btnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowClose.Font = new System.Drawing.Font("Omnes Med", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWindowClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowClose.Location = new System.Drawing.Point(1687, 4);
            this.btnWindowClose.Name = "btnWindowClose";
            this.btnWindowClose.Size = new System.Drawing.Size(26, 26);
            this.btnWindowClose.TabIndex = 2;
            this.btnWindowClose.Text = "X";
            this.btnWindowClose.UseVisualStyleBackColor = true;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(58, 17);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(56, 21);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.AntiqueWhite;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Brown;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Brown;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(26, 13);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelMenu.Controls.Add(this.LogoutBtn);
            this.panelMenu.Controls.Add(this.InboxBtn);
            this.panelMenu.Controls.Add(this.ExhibitionsBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 684);
            this.panelMenu.TabIndex = 4;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.IndianRed;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.LogoutBtn.IconColor = System.Drawing.Color.White;
            this.LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutBtn.IconSize = 20;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 636);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(210, 48);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // InboxBtn
            // 
            this.InboxBtn.BackColor = System.Drawing.Color.Transparent;
            this.InboxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InboxBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InboxBtn.FlatAppearance.BorderSize = 0;
            this.InboxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InboxBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InboxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InboxBtn.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.InboxBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InboxBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InboxBtn.IconSize = 32;
            this.InboxBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InboxBtn.Location = new System.Drawing.Point(0, 152);
            this.InboxBtn.Name = "InboxBtn";
            this.InboxBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.InboxBtn.Size = new System.Drawing.Size(210, 47);
            this.InboxBtn.TabIndex = 4;
            this.InboxBtn.Text = "Inbox";
            this.InboxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InboxBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InboxBtn.UseVisualStyleBackColor = false;
            this.InboxBtn.Click += new System.EventHandler(this.InboxBtn_Click);
            // 
            // ExhibitionsBtn
            // 
            this.ExhibitionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExhibitionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExhibitionsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExhibitionsBtn.FlatAppearance.BorderSize = 0;
            this.ExhibitionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExhibitionsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExhibitionsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExhibitionsBtn.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.ExhibitionsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExhibitionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExhibitionsBtn.IconSize = 32;
            this.ExhibitionsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExhibitionsBtn.Location = new System.Drawing.Point(0, 105);
            this.ExhibitionsBtn.Name = "ExhibitionsBtn";
            this.ExhibitionsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ExhibitionsBtn.Size = new System.Drawing.Size(210, 47);
            this.ExhibitionsBtn.TabIndex = 2;
            this.ExhibitionsBtn.Text = "Exhibitions";
            this.ExhibitionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExhibitionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExhibitionsBtn.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 105);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(15, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 87);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 684);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.panelDesktop.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel panelDesktop;
        private Panel panelTitleBar;
        private Button btnWindowMinimize;
        private Button btnWindowMaximize;
        private Button btnWindowClose;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private FontAwesome.Sharp.IconButton InboxBtn;
        private Panel panelLogo;
        private PictureBox btnHome;
        private FlowLayoutPanel InboxFlowLayout;
        private FontAwesome.Sharp.IconButton ExhibitionsBtn;
    }
}