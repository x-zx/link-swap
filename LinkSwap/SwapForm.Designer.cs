namespace LinkSwap
{
    partial class SwapForm
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
            this.lb_update = new System.Windows.Forms.Label();
            this.lb_loc = new System.Windows.Forms.Label();
            this.lb_wt_google = new System.Windows.Forms.Label();
            this.lb_wt_baidu = new System.Windows.Forms.Label();
            this.lb_num_360 = new System.Windows.Forms.Label();
            this.lb_num_baidu = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.swap = new System.Windows.Forms.GroupBox();
            this.lb_swp_num = new System.Windows.Forms.Label();
            this.lb_swp_loc = new System.Windows.Forms.Label();
            this.lb_swp_class = new System.Windows.Forms.Label();
            this.lb_swp_wt = new System.Windows.Forms.Label();
            this.btn_update_site = new System.Windows.Forms.Button();
            this.cb_my_site = new System.Windows.Forms.ComboBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.swap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_update);
            this.groupBox1.Controls.Add(this.lb_loc);
            this.groupBox1.Controls.Add(this.lb_wt_google);
            this.groupBox1.Controls.Add(this.lb_wt_baidu);
            this.groupBox1.Controls.Add(this.lb_num_360);
            this.groupBox1.Controls.Add(this.lb_num_baidu);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网站信息";
            // 
            // lb_update
            // 
            this.lb_update.AutoSize = true;
            this.lb_update.Location = new System.Drawing.Point(165, 115);
            this.lb_update.Name = "lb_update";
            this.lb_update.Size = new System.Drawing.Size(53, 12);
            this.lb_update.TabIndex = 8;
            this.lb_update.Text = "更新时间";
            // 
            // lb_loc
            // 
            this.lb_loc.AutoSize = true;
            this.lb_loc.Location = new System.Drawing.Point(23, 115);
            this.lb_loc.Name = "lb_loc";
            this.lb_loc.Size = new System.Drawing.Size(53, 12);
            this.lb_loc.TabIndex = 7;
            this.lb_loc.Text = "友链位置";
            // 
            // lb_wt_google
            // 
            this.lb_wt_google.AutoSize = true;
            this.lb_wt_google.Location = new System.Drawing.Point(165, 85);
            this.lb_wt_google.Name = "lb_wt_google";
            this.lb_wt_google.Size = new System.Drawing.Size(53, 12);
            this.lb_wt_google.TabIndex = 4;
            this.lb_wt_google.Text = "谷歌权重";
            // 
            // lb_wt_baidu
            // 
            this.lb_wt_baidu.AutoSize = true;
            this.lb_wt_baidu.Location = new System.Drawing.Point(23, 85);
            this.lb_wt_baidu.Name = "lb_wt_baidu";
            this.lb_wt_baidu.Size = new System.Drawing.Size(53, 12);
            this.lb_wt_baidu.TabIndex = 3;
            this.lb_wt_baidu.Text = "百度权重";
            // 
            // lb_num_360
            // 
            this.lb_num_360.AutoSize = true;
            this.lb_num_360.Location = new System.Drawing.Point(165, 56);
            this.lb_num_360.Name = "lb_num_360";
            this.lb_num_360.Size = new System.Drawing.Size(47, 12);
            this.lb_num_360.TabIndex = 2;
            this.lb_num_360.Text = "360收录";
            // 
            // lb_num_baidu
            // 
            this.lb_num_baidu.AutoSize = true;
            this.lb_num_baidu.Location = new System.Drawing.Point(23, 56);
            this.lb_num_baidu.Name = "lb_num_baidu";
            this.lb_num_baidu.Size = new System.Drawing.Size(53, 12);
            this.lb_num_baidu.TabIndex = 1;
            this.lb_num_baidu.Text = "百度收录";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_name.Location = new System.Drawing.Point(23, 28);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(57, 12);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "网站名称";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // swap
            // 
            this.swap.Controls.Add(this.lb_swp_num);
            this.swap.Controls.Add(this.lb_swp_loc);
            this.swap.Controls.Add(this.lb_swp_class);
            this.swap.Controls.Add(this.lb_swp_wt);
            this.swap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.swap.Location = new System.Drawing.Point(15, 170);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(366, 153);
            this.swap.TabIndex = 1;
            this.swap.TabStop = false;
            this.swap.Text = "换链要求";
            // 
            // lb_swp_num
            // 
            this.lb_swp_num.AutoSize = true;
            this.lb_swp_num.Location = new System.Drawing.Point(23, 62);
            this.lb_swp_num.Name = "lb_swp_num";
            this.lb_swp_num.Size = new System.Drawing.Size(53, 12);
            this.lb_swp_num.TabIndex = 7;
            this.lb_swp_num.Text = "收录类型";
            // 
            // lb_swp_loc
            // 
            this.lb_swp_loc.AutoSize = true;
            this.lb_swp_loc.Location = new System.Drawing.Point(23, 121);
            this.lb_swp_loc.Name = "lb_swp_loc";
            this.lb_swp_loc.Size = new System.Drawing.Size(53, 12);
            this.lb_swp_loc.TabIndex = 5;
            this.lb_swp_loc.Text = "友链位置";
            // 
            // lb_swp_class
            // 
            this.lb_swp_class.AutoSize = true;
            this.lb_swp_class.Location = new System.Drawing.Point(23, 91);
            this.lb_swp_class.Name = "lb_swp_class";
            this.lb_swp_class.Size = new System.Drawing.Size(53, 12);
            this.lb_swp_class.TabIndex = 3;
            this.lb_swp_class.Text = "行业要求";
            // 
            // lb_swp_wt
            // 
            this.lb_swp_wt.AutoSize = true;
            this.lb_swp_wt.Location = new System.Drawing.Point(23, 34);
            this.lb_swp_wt.Name = "lb_swp_wt";
            this.lb_swp_wt.Size = new System.Drawing.Size(53, 12);
            this.lb_swp_wt.TabIndex = 0;
            this.lb_swp_wt.Text = "权重类型";
            // 
            // btn_update_site
            // 
            this.btn_update_site.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_update_site.FlatAppearance.BorderSize = 0;
            this.btn_update_site.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_site.ForeColor = System.Drawing.Color.White;
            this.btn_update_site.Location = new System.Drawing.Point(276, 359);
            this.btn_update_site.Name = "btn_update_site";
            this.btn_update_site.Size = new System.Drawing.Size(105, 34);
            this.btn_update_site.TabIndex = 6;
            this.btn_update_site.Text = "提交";
            this.btn_update_site.UseVisualStyleBackColor = false;
            this.btn_update_site.Click += new System.EventHandler(this.btn_update_site_Click);
            // 
            // cb_my_site
            // 
            this.cb_my_site.DisplayMember = "name";
            this.cb_my_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_my_site.FormattingEnabled = true;
            this.cb_my_site.Location = new System.Drawing.Point(27, 367);
            this.cb_my_site.Name = "cb_my_site";
            this.cb_my_site.Size = new System.Drawing.Size(222, 20);
            this.cb_my_site.TabIndex = 7;
            this.cb_my_site.ValueMember = "id";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_price.ForeColor = System.Drawing.Color.Red;
            this.lb_price.Location = new System.Drawing.Point(302, 326);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(79, 21);
            this.lb_price.TabIndex = 8;
            this.lb_price.Text = "0 积分/月";
            // 
            // SwapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(393, 408);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.cb_my_site);
            this.Controls.Add(this.btn_update_site);
            this.Controls.Add(this.swap);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SwapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换链信息";
            this.Load += new System.EventHandler(this.SwapForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.swap.ResumeLayout(false);
            this.swap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_wt_google;
        private System.Windows.Forms.Label lb_wt_baidu;
        private System.Windows.Forms.Label lb_num_360;
        private System.Windows.Forms.Label lb_num_baidu;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.GroupBox swap;
        private System.Windows.Forms.Label lb_swp_num;
        private System.Windows.Forms.Label lb_swp_loc;
        private System.Windows.Forms.Label lb_swp_class;
        private System.Windows.Forms.Label lb_swp_wt;
        private System.Windows.Forms.Label lb_loc;
        private System.Windows.Forms.Button btn_update_site;
        private System.Windows.Forms.ComboBox cb_my_site;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_update;
    }
}