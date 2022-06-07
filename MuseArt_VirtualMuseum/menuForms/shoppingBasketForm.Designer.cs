namespace MuseArt_VirtualMuseum.menuForms
{
    partial class shoppingBasketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>emptyMsgLbl
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
            this.basketFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.emptyMsgLbl = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.completeBtn = new FontAwesome.Sharp.IconButton();
            this.pricelLbl = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.desktopPanelSB = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.desktopPanelSB.SuspendLayout();
            this.SuspendLayout();
            // 
            // basketFlowLayoutPanel
            // 
            this.basketFlowLayoutPanel.AutoScroll = true;
            this.basketFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Info;
            this.basketFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basketFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.basketFlowLayoutPanel.Name = "basketFlowLayoutPanel";
            this.basketFlowLayoutPanel.Size = new System.Drawing.Size(1186, 590);
            this.basketFlowLayoutPanel.TabIndex = 17;
            // 
            // emptyMsgLbl
            // 
            this.emptyMsgLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emptyMsgLbl.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emptyMsgLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emptyMsgLbl.Location = new System.Drawing.Point(326, 235);
            this.emptyMsgLbl.Name = "emptyMsgLbl";
            this.emptyMsgLbl.Size = new System.Drawing.Size(505, 44);
            this.emptyMsgLbl.TabIndex = 0;
            this.emptyMsgLbl.Text = "The shopping basket is empty.";
            this.emptyMsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelTop.Controls.Add(this.clearBtn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1186, 46);
            this.panelTop.TabIndex = 16;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.IndianRed;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearBtn.Location = new System.Drawing.Point(1073, 0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(113, 46);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear Basket";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.completeBtn);
            this.panel1.Controls.Add(this.pricelLbl);
            this.panel1.Controls.Add(this.totalText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 48);
            this.panel1.TabIndex = 18;
            // 
            // completeBtn
            // 
            this.completeBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.completeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.completeBtn.FlatAppearance.BorderSize = 0;
            this.completeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.completeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.completeBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.completeBtn.IconColor = System.Drawing.SystemColors.Control;
            this.completeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.completeBtn.IconSize = 25;
            this.completeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.completeBtn.Location = new System.Drawing.Point(1073, 0);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.completeBtn.Size = new System.Drawing.Size(113, 48);
            this.completeBtn.TabIndex = 2;
            this.completeBtn.Text = "Checkout";
            this.completeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.completeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.completeBtn.UseVisualStyleBackColor = false;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // pricelLbl
            // 
            this.pricelLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pricelLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricelLbl.Location = new System.Drawing.Point(927, 19);
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
            this.totalText.Location = new System.Drawing.Point(1018, 6);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(32, 15);
            this.totalText.TabIndex = 0;
            this.totalText.Text = "Total";
            // 
            // desktopPanelSB
            // 
            this.desktopPanelSB.Controls.Add(this.emptyMsgLbl);
            this.desktopPanelSB.Controls.Add(this.basketFlowLayoutPanel);
            this.desktopPanelSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanelSB.Location = new System.Drawing.Point(0, 46);
            this.desktopPanelSB.Name = "desktopPanelSB";
            this.desktopPanelSB.Size = new System.Drawing.Size(1186, 590);
            this.desktopPanelSB.TabIndex = 20;
            // 
            // shoppingBasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1186, 684);
            this.Controls.Add(this.desktopPanelSB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Name = "shoppingBasketForm";
            this.Text = "shoppingBasketForm";
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.desktopPanelSB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel basketFlowLayoutPanel;
        private Panel panelTop;
        private Panel panel1;
        private Label pricelLbl;
        private Label totalText;
        private FontAwesome.Sharp.IconButton completeBtn;
        private Panel desktopPanelSB;
        public Label emptyMsgLbl;
        private Button clearBtn;
    }
}