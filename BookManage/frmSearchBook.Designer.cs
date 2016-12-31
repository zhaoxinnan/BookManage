namespace BookManage
{
    partial class frmSearchBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboAnd = new System.Windows.Forms.ComboBox();
            this.cboOR = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSearchBook = new System.Windows.Forms.DataGridView();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.cboAnd);
            this.panel1.Controls.Add(this.cboOR);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 285);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(134, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(134, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(89, 152);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(121, 20);
            this.txtContent.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 7;
            // 
            // cboAnd
            // 
            this.cboAnd.FormattingEnabled = true;
            this.cboAnd.Items.AddRange(new object[] {
            "and",
            "or"});
            this.cboAnd.Location = new System.Drawing.Point(89, 116);
            this.cboAnd.Name = "cboAnd";
            this.cboAnd.Size = new System.Drawing.Size(121, 21);
            this.cboAnd.TabIndex = 6;
            // 
            // cboOR
            // 
            this.cboOR.FormattingEnabled = true;
            this.cboOR.Items.AddRange(new object[] {
            "and",
            "or"});
            this.cboOR.Location = new System.Drawing.Point(89, 53);
            this.cboOR.Name = "cboOR";
            this.cboOR.Size = new System.Drawing.Size(121, 21);
            this.cboOR.TabIndex = 5;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(89, 26);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "主要内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "图书类别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜索条件";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSearchBook);
            this.panel2.Location = new System.Drawing.Point(291, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 285);
            this.panel2.TabIndex = 1;
            // 
            // dgvSearchBook
            // 
            this.dgvSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookType,
            this.BookID,
            this.BookName,
            this.BookAuthor,
            this.BookPrice,
            this.BookPic,
            this.BookContent,
            this.BookIssue});
            this.dgvSearchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchBook.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchBook.Name = "dgvSearchBook";
            this.dgvSearchBook.Size = new System.Drawing.Size(356, 285);
            this.dgvSearchBook.TabIndex = 0;
            // 
            // BookType
            // 
            this.BookType.DataPropertyName = "BookType";
            this.BookType.HeaderText = "图书类别";
            this.BookType.Name = "BookType";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.Visible = false;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            // 
            // BookAuthor
            // 
            this.BookAuthor.DataPropertyName = "BookAuthor";
            this.BookAuthor.HeaderText = "作者";
            this.BookAuthor.Name = "BookAuthor";
            // 
            // BookPrice
            // 
            this.BookPrice.DataPropertyName = "BookPrice";
            this.BookPrice.HeaderText = "价格";
            this.BookPrice.Name = "BookPrice";
            // 
            // BookPic
            // 
            this.BookPic.DataPropertyName = "BookPic";
            this.BookPic.HeaderText = "封面";
            this.BookPic.Name = "BookPic";
            // 
            // BookContent
            // 
            this.BookContent.DataPropertyName = "BookContent";
            this.BookContent.HeaderText = "内容简介";
            this.BookContent.Name = "BookContent";
            // 
            // BookIssue
            // 
            this.BookIssue.DataPropertyName = "BookIssue";
            this.BookIssue.HeaderText = "指定访问码";
            this.BookIssue.Name = "BookIssue";
            // 
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 309);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSearchBook";
            this.Text = "BookQuery";
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboAnd;
        private System.Windows.Forms.ComboBox cboOR;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSearchBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIssue;
    }
}