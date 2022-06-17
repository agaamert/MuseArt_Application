namespace MuseArt_VirtualMuseum
{
    partial class InboxItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InboxItem));
            this.IconEmailClosed = new System.Windows.Forms.PictureBox();
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.IconEmailOpened = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmailClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmailOpened)).BeginInit();
            this.SuspendLayout();
            // 
            // IconEmailClosed
            // 
            this.IconEmailClosed.Image = ((System.Drawing.Image)(resources.GetObject("IconEmailClosed.Image")));
            this.IconEmailClosed.Location = new System.Drawing.Point(74, 22);
            this.IconEmailClosed.Name = "IconEmailClosed";
            this.IconEmailClosed.Size = new System.Drawing.Size(53, 58);
            this.IconEmailClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconEmailClosed.TabIndex = 0;
            this.IconEmailClosed.TabStop = false;
            // 
            // SubjectLbl
            // 
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubjectLbl.Location = new System.Drawing.Point(149, 40);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(67, 21);
            this.SubjectLbl.TabIndex = 1;
            this.SubjectLbl.Text = "Subject";
            // 
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReadBtn.FlatAppearance.BorderSize = 0;
            this.ReadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadBtn.ForeColor = System.Drawing.Color.OliveDrab;
            this.ReadBtn.Location = new System.Drawing.Point(614, 40);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 2;
            this.ReadBtn.Text = "READ";
            this.ReadBtn.UseVisualStyleBackColor = false;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.Location = new System.Drawing.Point(683, 40);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // IconEmailOpened
            // 
            this.IconEmailOpened.Image = ((System.Drawing.Image)(resources.GetObject("IconEmailOpened.Image")));
            this.IconEmailOpened.Location = new System.Drawing.Point(74, 22);
            this.IconEmailOpened.Name = "IconEmailOpened";
            this.IconEmailOpened.Size = new System.Drawing.Size(53, 58);
            this.IconEmailOpened.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconEmailOpened.TabIndex = 4;
            this.IconEmailOpened.TabStop = false;
            // 
            // InboxItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.IconEmailOpened);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.SubjectLbl);
            this.Controls.Add(this.IconEmailClosed);
            this.Name = "InboxItem";
            this.Size = new System.Drawing.Size(800, 100);
            ((System.ComponentModel.ISupportInitialize)(this.IconEmailClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmailOpened)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox IconEmailClosed;
        private Label SubjectLbl;
        private Button ReadBtn;
        private Button deleteBtn;
        private PictureBox IconEmailOpened;
    }
}
