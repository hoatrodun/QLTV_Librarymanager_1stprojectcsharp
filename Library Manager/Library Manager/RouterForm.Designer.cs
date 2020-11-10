namespace Library_Manager
{
    partial class RouterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouterForm));
            this.imgBook = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgBorrow = new System.Windows.Forms.PictureBox();
            this.imgData = new System.Windows.Forms.PictureBox();
            this.toolTipBook = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBorrow = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipData = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tacVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theThuVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuMuonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duLieuHeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tienIchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblAccount = new System.Windows.Forms.ToolStripLabel();
            this.lblTimeSys = new System.Windows.Forms.ToolStripLabel();
            this.timeSystem = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBook
            // 
            this.imgBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBook.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgBook.ErrorImage")));
            this.imgBook.Image = ((System.Drawing.Image)(resources.GetObject("imgBook.Image")));
            this.imgBook.InitialImage = null;
            this.imgBook.Location = new System.Drawing.Point(27, 58);
            this.imgBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBook.Name = "imgBook";
            this.imgBook.Size = new System.Drawing.Size(92, 91);
            this.imgBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBook.TabIndex = 0;
            this.imgBook.TabStop = false;
            this.imgBook.Tag = "BookForm";
            this.imgBook.Click += new System.EventHandler(this.imgGoToForm_Click);
            // 
            // imgUser
            // 
            this.imgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(150, 58);
            this.imgUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(99, 91);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 1;
            this.imgUser.TabStop = false;
            this.imgUser.Tag = "StudentForm";
            this.imgUser.Click += new System.EventHandler(this.imgGoToForm_Click);
            // 
            // imgBorrow
            // 
            this.imgBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBorrow.Image = ((System.Drawing.Image)(resources.GetObject("imgBorrow.Image")));
            this.imgBorrow.Location = new System.Drawing.Point(276, 58);
            this.imgBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBorrow.Name = "imgBorrow";
            this.imgBorrow.Size = new System.Drawing.Size(102, 91);
            this.imgBorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBorrow.TabIndex = 2;
            this.imgBorrow.TabStop = false;
            this.imgBorrow.Tag = "BorrowForm";
            this.imgBorrow.Click += new System.EventHandler(this.imgGoToForm_Click);
            // 
            // imgData
            // 
            this.imgData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgData.Image = ((System.Drawing.Image)(resources.GetObject("imgData.Image")));
            this.imgData.Location = new System.Drawing.Point(409, 58);
            this.imgData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgData.Name = "imgData";
            this.imgData.Size = new System.Drawing.Size(106, 93);
            this.imgData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgData.TabIndex = 3;
            this.imgData.TabStop = false;
            this.imgData.Tag = "DataForm";
            this.imgData.Click += new System.EventHandler(this.imgGoToForm_Click);
            // 
            // toolTipBook
            // 
            this.toolTipBook.AutomaticDelay = 100;
            this.toolTipBook.AutoPopDelay = 10000;
            this.toolTipBook.InitialDelay = 100;
            this.toolTipBook.ReshowDelay = 20;
            // 
            // toolTipUser
            // 
            this.toolTipUser.AutomaticDelay = 100;
            this.toolTipUser.AutoPopDelay = 10000;
            this.toolTipUser.InitialDelay = 100;
            this.toolTipUser.ReshowDelay = 20;
            // 
            // toolTipBorrow
            // 
            this.toolTipBorrow.AutomaticDelay = 100;
            this.toolTipBorrow.AutoPopDelay = 10000;
            this.toolTipBorrow.InitialDelay = 100;
            this.toolTipBorrow.ReshowDelay = 20;
            // 
            // toolTipData
            // 
            this.toolTipData.AutomaticDelay = 100;
            this.toolTipData.AutoPopDelay = 10000;
            this.toolTipData.InitialDelay = 100;
            this.toolTipData.ReshowDelay = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.tacVuToolStripMenuItem,
            this.tienIchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(540, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // tacVuToolStripMenuItem
            // 
            this.tacVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sachToolStripMenuItem,
            this.theThuVienToolStripMenuItem,
            this.phieuMuonSachToolStripMenuItem,
            this.duLieuHeThongToolStripMenuItem});
            this.tacVuToolStripMenuItem.Name = "tacVuToolStripMenuItem";
            this.tacVuToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.tacVuToolStripMenuItem.Text = "Tác vụ";
            this.tacVuToolStripMenuItem.Click += new System.EventHandler(this.tacVuToolStripMenuItem_Click);
            // 
            // sachToolStripMenuItem
            // 
            this.sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            this.sachToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.sachToolStripMenuItem.Text = "Sách";
            this.sachToolStripMenuItem.Click += new System.EventHandler(this.sachToolStripMenuItem_Click);
            // 
            // theThuVienToolStripMenuItem
            // 
            this.theThuVienToolStripMenuItem.Name = "theThuVienToolStripMenuItem";
            this.theThuVienToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.theThuVienToolStripMenuItem.Text = "Thẻ thư viện";
            this.theThuVienToolStripMenuItem.Click += new System.EventHandler(this.theThuVienToolStripMenuItem_Click);
            // 
            // phieuMuonSachToolStripMenuItem
            // 
            this.phieuMuonSachToolStripMenuItem.Name = "phieuMuonSachToolStripMenuItem";
            this.phieuMuonSachToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.phieuMuonSachToolStripMenuItem.Text = "Phiếu mượn sách";
            this.phieuMuonSachToolStripMenuItem.Click += new System.EventHandler(this.phieuMuonSachToolStripMenuItem_Click);
            // 
            // duLieuHeThongToolStripMenuItem
            // 
            this.duLieuHeThongToolStripMenuItem.Name = "duLieuHeThongToolStripMenuItem";
            this.duLieuHeThongToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.duLieuHeThongToolStripMenuItem.Text = "Dữ liệu hệ thống";
            this.duLieuHeThongToolStripMenuItem.Click += new System.EventHandler(this.duLieuHeThongToolStripMenuItem_Click);
            // 
            // tienIchToolStripMenuItem
            // 
            this.tienIchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinToolStripMenuItem});
            this.tienIchToolStripMenuItem.Name = "tienIchToolStripMenuItem";
            this.tienIchToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.tienIchToolStripMenuItem.Text = "Tiện ích";
            // 
            // thongTinToolStripMenuItem
            // 
            this.thongTinToolStripMenuItem.Name = "thongTinToolStripMenuItem";
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.thongTinToolStripMenuItem.Text = "Thông tin";
            this.thongTinToolStripMenuItem.Click += new System.EventHandler(this.thongTinToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Silver;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAccount,
            this.lblTimeSys});
            this.toolStrip2.Location = new System.Drawing.Point(0, 189);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(540, 32);
            this.toolStrip2.TabIndex = 37;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblAccount
            // 
            this.lblAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(91, 29);
            this.lblAccount.Text = "lblAccount";
            // 
            // lblTimeSys
            // 
            this.lblTimeSys.Name = "lblTimeSys";
            this.lblTimeSys.Size = new System.Drawing.Size(65, 29);
            this.lblTimeSys.Text = "lblTime";
            // 
            // timeSystem
            // 
            this.timeSystem.Enabled = true;
            this.timeSystem.Interval = 1000;
            this.timeSystem.Tick += new System.EventHandler(this.timeSystem_Tick);
            // 
            // RouterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 221);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imgData);
            this.Controls.Add(this.imgBorrow);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.imgBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("RouterForm.IconOptions.Icon")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RouterForm.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RouterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RouterForm_FormClosing);
            this.Load += new System.EventHandler(this.RouterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBook;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.PictureBox imgBorrow;
        private System.Windows.Forms.PictureBox imgData;
        private System.Windows.Forms.ToolTip toolTipBook;
        private System.Windows.Forms.ToolTip toolTipUser;
        private System.Windows.Forms.ToolTip toolTipBorrow;
        private System.Windows.Forms.ToolTip toolTipData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tacVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theThuVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuMuonSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duLieuHeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tienIchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lblAccount;
        private System.Windows.Forms.ToolStripLabel lblTimeSys;
        private System.Windows.Forms.Timer timeSystem;
    }
}