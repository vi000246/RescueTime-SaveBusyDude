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

        //定期執行method
        private void timer1_Tick(object sender, EventArgs e)
        {
//            GetCurrentWindowTitle();//取得活動視窗
            GetActiveProcessFileName();//取得程式名稱
        }
        // 會用到的 WinAPI
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowText(IntPtr hWnd, StringBuilder lpsb, Int32 count);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        //取得目前視窗標題
        private void GetCurrentWindowTitle()
        {
//            IntPtr handle = Handle;
//            StringBuilder WindowTitle = new StringBuilder(256);
//            handle = GetForegroundWindow();
//            if (GetWindowText(handle, WindowTitle, WindowTitle.Capacity))
//            {
//                notifyIcon1.ShowBalloonTip(900, this.Text,
//                    WindowTitle.ToString(),
//                    ToolTipIcon.Info);
//            }
        }

        //取得目前視窗的process name
        public void GetActiveProcessFileName()
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            notifyIcon1.ShowBalloonTip(900, this.Text,
                p.MainModule.FileName.ToString(),
                ToolTipIcon.Info);
        }

        //取得當前chrome tab的URL
        public static string GetActiveTabUrl()
        {
            Process[] procsChrome = Process.GetProcessesByName("chrome");

            if (procsChrome.Length <= 0)
                return null;

            foreach (Process proc in procsChrome)
            {
                // the chrome process must have a window 
                if (proc.MainWindowHandle == IntPtr.Zero)
                    continue;

                // to find the tabs we first need to locate something reliable - the 'New Tab' button 
                AutomationElement root = AutomationElement.FromHandle(proc.MainWindowHandle);
                var SearchBar = root.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Address and search bar"));
                if (SearchBar != null)
                    return (string)SearchBar.GetCurrentPropertyValue(ValuePatternIdentifiers.ValueProperty);
            }

            return null;
        }
    }
}
