namespace MuseArt_VirtualMuseum
{
    partial class BasketItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketItem));
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemDesc = new System.Windows.Forms.Label();
            this.itemImg = new System.Windows.Forms.PictureBox();
            this.ItemPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemRmvBtn = new System.Windows.Forms.PictureBox();
            this.categoryTextLbl = new System.Windows.Forms.Label();
            this.cateroryLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemImg)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemRmvBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemName.Location = new System.Drawing.Point(200, 27);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(56, 21);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "Name";
            // 
            // ItemDesc
            // 
            this.ItemDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItemDesc.AutoSize = true;
            this.ItemDesc.Location = new System.Drawing.Point(3, 0);
            this.ItemDesc.Name = "ItemDesc";
            this.ItemDesc.Size = new System.Drawing.Size(67, 15);
            this.ItemDesc.TabIndex = 2;
            this.ItemDesc.Text = "Description";
            // 
            // itemImg
            // 
            this.itemImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemImg.Location = new System.Drawing.Point(35, 21);
            this.itemImg.Name = "itemImg";
            this.itemImg.Size = new System.Drawing.Size(157, 108);
            this.itemImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImg.TabIndex = 0;
            this.itemImg.TabStop = false;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItemPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemPrice.Location = new System.Drawing.Point(373, 95);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(106, 25);
            this.ItemPrice.TabIndex = 4;
            this.ItemPrice.Text = "00.00";
            this.ItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ItemDesc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(198, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 78);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // itemRmvBtn
            // 
            this.itemRmvBtn.BackColor = System.Drawing.Color.Transparent;
            this.itemRmvBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemRmvBtn.Image = ((System.Drawing.Image)(resources.GetObject("itemRmvBtn.Image")));
            this.itemRmvBtn.Location = new System.Drawing.Point(487, 91);
            this.itemRmvBtn.Name = "itemRmvBtn";
            this.itemRmvBtn.Size = new System.Drawing.Size(83, 35);
            this.itemRmvBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemRmvBtn.TabIndex = 7;
            this.itemRmvBtn.TabStop = false;
            this.itemRmvBtn.Click += new System.EventHandler(this.itemRmvBtn_Click);
            // 
            // categoryTextLbl
            // 
            this.categoryTextLbl.AutoSize = true;
            this.categoryTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryTextLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryTextLbl.Location = new System.Drawing.Point(459, 56);
            this.categoryTextLbl.Name = "categoryTextLbl";
            this.categoryTextLbl.Size = new System.Drawing.Size(72, 20);
            this.categoryTextLbl.TabIndex = 15;
            this.categoryTextLbl.Text = "Category";
            // 
            // cateroryLbl
            // 
            this.cateroryLbl.AutoSize = true;
            this.cateroryLbl.BackColor = System.Drawing.Color.Transparent;
            this.cateroryLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cateroryLbl.Location = new System.Drawing.Point(380, 56);
            this.cateroryLbl.Name = "cateroryLbl";
            this.cateroryLbl.Size = new System.Drawing.Size(73, 20);
            this.cateroryLbl.TabIndex = 14;
            this.cateroryLbl.Text = "Category";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLbl.Location = new System.Drawing.Point(380, 30);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(42, 20);
            this.dateLbl.TabIndex = 12;
            this.dateLbl.Text = "Date";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(428, 30);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 20);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "Date";
            // 
            // BasketItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.categoryTextLbl);
            this.Controls.Add(this.cateroryLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.itemRmvBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.itemImg);
            this.Name = "BasketItem";
            this.Size = new System.Drawing.Size(602, 154);
            ((System.ComponentModel.ISupportInitialize)(this.itemImg)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemRmvBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ItemName;
        private Label ItemDesc;
        private PictureBox itemImg;
        private Label ItemPrice;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox itemRmvBtn;
        private Label categoryTextLbl;
        private Label cateroryLbl;
        private Label dateLbl;
        private Label dateLabel;
    }
}
