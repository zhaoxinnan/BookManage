using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookManage
{
    public partial class frmMain : Form
    {
        public static DialogResult result;
        public frmMain()
        {
            InitializeComponent();
        }
        //查询子窗体是否存在
        public bool checkchildfrm(string childfrmname)
        {
            foreach (Form childFrm in this.MdiChildren)
            {
                if (childFrm.WindowState == FormWindowState.Minimized)
                    childFrm.WindowState = FormWindowState.Normal;
                childFrm.Activate();//激活窗体
                return true;        //返回真值
            }
            return false;
        }
        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmLogin userLogin = new frmLogin();
            userLogin.Show();
        }

        

        

        

        private void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmLogin") == true)
                return;
            frmLogin user = new frmLogin();
            user.ShowDialog();
            //判断是否登录成功，登录成功则启用相应的菜单和按钮
            if (result==DialogResult.OK)
            {
                this.图书入库ToolStripMenuItem.Enabled = true;
                this.图书更新ToolStripMenuItem.Enabled = true;
                this.图书借阅ToolStripMenuItem.Enabled = true;
            }
        }
        //图书借阅
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmIssueBook") == true)
                return;
            frmBookIssue issuebook = new frmBookIssue();
            issuebook.MdiParent = this;
            issuebook.Show();
        }

        private void 图书借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmIssueBook") == true)
                return;
            frmBookIssue issuebook = new frmBookIssue();
            issuebook.MdiParent = this;
            issuebook.Show();
        }
        //图书检索
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmSearchBook") == true)
                return;
            frmSearchBook searchBook = new frmSearchBook();
            searchBook.Show();

        }
        private void 图书检索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton2.PerformClick();
        }
        //图书入库
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmAddBook"))
                return;
            frmAddBook putInStorage = new frmAddBook();
            putInStorage.Show();
        }

        private void 图书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3.PerformClick();
        }
        //图书更新
        private void 图书更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmUpdateBook") == true)
                return;
            frmUpdateBook objbook = new frmUpdateBook();
            objbook.MdiParent = this;
            objbook.Show();
        }
        //退出
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            退出ToolStripMenuItem.PerformClick();
        }
        //窗体载入使3个按钮不可用
        private void frmMain_Load(object sender, EventArgs e)
        {
            //this.图书入库ToolStripMenuItem.Enabled = false;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmUpdateBook") == true)
                return;
            frmUpdateBook objbook = new frmUpdateBook();
            objbook.MdiParent = this;
            objbook.Show();
        }
    }
    class DataAccess
    {
        private static string ConnectString= @"Server=(local)\sqlexpress;Database=BookManage;Trusted_Connection=True;";
        /// <summary>
        /// 根据表名获取数据集的表
        /// </summary>
        /// <param name="table">表名</param>
        /// <returns>DataTable</returns>
       public static DataTable GetDataSetByTableName(string table)
        {
            using (SqlConnection con=new SqlConnection(ConnectString))
            {
                string sql = "select * from " + table + "";
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table");
                    return ds.Tables[0];
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        ///<summary>
        ///根据sql语句获取数据对象
        ///</summary>
        ///<param name="sql">sql</param>
        ///<returns>DataSet</returns>
        public static DataSet GetDataSetBySql(string sql)
        {
            using (SqlConnection con=new SqlConnection(ConnectString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                try
                {
                    adapter.Fill(ds);
                    return ds;
                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);

                }
            }
        }
        //hit1
        //git
        ///<summary>
        ///根据id值获取DataReader对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader GetDataReaderByID(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                string sql = "select * from bookinfo where bookid=" + id;
                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    reader.Read();
                    return reader;
                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }
        ///<summary>
        ///更新数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool UpdateDataTable(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                try
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand(sql, con);
                    if (comm.ExecuteNonQuery()>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }
        ///<summary>
        ///根据数据集和sql语句更新数据库
        /// </summary>
        public static void UpdateDataSet(DataSet ds ,string sql)
        {
            using (SqlConnection con =new SqlConnection(ConnectString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "table");
                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }

    }
   
}
