using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinkSwap
{
    public partial class MainForm : Form
    {
        string token;
        Util util = new Util();
        int index = 0;
        string server = Properties.Settings.Default.server;
        string username = "";

        public MainForm(string token=null,int index=0)
        {
            this.token = token;
            this.index = index;
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = index;
            web_ad.Navigate(server + "ad/1");
            web_ad_trust.Navigate(server + "ad/2");
            UpdateUser();

        }

        private void UpdateUser()
        {
            try
            {
                string res = util.GET(String.Format(server + "api.php?action=get_user&token={0}", token));
                JObject user = JObject.Parse(res);
                lb_user.Text = (string)user["username"];
                username = (string)user["username"];
                lb_point.Text = "积分:" + user["point"];
                txt_email.Text = (string)user["email"];
                txt_phone.Text = (string)user["phone"];
                txt_qq.Text = (string)user["qq"];
                txt_alipay.Text = (string)user["alipay"];
            }
            catch { }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_nav1_Click(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = 1;
        }

        private void tp_business_Click(object sender, EventArgs e)
        {

        }

        private void btn_nav2_Click(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = 2;
        }

        private void btn_nav3_Click(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = 3;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_nav4_Click(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = 4;
        }

        private void btn_nav5_Click(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = 5;
        }

        private void tp_user_Click(object sender, EventArgs e)
        {

        }

        private void lb_buy_point_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tc_main.SelectedIndex = 5;
        }

        private void lb_user_Click(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = 5;
        }

        private void txt_pay_money_TextChanged(object sender, EventArgs e)
        {
            lb_convert_point.Text = "兑换积分：" + int.Parse(txt_pay_money.Text) * 10;
        }

        private void btn_add_site_Click(object sender, EventArgs e)
        {
            new SiteForm("1", "2").Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cb_trade.Text == "")
            {
                MessageBox.Show("!");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            string res = util.GET(String.Format(server + "api.php?action=update_user&token={0}&email={1}&phone={2}&qq={3}&alipay={4}", token,txt_email.Text,txt_phone.Text,txt_qq.Text,txt_alipay.Text));
            JObject jres = JObject.Parse(res);
            string msg = (string)jres["msg"];
            MessageBox.Show(msg);
        }

        private void btn_update_pass_Click(object sender, EventArgs e)
        {
            if(txt_pw.Text == txt_pw2.Text&&txt_pw.TextLength>=6)
            {
                string res = util.GET(String.Format(server + "api.php?action=update_pw&token={0}&old_pw={1}&new_pw={2}", token, txt_old_pw.Text,txt_pw.Text));
                JObject jres = JObject.Parse(res);
                string msg = (string)jres["msg"];
                MessageBox.Show(msg);

            }
            else
            {
                MessageBox.Show("密码输入有误");
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format(server + "pay.php?user={0}&fee={1}", username, int.Parse(txt_pay_money.Text)));
        }

        private void online_Tick(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void lb_update_user_info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateUser();
        }
    }
}
