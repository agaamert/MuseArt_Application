namespace MuseArt_VirtualMuseum.menuForms
{
    partial class exhibitionsForm
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
            this.exhibitsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.showtextLbl = new System.Windows.Forms.Label();
            this.addedPanel = new System.Windows.Forms.Panel();
            this.addedLblText = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panelDesktopEF = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.addedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.panelDesktopEF.SuspendLayout();
            this.SuspendLayout();
            // 
            // exhibitsFlowLayoutPanel
            // 
            this.exhibitsFlowLayoutPanel.AutoScroll = true;
            this.exhibitsFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Info;
            this.exhibitsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exhibitsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.exhibitsFlowLayoutPanel.Name = "exhibitsFlowLayoutPanel";
            this.exhibitsFlowLayoutPanel.Size = new System.Drawing.Size(1169, 590);
            this.exhibitsFlowLayoutPanel.TabIndex = 15;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelTop.Controls.Add(this.categoryComboBox);
            this.panelTop.Controls.Add(this.showtextLbl);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1169, 46);
            this.panelTop.TabIndex = 14;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "All",
            "Archeology",
            "NFT",
            "Portrait"});
            this.categoryComboBox.Location = new System.Drawing.Point(144, 11);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 23);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // showtextLbl
            // 
            this.showtextLbl.AutoSize = true;
            this.showtextLbl.Location = new System.Drawing.Point(31, 15);
            this.showtextLbl.Name = "showtextLbl";
            this.showtextLbl.Size = new System.Drawing.Size(107, 15);
            this.showtextLbl.TabIndex = 0;
            this.showtextLbl.Text = "Showing Category:";
            // 
            // addedPanel
            // 
            this.addedPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addedPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addedPanel.Controls.Add(this.addedLblText);
            this.addedPanel.Controls.Add(this.iconPictureBox1);
            this.addedPanel.Enabled = false;
            this.addedPanel.Location = new System.Drawing.Point(436, 3);
            this.addedPanel.Name = "addedPanel";
            this.addedPanel.Size = new System.Drawing.Size(353, 42);
            this.addedPanel.TabIndex = 0;
            // 
            // addedLblText
            // 
            this.addedLblText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addedLblText.ForeColor = System.Drawing.SystemColors.Control;
            this.addedLblText.Location = new System.Drawing.Point(64, 10);
            this.addedLblText.Name = "addedLblText";
            this.addedLblText.Size = new System.Drawing.Size(271, 21);
            this.addedLblText.TabIndex = 1;
            this.addedLblText.Text = "Item added to Basket.";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(15, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 31);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bottomPanel.Controls.Add(this.addedPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 636);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1169, 48);
            this.bottomPanel.TabIndex = 15;
            // 
            // panelDesktopEF
            // 
            this.panelDesktopEF.Controls.Add(this.exhibitsFlowLayoutPanel);
            this.panelDesktopEF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopEF.Location = new System.Drawing.Point(0, 46);
            this.panelDesktopEF.Name = "panelDesktopEF";
            this.panelDesktopEF.Size = new System.Drawing.Size(1169, 590);
            this.panelDesktopEF.TabIndex = 16;
            // 
            // exhibitionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1169, 684);
            this.Controls.Add(this.panelDesktopEF);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panelTop);
            this.Name = "exhibitionsForm";
            this.Text = "shopForm";
            this.Load += new System.EventHandler(this.exhibitionsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.addedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.panelDesktopEF.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel exhibitsFlowLayoutPanel;
        private Panel panelTop;
        private Panel addedPanel;
        private Label addedLblText;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel bottomPanel;
        private ComboBox categoryComboBox;
        private Label showtextLbl;
        private Panel panelDesktopEF;
    }
}