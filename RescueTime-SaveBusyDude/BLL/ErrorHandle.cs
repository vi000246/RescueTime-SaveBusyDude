using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RescueTime_SaveBusyDude.BLL
{
    public static class ErrorHandle
    {
        public static T Execute<T>(Func<T> func, string customMsg = null)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                showMsgBox(ex.Message, customMsg);
                throw new ArgumentException(ex.Message);
            }
        }

        public static void Execute(Action func, string customMsg = null)
        {
            try
            {
                func();
            }
            catch (Exception ex)
            {
                showMsgBox(ex.Message, customMsg);
            }

        }

        private static void showMsgBox(string msg, string customMsg)
        {
            if (!string.IsNullOrEmpty(customMsg))
                MessageBox.Show(customMsg + $"\nErrMsg:\n{msg}");
            else
            {
                MessageBox.Show(msg);
            }
        }
    }
}
