namespace Library_Manager
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
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
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tienIchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFDImage = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.timeSystem = new System.Windows.Forms.Timer(this.components);
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblMode = new System.Windows.Forms.ToolStripLabel();
            this.lblAccount = new System.Windows.Forms.ToolStripLabel();
            this.lblTimeSys = new System.Windows.Forms.ToolStripLabel();
            this.btnMode = new System.Windows.Forms.Button();
            this.tsbtnFindMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAddMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDelMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBorrow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvCart = new System.Windows.Forms.DataGridView();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIdBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFullCancel = new System.Windows.Forms.Button();
            this.rbtnFindbyIdBorrow = new System.Windows.Forms.RadioButton();
            this.rbtnFindbyIdStudent = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxBorrowTime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1000, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 581);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1000, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 581);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1000, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 581);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Tìm sinh viên";
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Thêm sinh viên";
            this.barLargeButtonItem2.Id = 1;
            this.barLargeButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.ImageOptions.LargeImage")));
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Xóa sinh viên";
            this.barLargeButtonItem3.Id = 2;
            this.barLargeButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem3.ImageOptions.LargeImage")));
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "Cập nhật sinh viên";
            this.barLargeButtonItem4.Id = 3;
            this.barLargeButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem4.ImageOptions.LargeImage")));
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
            this.barLargeButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem6.ImageOptions.LargeImage")));
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
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.cheDoToolStripMenuItem,
            this.tienIchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 31);
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
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // cheDoToolStripMenuItem
            // 
            this.cheDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timToolStripMenuItem,
            this.themToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.cheDoToolStripMenuItem.Name = "cheDoToolStripMenuItem";
            this.cheDoToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.cheDoToolStripMenuItem.Text = "Chế độ";
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.timToolStripMenuItem.Text = "Tìm...";
            this.timToolStripMenuItem.Click += new System.EventHandler(this.timToolStripMenuItem_Click);
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.themToolStripMenuItem.Text = "Thêm...";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
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
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.thongTinToolStripMenuItem.Text = "Thông tin";
            this.thongTinToolStripMenuItem.Click += new System.EventHandler(this.thongTinToolStripMenuItem_Click);
            // 
            // oFDImage
            // 
            this.oFDImage.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã sinh viên";
            // 
            // timeSystem
            // 
            this.timeSystem.Enabled = true;
            this.timeSystem.Interval = 1000;
            this.timeSystem.Tick += new System.EventHandler(this.timeSystem_Tick);
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIdStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIdStudent.Location = new System.Drawing.Point(129, 223);
            this.txtIdStudent.MaxLength = 15;
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(267, 22);
            this.txtIdStudent.TabIndex = 1;
            this.txtIdStudent.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 548);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(1000, 33);
            this.toolStrip2.TabIndex = 36;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.Green;
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(54, 30);
            this.lblMode.Text = "Mode";
            // 
            // lblAccount
            // 
            this.lblAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblAccount.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblAccount.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(74, 30);
            this.lblAccount.Text = "Account";
            // 
            // lblTimeSys
            // 
            this.lblTimeSys.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblTimeSys.Name = "lblTimeSys";
            this.lblTimeSys.Size = new System.Drawing.Size(83, 30);
            this.lblTimeSys.Text = "Thời gian";
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(207, 429);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(119, 36);
            this.btnMode.TabIndex = 7;
            this.btnMode.Text = "mode";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // tsbtnFindMode
            // 
            this.tsbtnFindMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFindMode.Image")));
            this.tsbtnFindMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnFindMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFindMode.Name = "tsbtnFindMode";
            this.tsbtnFindMode.Size = new System.Drawing.Size(42, 119);
            this.tsbtnFindMode.Text = "Tìm";
            this.tsbtnFindMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnFindMode.Click += new System.EventHandler(this.tsbtnFindMode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 122);
            // 
            // tsbtnAddMode
            // 
            this.tsbtnAddMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddMode.Image")));
            this.tsbtnAddMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAddMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddMode.Name = "tsbtnAddMode";
            this.tsbtnAddMode.Size = new System.Drawing.Size(57, 119);
            this.tsbtnAddMode.Text = "Thêm";
            this.tsbtnAddMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAddMode.Click += new System.EventHandler(this.tsbtnAddMode_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 122);
            // 
            // tsbtnDelMode
            // 
            this.tsbtnDelMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelMode.Image")));
            this.tsbtnDelMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDelMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelMode.Name = "tsbtnDelMode";
            this.tsbtnDelMode.Size = new System.Drawing.Size(43, 119);
            this.tsbtnDelMode.Text = "Xóa";
            this.tsbtnDelMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelMode.Click += new System.EventHandler(this.tsbtnDelMode_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 122);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(58, 119);
            this.tsbtnExit.Text = "Thoát";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 122);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 119);
            this.btnReset.Text = "Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.ToolTipText = "Đặt lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Khaki;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFindMode,
            this.toolStripSeparator1,
            this.tsbtnAddMode,
            this.toolStripSeparator2,
            this.tsbtnDelMode,
            this.toolStripSeparator3,
            this.tsbtnExit,
            this.toolStripSeparator5,
            this.btnReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 122);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Sách mượn";
            // 
            // txtIdBorrow
            // 
            this.txtIdBorrow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIdBorrow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIdBorrow.Location = new System.Drawing.Point(129, 172);
            this.txtIdBorrow.MaxLength = 15;
            this.txtIdBorrow.Name = "txtIdBorrow";
            this.txtIdBorrow.Size = new System.Drawing.Size(267, 22);
            this.txtIdBorrow.TabIndex = 2;
            this.txtIdBorrow.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mã thẻ";
            // 
            // dtgvCart
            // 
            this.dtgvCart.AllowUserToAddRows = false;
            this.dtgvCart.AllowUserToDeleteRows = false;
            this.dtgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerial,
            this.colNameOfBook,
            this.colAmount});
            this.dtgvCart.Location = new System.Drawing.Point(427, 204);
            this.dtgvCart.Name = "dtgvCart";
            this.dtgvCart.ReadOnly = true;
            this.dtgvCart.RowHeadersWidth = 51;
            this.dtgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCart.Size = new System.Drawing.Size(544, 261);
            this.dtgvCart.TabIndex = 52;
            // 
            // colSerial
            // 
            this.colSerial.HeaderText = "Serial";
            this.colSerial.MinimumWidth = 6;
            this.colSerial.Name = "colSerial";
            this.colSerial.ReadOnly = true;
            this.colSerial.Width = 125;
            // 
            // colNameOfBook
            // 
            this.colNameOfBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameOfBook.FillWeight = 350F;
            this.colNameOfBook.HeaderText = "Tên sách";
            this.colNameOfBook.MinimumWidth = 6;
            this.colNameOfBook.Name = "colNameOfBook";
            this.colNameOfBook.ReadOnly = true;
            this.colNameOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.HeaderText = "Số lượng";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIdBook
            // 
            this.txtIdBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIdBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIdBook.Location = new System.Drawing.Point(129, 321);
            this.txtIdBook.MaxLength = 15;
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.Size = new System.Drawing.Size(157, 22);
            this.txtIdBook.TabIndex = 3;
            this.txtIdBook.TextChanged += new System.EventHandler(this.txtIdBook_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Mã sách";
            // 
            // txtComment
            // 
            this.txtComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtComment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtComment.Location = new System.Drawing.Point(129, 273);
            this.txtComment.MaxLength = 100;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(267, 32);
            this.txtComment.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Ghi chú";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(292, 322);
            this.txtAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(53, 22);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Thời gian mượn";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(537, 476);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 25);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Bỏ mượn";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFullCancel
            // 
            this.btnFullCancel.Location = new System.Drawing.Point(750, 476);
            this.btnFullCancel.Name = "btnFullCancel";
            this.btnFullCancel.Size = new System.Drawing.Size(133, 25);
            this.btnFullCancel.TabIndex = 65;
            this.btnFullCancel.Text = "Bỏ mượn toàn bộ";
            this.btnFullCancel.UseVisualStyleBackColor = true;
            this.btnFullCancel.Click += new System.EventHandler(this.btnFullCancel_Click);
            // 
            // rbtnFindbyIdBorrow
            // 
            this.rbtnFindbyIdBorrow.AutoSize = true;
            this.rbtnFindbyIdBorrow.Location = new System.Drawing.Point(129, 198);
            this.rbtnFindbyIdBorrow.Name = "rbtnFindbyIdBorrow";
            this.rbtnFindbyIdBorrow.Size = new System.Drawing.Size(174, 21);
            this.rbtnFindbyIdBorrow.TabIndex = 71;
            this.rbtnFindbyIdBorrow.TabStop = true;
            this.rbtnFindbyIdBorrow.Text = "Tìm bằng mã thẻ mượn";
            this.rbtnFindbyIdBorrow.UseVisualStyleBackColor = true;
            this.rbtnFindbyIdBorrow.Visible = false;
            this.rbtnFindbyIdBorrow.CheckedChanged += new System.EventHandler(this.rbtnFindbyIdBorrow_CheckedChanged);
            // 
            // rbtnFindbyIdStudent
            // 
            this.rbtnFindbyIdStudent.AutoSize = true;
            this.rbtnFindbyIdStudent.Location = new System.Drawing.Point(129, 248);
            this.rbtnFindbyIdStudent.Name = "rbtnFindbyIdStudent";
            this.rbtnFindbyIdStudent.Size = new System.Drawing.Size(171, 21);
            this.rbtnFindbyIdStudent.TabIndex = 70;
            this.rbtnFindbyIdStudent.TabStop = true;
            this.rbtnFindbyIdStudent.Text = "Tìm bằng mã sinh viên";
            this.rbtnFindbyIdStudent.UseVisualStyleBackColor = true;
            this.rbtnFindbyIdStudent.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(129, 348);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 17);
            this.label.TabIndex = 77;
            this.label.Text = "Còn lại ";
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Location = new System.Drawing.Point(182, 348);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(16, 17);
            this.lblQuantum.TabIndex = 78;
            this.lblQuantum.Text = "0";
            this.lblQuantum.Click += new System.EventHandler(this.lblQuantum_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "quyển trong thư viện";
            // 
            // cbxBorrowTime
            // 
            this.cbxBorrowTime.FormattingEnabled = true;
            this.cbxBorrowTime.Items.AddRange(new object[] {
            "1 tuần",
            "2 tuần"});
            this.cbxBorrowTime.Location = new System.Drawing.Point(137, 379);
            this.cbxBorrowTime.Name = "cbxBorrowTime";
            this.cbxBorrowTime.Size = new System.Drawing.Size(105, 24);
            this.cbxBorrowTime.TabIndex = 89;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.cbxBorrowTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblQuantum);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rbtnFindbyIdBorrow);
            this.Controls.Add(this.rbtnFindbyIdStudent);
            this.Controls.Add(this.btnFullCancel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtIdBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvCart);
            this.Controls.Add(this.txtIdBorrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("BorrowForm.IconOptions.Image")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BorrowForm";
            this.Text = "Thao tác với thẻ mượn sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog oFDImage;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timeSystem;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.Button btnMode;
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
        private System.Windows.Forms.ToolStripMenuItem timToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnFindMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnAddMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtIdBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvCart;
        private System.Windows.Forms.TextBox txtIdBorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFullCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbtnFindbyIdBorrow;
        private System.Windows.Forms.RadioButton rbtnFindbyIdStudent;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.ComboBox cbxBorrowTime;
    }
}