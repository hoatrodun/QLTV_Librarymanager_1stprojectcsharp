namespace Library_Manager
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem5 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem6 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAnalyticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tienIchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSystem = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblMode = new System.Windows.Forms.ToolStripLabel();
            this.lblAccount = new System.Windows.Forms.ToolStripLabel();
            this.lblTimeSys = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddAccount = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFixAccount = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnViewAnalytics = new System.Windows.Forms.ToolStripButton();
            this.btnViewLog = new System.Windows.Forms.ToolStripButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblReTypePass = new System.Windows.Forms.Label();
            this.txtReTypePass = new System.Windows.Forms.TextBox();
            this.lblSupperAdmin = new System.Windows.Forms.Label();
            this.txtSuperAdminPass = new System.Windows.Forms.TextBox();
            this.cbxAnalytics = new System.Windows.Forms.ComboBox();
            this.dgvAnalytics = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4,
            this.barLargeButtonItem5,
            this.barLargeButtonItem6,
            this.barStaticItem1});
            this.barManager1.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1156, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 671);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1156, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 671);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1156, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 671);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Tìm sinh viên";
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Thêm sinh viên";
            this.barLargeButtonItem2.Id = 1;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Xóa sinh viên";
            this.barLargeButtonItem3.Id = 2;
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "Cập nhật sinh viên";
            this.barLargeButtonItem4.Id = 3;
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
            // 
            // barLargeButtonItem5
            // 
            this.barLargeButtonItem5.Caption = "Cập nhật dữ liệu";
            this.barLargeButtonItem5.Id = 4;
            this.barLargeButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem5.ImageOptions.LargeImage")));
            this.barLargeButtonItem5.Name = "barLargeButtonItem5";
            this.barLargeButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barLargeButtonItem6
            // 
            this.barLargeButtonItem6.Caption = "Đóng của sổ";
            this.barLargeButtonItem6.Id = 5;
            this.barLargeButtonItem6.Name = "barLargeButtonItem6";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 11;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.cheDoToolStripMenuItem,
            this.tienIchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1156, 29);
            this.menuStrip1.TabIndex = 9;
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
            // cheDoToolStripMenuItem
            // 
            this.cheDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLogToolStripMenuItem,
            this.viewAnalyticsToolStripMenuItem,
            this.addAccountToolStripMenuItem,
            this.editAccountToolStripMenuItem});
            this.cheDoToolStripMenuItem.Name = "cheDoToolStripMenuItem";
            this.cheDoToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.cheDoToolStripMenuItem.Text = "Chế độ";
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.viewLogToolStripMenuItem.Text = "Hoạt động user";
            this.viewLogToolStripMenuItem.Click += new System.EventHandler(this.viewLogToolStripMenuItem_Click);
            // 
            // viewAnalyticsToolStripMenuItem
            // 
            this.viewAnalyticsToolStripMenuItem.Name = "viewAnalyticsToolStripMenuItem";
            this.viewAnalyticsToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.viewAnalyticsToolStripMenuItem.Text = "Thống kê";
            this.viewAnalyticsToolStripMenuItem.Click += new System.EventHandler(this.viewAnalyticsToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.addAccountToolStripMenuItem.Text = "Thêm tài khoản quản trị";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.editAccountToolStripMenuItem.Text = "Sửa tài khoản quản trị";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editAccountToolStripMenuItem_Click);
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
            // timeSystem
            // 
            this.timeSystem.Enabled = true;
            this.timeSystem.Interval = 1000;
            this.timeSystem.Tick += new System.EventHandler(this.timeSystem_Tick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Silver;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMode,
            this.lblAccount,
            this.lblTimeSys});
            this.toolStrip2.Location = new System.Drawing.Point(0, 646);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(1156, 25);
            this.toolStrip2.TabIndex = 36;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.Green;
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(54, 22);
            this.lblMode.Text = "Mode";
            // 
            // lblAccount
            // 
            this.lblAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblAccount.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblAccount.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(74, 22);
            this.lblAccount.Text = "Account";
            // 
            // lblTimeSys
            // 
            this.lblTimeSys.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblTimeSys.Name = "lblTimeSys";
            this.lblTimeSys.Size = new System.Drawing.Size(83, 22);
            this.lblTimeSys.Text = "Thời gian";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(58, 121);
            this.tsbtnExit.Text = "Thoát";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 124);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
            this.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(183, 121);
            this.btnAddAccount.Text = "Tạo tài khoản quản trị";
            this.btnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddAccount.ToolTipText = "Tạo tài khoản quản trị";
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Khaki;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.btnAddAccount,
            this.toolStripSeparator2,
            this.btnFixAccount,
            this.btnReset,
            this.btnViewAnalytics,
            this.btnViewLog,
            this.tsbtnExit,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1156, 124);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 124);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 124);
            // 
            // btnFixAccount
            // 
            this.btnFixAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnFixAccount.Image")));
            this.btnFixAccount.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFixAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFixAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFixAccount.Name = "btnFixAccount";
            this.btnFixAccount.Size = new System.Drawing.Size(183, 121);
            this.btnFixAccount.Text = "Sửa tài khoản quản trị";
            this.btnFixAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFixAccount.ToolTipText = "Sửa tài khoản quản trị";
            this.btnFixAccount.Click += new System.EventHandler(this.btnFixAccount_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 121);
            this.btnReset.Text = "Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.ToolTipText = "Đặt lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnViewAnalytics
            // 
            this.btnViewAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("btnViewAnalytics.Image")));
            this.btnViewAnalytics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnViewAnalytics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewAnalytics.Name = "btnViewAnalytics";
            this.btnViewAnalytics.Size = new System.Drawing.Size(100, 121);
            this.btnViewAnalytics.Text = "Thống kê";
            this.btnViewAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewAnalytics.ToolTipText = "Xem thống kê";
            this.btnViewAnalytics.Click += new System.EventHandler(this.btnViewAnalytics_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Image = ((System.Drawing.Image)(resources.GetObject("btnViewLog.Image")));
            this.btnViewLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnViewLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(133, 121);
            this.btnViewLog.Text = "Hoạt động user";
            this.btnViewLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewLog.ToolTipText = "Xem file log";
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(507, 480);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(160, 25);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Tạo tài khoản";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(480, 252);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 17);
            this.lblPassword.TabIndex = 50;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(480, 177);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 17);
            this.lblUserName.TabIndex = 49;
            this.lblUserName.Text = "Tên đăng nhập";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(480, 278);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(213, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(480, 202);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.MaxLength = 32;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(213, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlignChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // lblReTypePass
            // 
            this.lblReTypePass.AutoSize = true;
            this.lblReTypePass.Location = new System.Drawing.Point(480, 329);
            this.lblReTypePass.Name = "lblReTypePass";
            this.lblReTypePass.Size = new System.Drawing.Size(107, 17);
            this.lblReTypePass.TabIndex = 53;
            this.lblReTypePass.Text = "Gõ lại mật khẩu";
            // 
            // txtReTypePass
            // 
            this.txtReTypePass.Location = new System.Drawing.Point(480, 353);
            this.txtReTypePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReTypePass.MaxLength = 32;
            this.txtReTypePass.Name = "txtReTypePass";
            this.txtReTypePass.PasswordChar = '*';
            this.txtReTypePass.Size = new System.Drawing.Size(213, 22);
            this.txtReTypePass.TabIndex = 3;
            this.txtReTypePass.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // lblSupperAdmin
            // 
            this.lblSupperAdmin.AutoSize = true;
            this.lblSupperAdmin.Location = new System.Drawing.Point(480, 404);
            this.lblSupperAdmin.Name = "lblSupperAdmin";
            this.lblSupperAdmin.Size = new System.Drawing.Size(157, 17);
            this.lblSupperAdmin.TabIndex = 55;
            this.lblSupperAdmin.Text = "Mật khẩu tài khoản root";
            // 
            // txtSuperAdminPass
            // 
            this.txtSuperAdminPass.Location = new System.Drawing.Point(480, 430);
            this.txtSuperAdminPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuperAdminPass.MaxLength = 32;
            this.txtSuperAdminPass.Name = "txtSuperAdminPass";
            this.txtSuperAdminPass.PasswordChar = '*';
            this.txtSuperAdminPass.Size = new System.Drawing.Size(213, 22);
            this.txtSuperAdminPass.TabIndex = 4;
            this.txtSuperAdminPass.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // cbxAnalytics
            // 
            this.cbxAnalytics.BackColor = System.Drawing.SystemColors.Info;
            this.cbxAnalytics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnalytics.FormattingEnabled = true;
            this.cbxAnalytics.Items.AddRange(new object[] {
            "Xem các thẻ mượn sách quá hạn",
            "Xem số lượng sách trong kho",
            "Xem toàn bộ sinh viên",
            "Xem tất cả các phiếu mượn sách"});
            this.cbxAnalytics.Location = new System.Drawing.Point(0, 155);
            this.cbxAnalytics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAnalytics.Name = "cbxAnalytics";
            this.cbxAnalytics.Size = new System.Drawing.Size(267, 24);
            this.cbxAnalytics.TabIndex = 60;
            this.cbxAnalytics.SelectedIndexChanged += new System.EventHandler(this.cbxAnalytics_SelectedIndexChanged);
            // 
            // dgvAnalytics
            // 
            this.dgvAnalytics.AllowUserToAddRows = false;
            this.dgvAnalytics.AllowUserToDeleteRows = false;
            this.dgvAnalytics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalytics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalytics.Location = new System.Drawing.Point(0, 183);
            this.dgvAnalytics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAnalytics.Name = "dgvAnalytics";
            this.dgvAnalytics.ReadOnly = true;
            this.dgvAnalytics.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalytics.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnalytics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalytics.Size = new System.Drawing.Size(1140, 438);
            this.dgvAnalytics.TabIndex = 65;
            // 
            // colTime
            // 
            this.colTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTime.FillWeight = 500F;
            this.colTime.HeaderText = "Thời gian";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colEvent
            // 
            this.colEvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEvent.FillWeight = 500F;
            this.colEvent.HeaderText = "Hành động";
            this.colEvent.MinimumWidth = 6;
            this.colEvent.Name = "colEvent";
            this.colEvent.ReadOnly = true;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEvent,
            this.colTime});
            this.dgvLog.Location = new System.Drawing.Point(0, 155);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersWidth = 51;
            this.dgvLog.Size = new System.Drawing.Size(1140, 438);
            this.dgvLog.TabIndex = 42;
            // 
            // DataForm
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 671);
            this.Controls.Add(this.dgvAnalytics);
            this.Controls.Add(this.cbxAnalytics);
            this.Controls.Add(this.lblSupperAdmin);
            this.Controls.Add(this.txtSuperAdminPass);
            this.Controls.Add(this.lblReTypePass);
            this.Controls.Add(this.txtReTypePass);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DataForm.IconOptions.LargeImage")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DataForm";
            this.Text = "Thao tác với dữ liệu hệ thống";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem4;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem5;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timeSystem;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lblMode;
        private System.Windows.Forms.ToolStripLabel lblAccount;
        private System.Windows.Forms.ToolStripLabel lblTimeSys;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tienIchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAnalyticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnAddAccount;
        private System.Windows.Forms.ToolStripButton btnFixAccount;
        private System.Windows.Forms.ToolStripButton btnViewLog;
        private System.Windows.Forms.ToolStripButton btnViewAnalytics;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblReTypePass;
        private System.Windows.Forms.TextBox txtReTypePass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblSupperAdmin;
        private System.Windows.Forms.TextBox txtSuperAdminPass;
        private System.Windows.Forms.ComboBox cbxAnalytics;
        private System.Windows.Forms.DataGridView dgvAnalytics;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
    }
}