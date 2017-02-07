using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LinkSwap
{
    public static class Program
    {
        public static LoginForm loginForm;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool ret;
            Mutex mutex = new Mutex(true,Application.ProductName,out ret);
            

            if (ret)
            {
                mutex.ReleaseMutex();
            }else
            {
                MessageBox.Show("请不要重复运行", "换链宝");
                return;
            }

            loginForm = new LoginForm();
            string cb = Clipboard.GetText();

            if (cb.IndexOf("hlb_") > -1)
            {
                string token = cb.Substring(5, cb.Length-5);
                if (MessageBox.Show("是否登陆: " + token, "快捷登陆", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    new MainForm(token).Show();
                }
                else
                {
                    //loginForm.Show();
                    Application.Run(loginForm);
                }
            }else
            {
                //loginForm.Show();
                Application.Run(loginForm);
            }
            
        }
    }
}
