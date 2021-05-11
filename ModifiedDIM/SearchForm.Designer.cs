namespace ModifiedDIM
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.pnlTitleBar1 = new System.Windows.Forms.Panel();
            this.pnlTitleBar2 = new System.Windows.Forms.Panel();
            this.windowBtn = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.lblAppIcon = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnApi = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlFooter2 = new System.Windows.Forms.Panel();
            this.imgResize = new System.Windows.Forms.PictureBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleBar1.SuspendLayout();
            this.pnlTitleBar2.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlFooter2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResize)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar1
            // 
            this.pnlTitleBar1.AutoSize = true;
            this.pnlTitleBar1.BackColor = System.Drawing.Color.Black;
            this.pnlTitleBar1.Controls.Add(this.pnlTitleBar2);
            this.pnlTitleBar1.Controls.Add(this.lblAppIcon);
            this.pnlTitleBar1.Controls.Add(this.lblAppName);
            this.pnlTitleBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar1.MinimumSize = new System.Drawing.Size(0, 55);
            this.pnlTitleBar1.Name = "pnlTitleBar1";
            this.pnlTitleBar1.Size = new System.Drawing.Size(1482, 55);
            this.pnlTitleBar1.TabIndex = 2;
            this.pnlTitleBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar1_OnMouseDown);
            // 
            // pnlTitleBar2
            // 
            this.pnlTitleBar2.BackColor = System.Drawing.Color.Black;
            this.pnlTitleBar2.Controls.Add(this.windowBtn);
            this.pnlTitleBar2.Controls.Add(this.minBtn);
            this.pnlTitleBar2.Controls.Add(this.closeBtn);
            this.pnlTitleBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTitleBar2.Location = new System.Drawing.Point(1262, 0);
            this.pnlTitleBar2.Name = "pnlTitleBar2";
            this.pnlTitleBar2.Size = new System.Drawing.Size(220, 55);
            this.pnlTitleBar2.TabIndex = 4;
            // 
            // windowBtn
            // 
            this.windowBtn.BackColor = System.Drawing.Color.Black;
            this.windowBtn.Image = ((System.Drawing.Image)(resources.GetObject("windowBtn.Image")));
            this.windowBtn.Location = new System.Drawing.Point(107, 0);
            this.windowBtn.Name = "windowBtn";
            this.windowBtn.Size = new System.Drawing.Size(65, 55);
            this.windowBtn.TabIndex = 3;
            this.windowBtn.Click += new System.EventHandler(this.winBtn_Click);
            this.windowBtn.MouseEnter += new System.EventHandler(this.windowBtn_MouseEnter);
            this.windowBtn.MouseLeave += new System.EventHandler(this.windowBtn_MouseLeave);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.Black;
            this.minBtn.Image = ((System.Drawing.Image)(resources.GetObject("minBtn.Image")));
            this.minBtn.Location = new System.Drawing.Point(54, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(65, 55);
            this.minBtn.TabIndex = 2;
            this.minBtn.Click += new System.EventHandler(this.min_Click);
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Black;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(162, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(65, 55);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.close_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // lblAppIcon
            // 
            this.lblAppIcon.BackColor = System.Drawing.Color.Black;
            this.lblAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblAppIcon.Image")));
            this.lblAppIcon.Location = new System.Drawing.Point(23, 16);
            this.lblAppIcon.Name = "lblAppIcon";
            this.lblAppIcon.Size = new System.Drawing.Size(32, 28);
            this.lblAppIcon.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(61, 16);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(117, 28);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Vault Buddy";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(12, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(178, 30);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.Text = "CagedNebula";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(196, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnApi
            // 
            this.btnApi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApi.Location = new System.Drawing.Point(0, 4);
            this.btnApi.Name = "btnApi";
            this.btnApi.Size = new System.Drawing.Size(160, 26);
            this.btnApi.TabIndex = 17;
            this.btnApi.Text = "Show API";
            this.btnApi.UseVisualStyleBackColor = true;
            this.btnApi.Visible = false;
            this.btnApi.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.AutoSize = true;
            this.pnlFooter.BackColor = System.Drawing.Color.Black;
            this.pnlFooter.Controls.Add(this.pnlFooter2);
            this.pnlFooter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlFooter.Location = new System.Drawing.Point(0, 726);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.MinimumSize = new System.Drawing.Size(0, 25);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1473, 31);
            this.pnlFooter.TabIndex = 32;
            // 
            // pnlFooter2
            // 
            this.pnlFooter2.BackColor = System.Drawing.Color.Black;
            this.pnlFooter2.Controls.Add(this.imgResize);
            this.pnlFooter2.Controls.Add(this.btnApi);
            this.pnlFooter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFooter2.Location = new System.Drawing.Point(1273, 0);
            this.pnlFooter2.Name = "pnlFooter2";
            this.pnlFooter2.Size = new System.Drawing.Size(200, 31);
            this.pnlFooter2.TabIndex = 4;
            // 
            // imgResize
            // 
            this.imgResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgResize.BackColor = System.Drawing.Color.Transparent;
            this.imgResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.imgResize.Enabled = false;
            this.imgResize.Image = ((System.Drawing.Image)(resources.GetObject("imgResize.Image")));
            this.imgResize.Location = new System.Drawing.Point(177, 0);
            this.imgResize.Name = "imgResize";
            this.imgResize.Size = new System.Drawing.Size(25, 25);
            this.imgResize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgResize.TabIndex = 9;
            this.imgResize.TabStop = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.tbSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 55);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1482, 48);
            this.pnlSearch.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Location = new System.Drawing.Point(0, 207);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1482, 517);
            this.pnlBody.TabIndex = 6;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Transparent;
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 103);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1482, 98);
            this.pnlHead.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(650, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading...";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ModifiedDIM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 755);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTitleBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1482, 0);
            this.Name = "SearchForm";
            this.Text = "Vault Buddy";
            this.Load += new System.EventHandler(this.FormOAuthBrowser_Load);
            this.pnlTitleBar1.ResumeLayout(false);
            this.pnlTitleBar1.PerformLayout();
            this.pnlTitleBar2.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgResize)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar1;
        private System.Windows.Forms.Panel pnlTitleBar2;
        private System.Windows.Forms.Label windowBtn;
        private System.Windows.Forms.Label minBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnApi;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlFooter2;
        private System.Windows.Forms.PictureBox imgResize;
        private System.Windows.Forms.Label lblAppIcon;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label label1;
    }
}