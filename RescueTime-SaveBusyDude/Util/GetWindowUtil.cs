using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace rescuetime_savebusydude
{
    /// <summary>
    /// 取得視窗資訊相關邏輯
    /// </summary>
    public static class WindowUtil
    {
        // 會用到的 WinAPI
//        [DllImport("user32.dll")]
//        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpsb, int count);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        //取得目前視窗標題
//        public static string GetCurrentWindowTitle()
//        {
//            const int nChars = 256;
//            StringBuilder Buff = new StringBuilder(nChars);
//            IntPtr handle = GetForegroundWindow();
//
//            if (GetWindowText(handle, Buff, nChars) > 0)
//            {
//                return Buff.ToString();
//            }
//            return null;
//        }

        //取得目前視窗的process name
        public static string GetActiveProcessName()
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            return p.ProcessName;
        }

        //取得當前chrome tab的URL
        public static string GetActiveTabUrl()
        {
            foreach (Process process in Process.GetProcessesByName("chrome"))
            {
                string url = GetChromeUrl(process);
                if (url == null)
                    continue;

                return GetDomainFromUrl(url);
            }

            return null;
        }

        private static string GetDomainFromUrl(string url)
        {
            var regex = new Regex(@"^(?:https?:\/\/)?(?:[^@\n]+@)?(?:www\.)?([^:\/\n?]+)");
            var match = regex.Match(url);
            if (match.Success)
                return match.Groups[1].Value;
            else
            {
                return null;
            }
        }

        private static string GetChromeUrl(Process process)
        {
            if (process == null)
                throw new ArgumentNullException("process");

            if (process.MainWindowHandle == IntPtr.Zero)
                return null;

            AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
            if (element == null)
                return null;

            AutomationElementCollection elm1 = element.FindAll(TreeScope.Subtree, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));
            if (elm1.Count > 0)
            {
                AutomationElement elm = elm1[0];
                string vp = ((ValuePattern) elm.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
                Console.WriteLine(vp);
                return vp;
            }

            return null;
        }
    }
}
