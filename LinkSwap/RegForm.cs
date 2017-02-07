using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LinkSwap
{
    public partial class RegForm : Form
    {
        Util util = new Util();
        string server = Properties.Settings.Default.server;
        string user, pw;
        public RegForm(string user="",string pw="")
        {
            this.user = user;
            this.pw = pw;

            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            txt_user.Text = user;
            txt_pw.Text = pw;
        }
        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    string res = util.GET(String.Format(server + "api.php?action=reg&username={0}&password={1}&email={2}&phone={3}&qq={4}&alipay={5}", txt_user.Text, txt_pw.Text, txt_email.Text, txt_phone.Text, txt_qq.Text, txt_alipay.Text));
                    JObject jres = JObject.Parse(res);
                    bool state = (bool)jres["success"];
                    string msg = (string)jres["msg"];
                    MessageBox.Show(msg);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckInput()
        {
            if (txt_user.TextLength == 0|| txt_pw.TextLength == 0||txt_pw2.TextLength==0||txt_email.TextLength==0||txt_phone.TextLength==0||txt_qq.TextLength==0)
            {
                MessageBox.Show("不能为空");
                return false;
            }else if (txt_pw.Text != txt_pw2.Text)
            {
                MessageBox.Show("密码不一致");
                return false;
            }else if (txt_email.Text.IndexOf("@") < 0)
            {
                MessageBox.Show("邮箱格式不正确");
                return false;
            }else if (txt_phone.TextLength != 11 && IsNumeric(txt_phone.Text))
            {
                MessageBox.Show("手机格式不正确");
                return false;
            }else if (!IsNumeric(txt_qq.Text))
            {
                MessageBox.Show("QQ格式错误");
                return false;
            }

            return true;
        }
    }
}
