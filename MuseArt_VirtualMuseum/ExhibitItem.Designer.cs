namespace MuseArt_VirtualMuseum
{
    partial class ExhibitItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExhibitItem));
            this.nameLbl = new System.Windows.Forms.Label();
            this.exhibitImage = new System.Windows.Forms.PictureBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemAddBtn = new FontAwesome.Sharp.IconButton();
            this.dateLbl = new System.Windows.Forms.Label();
            this.cateroryLbl = new System.Windows.Forms.Label();
            this.dateTextLbl = new System.Windows.Forms.Label();
            this.categoryTextLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(223, 33);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 20);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // exhibitImage
            // 
            this.exhibitImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exhibitImage.Location = new System.Drawing.Point(27, 25);
            this.exhibitImage.Name = "exhibitImage";
            this.exhibitImage.Size = new System.Drawing.Size(171, 203);
            this.exhibitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exhibitImage.TabIndex = 1;
            this.exhibitImage.TabStop = false;
            this.exhibitImage.Click += new System.EventHandler(this.exhibitImage_Click);
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.BackColor = System.Drawing.Color.Transparent;
            this.descLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descLbl.Location = new System.Drawing.Point(3, 0);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(74, 17);
            this.descLbl.TabIndex = 2;
            this.descLbl.Text = "Description";
            // 
            // priceLbl
            // 
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(251, 191);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(87, 21);
            this.priceLbl.TabIndex = 4;
            this.priceLbl.Text = "99 €";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.descLbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(221, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(171, 58);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // itemAddBtn
            // 
            this.itemAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.itemAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemAddBtn.FlatAppearance.BorderSize = 0;
            this.itemAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemAddBtn.ForeColor = System.Drawing.Color.White;
            this.itemAddBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.itemAddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemAddBtn.IconSize = 36;
            this.itemAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemAddBtn.Location = new System.Drawing.Point(349, 181);
            this.itemAddBtn.Name = "itemAddBtn";
            this.itemAddBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.itemAddBtn.Size = new System.Drawing.Size(43, 44);
            this.itemAddBtn.TabIndex = 7;
            this.itemAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemAddBtn.UseVisualStyleBackColor = false;
            this.itemAddBtn.Click += new System.EventHandler(this.itemAddBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLbl.Location = new System.Drawing.Point(227, 124);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(42, 20);
            this.dateLbl.TabIndex = 8;
            this.dateLbl.Text = "Date";
            // 
            // cateroryLbl
            // 
            this.cateroryLbl.AutoSize = true;
            this.cateroryLbl.BackColor = System.Drawing.Color.Transparent;
            this.cateroryLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cateroryLbl.Location = new System.Drawing.Point(227, 150);
            this.cateroryLbl.Name = "cateroryLbl";
            this.cateroryLbl.Size = new System.Drawing.Size(73, 20);
            this.cateroryLbl.TabIndex = 10;
            this.cateroryLbl.Text = "Category";
            // 
            // dateTextLbl
            // 
            this.dateTextLbl.AutoSize = true;
            this.dateTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateTextLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTextLbl.Location = new System.Drawing.Point(275, 124);
            this.dateTextLbl.Name = "dateTextLbl";
            this.dateTextLbl.Size = new System.Drawing.Size(41, 20);
            this.dateTextLbl.TabIndex = 9;
            this.dateTextLbl.Text = "Date";
            // 
            // categoryTextLbl
            // 
            this.categoryTextLbl.AutoSize = true;
            this.categoryTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryTextLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryTextLbl.Location = new System.Drawing.Point(306, 150);
            this.categoryTextLbl.Name = "categoryTextLbl";
            this.categoryTextLbl.Size = new System.Drawing.Size(72, 20);
            this.categoryTextLbl.TabIndex = 11;
            this.categoryTextLbl.Text = "Category";
            // 
            // ExhibitItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.categoryTextLbl);
            this.Controls.Add(this.cateroryLbl);
            this.Controls.Add(this.dateTextLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.itemAddBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.exhibitImage);
            this.Controls.Add(this.nameLbl);
            this.Name = "ExhibitItem";
            this.Size = new System.Drawing.Size(450, 250);
            ((System.ComponentModel.ISupportInitialize)(this.exhibitImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLbl;
        private PictureBox exhibitImage;
        private Label descLbl;
        private Label priceLbl;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton itemAddBtn;
        private Label dateLbl;
        private Label cateroryLbl;
        private Label dateTextLbl;
        private Label categoryTextLbl;
    }
}
