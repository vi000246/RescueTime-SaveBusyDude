using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;
using rescuetime_savebusydude;
using RescueTime_SaveBusyDude.Util;

namespace RescueTime_SaveBusyDude
{
    public partial class Form1 : Form
    {
        #region 視窗控制
        public Form1()
        {
            InitializeComponent();
            //加入結束按鈕
            ToolStripItem btnClose = this.contextMenuStrip1.Items.Add("結束");
            btnClose.Click += new EventHandler(btnClose_Click);
            ToolStripItem btnStartFocus = this.contextMenuStrip1.Items.Add("Start Focus");
            btnStartFocus.Click += new EventHandler(btnStartFocus_Click);
            //氣泡提示popup
            notifyIcon1.ShowBalloonTip(3000, this.Text,
                "程式已在背景執行!",
                ToolTipIcon.Info);
        }
        void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Close();
        }

        //專注按鈕點擊
        void btnStartFocus_Click(object sender, EventArgs e)
        {
            int minute = 0;
            CustomForm.InputBox("開始專心", "請輸入要專注的時間(分鐘):",ref minute);
        }
        //托盤icon點擊
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }
        //氣泡圖示點擊
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowForm();
        }
        /// <summary>
        /// 顯示出主畫面
        /// </summary>
        private void ShowForm()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //如果目前是縮小狀態，才要回覆成一般大小的視窗
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            // Activate the form.
            this.Activate();
            this.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Tag = string.Empty;
                notifyIcon1.ShowBalloonTip(3000, this.Text,
                    "程式並未結束，要結束請在圖示上按右鍵，選取結束功能!",
                    ToolTipIcon.Info);
            }
        }
        #endregion

        //定期執行method 用來show Alert
        private void timer1_Tick(object sender, EventArgs e)
        {
            var name = WindowUtil.GetActiveProcessName();//取得程式名稱
            if (name == "chrome")
            {
                name = WindowUtil.GetActiveTabUrl();
            }
            if (!string.IsNullOrEmpty(name))
            {
//                 notifyIcon1.ShowBalloonTip(900, this.Text,
//                     name,
//                     ToolTipIcon.Info);
            }
        }
       
    }
}
