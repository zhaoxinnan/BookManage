namespace BookManage
{
    partial class frmBookIssue
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
            this.cboBookName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtIssID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBookAccessCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvIssInfo = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IssBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cboBookName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.txtIssID);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtBookAccessCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 315);
            this.panel1.TabIndex = 0;
            // 
            // cboBookName
            // 
            this.cboBookName.FormattingEnabled = true;
            this.cboBookName.Location = new System.Drawing.Point(89, 164);
            this.cboBookName.Name = "cboBookName";
            this.cboBookName.Size = new System.Drawing.Size(100, 21);
            this.cboBookName.TabIndex = 10;
            this.cboBookName.SelectedIndexChanged += new System.EventHandler(this.cboBookName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "借阅日期";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(89, 220);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 8;
            // 
            // txtIssID
            // 
            this.txtIssID.Location = new System.Drawing.Point(89, 124);
            this.txtIssID.Name = "txtIssID";
            this.txtIssID.Size = new System.Drawing.Size(100, 20);
            this.txtIssID.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // txtBookAccessCode
            // 
            this.txtBookAccessCode.Location = new System.Drawing.Point(89, 31);
            this.txtBookAccessCode.Name = "txtBookAccessCode";
            this.txtBookAccessCode.Size = new System.Drawing.Size(100, 20);
            this.txtBookAccessCode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "作者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "书名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "图书访问码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "借阅证号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvIssInfo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(243, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 299);
            this.panel2.TabIndex = 1;
            // 
            // dgvIssInfo
            // 
            this.dgvIssInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssBookID,
            this.IssDateTime,
            this.BookName,
            this.BookID});
            this.dgvIssInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvIssInfo.Name = "dgvIssInfo";
            this.dgvIssInfo.Size = new System.Drawing.Size(486, 299);
            this.dgvIssInfo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, -13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "借阅详细信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "借阅详细信息";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "借阅详细信息";
            // 
            // IssBookID
            // 
            this.IssBookID.DataPropertyName = "IssBookID";
            this.IssBookID.HeaderText = "借阅证号";
            this.IssBookID.Name = "IssBookID";
            // 
            // IssDateTime
            // 
            this.IssDateTime.DataPropertyName = "IssDateTime";
            this.IssDateTime.HeaderText = "借阅时间";
            this.IssDateTime.Name = "IssDateTime";
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "借阅图书";
            this.BookName.Name = "BookName";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "图书ID";
            this.BookID.Name = "BookID";
            this.BookID.Visible = false;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Location = new System.Drawing.Point(543, 330);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(75, 23);
            this.btnIssueBook.TabIndex = 4;
            this.btnIssueBook.Text = "借阅";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // frmBookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 365);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBookIssue";
            this.Text = "图书借阅";
            this.Load += new System.EventHandler(this.frmBookIssue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtIssID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtBookAccessCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIssInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}