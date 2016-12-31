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
    public partial class frmBookIssue : Form
    {
        private DataSet da;

        public frmBookIssue()
        {
            InitializeComponent();
        }

        private void frmBookIssue_Load(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("selelct BookInfo.BookID,BookName,IssueBookID,IssDateTime from IssueInfo,BookInfo where BookInfo.BookID=IssueInfo.BookID");
            this.dgvIssInfo.DataSource = ds.Tables[0];
            da = DataAccess.GetDataSetBySql("select * from BookInfo");
            this.cboBookName.DataSource = da.Tables[0];
            this.cboBookName.DisplayMember = "BookName";
            this.cboBookName.ValueMember = "BookID";
        }

        private void cboBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(DataRow objRow in da.Tables[0].Rows)
            {
                if (string.Compare(cboBookName.Text, objRow["BookName"].ToString(), true) == 0)
                {
                    this.txtBookAccessCode.Text = objRow["BookIssue"].ToString();
                    this.txtAuthor.Text = objRow["BookAuthor"].ToString();
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            int issue= Convert.ToInt32(this.txtIssID.Text);
            string sql1 = string.Format("select BookInfo.BookID where BookInfo.BookIssue={0}",issue);
            int getid = 2;
                //DataAccess.GetDataSetBySql(sql1);
            int bookid = Convert.ToInt32(this.cboBookName.SelectedValue);
            int txtbookaccesscode = Convert.ToInt32(this.txtBookAccessCode.Text);
            DateTime date = Convert.ToDateTime(this.dateTimePicker1.Text);
            string sql = string.Format("insert into IssueInfo(BookID,IssBookID,IssDateTime) values({0},{1},'{2}')", getid,txtbookaccesscode, date);
            if (DataAccess.UpdateDataTable(sql))
            {
                MessageBox.Show("节约成功");

            }
            //string sql2 =  string.Format("select IssBookID,IssDateTime from IssueInfo where IssueInfo.BookID={0}", bookid );
            //DataSet data = DataAccess.GetDataSetBySql(sql2);
            //this.dgvIssInfo.DataSource = data.Tables[0];
        }
    }
}
