using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace LinkSwap
{
    public partial class LoginForm : Form
    {
        Util util = new Util();
        string server = Properties.Settings.Default.server;
        string version;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += " " + version;
            lb_copyright.Text = "软件著作号:12345678 侵权必究";
            txt_user.Text = Properties.Settings.Default.username;
            txt_pw.Text = Properties.Settings.Default.password;

            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    string res = util.GET(String.Format(server + "api.php?action=login&username={0}&password={1}", txt_user.Text, txt_pw.Text));
                    JObject jres = JObject.Parse(res);
                    bool state = (bool)jres["success"];
                    string token = (string)jres["token"];
                    string msg = (string)jres["msg"];
                    if (state)
                    {
                        this.Hide();
                        new MainForm(token).Show();
                        if (cb_save_pw.Checked)
                        {
                            Properties.Settings.Default.username = txt_user.Text;
                            Properties.Settings.Default.password = txt_pw.Text;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.username = "";
                            Properties.Settings.Default.password = "";
                            Properties.Settings.Default.Save();
                        }
                    }
                    else
                    {
                        MessageBox.Show(msg);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("请输入用户名/密码");
            }

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            new RegForm(txt_user.Text, txt_pw.Text).Show();
        }

        private bool CheckInput()
        {
            return (txt_user.TextLength > 0 && txt_pw.TextLength > 0);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            new Thread(CheckNewVersion).Start();
        }

        private void CheckNewVersion()
        {
            string res = util.GET(String.Format(server + "config/version.json"));
            JObject jres = JObject.Parse(res);
            string new_ver = (string)jres["version"];
            string new_url = (string)jres["url"];
            if (new_ver != version && MessageBox.Show("是否下载新版本 " + new_ver, "发现新版本", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                System.Diagnostics.Process.Start(new_url);
            }
        }

        private void lb_forget_pw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txt_user.TextLength > 0)
            {
                string res = util.GET(String.Format(server + "api.php?action=forget_pw&user={0}", txt_user.Text));
                MessageBox.Show("已发送找回密码链接到您的邮箱");

            }else
            {
                MessageBox.Show("请输入用户名");
            }
        }

        private void lb_copyright_Click(object sender, EventArgs e)
        {

        }
    }
}
