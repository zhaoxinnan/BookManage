namespace BookManage
{
    partial class frmBookPic
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书封面路径";
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(150, 26);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(195, 20);
            this.txtPic.TabIndex = 1;
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(68, 57);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 2;
            this.btnPic.Text = "修改封面";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // pbBook
            // 
            this.pbBook.Location = new System.Drawing.Point(68, 86);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(277, 195);
            this.pbBook.TabIndex = 3;
            this.pbBook.TabStop = false;
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.Location = new System.Drawing.Point(67, 304);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePic.TabIndex = 4;
            this.btnUpdatePic.Text = "更新封面";
            this.btnUpdatePic.UseVisualStyleBackColor = true;
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(202, 304);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmBookPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 339);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnUpdatePic);
            this.Controls.Add(this.pbBook);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.label1);
            this.Name = "frmBookPic";
            this.Text = "frmBookPic";
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.Button btnCancle;
    }
}