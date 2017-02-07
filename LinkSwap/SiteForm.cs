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
    public partial class SiteForm : Form
    {
        string user_id;
        string site_id;
        Util util = new Util();
        string server = Properties.Settings.Default.server;

        public SiteForm(string user_id,string site_id=null)
        {
            this.site_id = site_id;
            this.user_id = user_id;

            
            InitializeComponent();
        }

        private void SiteForm_Load(object sender, EventArgs e)
        {
            if (site_id != null)
            {
                LoadSite();
            }
            
        }

        private void LoadSite()
        {
            string data = String.Format("id={0}",site_id);
            string res = util.GET(server + "api.php?action=get_link&" + data);
            JObject jres = JObject.Parse(res);
            //foreach(var item in jres)
            //{

            //}
            //ListViewItem lvi = new ListViewItem();
            txt_name.Text = (string)jres["name"];
            txt_domain.Text = (string)jres["domain"];
            cb_site_class.Text = (string)jres["class"];
            cb_link_loc.Text = (string)jres["loc"];
            cb_target_site_class.Text = (string)jres["swp_class"];
            cb_wt_type.Text = (string)jres["swp_wt_type"];
            nud_wt.Value = (int)jres["swp_wt"];
            cb_target_link_loc.Text = (string)jres["swp_loc"];
            cb_se.Text = (string)jres["swp_num_type"];
            txt_search_num.Text = (string)jres["swp_num"];
            nud_wt.Value = (int)jres["swp_wt"];
            int price = (int)jres["price"];
            if (price > 0) cb_link_business.Checked = true;
            nud_point.Value = price;
        }

        private void cb_link_business_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_link_business.Checked)
            {
                if(nud_point.Value==0) nud_point.Value = 10;
                swap_group.Enabled = false;
                //

            }
            else
            {
                swap_group.Enabled = true;
                nud_point.Value = 0;
            }
        }

        private void txt_domain_Leave(object sender, EventArgs e)
        {
            txt_domain.Text = txt_domain.Text.Replace("http://", "");
            txt_domain.Text = txt_domain.Text.Replace("/", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_site_Click(object sender, EventArgs e)
        {

            if (txt_name.TextLength == 0 || txt_domain.TextLength == 0||cb_site_class.Text==""||cb_link_loc.Text=="")
            {
                return;
            }
            btn_update_site.Text = "提交中...";
            btn_update_site.Enabled = false;

            new Thread(delegate () {
                SEO seo = new SEO(txt_domain.Text);
                string seo_data = String.Format("&num_baidu={0}&num_360={1}&wt_aizhan={2}&wt_chinaz={3}&num_in={4}&num_out={5}&pr_google={6}", seo.GetNum("baidu"), seo.GetNum("360"), seo.GetWeight("aizhan"), seo.GetWeight("chinaz"), seo.GetNum("in"), seo.GetNum("out"), seo.GetPR());
                //
                string data = "";
                string id = "";
                if (site_id != null)
                {
                    id = "id=" + site_id.ToString() + "&";
                }
                if (cb_link_business.Checked)
                {
                    data = String.Format(id + "user_id={0}&name={1}&domain={2}&class={3}&loc={4}&price={5}" + seo_data, user_id, txt_name.Text, txt_domain.Text, cb_site_class.Text, cb_link_loc.Text, nud_point.Value);
                }
                else
                {
                    data = String.Format(id + "user_id={0}&name={1}&domain={2}&class={3}&loc={4}&price={5}&swp_class={6}&swp_wt_type={7}&swp_wt={8}&swp_loc={9}&swp_num_type={10}&swp_num={11}" + seo_data, user_id, txt_name.Text, txt_domain.Text, cb_site_class.Text, cb_link_loc.Text, nud_point.Value, cb_target_site_class.Text, cb_wt_type.Text=="爱站"?"aizhan":"chinaz", nud_wt.Value, cb_target_link_loc.Text, cb_se.Text=="360"?"360":"baidu", txt_search_num.Text);
                }
                string res = util.GET(server + "api.php?action=update_link&" + data);
                JObject jres = JObject.Parse(res);
                bool state = (bool)jres["success"];
                string msg = (string)jres["msg"];
                MessageBox.Show(msg);
                this.Close();
            }).Start();
            
        }

        private void nud_point_ValueChanged(object sender, EventArgs e)
        {
            if (nud_point.Value <= 0)
            {
                cb_link_business.Checked = false;
            }
            else
            {
                cb_link_business.Checked = true;
            }
        }

        private void SiteForm_Shown(object sender, EventArgs e)
        {
            if (site_id != null)
            {
                txt_domain.Enabled = false;
            }
        }
    }
}
