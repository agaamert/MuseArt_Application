namespace MuseArt_VirtualMuseum
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MuseArtbtnExploreVM = new FontAwesome.Sharp.IconButton();
            this.btnShoppingCart = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnTalk = new FontAwesome.Sharp.IconButton();
            this.btnExhibitions = new FontAwesome.Sharp.IconButton();
            this.btnExplore = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnWindowMinimize = new System.Windows.Forms.Button();
            this.btnWindowMaximize = new System.Windows.Forms.Button();
            this.btnWindowClose = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelLine = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelMenu.Controls.Add(this.MuseArtbtnExploreVM);
            this.panelMenu.Controls.Add(this.btnShoppingCart);
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnTalk);
            this.panelMenu.Controls.Add(this.btnExhibitions);
            this.panelMenu.Controls.Add(this.btnExplore);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 684);
            this.panelMenu.TabIndex = 0;
            // 
            // MuseArtbtnExploreVM
            // 
            this.MuseArtbtnExploreVM.BackColor = System.Drawing.Color.Transparent;
            this.MuseArtbtnExploreVM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuseArtbtnExploreVM.FlatAppearance.BorderSize = 0;
            this.MuseArtbtnExploreVM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuseArtbtnExploreVM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuseArtbtnExploreVM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MuseArtbtnExploreVM.IconChar = FontAwesome.Sharp.IconChar.Ioxhost;
            this.MuseArtbtnExploreVM.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MuseArtbtnExploreVM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MuseArtbtnExploreVM.IconSize = 40;
            this.MuseArtbtnExploreVM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MuseArtbtnExploreVM.Location = new System.Drawing.Point(-1, 422);
            this.MuseArtbtnExploreVM.Name = "MuseArtbtnExploreVM";
            this.MuseArtbtnExploreVM.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MuseArtbtnExploreVM.Size = new System.Drawing.Size(211, 60);
            this.MuseArtbtnExploreVM.TabIndex = 7;
            this.MuseArtbtnExploreVM.Text = "MuseArt Virtual Tour";
            this.MuseArtbtnExploreVM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MuseArtbtnExploreVM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MuseArtbtnExploreVM.UseVisualStyleBackColor = false;
            this.MuseArtbtnExploreVM.Click += new System.EventHandler(this.MuseArtbtnExploreVM_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.BackColor = System.Drawing.Color.IndianRed;
            this.btnShoppingCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoppingCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.ForeColor = System.Drawing.Color.White;
            this.btnShoppingCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btnShoppingCart.IconColor = System.Drawing.Color.White;
            this.btnShoppingCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShoppingCart.IconSize = 32;
            this.btnShoppingCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShoppingCart.Location = new System.Drawing.Point(0, 636);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(210, 48);
            this.btnShoppingCart.TabIndex = 6;
            this.btnShoppingCart.Text = "Basket";
            this.btnShoppingCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShoppingCart.UseVisualStyleBackColor = false;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            this.btnShoppingCart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnAbout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 32;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 246);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAbout.Size = new System.Drawing.Size(210, 47);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About MuseArt";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnTalk
            // 
            this.btnTalk.BackColor = System.Drawing.Color.Transparent;
            this.btnTalk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTalk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTalk.FlatAppearance.BorderSize = 0;
            this.btnTalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTalk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTalk.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.btnTalk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTalk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTalk.IconSize = 32;
            this.btnTalk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTalk.Location = new System.Drawing.Point(0, 199);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTalk.Size = new System.Drawing.Size(210, 47);
            this.btnTalk.TabIndex = 4;
            this.btnTalk.Text = "Communicate";
            this.btnTalk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTalk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnExhibitions
            // 
            this.btnExhibitions.BackColor = System.Drawing.Color.Transparent;
            this.btnExhibitions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExhibitions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExhibitions.FlatAppearance.BorderSize = 0;
            this.btnExhibitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExhibitions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExhibitions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExhibitions.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.btnExhibitions.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExhibitions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExhibitions.IconSize = 32;
            this.btnExhibitions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExhibitions.Location = new System.Drawing.Point(0, 152);
            this.btnExhibitions.Name = "btnExhibitions";
            this.btnExhibitions.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExhibitions.Size = new System.Drawing.Size(210, 47);
            this.btnExhibitions.TabIndex = 2;
            this.btnExhibitions.Text = "Exhibitions";
            this.btnExhibitions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExhibitions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExhibitions.UseVisualStyleBackColor = false;
            this.btnExhibitions.Click += new System.EventHandler(this.btnExhibitions_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.BackColor = System.Drawing.Color.Transparent;
            this.btnExplore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExplore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExplore.FlatAppearance.BorderSize = 0;
            this.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExplore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExplore.IconChar = FontAwesome.Sharp.IconChar.Map;
            this.btnExplore.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExplore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExplore.IconSize = 32;
            this.btnExplore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExplore.Location = new System.Drawing.Point(0, 105);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExplore.Size = new System.Drawing.Size(210, 47);
            this.btnExplore.TabIndex = 1;
            this.btnExplore.Text = "Explore";
            this.btnExplore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExplore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExplore.UseVisualStyleBackColor = false;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.DoubleClick += new System.EventHandler(this.panelTitleBar_DoubleClick);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnWindowMinimize
            // 
            this.btnWindowMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowMinimize.FlatAppearance.BorderSize = 0;
            this.btnWindowMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMinimize.Font = new System.Drawing.Font("Boldfinger", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWindowMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowMinimize.Location = new System.Drawing.Point(872, 4);
            this.btnWindowMinimize.Name = "btnWindowMinimize";
            this.btnWindowMinimize.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnWindowMinimize.Size = new System.Drawing.Size(26, 26);
            this.btnWindowMinimize.TabIndex = 4;
            this.btnWindowMinimize.Text = "_";
            this.btnWindowMinimize.UseVisualStyleBackColor = true;
            this.btnWindowMinimize.Click += new System.EventHandler(this.btnWindowMinimize_Click);
            // 
            // btnWindowMaximize
            // 
            this.btnWindowMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowMaximize.FlatAppearance.BorderSize = 0;
            this.btnWindowMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMaximize.Font = new System.Drawing.Font("Omnes Med", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWindowMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowMaximize.Location = new System.Drawing.Point(901, 4);
            this.btnWindowMaximize.Name = "btnWindowMaximize";
            this.btnWindowMaximize.Size = new System.Drawing.Size(26, 26);
            this.btnWindowMaximize.TabIndex = 3;
            this.btnWindowMaximize.Text = "O";
            this.btnWindowMaximize.UseVisualStyleBackColor = true;
            this.btnWindowMaximize.Click += new System.EventHandler(this.btnWindowMaximize_Click);
            // 
            // btnWindowClose
            // 
            this.btnWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowClose.FlatAppearance.BorderSize = 0;
            this.btnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowClose.Font = new System.Drawing.Font("Omnes Med", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWindowClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.btnWindowClose.Location = new System.Drawing.Point(928, 4);
            this.btnWindowClose.Name = "btnWindowClose";
            this.btnWindowClose.Size = new System.Drawing.Size(26, 26);
            this.btnWindowClose.TabIndex = 2;
            this.btnWindowClose.Text = "X";
            this.btnWindowClose.UseVisualStyleBackColor = true;
            this.btnWindowClose.Click += new System.EventHandler(this.btnWindowClose_Click);
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
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Brown;
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(210, 56);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(959, 3);
            this.panelLine.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Info;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(210, 59);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(959, 625);
            this.panelDesktop.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1169, 684);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnTalk;
        private FontAwesome.Sharp.IconButton btnExhibitions;
        private FontAwesome.Sharp.IconButton btnExplore;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelLine;
        private FontAwesome.Sharp.IconButton btnShoppingCart;
        private Button btnWindowClose;
        private Button btnWindowMinimize;
        private Button btnWindowMaximize;
        private FontAwesome.Sharp.IconButton MuseArtbtnExploreVM;
        public Panel panelDesktop;
    }
}