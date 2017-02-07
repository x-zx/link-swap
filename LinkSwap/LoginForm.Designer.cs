namespace LinkSwap
{
    partial class LoginForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lb_ver = new System.Windows.Forms.Label();
            this.lb_forget_pw = new System.Windows.Forms.LinkLabel();
            this.cb_save_pw = new System.Windows.Forms.CheckBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_copyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.lb_copyright);
            this.splitContainer1.Panel1.Controls.Add(this.lb_ver);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.lb_forget_pw);
            this.splitContainer1.Panel2.Controls.Add(this.cb_save_pw);
            this.splitContainer1.Panel2.Controls.Add(this.btn_reg);
            this.splitContainer1.Panel2.Controls.Add(this.btn_login);
            this.splitContainer1.Panel2.Controls.Add(this.txt_pw);
            this.splitContainer1.Panel2.Controls.Add(this.txt_user);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(384, 246);
            this.splitContainer1.SplitterDistance = 81;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // lb_ver
            // 
            this.lb_ver.AutoSize = true;
            this.lb_ver.BackColor = System.Drawing.Color.Transparent;
            this.lb_ver.ForeColor = System.Drawing.Color.Gray;
            this.lb_ver.Location = new System.Drawing.Point(12, 66);
            this.lb_ver.Name = "lb_ver";
            this.lb_ver.Size = new System.Drawing.Size(47, 12);
            this.lb_ver.TabIndex = 10;
            this.lb_ver.Text = "0.0.0.0";
            this.lb_ver.Visible = false;
            // 
            // lb_forget_pw
            // 
            this.lb_forget_pw.ActiveLinkColor = System.Drawing.Color.Red;
            this.lb_forget_pw.AutoSize = true;
            this.lb_forget_pw.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_forget_pw.Location = new System.Drawing.Point(176, 96);
            this.lb_forget_pw.Name = "lb_forget_pw";
            this.lb_forget_pw.Size = new System.Drawing.Size(53, 12);
            this.lb_forget_pw.TabIndex = 9;
            this.lb_forget_pw.TabStop = true;
            this.lb_forget_pw.Text = "忘记密码";
            this.lb_forget_pw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_forget_pw_LinkClicked);
            // 
            // cb_save_pw
            // 
            this.cb_save_pw.AutoSize = true;
            this.cb_save_pw.Checked = true;
            this.cb_save_pw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_save_pw.Location = new System.Drawing.Point(244, 95);
            this.cb_save_pw.Name = "cb_save_pw";
            this.cb_save_pw.Size = new System.Drawing.Size(72, 16);
            this.cb_save_pw.TabIndex = 8;
            this.cb_save_pw.Text = "记住密码";
            this.cb_save_pw.UseVisualStyleBackColor = true;
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_reg.FlatAppearance.BorderSize = 0;
            this.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg.ForeColor = System.Drawing.Color.White;
            this.btn_reg.Location = new System.Drawing.Point(141, 129);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(75, 23);
            this.btn_reg.TabIndex = 7;
            this.btn_reg.Text = "注册";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(241, 129);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "登陆";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(128, 68);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(188, 21);
            this.txt_pw.TabIndex = 2;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(128, 21);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(188, 21);
            this.txt_user.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // lb_copyright
            // 
            this.lb_copyright.AutoSize = true;
            this.lb_copyright.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_copyright.Location = new System.Drawing.Point(192, 66);
            this.lb_copyright.Name = "lb_copyright";
            this.lb_copyright.Size = new System.Drawing.Size(107, 12);
            this.lb_copyright.TabIndex = 10;
            this.lb_copyright.Text = "软件著作权 123456";
            this.lb_copyright.Click += new System.EventHandler(this.lb_copyright_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 246);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换链宝";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.CheckBox cb_save_pw;
        private System.Windows.Forms.Label lb_ver;
        private System.Windows.Forms.LinkLabel lb_forget_pw;
        private System.Windows.Forms.Label lb_copyright;
    }
}