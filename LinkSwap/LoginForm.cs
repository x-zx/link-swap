using Newtonsoft.Json;
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
    public partial class LoginForm : Form
    {
        Util util = new Util();
        string server = Properties.Settings.Default.server;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lb_ver.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
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
                        new MainForm(token).Show();
                        if (cb_save_pw.Checked)
                        {
                            Properties.Settings.Default.username = txt_user.Text;
                            Properties.Settings.Default.password = txt_pw.Text;
                            Properties.Settings.Default.Save();
                        }else
                        {
                            Properties.Settings.Default.username = "";
                            Properties.Settings.Default.password = "";
                            Properties.Settings.Default.Save();
                        }
                        

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(msg);
                    }
                }
                catch(Exception ex)
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
            new RegForm(txt_user.Text,txt_pw.Text).Show();
        }

        private bool CheckInput()
        {
            return (txt_user.TextLength > 0 && txt_pw.TextLength > 0);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
