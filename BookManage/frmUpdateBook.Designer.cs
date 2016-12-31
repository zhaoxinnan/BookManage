namespace BookManage
{
    partial class frmUpdateBook
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbType = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbAuthor = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbPic = new System.Windows.Forms.TextBox();
            this.txtbContent = new System.Windows.Forms.TextBox();
            this.txtbIssueID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBookInfo);
            this.panel2.Location = new System.Drawing.Point(12, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 267);
            this.panel2.TabIndex = 4;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.BookID,
            this.BookType,
            this.BookAuthor,
            this.BookPrice,
            this.BookPic,
            this.BookContent,
            this.BookIssue});
            this.dgvBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.Size = new System.Drawing.Size(404, 267);
            this.dgvBookInfo.TabIndex = 0;
            this.dgvBookInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookInfo_CellClick);
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "图书名称";
            this.BookName.Name = "BookName";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "图书ID";
            this.BookID.Name = "BookID";
            this.BookID.Visible = false;
            // 
            // BookType
            // 
            this.BookType.DataPropertyName = "BookType";
            this.BookType.HeaderText = "类别";
            this.BookType.Name = "BookType";
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
            this.BookIssue.HeaderText = "图书指定访问码";
            this.BookIssue.Name = "BookIssue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "图书详细信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "图书编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "图书类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "图书名字";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "图书作者";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "图书价格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "图书封面";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "图书内容";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "访问码";
            // 
            // txtbID
            // 
            this.txtbID.Enabled = false;
            this.txtbID.Location = new System.Drawing.Point(488, 37);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 20);
            this.txtbID.TabIndex = 14;
            // 
            // txtbType
            // 
            this.txtbType.Location = new System.Drawing.Point(488, 97);
            this.txtbType.Name = "txtbType";
            this.txtbType.Size = new System.Drawing.Size(100, 20);
            this.txtbType.TabIndex = 15;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(486, 152);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 20);
            this.txtbName.TabIndex = 16;
            // 
            // txtbAuthor
            // 
            this.txtbAuthor.Location = new System.Drawing.Point(486, 203);
            this.txtbAuthor.Name = "txtbAuthor";
            this.txtbAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtbAuthor.TabIndex = 17;
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(265, 7);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbPrice.TabIndex = 18;
            // 
            // txtbPic
            // 
            this.txtbPic.Location = new System.Drawing.Point(687, 97);
            this.txtbPic.Name = "txtbPic";
            this.txtbPic.Size = new System.Drawing.Size(100, 20);
            this.txtbPic.TabIndex = 19;
            // 
            // txtbContent
            // 
            this.txtbContent.Location = new System.Drawing.Point(687, 152);
            this.txtbContent.Name = "txtbContent";
            this.txtbContent.Size = new System.Drawing.Size(100, 20);
            this.txtbContent.TabIndex = 20;
            // 
            // txtbIssueID
            // 
            this.txtbIssueID.Location = new System.Drawing.Point(687, 207);
            this.txtbIssueID.Name = "txtbIssueID";
            this.txtbIssueID.Size = new System.Drawing.Size(100, 20);
            this.txtbIssueID.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.Location = new System.Drawing.Point(53, 228);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePic.TabIndex = 23;
            this.btnUpdatePic.Text = "更新封面";
            this.btnUpdatePic.UseVisualStyleBackColor = true;
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(134, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(215, 228);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "关闭";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnUpdatePic);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtbPrice);
            this.panel1.Location = new System.Drawing.Point(422, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 267);
            this.panel1.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "更新图书信息";
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 348);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtbIssueID);
            this.Controls.Add(this.txtbContent);
            this.Controls.Add(this.txtbPic);
            this.Controls.Add(this.txtbAuthor);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.txtbType);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdateBook";
            this.Text = "frmUpdateBook";
            this.Load += new System.EventHandler(this.frmUpdateBook_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbType;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbAuthor;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbPic;
        private System.Windows.Forms.TextBox txtbContent;
        private System.Windows.Forms.TextBox txtbIssueID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIssue;
    }
}