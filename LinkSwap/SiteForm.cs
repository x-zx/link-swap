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
    public partial class SiteForm : Form
    {
        string token;
        string site_id;
        Util util = new Util();
        string server = Properties.Settings.Default.server;

        public SiteForm(string token,string site_id=null)
        {
            if (site_id == null)
            {
                txt_domain.Enabled = false;

            }
            InitializeComponent();
        }

        private void SiteForm_Load(object sender, EventArgs e)
        {

        }

        private void cb_link_business_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_link_business.Checked)
            {
                if(nud_point.Value==0) nud_point.Value = 10;
                swap_group.Enabled = false;

            }else
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
            
            if (cb_link_business.Checked)
            {
                string data = String.Format("name={0}&domain={1}&class={2}&loc={3}&price={4}", txt_name.Text, txt_domain.Text, cb_link_loc.Text, nud_point.Value);
            }else
            {
                string data = String.Format("name={0}&domain={1}&class={2}&loc={3}&price={4}", txt_name.Text, txt_domain.Text, cb_link_loc.Text, nud_point.Value);
            }
            //string res = util.GET(String.Format(server + "api.php?action=update_link&name={0}&domain={1}&class={2}&loc={3}", txt_user.Text, txt_pw.Text, txt_email.Text, txt_phone.Text, txt_qq.Text, txt_alipay.Text));
            //JObject jres = JObject.Parse(res);
            //bool state = (bool)jres["success"];
            //string msg = (string)jres["msg"];
            //MessageBox.Show(msg);
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
    }
}
