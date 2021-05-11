namespace ModifiedDIM
{
    partial class DIMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIMForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleBar1 = new System.Windows.Forms.Panel();
            this.pnlTitleBar2 = new System.Windows.Forms.Panel();
            this.windowBtn = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.lblAuth = new System.Windows.Forms.Label();
            this.lblAuth2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgResize = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar1.SuspendLayout();
            this.pnlTitleBar2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 28);
            this.label1.TabIndex = 0;
            // 
            // pnlTitleBar1
            // 
            this.pnlTitleBar1.AutoSize = true;
            this.pnlTitleBar1.BackColor = System.Drawing.Color.Black;
            this.pnlTitleBar1.Controls.Add(this.pnlTitleBar2);
            this.pnlTitleBar1.Controls.Add(this.label1);
            this.pnlTitleBar1.Controls.Add(this.label2);
            this.pnlTitleBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar1.MinimumSize = new System.Drawing.Size(0, 55);
            this.pnlTitleBar1.Name = "pnlTitleBar1";
            this.pnlTitleBar1.Size = new System.Drawing.Size(1000, 55);
            this.pnlTitleBar1.TabIndex = 1;
            this.pnlTitleBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar1_OnMouseDown);
            // 
            // pnlTitleBar2
            // 
            this.pnlTitleBar2.BackColor = System.Drawing.Color.Black;
            this.pnlTitleBar2.Controls.Add(this.windowBtn);
            this.pnlTitleBar2.Controls.Add(this.minBtn);
            this.pnlTitleBar2.Controls.Add(this.closeBtn);
            this.pnlTitleBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTitleBar2.Location = new System.Drawing.Point(780, 0);
            this.pnlTitleBar2.Name = "pnlTitleBar2";
            this.pnlTitleBar2.Size = new System.Drawing.Size(220, 55);
            this.pnlTitleBar2.TabIndex = 4;
            // 
            // windowBtn
            // 
            this.windowBtn.BackColor = System.Drawing.Color.Black;
            this.windowBtn.Image = ((System.Drawing.Image)(resources.GetObject("windowBtn.Image")));
            this.windowBtn.Location = new System.Drawing.Point(88, 0);
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
            this.minBtn.Location = new System.Drawing.Point(23, -2);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(65, 63);
            this.minBtn.TabIndex = 2;
            this.minBtn.Click += new System.EventHandler(this.min_Click);
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Black;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(154, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(65, 55);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.close_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vault Buddy";
            // 
            // btnAuth
            // 
            this.btnAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnAuth.FlatAppearance.BorderSize = 0;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuth.Location = new System.Drawing.Point(325, 445);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(0);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(372, 70);
            this.btnAuth.TabIndex = 5;
            this.btnAuth.Text = "Authorize with Bungie.net";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // lblAuth
            // 
            this.lblAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAuth.BackColor = System.Drawing.Color.Transparent;
            this.lblAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuth.ForeColor = System.Drawing.Color.White;
            this.lblAuth.Location = new System.Drawing.Point(176, 218);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(670, 129);
            this.lblAuth.TabIndex = 6;
            this.lblAuth.Text = "We need your permission...";
            this.lblAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuth2
            // 
            this.lblAuth2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAuth2.BackColor = System.Drawing.Color.Transparent;
            this.lblAuth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuth2.ForeColor = System.Drawing.Color.White;
            this.lblAuth2.Location = new System.Drawing.Point(161, 316);
            this.lblAuth2.Name = "lblAuth2";
            this.lblAuth2.Size = new System.Drawing.Size(661, 84);
            this.lblAuth2.TabIndex = 7;
            this.lblAuth2.Text = "Allow Vault Buddy to view and modify your Destiny characters, vault, and progress" +
    "ion.";
            this.lblAuth2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 712);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 25);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.imgResize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(780, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 25);
            this.panel2.TabIndex = 4;
            // 
            // imgResize
            // 
            this.imgResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgResize.BackColor = System.Drawing.Color.Transparent;
            this.imgResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.imgResize.Enabled = false;
            this.imgResize.Image = ((System.Drawing.Image)(resources.GetObject("imgResize.Image")));
            this.imgResize.Location = new System.Drawing.Point(195, 0);
            this.imgResize.Name = "imgResize";
            this.imgResize.Size = new System.Drawing.Size(25, 25);
            this.imgResize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgResize.TabIndex = 9;
            this.imgResize.TabStop = false;
            this.imgResize.Visible = false;
            // 
            // DIMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 737);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAuth2);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.pnlTitleBar1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "DIMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Vault Buddy";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.DIMForm_Load);
            this.pnlTitleBar1.ResumeLayout(false);
            this.pnlTitleBar1.PerformLayout();
            this.pnlTitleBar2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgResize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTitleBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minBtn;
        private System.Windows.Forms.Label windowBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Panel pnlTitleBar2;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Label lblAuth2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgResize;
    }
}

