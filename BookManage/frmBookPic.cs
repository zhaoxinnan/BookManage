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
    public partial class frmBookPic : Form
    {
        private int id;
        public frmBookPic()
        {
            InitializeComponent();
        }
        public void ShowContent(int bookid,string pic)
        {
            id = bookid;
            this.txtPic.Text = pic;
            if (pic != string.Empty)
            {
                this.pbBook.Image = Image.FromFile(this.txtPic.Text);
            }
        }
        private void btnPic_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPic.Text = ofdFile.FileName;
                this.pbBook.Image = Image.FromFile(txtPic.Text);
            }
        }

        private void btnUpdatePic_Click(object sender, EventArgs e)
        {
            if(DataAccess.UpdateDataTable("update bookInfo set BookPic'"+txtPic.Text+"' where BookID="+id+" "))
            {
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
