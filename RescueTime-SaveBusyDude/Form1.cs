using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;
using rescuetime_savebusydude;
using RescueTime_SaveBusyDude.BLL;
using RescueTime_SaveBusyDude.Forms;

namespace RescueTime_SaveBusyDude
{
    public partial class Form1 : Form
    {
        #region 視窗控制
        public Form1()
        {
            InitializeComponent();
            //加入設置按鈕
            ToolStripItem btnSetting = this.contextMenuStrip1.Items.Add("Setting");
            btnSetting.Click += new EventHandler(btnSetting_Click);
            //加入結束按鈕
            ToolStripItem btnClose = this.contextMenuStrip1.Items.Add("Exit");
            btnClose.Click += new EventHandler(btnClose_Click);
            //氣泡提示popup
            notifyIcon1.ShowBalloonTip(3000, this.Text,
                "Process is running in the background!",
                ToolTipIcon.Info);

            new ConfigForm().Show();
        }

        //離開程式
        void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Close();
        }

        void btnSetting_Click(object sender, EventArgs e)
        {
            new ConfigForm().Show();
        }

        //托盤icon點擊
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ShowForm();
        }
        //氣泡圖示點擊
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //ShowForm();
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
                    "The program is not closing yet,\nif you want to exit,\nplease right click on task bar icon,then click exit.",
                    ToolTipIcon.Info);
            }
        }
        #endregion

        //定期執行method 用來show Alert
        private void Alerttimer_Tick(object sender, EventArgs e)
        {
            var config = ConfigUtil.GetJsonConfigData();
            var data = RescueTimeAPI.GetActivityDataByHour();
            string msg = new Alert().DisplayAlertProcess(data,config);
            if (!string.IsNullOrEmpty(msg))
            {
                //氣泡提示popup
                notifyIcon1.ShowBalloonTip(10000, "Alert",
                    msg,
                    ToolTipIcon.Warning);
            }
        }
    }
}
