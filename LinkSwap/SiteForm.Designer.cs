namespace LinkSwap
{
    partial class SiteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_link_loc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_site_class = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_domain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.swap_group = new System.Windows.Forms.GroupBox();
            this.cb_se = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_search_num = new System.Windows.Forms.TextBox();
            this.cb_target_link_loc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_wt_type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_wt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_target_site_class = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_link_business = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_point = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_update_site = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.swap_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wt)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_point)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cb_link_loc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cb_site_class);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_domain);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网站信息";
            // 
            // cb_link_loc
            // 
            this.cb_link_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_link_loc.FormattingEnabled = true;
            this.cb_link_loc.Items.AddRange(new object[] {
            "首页",
            "二级域名",
            "栏目"});
            this.cb_link_loc.Location = new System.Drawing.Point(74, 125);
            this.cb_link_loc.Name = "cb_link_loc";
            this.cb_link_loc.Size = new System.Drawing.Size(70, 20);
            this.cb_link_loc.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "友链位置";
            // 
            // cb_site_class
            // 
            this.cb_site_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_site_class.FormattingEnabled = true;
            this.cb_site_class.Items.AddRange(new object[] {
            "新闻媒体",
            "论坛博客",
            "机构组织",
            "服饰服装",
            "食品美食",
            "家产家居",
            "工艺礼品",
            "教育培训",
            "医药卫生",
            "农林牧渔",
            "电子商务",
            "生活服务",
            "休闲娱乐",
            "it互联网",
            "地方门户",
            "游戏动漫",
            "音乐视频",
            "娱乐时尚",
            "古玩收藏",
            "军事国防",
            "求职招聘",
            "影楼婚嫁",
            "机械五金",
            "汽车配件",
            "水暖安防",
            "建筑材料",
            "家电数码",
            "食品包装",
            "组织皮革",
            "化石能源",
            "物流运输",
            "商务服务",
            "小说文学",
            "酒店旅游",
            "体育运动",
            "美容护肤",
            "健康养生",
            "法律律师",
            "其他行业"});
            this.cb_site_class.Location = new System.Drawing.Point(74, 93);
            this.cb_site_class.Name = "cb_site_class";
            this.cb_site_class.Size = new System.Drawing.Size(121, 20);
            this.cb_site_class.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "网站分类";
            // 
            // txt_domain
            // 
            this.txt_domain.Location = new System.Drawing.Point(74, 58);
            this.txt_domain.Name = "txt_domain";
            this.txt_domain.Size = new System.Drawing.Size(229, 21);
            this.txt_domain.TabIndex = 3;
            this.txt_domain.Leave += new System.EventHandler(this.txt_domain_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "网站域名";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(74, 27);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(229, 21);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网站名称";
            // 
            // swap_group
            // 
            this.swap_group.Controls.Add(this.cb_se);
            this.swap_group.Controls.Add(this.label12);
            this.swap_group.Controls.Add(this.txt_search_num);
            this.swap_group.Controls.Add(this.cb_target_link_loc);
            this.swap_group.Controls.Add(this.label11);
            this.swap_group.Controls.Add(this.cb_wt_type);
            this.swap_group.Controls.Add(this.label9);
            this.swap_group.Controls.Add(this.nud_wt);
            this.swap_group.Controls.Add(this.label5);
            this.swap_group.Controls.Add(this.cb_target_site_class);
            this.swap_group.Controls.Add(this.label6);
            this.swap_group.Controls.Add(this.label4);
            this.swap_group.Location = new System.Drawing.Point(12, 186);
            this.swap_group.Name = "swap_group";
            this.swap_group.Size = new System.Drawing.Size(314, 160);
            this.swap_group.TabIndex = 1;
            this.swap_group.TabStop = false;
            this.swap_group.Text = "友链交换";
            // 
            // cb_se
            // 
            this.cb_se.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_se.FormattingEnabled = true;
            this.cb_se.Items.AddRange(new object[] {
            "百度",
            "360"});
            this.cb_se.Location = new System.Drawing.Point(74, 131);
            this.cb_se.Name = "cb_se";
            this.cb_se.Size = new System.Drawing.Size(70, 20);
            this.cb_se.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "以上";
            // 
            // txt_search_num
            // 
            this.txt_search_num.Location = new System.Drawing.Point(154, 131);
            this.txt_search_num.Name = "txt_search_num";
            this.txt_search_num.Size = new System.Drawing.Size(52, 21);
            this.txt_search_num.TabIndex = 20;
            this.txt_search_num.Text = "0";
            this.txt_search_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_target_link_loc
            // 
            this.cb_target_link_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_target_link_loc.FormattingEnabled = true;
            this.cb_target_link_loc.Items.AddRange(new object[] {
            "不限制",
            "首页",
            "二级域名",
            "栏目"});
            this.cb_target_link_loc.Location = new System.Drawing.Point(74, 97);
            this.cb_target_link_loc.Name = "cb_target_link_loc";
            this.cb_target_link_loc.Size = new System.Drawing.Size(70, 20);
            this.cb_target_link_loc.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "友链位置";
            // 
            // cb_wt_type
            // 
            this.cb_wt_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_wt_type.FormattingEnabled = true;
            this.cb_wt_type.Items.AddRange(new object[] {
            "爱站",
            "站长"});
            this.cb_wt_type.Location = new System.Drawing.Point(74, 64);
            this.cb_wt_type.Name = "cb_wt_type";
            this.cb_wt_type.Size = new System.Drawing.Size(74, 20);
            this.cb_wt_type.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "以上";
            // 
            // nud_wt
            // 
            this.nud_wt.Location = new System.Drawing.Point(154, 64);
            this.nud_wt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_wt.Name = "nud_wt";
            this.nud_wt.Size = new System.Drawing.Size(41, 21);
            this.nud_wt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "网站权重";
            // 
            // cb_target_site_class
            // 
            this.cb_target_site_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_target_site_class.FormattingEnabled = true;
            this.cb_target_site_class.Items.AddRange(new object[] {
            "不限制",
            "新闻媒体",
            "论坛博客",
            "机构组织",
            "服饰服装",
            "食品美食",
            "家产家居",
            "工艺礼品",
            "教育培训",
            "医药卫生",
            "农林牧渔",
            "电子商务",
            "生活服务",
            "休闲娱乐",
            "it互联网",
            "地方门户",
            "游戏动漫",
            "音乐视频",
            "娱乐时尚",
            "古玩收藏",
            "军事国防",
            "求职招聘",
            "影楼婚嫁",
            "机械五金",
            "汽车配件",
            "水暖安防",
            "建筑材料",
            "家电数码",
            "食品包装",
            "组织皮革",
            "化石能源",
            "物流运输",
            "商务服务",
            "小说文学",
            "酒店旅游",
            "体育运动",
            "美容护肤",
            "健康养生",
            "法律律师",
            "其他行业"});
            this.cb_target_site_class.Location = new System.Drawing.Point(74, 32);
            this.cb_target_site_class.Name = "cb_target_site_class";
            this.cb_target_site_class.Size = new System.Drawing.Size(121, 20);
            this.cb_target_site_class.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "网站分类";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "搜索收录";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_link_business);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nud_point);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cb_link_business
            // 
            this.cb_link_business.AutoSize = true;
            this.cb_link_business.Location = new System.Drawing.Point(17, 0);
            this.cb_link_business.Name = "cb_link_business";
            this.cb_link_business.Size = new System.Drawing.Size(72, 16);
            this.cb_link_business.TabIndex = 18;
            this.cb_link_business.Text = "友链交易";
            this.cb_link_business.UseVisualStyleBackColor = true;
            this.cb_link_business.CheckedChanged += new System.EventHandler(this.cb_link_business_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "/月";
            // 
            // nud_point
            // 
            this.nud_point.Location = new System.Drawing.Point(74, 36);
            this.nud_point.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_point.Name = "nud_point";
            this.nud_point.Size = new System.Drawing.Size(41, 21);
            this.nud_point.TabIndex = 13;
            this.nud_point.ValueChanged += new System.EventHandler(this.nud_point_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "所需积分";
            // 
            // btn_update_site
            // 
            this.btn_update_site.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_update_site.FlatAppearance.BorderSize = 0;
            this.btn_update_site.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_site.ForeColor = System.Drawing.Color.White;
            this.btn_update_site.Location = new System.Drawing.Point(251, 429);
            this.btn_update_site.Name = "btn_update_site";
            this.btn_update_site.Size = new System.Drawing.Size(75, 23);
            this.btn_update_site.TabIndex = 5;
            this.btn_update_site.Text = "更新网站";
            this.btn_update_site.UseVisualStyleBackColor = false;
            this.btn_update_site.Click += new System.EventHandler(this.btn_update_site_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(196, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "(不需要加http://)";
            // 
            // SiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 464);
            this.Controls.Add(this.btn_update_site);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.swap_group);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SiteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网站信息";
            this.Load += new System.EventHandler(this.SiteForm_Load);
            this.Shown += new System.EventHandler(this.SiteForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.swap_group.ResumeLayout(false);
            this.swap_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_point)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_site_class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_domain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox swap_group;
        private System.Windows.Forms.ComboBox cb_wt_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_wt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_target_site_class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_point;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_link_business;
        private System.Windows.Forms.Button btn_update_site;
        private System.Windows.Forms.ComboBox cb_link_loc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_search_num;
        private System.Windows.Forms.ComboBox cb_target_link_loc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_se;
        private System.Windows.Forms.Label label13;
    }
}