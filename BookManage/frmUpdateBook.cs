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
    public partial class frmUpdateBook : Form
    {
        public frmUpdateBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from BookInfo";
            DialogResult result = MessageBox.Show("确实要将修改保存到数据库吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //DataAccess.UpdateDataSet(ds, sql);
                MessageBox.Show("保存成功");
            }
            this.dgvBookInfo.DataSource = DataAccess.GetDataSetBySql(sql).Tables[0];
        }

        private void dgvBookInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得当前鼠标单击时的行索引号
            int index = this.dgvBookInfo.CurrentCell.RowIndex;
            this.txtbID.Text = this.dgvBookInfo.Rows[index].Cells[0].Value.ToString().Trim();
            this.txtbType.Text = this.dgvBookInfo.Rows[index].Cells[1].Value.ToString().Trim();
            this.txtbName.Text = this.dgvBookInfo.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtbAuthor.Text = this.dgvBookInfo.Rows[index].Cells[3].Value.ToString().Trim();
            this.txtbPrice.Text = this.dgvBookInfo.Rows[index].Cells[4].Value.ToString().Trim();
            this.txtbPic.Text = this.dgvBookInfo.Rows[index].Cells[5].Value.ToString().Trim();
            this.txtbContent.Text = this.dgvBookInfo.Rows[index].Cells[6].Value.ToString();
            this.txtbIssueID.Text = this.dgvBookInfo.Rows[index].Cells[7].Value.ToString();
        }

        private void frmUpdateBook_Load(object sender, EventArgs e)
        {
            string sql = "select * from bookinfo";
            DataSet ds = DataAccess.GetDataSetBySql(sql);
            DataTable table = ds.Tables[0];
            this.dgvBookInfo.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string booktype = this.txtbType.Text.ToString();
            string bookname = this.txtbName.Text.ToString();
            string bookauthor = this.txtbAuthor.Text.ToString();
            double bookprice = Convert.ToDouble(this.txtbPrice.Text.ToString());
            string bookpic = this.txtbPic.Text.ToString();
            string bookcontent = this.txtbContent.Text.ToString();
            int bookissue = Convert.ToInt32(this.txtbIssueID.Text);
            string sql = string.Format("update bookInfo set BookType='{0}',BookName='{1}',BookAuthor='{2}',BookPrice={3},BookPic='{4}',BookContent='{5}',BookIssue={6} where BookID={7}", booktype, bookname, bookauthor, bookprice, bookpic, bookcontent, bookissue, Convert.ToInt32(this.txtbID.Text));
            if (DataAccess.UpdateDataTable(sql))
            {
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select * from IssueInfo where BookID=" + Convert.ToInt32(this.txtbID.Text) + " ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("此书有借，不能删除");
            }
            else
            {
                string sql = "delete from bookInfo where BookID=" + this.txtbID.Text + "";
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            this.txtbID.Text = "";
            this.txtbType.Text = "";
            this.txtbName.Text = "";
            this.txtbAuthor.Text = "";
            this.txtbPrice.Text = "";
            this.txtbPic.Text = "";
            this.txtbContent.Text = "";
            this.txtbIssueID.Text = "";
        }

        private void btnUpdatePic_Click(object sender, EventArgs e)
        {
            string pic = this.txtbPic.Text.ToString();
            int bookid = Convert.ToInt32(this.txtbID.Text);
            frmBookPic bookpic = new frmBookPic();
            bookpic.ShowContent(bookid, pic);
            bookpic.ShowDialog();
        }
    }
}
