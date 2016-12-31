using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //登录按钮
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("123");
            if (Validate())
            {
                string state = this.cboUserType.Text;
                int num;
                if (state.Equals("管理员"))
                    num = 1;
                else
                    num = 2;
                string sql = string.Format("select * from userinfo where uname='{0}' and upwd='{1}' and ustate={2}", this.txName.Text.Trim(), this.txtPwd.Text.Trim(), num);
                DataSet ds = DataAccess.GetDataSetBySql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("登陆成功");
                    frmMain.result = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("用户名或密码错误！");
            }
            //else
            //{
            //    MessageBox.Show("用户名或密码错误！");
            //}

        }
        private new bool Validate()
        {
            if (this.txName.Text != string.Empty && this.txtPwd.Text != string.Empty)
            {
                return true;
            }
            else {
                MessageBox.Show("用户名或密码不能为空");
                return false;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
