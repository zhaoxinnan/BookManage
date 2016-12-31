namespace BookManage
{
    partial class frmLogin
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
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboUserType
            // 
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.cboUserType.Location = new System.Drawing.Point(161, 141);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(121, 21);
            this.cboUserType.TabIndex = 0;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(161, 29);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 20);
            this.txName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(161, 88);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(64, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(178, 194);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "用户类型";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.cboUserType);
            this.Name = "frmLogin";
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}