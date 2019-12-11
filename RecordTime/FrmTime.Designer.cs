namespace RecordTime
{
    partial class FrmTime
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTime));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.NowTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStatr = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NudMiao = new System.Windows.Forms.NumericUpDown();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.lblTishi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbsystemtime = new System.Windows.Forms.GroupBox();
            this.lblNowTime = new System.Windows.Forms.Label();
            this.gbPowerOff = new System.Windows.Forms.GroupBox();
            this.pbGou = new System.Windows.Forms.PictureBox();
            this.cbEverday = new System.Windows.Forms.CheckBox();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.NudMinute = new System.Windows.Forms.NumericUpDown();
            this.lblHour = new System.Windows.Forms.Label();
            this.NudHour = new System.Windows.Forms.NumericUpDown();
            this.rbNoPowerOff = new System.Windows.Forms.RadioButton();
            this.rbPowerOffTime = new System.Windows.Forms.RadioButton();
            this.timerNo = new System.Windows.Forms.Timer(this.components);
            this.TimerPowerOff = new System.Windows.Forms.Timer(this.components);
            this.TimerPowerOff2 = new System.Windows.Forms.Timer(this.components);
            this.pbX = new System.Windows.Forms.PictureBox();
            this.pbB = new System.Windows.Forms.PictureBox();
            this.Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsClose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMiao)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbsystemtime.SuspendLayout();
            this.gbPowerOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            this.cmsClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // NowTimer
            // 
            this.NowTimer.Enabled = true;
            this.NowTimer.Interval = 1000;
            this.NowTimer.Tick += new System.EventHandler(this.NowTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnRecord);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnStatr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "秒表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblT3);
            this.groupBox1.Controls.Add(this.lblT2);
            this.groupBox1.Controls.Add(this.lblT1);
            this.groupBox1.Controls.Add(this.lblTime1);
            this.groupBox1.Controls.Add(this.lblTime2);
            this.groupBox1.Controls.Add(this.lblTime3);
            this.groupBox1.Location = new System.Drawing.Point(31, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 250);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "记录列表";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT3.Location = new System.Drawing.Point(43, 153);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(0, 29);
            this.lblT3.TabIndex = 10;
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT2.Location = new System.Drawing.Point(43, 106);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(0, 29);
            this.lblT2.TabIndex = 9;
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT1.Location = new System.Drawing.Point(43, 59);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(0, 29);
            this.lblT1.TabIndex = 8;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime1.ForeColor = System.Drawing.Color.Red;
            this.lblTime1.Location = new System.Drawing.Point(87, 57);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(0, 29);
            this.lblTime1.TabIndex = 5;
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime2.ForeColor = System.Drawing.Color.Red;
            this.lblTime2.Location = new System.Drawing.Point(87, 106);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(0, 29);
            this.lblTime2.TabIndex = 6;
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime3.ForeColor = System.Drawing.Color.Red;
            this.lblTime3.Location = new System.Drawing.Point(87, 155);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(0, 29);
            this.lblTime3.TabIndex = 7;
            // 
            // btnRecord
            // 
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.Location = new System.Drawing.Point(156, 103);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 33);
            this.btnRecord.TabIndex = 38;
            this.btnRecord.Text = "记录";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click_1);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(46, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(295, 48);
            this.lblTime.TabIndex = 37;
            this.lblTime.Text = "00:00:00.00";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(269, 103);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 33);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "重置";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnStatr
            // 
            this.btnStatr.BackColor = System.Drawing.Color.Transparent;
            this.btnStatr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatr.Location = new System.Drawing.Point(54, 103);
            this.btnStatr.Name = "btnStatr";
            this.btnStatr.Size = new System.Drawing.Size(57, 33);
            this.btnStatr.TabIndex = 35;
            this.btnStatr.Text = "开始";
            this.btnStatr.UseVisualStyleBackColor = false;
            this.btnStatr.Click += new System.EventHandler(this.btnStatr_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.NudMiao);
            this.tabPage2.Controls.Add(this.btnClear1);
            this.tabPage2.Controls.Add(this.lblTishi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblNo);
            this.tabPage2.Controls.Add(this.btnBegin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "倒计时";
            // 
            // NudMiao
            // 
            this.NudMiao.Location = new System.Drawing.Point(154, 327);
            this.NudMiao.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NudMiao.Name = "NudMiao";
            this.NudMiao.Size = new System.Drawing.Size(72, 21);
            this.NudMiao.TabIndex = 6;
            this.NudMiao.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NudMiao.ValueChanged += new System.EventHandler(this.NudMiao_ValueChanged);
            this.NudMiao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiao_KeyPress_1);
            this.NudMiao.Leave += new System.EventHandler(this.NudMiao_Leave);
            // 
            // btnClear1
            // 
            this.btnClear1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClear1.ForeColor = System.Drawing.Color.Black;
            this.btnClear1.Location = new System.Drawing.Point(215, 380);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(117, 42);
            this.btnClear1.TabIndex = 5;
            this.btnClear1.Text = "复位";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // lblTishi
            // 
            this.lblTishi.AutoSize = true;
            this.lblTishi.ForeColor = System.Drawing.Color.Red;
            this.lblTishi.Location = new System.Drawing.Point(152, 356);
            this.lblTishi.Name = "lblTishi";
            this.lblTishi.Size = new System.Drawing.Size(0, 12);
            this.lblTishi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "秒";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("宋体", 159.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo.Location = new System.Drawing.Point(52, 80);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(306, 213);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "00";
            // 
            // btnBegin
            // 
            this.btnBegin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBegin.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBegin.ForeColor = System.Drawing.Color.Black;
            this.btnBegin.Location = new System.Drawing.Point(53, 380);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(121, 42);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "开始";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbsystemtime);
            this.tabPage3.Controls.Add(this.gbPowerOff);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(395, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "定时关机";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbsystemtime
            // 
            this.gbsystemtime.Controls.Add(this.lblNowTime);
            this.gbsystemtime.Location = new System.Drawing.Point(8, 274);
            this.gbsystemtime.Name = "gbsystemtime";
            this.gbsystemtime.Size = new System.Drawing.Size(378, 147);
            this.gbsystemtime.TabIndex = 40;
            this.gbsystemtime.TabStop = false;
            this.gbsystemtime.Text = "系统时间：";
            // 
            // lblNowTime
            // 
            this.lblNowTime.AutoSize = true;
            this.lblNowTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowTime.Location = new System.Drawing.Point(38, 60);
            this.lblNowTime.Name = "lblNowTime";
            this.lblNowTime.Size = new System.Drawing.Size(0, 27);
            this.lblNowTime.TabIndex = 3;
            // 
            // gbPowerOff
            // 
            this.gbPowerOff.Controls.Add(this.pbGou);
            this.gbPowerOff.Controls.Add(this.cbEverday);
            this.gbPowerOff.Controls.Add(this.lblMinute);
            this.gbPowerOff.Controls.Add(this.btnSearch);
            this.gbPowerOff.Controls.Add(this.NudMinute);
            this.gbPowerOff.Controls.Add(this.lblHour);
            this.gbPowerOff.Controls.Add(this.NudHour);
            this.gbPowerOff.Controls.Add(this.rbNoPowerOff);
            this.gbPowerOff.Controls.Add(this.rbPowerOffTime);
            this.gbPowerOff.Location = new System.Drawing.Point(6, 36);
            this.gbPowerOff.Name = "gbPowerOff";
            this.gbPowerOff.Size = new System.Drawing.Size(380, 219);
            this.gbPowerOff.TabIndex = 7;
            this.gbPowerOff.TabStop = false;
            this.gbPowerOff.Text = "关机设置";
            // 
            // pbGou
            // 
            this.pbGou.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGou.BackgroundImage")));
            this.pbGou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGou.Location = new System.Drawing.Point(20, 90);
            this.pbGou.Name = "pbGou";
            this.pbGou.Size = new System.Drawing.Size(33, 35);
            this.pbGou.TabIndex = 13;
            this.pbGou.TabStop = false;
            // 
            // cbEverday
            // 
            this.cbEverday.AutoSize = true;
            this.cbEverday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEverday.Enabled = false;
            this.cbEverday.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.cbEverday.Location = new System.Drawing.Point(101, 65);
            this.cbEverday.Name = "cbEverday";
            this.cbEverday.Size = new System.Drawing.Size(118, 24);
            this.cbEverday.TabIndex = 12;
            this.cbEverday.Text = "每天定时关机";
            this.cbEverday.UseVisualStyleBackColor = true;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(300, 38);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(17, 12);
            this.lblMinute.TabIndex = 11;
            this.lblMinute.Text = "分";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(133, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "确定";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // NudMinute
            // 
            this.NudMinute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NudMinute.Enabled = false;
            this.NudMinute.Location = new System.Drawing.Point(250, 34);
            this.NudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudMinute.Name = "NudMinute";
            this.NudMinute.Size = new System.Drawing.Size(42, 21);
            this.NudMinute.TabIndex = 10;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(214, 38);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(17, 12);
            this.lblHour.TabIndex = 9;
            this.lblHour.Text = "时";
            // 
            // NudHour
            // 
            this.NudHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NudHour.Enabled = false;
            this.NudHour.Location = new System.Drawing.Point(166, 34);
            this.NudHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NudHour.Name = "NudHour";
            this.NudHour.Size = new System.Drawing.Size(42, 21);
            this.NudHour.TabIndex = 8;
            // 
            // rbNoPowerOff
            // 
            this.rbNoPowerOff.AutoSize = true;
            this.rbNoPowerOff.Checked = true;
            this.rbNoPowerOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNoPowerOff.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbNoPowerOff.Location = new System.Drawing.Point(63, 98);
            this.rbNoPowerOff.Name = "rbNoPowerOff";
            this.rbNoPowerOff.Size = new System.Drawing.Size(102, 24);
            this.rbNoPowerOff.TabIndex = 7;
            this.rbNoPowerOff.TabStop = true;
            this.rbNoPowerOff.Text = "不设置关机";
            this.rbNoPowerOff.UseVisualStyleBackColor = true;
            this.rbNoPowerOff.CheckedChanged += new System.EventHandler(this.rbNoPowerOff_CheckedChanged);
            // 
            // rbPowerOffTime
            // 
            this.rbPowerOffTime.AutoSize = true;
            this.rbPowerOffTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPowerOffTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbPowerOffTime.Location = new System.Drawing.Point(64, 32);
            this.rbPowerOffTime.Name = "rbPowerOffTime";
            this.rbPowerOffTime.Size = new System.Drawing.Size(87, 24);
            this.rbPowerOffTime.TabIndex = 6;
            this.rbPowerOffTime.Text = "关机时间";
            this.rbPowerOffTime.UseVisualStyleBackColor = true;
            this.rbPowerOffTime.CheckedChanged += new System.EventHandler(this.rbPowerOffTime_CheckedChanged);
            // 
            // timerNo
            // 
            this.timerNo.Interval = 1000;
            this.timerNo.Tick += new System.EventHandler(this.timerNo_Tick);
            // 
            // TimerPowerOff
            // 
            this.TimerPowerOff.Interval = 1000;
            this.TimerPowerOff.Tick += new System.EventHandler(this.TimerPowerOff_Tick);
            // 
            // TimerPowerOff2
            // 
            this.TimerPowerOff2.Interval = 1000;
            this.TimerPowerOff2.Tick += new System.EventHandler(this.TimerPowerOff2_Tick);
            // 
            // pbX
            // 
            this.pbX.AccessibleDescription = "关闭";
            this.pbX.AccessibleName = "关闭";
            this.pbX.BackColor = System.Drawing.Color.Transparent;
            this.pbX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbX.BackgroundImage")));
            this.pbX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbX.Location = new System.Drawing.Point(372, 3);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(32, 26);
            this.pbX.TabIndex = 1;
            this.pbX.TabStop = false;
            this.pbX.Tag = "关闭";
            this.pbX.Click += new System.EventHandler(this.pbX_Click);
            // 
            // pbB
            // 
            this.pbB.BackColor = System.Drawing.Color.Transparent;
            this.pbB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbB.BackgroundImage")));
            this.pbB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbB.Location = new System.Drawing.Point(331, 1);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(35, 30);
            this.pbB.TabIndex = 2;
            this.pbB.TabStop = false;
            this.pbB.Click += new System.EventHandler(this.pbB_Click);
            // 
            // Icon
            // 
            this.Icon.ContextMenuStrip = this.cmsClose;
            this.Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Icon.Icon")));
            this.Icon.Text = "小学生计时器";
            this.Icon.Visible = true;
            this.Icon.DoubleClick += new System.EventHandler(this.Icon_DoubleClick);
            // 
            // cmsClose
            // 
            this.cmsClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmQuit});
            this.cmsClose.Name = "cmsClose";
            this.cmsClose.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(100, 22);
            this.tsmOpen.Text = "打开";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmQuit
            // 
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(100, 22);
            this.tsmQuit.Text = "退出";
            this.tsmQuit.Click += new System.EventHandler(this.tsmQuit_Click);
            // 
            // FrmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(407, 583);
            this.Controls.Add(this.pbB);
            this.Controls.Add(this.pbX);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmTime";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小学生计时器";
            this.MinimumSizeChanged += new System.EventHandler(this.FrmTime_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTime_FormClosing);
            this.Load += new System.EventHandler(this.FrmTime_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMiao)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gbsystemtime.ResumeLayout(false);
            this.gbsystemtime.PerformLayout();
            this.gbPowerOff.ResumeLayout(false);
            this.gbPowerOff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            this.cmsClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer NowTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStatr;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Timer timerNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTishi;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.NumericUpDown NudMiao;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbPowerOff;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.NumericUpDown NudMinute;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.NumericUpDown NudHour;
        private System.Windows.Forms.RadioButton rbNoPowerOff;
        private System.Windows.Forms.RadioButton rbPowerOffTime;
        private System.Windows.Forms.GroupBox gbsystemtime;
        private System.Windows.Forms.Label lblNowTime;
        private System.Windows.Forms.Timer TimerPowerOff;
        private System.Windows.Forms.Timer TimerPowerOff2;
        private System.Windows.Forms.CheckBox cbEverday;
        private System.Windows.Forms.PictureBox pbX;
        private System.Windows.Forms.PictureBox pbB;
        public System.Windows.Forms.NotifyIcon Icon;
        private System.Windows.Forms.ContextMenuStrip cmsClose;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmQuit;
        private System.Windows.Forms.PictureBox pbGou;
    }
}

