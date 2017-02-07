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
    public partial class SwapForm : Form
    {

        string site_id;
        string user_id;
        string swp_user_id;
        string url;
        int price = 0;
        Util util = new Util();
        string server = Properties.Settings.Default.server;
        public SwapForm(string user_id,string site_id)
        {
            this.site_id = site_id;
            this.user_id = user_id;
            InitializeComponent();
        }

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


        private void LoadSite()
        {
            string data = String.Format("id={0}",site_id);
            string res = util.GET(server + "api.php?action=get_link&" + data);
            JObject jres = JObject.Parse(res);
            swp_user_id = (string)jres["user_id"];
            url = "http://" + (string)jres["domain"];
            lb_name.Text = "网站名称：" + (string)jres["name"] + " (" + (string)jres["domain"] + ")";
            lb_num_baidu.Text = "百度收录：" + (string)jres["num_baidu"];
            lb_num_360.Text = "360收录：" + (string)jres["num_360"];
            lb_wt_baidu.Text = "站长权重：" + (string)jres["wt_chinaz"];
            lb_wt_google.Text = "谷歌PR："+(string)jres["pr_google"];
            lb_loc.Text = "友链位置：" + (string)jres["loc"];
            lb_update.Text = "更新时间：" + (string)jres["update_time"];
            string wt_type = "百度权重";
            string num_type = "百度收录";
            switch ((string)jres["swp_wt_type"])
            {
                case "aizhan":wt_type = "爱站权重";break;
                case "Google":wt_type = "站长权重";break;
            }
            switch ((string)jres["swp_num_type"])
            {
                case "baidu": num_type = "百度收录"; break;
                case "360": num_type = "360收录"; break;
            }
            lb_swp_wt.Text = wt_type + "：" + (string)jres["swp_wt"];
            lb_swp_num.Text = num_type + "：" + (string)jres["swp_num"];
            lb_swp_class.Text = "行业要求："+ (string)jres["swp_class"];
            lb_swp_loc.Text = "友链位置：" + (string)jres["swp_loc"];

            price = int.Parse((string)jres["price"]);
            if (price > 0)
            {
                lb_price.Text = price.ToString() + " 积分/月";
                lb_price.Show();
                swap.Enabled = false;
            }else
            {
                lb_price.Hide();
            }

            //

            res = util.GET(server + String.Format("api.php?action=get_links&user_id={0}", user_id));
            var jarr = JArray.Parse(res);

            foreach (var j in jarr)  //查找某个字段与值
            {
                JObject item = ((JObject)j);
                cb_my_site.Items.Add(new ComboBoxItem { Value = (string)item["id"], Text = (string)item["name"] });
            }
        }

        private void AddSwap()
        {
            if(swp_user_id == user_id)
            {
                MessageBox.Show("不能和自己交换链接");
                return;
                this.Close();
            }
            string data = String.Format("user_id_1={0}&user_id_2={1}&link_id_1={2}&link_id_2={3}&price={4}", swp_user_id, user_id, site_id, ((ComboBoxItem)cb_my_site.SelectedItem).Value,price);
            string res = util.GET(server + "api.php?action=add_swap&" + data);
            JObject jres = JObject.Parse(res);
            MessageBox.Show((string)jres["msg"]);
        }

        private void SwapForm_Load(object sender, EventArgs e)
        {
            LoadSite();
           

        }

        private void lb_name_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void btn_update_site_Click(object sender, EventArgs e)
        {
            if (cb_my_site.Text != "")
            {
                AddSwap();
                this.Close();
            }else
            {
                MessageBox.Show("请选择网站");
            }
            
        }
    }
}
