using System;

namespace BookManage
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书借阅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tushugengxin = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem,
            this.图书借阅ToolStripMenuItem,
            this.系统帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户登录ToolStripMenuItem,
            this.管理员登录ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 用户登录ToolStripMenuItem
            // 
            this.用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            this.用户登录ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.用户登录ToolStripMenuItem.Text = "用户登录";
            this.用户登录ToolStripMenuItem.Click += new System.EventHandler(this.用户登录ToolStripMenuItem_Click);
            // 
            // 管理员登录ToolStripMenuItem
            // 
            this.管理员登录ToolStripMenuItem.Name = "管理员登录ToolStripMenuItem";
            this.管理员登录ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.管理员登录ToolStripMenuItem.Text = "管理员登录";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书入库ToolStripMenuItem,
            this.图书更新ToolStripMenuItem,
            this.图书检索ToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // 图书入库ToolStripMenuItem
            // 
            this.图书入库ToolStripMenuItem.Enabled = false;
            this.图书入库ToolStripMenuItem.Name = "图书入库ToolStripMenuItem";
            this.图书入库ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.图书入库ToolStripMenuItem.Text = "图书入库";
            this.图书入库ToolStripMenuItem.Click += new System.EventHandler(this.图书入库ToolStripMenuItem_Click);
            // 
            // 图书更新ToolStripMenuItem
            // 
            this.图书更新ToolStripMenuItem.Enabled = false;
            this.图书更新ToolStripMenuItem.Name = "图书更新ToolStripMenuItem";
            this.图书更新ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.图书更新ToolStripMenuItem.Text = "图书更新";
            this.图书更新ToolStripMenuItem.Click += new System.EventHandler(this.图书更新ToolStripMenuItem_Click);
            // 
            // 图书检索ToolStripMenuItem
            // 
            this.图书检索ToolStripMenuItem.Name = "图书检索ToolStripMenuItem";
            this.图书检索ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.图书检索ToolStripMenuItem.Text = "图书检索";
            this.图书检索ToolStripMenuItem.Click += new System.EventHandler(this.图书检索ToolStripMenuItem_Click);
            // 
            // 图书借阅ToolStripMenuItem
            // 
            this.图书借阅ToolStripMenuItem.Enabled = false;
            this.图书借阅ToolStripMenuItem.Name = "图书借阅ToolStripMenuItem";
            this.图书借阅ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.图书借阅ToolStripMenuItem.Text = "图书借阅";
            this.图书借阅ToolStripMenuItem.Click += new System.EventHandler(this.图书借阅ToolStripMenuItem_Click);
            // 
            // 系统帮助ToolStripMenuItem
            // 
            this.系统帮助ToolStripMenuItem.Name = "系统帮助ToolStripMenuItem";
            this.系统帮助ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.系统帮助ToolStripMenuItem.Text = "系统帮助";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripButton3,
            this.toolStripLabel3,
            this.toolStripButton4,
            this.toolStripLabel4,
            this.toolStripButton5,
            this.toolStripLabel5,
            this.toolStripButton6,
            this.tushugengxin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "登录";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "登录";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "图书查询";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel2.Text = "图书查询";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "图书入库";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel3.Text = "图书入库";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "图书借阅";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel4.Text = "图书借阅";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "退出";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel5.Text = "退出";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tushugengxin
            // 
            this.tushugengxin.Name = "tushugengxin";
            this.tushugengxin.Size = new System.Drawing.Size(55, 22);
            this.tushugengxin.Text = "图书更新";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 330);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "图书管理信息系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书借阅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripMenuItem 用户登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel tushugengxin;
    }
}

