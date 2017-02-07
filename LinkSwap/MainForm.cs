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
using static System.Windows.Forms.ListViewItem;

namespace LinkSwap
{
    public partial class MainForm : Form
    {
        string token;
        static string title = "换链宝";
        Util util = new Util();
        int index = 0;
        string server = Properties.Settings.Default.server;
        string username = "";
        string user_id = "";
        float fee_rate = 1;
        float vip_price = 0;
        float super_vip_price = 0;
        float trust_price = 0;
        bool access = false;

        List<LinkLabel> lb_list = new List<LinkLabel>();
        List<Link> link_list = new List<Link>();

        public class ComboBoxItem
        {
            private string _text = null;
            private object _value = null;
            public string Text { get { return this._text; } set { this._text = value; } }
            public object Value { get { return this._value; } set { this._value = value; } }
            public override string ToString()
            {
                return this._text;
            }
        }

        public class Link
        {
            public string title { get; set; }
            public string url { get; set; }
            public bool bold { get; set; }
            public Color color { get; set; }
        }

        public MainForm(string token = null, int index = 1)
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
            Control.CheckForIllegalCrossThreadCalls = false;

            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += " " + version;
            lb_copyright.Text = "软件著作号:12345678 侵权必究";
            tc_main.SelectedIndex = index;
            web_ad.Navigate(server + "ad/welcome");
            web_ad_trust.Navigate(server + "ad/trust");
            web_ad_vip.Navigate(server + "ad/vip");

            ad_link_1.Navigate(server + "api.php?action=get_link_ad");
            ad_link_2.Navigate(server + "api.php?action=get_link_ad");
            ad_link_3.Navigate(server + "api.php?action=get_link_ad");
            ad_link_4.Navigate(server + "api.php?action=get_link_ad");
            
            tip_buslist.SetToolTip(list_link, "双击/右键操作");

            cb_class.SelectedIndex = 0;
            cb_swap_class.SelectedIndex = 0;
            cb_se.SelectedIndex = 0;
            cb_wt_site.SelectedIndex = 0;
        }

        private void GetMoneyConfig()
        {
            //string res = util.GET(server + String.Format("api.php?action=get_links&user_id={0}", user_id));
            string res = util.GET(String.Format(server + "config/money.json"));
            JObject jres = JObject.Parse(res);
            fee_rate = (float)jres["fee_rate"];
            vip_price = (float)jres["vip_price"];
            super_vip_price = (float)jres["super_vip_price"];
            trust_price = (float)jres["trust_price"];
            btn_buy_vip.Text = vip_price.ToString() + "积分 升级VIP/年";
            btn_buy_super_vip.Text = super_vip_price.ToString() + "积分 升级超级VIP/年";
            lb_fee.Text = "手续费：" + Math.Round(fee_rate * 100, 2).ToString() + "%";
            lb_trust_price.Text = trust_price.ToString() + " 积分/月";
        }
        private void LoadTrustMySite()
        {
            cb_site_name.Items.Clear();
            string res = util.GET(server + String.Format("api.php?action=get_links&user_id={0}", user_id));
            var jarr = JArray.Parse(res);

            foreach (var j in jarr)  //查找某个字段与值
            {
                JObject item = ((JObject)j);
                cb_site_name.Items.Add(new ComboBoxItem { Value = (string)item["id"], Text = (string)item["name"] });
            }
        }

        private void UpdateUser()
        {

            try
            {
                string res = util.GET(String.Format(server + "api.php?action=get_user&token={0}", token));
                JObject user = JObject.Parse(res);
                access = (bool)user["access"];
                if (!access)
                {
                    this.Hide();
                    MessageBox.Show("登陆失效，请重新登录",title);
                    Application.Restart();
                }
                user_id = (string)user["id"];
                lb_user.Text = (string)user["username"];
                username = (string)user["username"];
                lb_point.Text = "账户余额：" + user["point"] +" 积分  可兑换：" + ((int)user["point"]*(1-fee_rate)/10).ToString()+" 元";
                txt_email.Text = (string)user["email"];
                txt_phone.Text = (string)user["phone"];
                txt_qq.Text = (string)user["qq"];
                txt_alipay.Text = (string)user["alipay"];
                bool vip = (bool)user["isVIP"];
                bool super_vip = (bool)user["isSuperVIP"];

                if (vip)
                {
                    btn_buy_vip.Visible = false;
                    lb_vip.Text = "VIP";

                }else if (super_vip)
                {
                    btn_buy_vip.Visible = false;

                    btn_buy_super_vip.Visible = false;


                    lb_vip.Text = "超级VIP";
                }
                        

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
            lb_convert_point.Text = "兑换积分：" + int.Parse("0" + txt_pay_money.Text) * 10;
        }

        private void btn_add_site_Click(object sender, EventArgs e)
        {
            new SiteForm(user_id).Show();
            //new SiteForm(user_id, "2").Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadBusLink();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            string res = util.GET(String.Format(server + "api.php?action=update_user&token={0}&email={1}&phone={2}&qq={3}&alipay={4}", token, txt_email.Text, txt_phone.Text, txt_qq.Text, txt_alipay.Text));
            JObject jres = JObject.Parse(res);
            string msg = (string)jres["msg"];
            MessageBox.Show(msg,title);
        }

        private void btn_update_pass_Click(object sender, EventArgs e)
        {
            if (txt_pw.Text == txt_pw2.Text && txt_pw.TextLength >= 6)
            {
                string res = util.GET(String.Format(server + "api.php?action=update_pw&token={0}&old_pw={1}&new_pw={2}", token, txt_old_pw.Text, txt_pw.Text));
                JObject jres = JObject.Parse(res);
                string msg = (string)jres["msg"];
                MessageBox.Show(msg,title);
                

            }
            else
            {
                MessageBox.Show("密码输入有误(最少6位)",title);
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

        private void btn_update_my_site_Click(object sender, EventArgs e)
        {

        }

        private void LoadBusLink()
        {
            string se_name = "";
            string wt_name = "";
            switch (cb_se.Text)
            {
                case "百度":
                    se_name = "baidu";
                    break;
                case "360":
                    se_name = "360";
                    break;
                default:
                    se_name = "baidu";
                    break;
            }
            switch (cb_wt_site.Text)
            {
                case "爱站":
                    wt_name = "aizhan";
                    break;
                case "站长":
                    wt_name = "chinaz";
                    break;
                default:
                    wt_name = "chinaz";
                    break;
            }

            string res = util.GET(server + String.Format("api.php?action=get_links&class={0}&num_type={1}&num={2}&wt_type={3}&wt={4}&price={5}&word={6}&online={7}&page={8}&swp_class={9}&out={10}", cb_class.Text.Replace("不限制", ""), se_name, txt_search_num.Text, wt_name, nud_wt.Value, nud_point.Value, txt_keyword.Text, cb_online.Checked, txt_page.Text,cb_swap_class.Text,nud_out.Value));
            var jarr = JArray.Parse(res);
            list_link.Items.Clear();
            bool zebra_style_flag = true;
            foreach (var j in jarr)  //查找某个字段与值
            {
                JObject item = ((JObject)j);
                //Console.WriteLine(((JObject)j)["id"]);
                ListViewItem lvi_id = new ListViewItem();
                lvi_id.UseItemStyleForSubItems = false;
                //Zebra Style
                Color item_color;
                if (zebra_style_flag)
                {
                    item_color = Color.WhiteSmoke;
                }
                else
                {
                    item_color = Color.White;
                }
                zebra_style_flag = !zebra_style_flag;

                
                //
                //
                ListViewSubItem lvi_class = new ListViewSubItem();
                ListViewSubItem lvi_name = new ListViewSubItem();
                ListViewSubItem lvi_loc = new ListViewSubItem();
                ListViewSubItem lvi_num_baidu = new ListViewSubItem();
                ListViewSubItem lvi_num_360 = new ListViewSubItem();
                ListViewSubItem lvi_wt_chinaz = new ListViewSubItem();
                ListViewSubItem lvi_pr_google = new ListViewSubItem();
                ListViewSubItem lvi_in = new ListViewSubItem();
                ListViewSubItem lvi_out = new ListViewSubItem();
                ListViewSubItem lvi_swap_count = new ListViewSubItem();
                ListViewSubItem lvi_update = new ListViewSubItem();
                ListViewSubItem lvi_state = new ListViewSubItem();
                ListViewSubItem lvi_price = new ListViewSubItem();

                lvi_class.BackColor = item_color;
                lvi_name.BackColor = item_color;
                lvi_loc.BackColor = item_color;
                lvi_num_baidu.BackColor = item_color;
                lvi_num_360.BackColor = item_color;
                lvi_wt_chinaz.BackColor = item_color;
                lvi_pr_google.BackColor = item_color;
                lvi_out.BackColor = item_color;
                lvi_swap_count.BackColor = item_color;
                lvi_update.BackColor = item_color;
                lvi_price.BackColor = item_color;

                lvi_id.SubItems.Add(lvi_class);
                lvi_id.SubItems.Add(lvi_name);
                lvi_id.SubItems.Add(lvi_loc);
                lvi_id.SubItems.Add(lvi_num_baidu);
                lvi_id.SubItems.Add(lvi_num_360);
                lvi_id.SubItems.Add(lvi_wt_chinaz);
                lvi_id.SubItems.Add(lvi_pr_google);
                //lvi_id.SubItems.Add(lvi_in);
                lvi_id.SubItems.Add(lvi_out);
                lvi_id.SubItems.Add(lvi_swap_count);
                lvi_id.SubItems.Add(lvi_update);
                //lvi_id.SubItems.Add(lvi_state);
                lvi_id.SubItems.Add(lvi_price);


                lvi_id.Text = (string)item["id"];
                lvi_class.Text = (string)item["class"];
                lvi_name.Text = (string)item["name"];
                lvi_loc.Text = (string)item["loc"];
                lvi_num_baidu.Text = (string)item["num_" + "baidu"];
                lvi_num_360.Text = (string)item["num_" + "360"];
                lvi_wt_chinaz.Text = (string)item["wt_" + "chinaz"];
                lvi_pr_google.Text = (string)item["pr_" + "google"];
                //lvi_in.Text = (string)item["num_in"];
                lvi_out.Text = (string)item["num_out"];
                lvi_swap_count.Text = (string)item["swap_count"];
                DateTime dt = DateTime.Parse((string)item["update_time"]);
                int update_days = (DateTime.Now - dt).Days;
                int update_hours = (DateTime.Now - dt).Hours;
                int update_min = (DateTime.Now - dt).Minutes;
                if (update_days > 0)
                {
                    lvi_update.Text = update_days.ToString() + "天前";
                }else if (update_hours > 0)
                {
                    lvi_update.Text = update_hours.ToString() + "小时前";
                }else
                {
                    lvi_update.Text = update_min.ToString() + "分钟前";
                }
                
                //lvi_state.Text = (string)item["state"];
                int price = int.Parse((string)item["price"]);
                if (price > 0)
                {
                    lvi_price.Text = price.ToString() + "积分/月";
                    lvi_price.ForeColor = Color.Red;
                    
                }
                else
                {
                    lvi_price.Text = "交换";
                    lvi_price.ForeColor = Color.Blue;
                    
                }
                //lvi_price.Font = new Font(lvi_price.Font, FontStyle.Underline);
                
                list_link.Items.Add(lvi_id);
            }


        }


        private void LoadMyLink()
        {
            string se_name = "";
            string wt_name = "";
            switch (cb_se.Text)
            {
                case "百度":
                    se_name = "baidu";
                    break;
                case "360":
                    se_name = "360";
                    break;
                default:
                    se_name = "baidu";
                    break;
            }
            switch (cb_wt_site.Text)
            {
                case "百度":
                    wt_name = "baidu";
                    break;
                case "Google":
                    wt_name = "google";
                    break;
                default:
                    wt_name = "baidu";
                    break;
            }

            string res = util.GET(server + String.Format("api.php?action=get_links&user_id={0}&class={1}&page={2}", user_id,cb_my_class.Text,txt_page_my.Text));
            var jarr = JArray.Parse(res);
            list_my_site.Items.Clear();
            foreach (var j in jarr)  //查找某个字段与值
            {
                JObject item = ((JObject)j);
                //Console.WriteLine(((JObject)j)["id"]);
                ListViewItem lvi_id = new ListViewItem();
                ListViewSubItem lvi_class = new ListViewSubItem();
                ListViewSubItem lvi_name = new ListViewSubItem();
                ListViewSubItem lvi_num = new ListViewSubItem();
                ListViewSubItem lvi_wt = new ListViewSubItem();
                ListViewSubItem lvi_in = new ListViewSubItem();
                ListViewSubItem lvi_out = new ListViewSubItem();
                ListViewSubItem lvi_update = new ListViewSubItem();
                ListViewSubItem lvi_state = new ListViewSubItem();
                ListViewSubItem lvi_price = new ListViewSubItem();
                lvi_id.SubItems.Add(lvi_class);
                lvi_id.SubItems.Add(lvi_name);
                lvi_id.SubItems.Add(lvi_num);
                lvi_id.SubItems.Add(lvi_wt);
                lvi_id.SubItems.Add(lvi_in);
                lvi_id.SubItems.Add(lvi_out);
                lvi_id.SubItems.Add(lvi_update);
                //lvi_id.SubItems.Add(lvi_state);
                lvi_id.SubItems.Add(lvi_price);


                lvi_id.Text = (string)item["id"];
                lvi_class.Text = (string)item["class"];
                lvi_name.Text = (string)item["name"];
                lvi_num.Text = (string)item["num_" + "baidu"];
                lvi_wt.Text = (string)item["wt_" + "chinaz"];
                lvi_in.Text = (string)item["num_in"];
                lvi_out.Text = (string)item["num_out"];
                lvi_update.Text = DateTime.Parse((string)item["update_time"]).ToShortDateString();
                lvi_state.Text = (string)item["state"];

                int price = int.Parse((string)item["price"]);
                if (price > 0)
                {
                    lvi_price.Text = price.ToString() + " 积分/月";
                }
                else
                {
                    lvi_price.Text = "";
                }


                list_my_site.Items.Add(lvi_id);
            }


        }


        private void LoadSwapList()
        {

            string res = util.GET(server + String.Format("api.php?action=get_swap_list&user_id={0}", user_id));
            var jarr = JArray.Parse(res);
            list_swap.Items.Clear();
            foreach (var j in jarr)  //查找某个字段与值
            {
                JObject item = ((JObject)j);
                //Console.WriteLine(((JObject)j)["id"]);
                ListViewItem lvi_id = new ListViewItem();
                ListViewSubItem lvi_domain_1 = new ListViewSubItem();
                ListViewSubItem lvi_domain_2 = new ListViewSubItem();
                ListViewSubItem lvi_valid = new ListViewSubItem();
                ListViewSubItem lvi_state = new ListViewSubItem();
                ListViewSubItem lvi_qq = new ListViewSubItem();

                lvi_id.SubItems.Add(lvi_domain_1);
                lvi_id.SubItems.Add(lvi_domain_2);
                lvi_id.SubItems.Add(lvi_valid);
                lvi_id.SubItems.Add(lvi_state);
                lvi_id.SubItems.Add(lvi_qq);


                lvi_domain_1.Text = (string)item["domain_1"];
                lvi_domain_2.Text = (string)item["domain_2"];
                lvi_valid.Text = (string)item["valid_time"];
                lvi_state.Text = (string)item["state"];
                lvi_qq.Text = (string)item["qq"];

                list_swap.Items.Add(lvi_id);
            }


        }


        private void LoadTrustList()
        {

            string res = util.GET(server + String.Format("api.php?action=get_trust_list&user_id={0}", user_id));
            var jarr = JArray.Parse(res);
            list_trust.Items.Clear();
            foreach (var j in jarr)  //查找某个字段与值
            {
                JObject item = ((JObject)j);
                //Console.WriteLine(((JObject)j)["id"]);
                ListViewItem lvi_id = new ListViewItem();
                ListViewSubItem lvi_name = new ListViewSubItem();
                ListViewSubItem lvi_num = new ListViewSubItem();
                ListViewSubItem lvi_valid = new ListViewSubItem();
                ListViewSubItem lvi_state = new ListViewSubItem();

                lvi_id.SubItems.Add(lvi_name);
                lvi_id.SubItems.Add(lvi_num);
                lvi_id.SubItems.Add(lvi_valid);
                lvi_id.SubItems.Add(lvi_state);
                lvi_id.Text = (string)item["id"];
                lvi_name.Text = (string)item["name"];
                lvi_num.Text = (string)item["num"];
                lvi_valid.Text = (string)item["valid_time"];
                lvi_state.Text = (string)item["state"];

                list_trust.Items.Add(lvi_id);
            }


        }

        public static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string site_id = list_link.SelectedItems[0].Text;
                new SwapForm(user_id, site_id).Show();
            }
            catch { }


        }

        private void cm_bus_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                string site_id = list_my_site.SelectedItems[0].Text;
                new SiteForm(user_id, site_id).Show();
            }
            catch { }

        }

        private void btn_page_up_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txt_page.Text);
            if (page - 1 > 0) txt_page.Text = (page - 1).ToString();
        }

        private void btn_page_down_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txt_page.Text);
            txt_page.Text = (page + 1).ToString();
        }

        private void txt_page_TextChanged(object sender, EventArgs e)
        {
            LoadBusLink();
        }


        private void btn_update_swp_Click(object sender, EventArgs e)
        {
            LoadSwapList();
        }

        private void tp_swap_list_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                string domain_1 = "http://" + list_swap.SelectedItems[0].SubItems[1].Text;
                string domain_2 = "http://" + list_swap.SelectedItems[0].SubItems[2].Text;
                bool link_up_1 = util.Exist(domain_1, domain_2);
                bool link_up_2 = util.Exist(domain_2, domain_1);

                if (link_up_1 && link_up_2)
                {
                    list_swap.SelectedItems[0].SubItems[4].Text = "正常";
                }

                if (!link_up_1 || !link_up_2)
                {
                    list_swap.SelectedItems[0].SubItems[4].Text = "等待上链";
                }

            }
            catch { }

        }

        private void tp_trust_Click(object sender, EventArgs e)
        {

        }

        private void btn_buy_trust_Click(object sender, EventArgs e)
        {
            if (nud_trust_month.Value <= 0) return;

            if (cb_site_name.Text == "")
            {
                MessageBox.Show("请选择网站",title);
                return;
            }
            string res = util.GET(String.Format(server + "api.php?action=buy_trust&link_id={0}&m={1}", ((ComboBoxItem)cb_site_name.SelectedItem).Value, nud_trust_month.Value));
            JObject jres = JObject.Parse(res);
            string msg = (string)jres["msg"];
            MessageBox.Show(msg,title);
            LoadTrustList();
        }

        private void btn_update_my_site_Click_1(object sender, EventArgs e)
        {
            LoadMyLink();
        }

        private void tc_main_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tc_main.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    LoadBusLink();
                    break;
                case 2:
                    LoadSwapList();
                    break;
                case 3:
                    LoadMyLink();
                    break;
                case 4:
                    LoadTrustList();
                    LoadTrustMySite();
                    break;
            }

        }

        //private void GotoAdLink(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    LinkLabel lb = (LinkLabel)sender;
        //    int index = int.Parse(lb.Tag.ToString());
        //    string url = link_list[index - 1].url;
        //    System.Diagnostics.Process.Start(url);
        //}

        //private void GetLinkAdList()
        //{
        //    lb_list.Add(lb_ad_1_1);
        //    lb_list.Add(lb_ad_1_2);
        //    lb_list.Add(lb_ad_2_3);
        //    lb_list.Add(lb_ad_2_1);
        //    lb_list.Add(lb_ad_2_2);
        //    lb_list.Add(lb_ad_2_3);
        //    lb_list.Add(lb_ad_3_1);
        //    lb_list.Add(lb_ad_3_2);
        //    lb_list.Add(lb_ad_3_3);
        //    lb_list.Add(lb_ad_4_1);
        //    lb_list.Add(lb_ad_4_2);
        //    lb_list.Add(lb_ad_4_3);

        //    try
        //    {
        //        string res = util.GET(String.Format(server + "config/ad.json"));
        //        var jarr = JArray.Parse(res);
        //        int index = 0;
        //        foreach (var j in jarr)  //查找某个字段与值
        //        {
        //            JObject item = ((JObject)j);
        //            link_list[index].title = (string)item["title"];
        //            link_list[index].url = (string)item["url"];
        //            link_list[index].bold = (bool)item["bold"];
        //            lb_list[index].Text = link_list[index].title;
        //            lb_list[index].Font = new Font(lb_list[index].Font, FontStyle.Bold);
        //            switch ((string)item["color"])
        //            {
        //                case "red":
        //                    link_list[index].color = Color.Red;
        //                    break;
        //                case "blue":
        //                    link_list[index].color = Color.Blue;
        //                    break;
        //                default:
        //                    link_list[index].color = Color.Blue;
        //                    break;
        //            }
        //            lb_list[index].ForeColor = link_list[index].color;
        //            index++;
        //        }
        //    }
        //    catch { }

        //}
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lb_vip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tc_main.SelectedIndex = 5;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //new Thread(UpdateUser).Start();
            //new Thread(GetLinkAdList).Start();
            new Thread(GetMoneyConfig).Start();
            UpdateUser();

        }

        private void btn_trans_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_trans.Text) <= 0) return;
            string res = util.GET(String.Format(server + "api.php?action=new_trans&user={0}&token={1}&sum={2}&alipay={3}", username, token, txt_trans.Text, txt_alipay.Text));
            JObject jres = JObject.Parse(res);
            string msg = (string)jres["msg"];
            MessageBox.Show(msg,title);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("是否确认退出？", title, MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
            
            //Program.loginForm.Show();
            //online.Enabled = false;
            //this.Close();
        }

        private void cm_my_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cm_swp_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_update_state_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_swap.Items)
            {
                lvi.SubItems[4].Text = "查询中";
            }

            new Thread(delegate ()
            {
                try
                {
                    foreach (ListViewItem lvi in list_swap.Items)
                    {
                        string domain_1 = "http://" + lvi.SubItems[1].Text;
                        string domain_2 = "http://" + lvi.SubItems[2].Text;
                        bool link_up_1 = util.Exist(domain_1, domain_2);
                        bool link_up_2 = util.Exist(domain_2, domain_1);

                        if (link_up_1 && link_up_2)
                        {
                            lvi.SubItems[4].Text = "正常";
                        }

                        if (!link_up_1 || !link_up_2)
                        {
                            lvi.SubItems[4].Text = "等待上链";
                        }
                    }
                }
                catch { }
            }).Start();

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                string res = util.GET(String.Format(server + "api.php?action=del_link&id={0}", list_my_site.SelectedItems[0].Text));
                LoadMyLink();
            }
            catch { }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 更新列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMyLink();
        }

        private void 添加网站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SiteForm(user_id).Show();
        }

        private void cb_my_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMyLink();
        }

        private void btn_page_up_my_Click(object sender, EventArgs e)
        {
            if (int.Parse("0" + txt_page_my.Text) <= 1)return;

            txt_page_my.Text = (int.Parse("0" + txt_page_my.Text) - 1).ToString();
        }

        private void btn_page_down_my_Click(object sender, EventArgs e)
        {
            txt_page_my.Text = (int.Parse("0" + txt_page_my.Text) +1).ToString();
        }

        private void txt_page_my_TextChanged(object sender, EventArgs e)
        {
            LoadMyLink();
        }

        private void btn_buy_vip_Click(object sender, EventArgs e)
        {
            string res = util.GET(String.Format(server + "api.php?action=buy_vip&user={0}&type=vip", username));
            JObject jres = JObject.Parse(res);
            string msg = (string)jres["msg"];
            MessageBox.Show(msg,title);
            UpdateUser();
        }

        private void btn_buy_super_vip_Click(object sender, EventArgs e)
        {
            string res = util.GET(String.Format(server + "api.php?action=buy_vip&user={0}&type=super_vip", username));
            JObject jres = JObject.Parse(res);
            string msg = (string)jres["msg"];
            MessageBox.Show(msg,title);
            UpdateUser();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            string id = list_trust.SelectedItems[0].Text;
            string res = util.GET(String.Format(server + "api.php?action=set_trust&id={0}&state=托管中", id));
            LoadTrustList();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string id = list_trust.SelectedItems[0].Text;
            string res = util.GET(String.Format(server + "api.php?action=set_trust&id={0}&state=未托管", id));
            LoadTrustList();
        }

        private void list_link_Click(object sender, EventArgs e)
        {
            
        }

        private void list_link_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string site_id = list_link.SelectedItems[0].Text;
                new SwapForm(user_id, site_id).Show();
            }
            catch { }
        }
    }
}
