using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Xml;
using System.IO;

namespace RecordTime
{
    public partial class FrmTime : Form
    {
        public FrmTime()
        {
            InitializeComponent();
        }

        //=============================秒表==================================

        private bool Statue = false;//判断是否为"开始"或"停止"状态，false为停止状态
        private int Haomiao = 0;//毫秒
        private int Miao = 0;//秒
        private int Fen = 0;//分
        private int Hour = 0;//时

        private void btnStatr_Click_1(object sender, EventArgs e)
        {
            if (Statue == false)
            {
                Timer.Start();
                this.btnStatr.Text = "停止";
                Statue = true;//切换回"开始"状态
            }
            else
            {
                Timer.Stop();
                this.btnStatr.Text = "开始";
                Statue = false;//切换回"停止"状态
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Haomiao++;//Timer10毫秒触发一次，毫秒+1
            if (Haomiao == 100)//当毫秒累加到100时秒钟+1
            {
                Miao++;
                Haomiao = 0;//毫秒又重0开始累加
            }
            if (Miao == 60)//当秒钟累加到60秒时，分钟+1（60秒等于1分钟）
            {
                Fen++;
                Miao = 0;//秒钟又重0开始累加
            }
            if (Fen == 60)//当分钟累加到60分时，小时+1（60分等于1小时）
            {
                Hour++;
                Fen = 0;//分钟又重0开始累加
            }
            string time = Hour.ToString().PadLeft(2, '0') + ":" + Fen.ToString().PadLeft(2, '0') + ":" + Miao.ToString().PadLeft(2, '0') + "." + Haomiao.ToString().PadLeft(2, '0');
            this.lblTime.Text = time;
        }

        private int Num = 1;//标识显示秒表记录的第几行

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Timer.Stop();
            this.btnStatr.Text = "开始";
            Statue = false;//切换回"停止"状态
            //所有时间清零
            Haomiao = 0;
            Miao = 0;
            Fen = 0;
            Hour = 0;
            string time = Hour.ToString().PadLeft(2, '0') + ":" + Fen.ToString().PadLeft(2, '0') + ":" + Miao.ToString().PadLeft(2, '0') + "." + Haomiao.ToString().PadLeft(2, '0');
            this.lblTime.Text = time;
            this.lblTime1.Text = "";
            this.lblTime2.Text = "";
            this.lblTime3.Text = "";
            lblT1.Text = "";
            lblT2.Text = "";
            lblT3.Text = "";
            this.btnRecord.Text = "记录";
            Num = 1;//设置显示秒表记录的行数重回1
        }

        private void NowTimer_Tick(object sender, EventArgs e)
        {
            DateTime Nowtime = DateTime.Now;//得到当前系统时间
            string StrNowTime = string.Format(@"{0}年{1}月{2}日 {3}时{4}分{5}秒",
            Nowtime.Year, Nowtime.Month, Nowtime.Day, Nowtime.Hour, Nowtime.Minute, Nowtime.Second.ToString().PadLeft(2, '0'));
            lblNowTime.Text = StrNowTime;

        }

        private void btnRecord_Click_1(object sender, EventArgs e)
        {
            if (this.btnRecord.Text == "清除记录")
            {
                this.lblTime1.Text = "";
                this.lblTime2.Text = "";
                this.lblTime3.Text = "";
                lblT1.Text = "";
                lblT2.Text = "";
                lblT3.Text = "";
                this.btnRecord.Text = "记录";
                Num = 1;
                return;
            }
            if (Num == 1)
            {
                lblT1.Text = "1.";
                this.lblTime1.Text = lblTime.Text;
                Num++;
                return;
            }
            if (Num == 2)
            {
                lblT2.Text = "2.";
                this.lblTime2.Text = lblTime.Text;
                Num++;
                return;
            }
            if (Num == 3)//只能记录3条记录，显示3条后转换为"清除记录"
            {
                lblT3.Text = "3.";
                this.lblTime3.Text = lblTime.Text;
                Num++;
                this.btnRecord.Text = "清除记录";
                return;
            }
            
        }

        //=============================秒表==================================





        //=============================倒计时================================

        private int BeginNo;//倒计时的开始秒钟
        private bool Statue2 = false;//判断是否为"开始"或"停止"状态
        private bool Begin = false;////判断重新开始

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (NudMiao.Text.Trim().Length == 0)
            {
                lblTishi.Text = "请输入倒计分钟";
                return;
            }
            if (this.NudMiao.Value > 10000)
            {
                lblTishi.Text = "秒钟不能大于10000秒";
                return;
            }
            if (this.NudMiao.Value <= 0)
            {
                lblTishi.Text = "秒钟不能小于1秒";
                return;
            }
            if (Begin == false)
            {
                BeginNo = Convert.ToInt32(this.NudMiao.Value);
                this.lblNo.Text = BeginNo.ToString();
                Begin = true;
            }
            if (Statue2 == false)
            {
                this.btnBegin.Text = "暂停";
                timerNo.Start();
                Statue2 = true;
            }
            else
            {
                if (BeginNo != 0) this.btnBegin.Text = "继续";
                else this.btnBegin.Text = "开始";
                timerNo.Stop();
                Statue2 = false;
            }
            this.lblNo.ForeColor = System.Drawing.Color.Black;
            if (this.lblNo.Text == "时间到！")
            {
                this.lblNo.Text = BeginNo.ToString();
            }
            this.lblNo.Font = new System.Drawing.Font("宋体", 159.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo.Location = new Point((this.Width - this.lblNo.Width) / 2, 80);
        }

        private void timerNo_Tick(object sender, EventArgs e)
        {
            BeginNo--;
            this.lblNo.Text = BeginNo.ToString();
            if (BeginNo == 0)
            {
                timerNo.Stop();//时间到停止timerNo计时器
                BeginNo = Convert.ToInt32(this.NudMiao.Value);//重新得到NudMiao里的值方便用户重新开始
                lblNo.Text = "时间到！";
                this.lblNo.ForeColor = System.Drawing.Color.Red;
                this.lblNo.Font = new System.Drawing.Font("宋体", 60.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                this.btnBegin.Text = "重新开始";
                Statue2 = false;
                this.lblNo.Location = new Point((this.Width - 300) / 2, (this.Height - 210) / 2);
                return;
            }
            this.lblNo.Font = new System.Drawing.Font("宋体", 159.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo.Location = new Point((this.Width - this.lblNo.Width) / 2, 80);

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            //单击"重置"回到原始状态
            BeginNo = 0;//重置"开始秒钟"为0
            timerNo.Stop();
            this.lblNo.ForeColor = System.Drawing.Color.Black;
            lblNo.Text = "00";
            this.lblNo.Font = new System.Drawing.Font("宋体", 159.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo.Location = new Point((this.Width - this.lblNo.Width) / 2, 80);
            btnBegin.Text = "开始";
            Statue2 = false;
            Begin = false;//重新开始
        }

        private void txtMiao_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //为了防止用户输入非法数字，数据类型转换抛异常
            e.Handled = true;//先将键盘锁住
            //如果用户输入的按键是"0"到"9"的数字键或者"回删键"，键盘解锁
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8) e.Handled = false;//键盘解锁
            else
            {
                lblTishi.Text = "不能输入非数字字符";
                return;
            }
            lblTishi.Text = "";
        }

        private void NudMiao_ValueChanged(object sender, EventArgs e)
        {
            btnBegin.Text = "开始";
        }

        private void NudMiao_Leave(object sender, EventArgs e)
        {
            if (this.NudMiao.Value > 10000)
            {
                lblTishi.Text = "秒钟不能大于10000秒";
                return;
            }
            BeginNo = Convert.ToInt32(this.NudMiao.Value);
        }

        //=============================倒计时================================





        //=============================定时关机===============================

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbNoPowerOff.Checked)
            {
                TimerPowerOff.Stop();//关闭关机计时器
                MessageBox.Show("设置成功，不定时关机", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.pbGou.Location = new System.Drawing.Point(20, 90);
                return;
            }
            else if (rbPowerOffTime.Checked)
            {
                if (NudHour.Value == DateTime.Now.Hour && NudMinute.Value - DateTime.Now.Minute <= 1)
                {
                    MessageBox.Show("关机时间至少必须提前2分钟", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("设置成功，关机时间为：" + NudHour.Value + "时" + NudMinute.Value + "分", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TimerPowerOff.Start();//启动关机计时器
                this.pbGou.Location = new System.Drawing.Point(20, 25);
                return;
            }
        }

        private void rbPowerOffTime_CheckedChanged(object sender, EventArgs e)
        {
            this.NudHour.Enabled = true;
            this.NudMinute.Enabled = true;
            cbEverday.Enabled = true;
        }

        private void rbNoPowerOff_CheckedChanged(object sender, EventArgs e)
        {
            this.NudHour.Enabled = false;
            this.NudMinute.Enabled = false;
            cbEverday.Enabled = false;
            cbEverday.Checked = false;
        }

        private void TimerPowerOff_Tick(object sender, EventArgs e)
        {
            DateTime NowTime = DateTime.Now;
            if (NudHour.Value == NowTime.Hour && NudMinute.Value == NowTime.Minute)
            {
                TimerPowerOff.Stop();
                ShutDown();
                MessageBox.Show("正在准备关机...", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //TimerPowerOff2.Start();
                return;
            }
        }

        //定时时间到后再给用户60秒确定要取消定时关机，否则60秒后自动关机
        private int miao = 60;

        private void TimerPowerOff2_Tick(object sender, EventArgs e)
        {
            miao--;
            MessageBox.Show(miao + "秒后自动关机");
            //this.Show
            return;

        }

        //定义关机方法 
        private void ShutDown()
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();//启动进程
            p.StandardInput.WriteLine("shutdown -s -f");
            p.Close();
        }

        //C#倒计时关闭对话框VS2008源代码！Messagebox 自定义倒计时关闭！3秒钟后关闭...2秒钟后关闭...1秒钟后关闭... 
        private void StartKiller()
        {

            //Timer timer = new Timer();

            //timer.Interval = 3000; //3秒启动

            //timer.Tick += new EventHandler(timer1_Tick);

            //timer.Start();

            //}

            //private void KillMessageBox()

            //{

            ////按照MessageBox的标题，找到MessageBox的窗口

            //IntPtr ptr = FindWindow(null, "MessageBox");

            //if (ptr != IntPtr.Zero)

            //{

            ////找到则关闭MessageBox窗口

            //PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);

            //}

        }

        //=============================定时关机===============================






        //=============================读写XML文件============================

        private void FrmTime_Load(object sender, EventArgs e)
        {
            string PowerOffeveryDay = string.Empty;//(空字符串)用来判断用户上次关闭程序之前是否都"每天定时关机"
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("D:\\小学生计时器配置文件.xml");
            }
            catch (Exception)
            {
                return;//如果找不到配置文件，会抛异常，直接结束后面的程序
            }
            XmlElement xmlRoot = doc.DocumentElement;
            foreach (XmlNode node in xmlRoot.ChildNodes)
            {
                if (node.Name.Equals("Remember")) { PowerOffeveryDay = node.InnerText; continue; }
                if (node.Name.Equals("Hour")) { NudHour.Value = Convert.ToInt32(node.InnerText); continue; }
                if (node.Name.Equals("Minute")) { NudMinute.Value = Convert.ToInt32(node.InnerText); continue; }
            }
            //判断用户上次关闭程序之前是否都"每天定时关机"
            if (PowerOffeveryDay.Equals("True"))
            {
                rbPowerOffTime.Checked = true;
                cbEverday.Checked = true;
                this.pbGou.Location = new System.Drawing.Point(20, 25);
                return;
            }
            
        }

        private void FrmTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool PowerOffeveryDay = false;//用户上次关闭程序之前是否都"每天定时关机"
            if (cbEverday.Checked) { PowerOffeveryDay = true; }//判断用户上次关闭程序之前是否都"每天定时关机"
            FileStream myfs = new FileStream("D:\\小学生计时器配置文件.xml", FileMode.Create);
            StreamWriter mySw = new StreamWriter(myfs);
            mySw.WriteLine("<?xml   version=\"1.0\"   encoding=\"utf-8\"?>");
            mySw.WriteLine("<YesNo>");
            mySw.WriteLine("\t<Remember>" + PowerOffeveryDay + "</Remember>");
            mySw.WriteLine("\t<Hour>" + NudHour.Value + "</Hour>");
            mySw.WriteLine("\t<Minute>" + NudMinute.Value + "</Minute>");
            mySw.WriteLine("</YesNo>");
            mySw.Close();
            myfs.Close();
        }

        //=============================读写XML文件============================





        //=============================最小化到托盘===========================

        private void pbX_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmTime_MinimumSizeChanged(object sender, EventArgs e)
        {
            //this.SizeChanged += new System.EventHandler(this.FrmTime_SizeChanged);
        }
        
        private void FrmTime_SizeChanged(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();
            //}
        }

        private void Icon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmQuit_Click(object sender, EventArgs e)
        {
            if (rbNoPowerOff.Checked)
            {
                this.Close();
                Application.ExitThread();
            }
            DialogResult Dr = MessageBox.Show("退出程序后定时功能将失效，是否继续退出？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dr == DialogResult.No) return;
            this.Close();
            Application.ExitThread();
        }

        //=============================最小化到托盘===========================
    }
}
