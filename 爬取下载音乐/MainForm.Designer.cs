namespace 爬取下载音乐
{
    partial class MainForm
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
            this.cmbUrlList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SongGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPageNum = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurPageInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDownloadFoldPath = new System.Windows.Forms.TextBox();
            this.btnChoseDownloadFold = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.fldDownload = new System.Windows.Forms.FolderBrowserDialog();
            this.media_mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selOK = new System.Windows.Forms.DataGridViewLinkColumn();
            this.media_mid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songmid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songname2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDownloadInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SongGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUrlList
            // 
            this.cmbUrlList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrlList.DropDownWidth = 180;
            this.cmbUrlList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUrlList.FormattingEnabled = true;
            this.cmbUrlList.Location = new System.Drawing.Point(144, 15);
            this.cmbUrlList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUrlList.Name = "cmbUrlList";
            this.cmbUrlList.Size = new System.Drawing.Size(347, 35);
            this.cmbUrlList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "解析来源：";
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbKeyWord.Location = new System.Drawing.Point(649, 15);
            this.tbKeyWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(372, 34);
            this.tbKeyWord.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(1031, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "解析";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(500, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入关键字：";
            // 
            // SongGrid
            // 
            this.SongGrid.AllowUserToAddRows = false;
            this.SongGrid.AllowUserToDeleteRows = false;
            this.SongGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.media_mid,
            this.songmid,
            this.name,
            this.selOK});
            this.SongGrid.Location = new System.Drawing.Point(8, 19);
            this.SongGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SongGrid.Name = "SongGrid";
            this.SongGrid.ReadOnly = true;
            this.SongGrid.RowTemplate.Height = 23;
            this.SongGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SongGrid.Size = new System.Drawing.Size(593, 580);
            this.SongGrid.TabIndex = 5;
            this.SongGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SongGrid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbPageNum);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblTotalNum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblCurPageInfo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 606);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 38);
            this.panel1.TabIndex = 6;
            // 
            // cmbPageNum
            // 
            this.cmbPageNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPageNum.FormattingEnabled = true;
            this.cmbPageNum.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "50"});
            this.cmbPageNum.Location = new System.Drawing.Point(51, 8);
            this.cmbPageNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPageNum.Name = "cmbPageNum";
            this.cmbPageNum.Size = new System.Drawing.Size(45, 23);
            this.cmbPageNum.TabIndex = 7;
            this.cmbPageNum.SelectedIndexChanged += new System.EventHandler(this.cmbPageNum_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(501, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 26);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(549, 6);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(40, 26);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(453, 6);
            this.btnPre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(40, 26);
            this.btnPre.TabIndex = 9;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(405, 6);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(40, 26);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "条记录";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Location = new System.Drawing.Point(303, 11);
            this.lblTotalNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(15, 15);
            this.lblTotalNum.TabIndex = 6;
            this.lblTotalNum.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "共";
            // 
            // lblCurPageInfo
            // 
            this.lblCurPageInfo.AutoSize = true;
            this.lblCurPageInfo.Location = new System.Drawing.Point(217, 11);
            this.lblCurPageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurPageInfo.Name = "lblCurPageInfo";
            this.lblCurPageInfo.Size = new System.Drawing.Size(47, 15);
            this.lblCurPageInfo.TabIndex = 4;
            this.lblCurPageInfo.Text = "0 / 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "当前页：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "条";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "每页";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SongGrid);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(613, 655);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.selectGrid);
            this.groupBox2.Location = new System.Drawing.Point(637, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(613, 655);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已选择列表";
            // 
            // selectGrid
            // 
            this.selectGrid.AllowUserToAddRows = false;
            this.selectGrid.AllowUserToDeleteRows = false;
            this.selectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.media_mid2,
            this.songmid2,
            this.songname2,
            this.selRemove});
            this.selectGrid.Location = new System.Drawing.Point(8, 19);
            this.selectGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectGrid.Name = "selectGrid";
            this.selectGrid.ReadOnly = true;
            this.selectGrid.RowTemplate.Height = 23;
            this.selectGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectGrid.Size = new System.Drawing.Size(593, 580);
            this.selectGrid.TabIndex = 6;
            this.selectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectGrid_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "下载目录：";
            // 
            // tbDownloadFoldPath
            // 
            this.tbDownloadFoldPath.Enabled = false;
            this.tbDownloadFoldPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDownloadFoldPath.Location = new System.Drawing.Point(144, 58);
            this.tbDownloadFoldPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDownloadFoldPath.Name = "tbDownloadFoldPath";
            this.tbDownloadFoldPath.Size = new System.Drawing.Size(877, 34);
            this.tbDownloadFoldPath.TabIndex = 10;
            // 
            // btnChoseDownloadFold
            // 
            this.btnChoseDownloadFold.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseDownloadFold.Location = new System.Drawing.Point(1031, 56);
            this.btnChoseDownloadFold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoseDownloadFold.Name = "btnChoseDownloadFold";
            this.btnChoseDownloadFold.Size = new System.Drawing.Size(100, 36);
            this.btnChoseDownloadFold.TabIndex = 11;
            this.btnChoseDownloadFold.Text = "选择";
            this.btnChoseDownloadFold.UseVisualStyleBackColor = true;
            this.btnChoseDownloadFold.Click += new System.EventHandler(this.btnChoseDownloadFold_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnlock.Location = new System.Drawing.Point(1139, 15);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(100, 36);
            this.btnUnlock.TabIndex = 12;
            this.btnUnlock.Text = "解锁";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDownload.Location = new System.Drawing.Point(1139, 56);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 36);
            this.btnDownload.TabIndex = 13;
            this.btnDownload.Text = "下载";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // media_mid
            // 
            this.media_mid.DataPropertyName = "media_mid";
            this.media_mid.HeaderText = "媒体ID";
            this.media_mid.Name = "media_mid";
            this.media_mid.ReadOnly = true;
            this.media_mid.Visible = false;
            // 
            // songmid
            // 
            this.songmid.DataPropertyName = "songmid";
            this.songmid.HeaderText = "歌曲Id";
            this.songmid.Name = "songmid";
            this.songmid.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "songname";
            this.name.HeaderText = "歌曲名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 240;
            // 
            // selOK
            // 
            this.selOK.DataPropertyName = "selOK";
            this.selOK.HeaderText = "选择";
            this.selOK.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.selOK.Name = "selOK";
            this.selOK.ReadOnly = true;
            this.selOK.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selOK.Text = "";
            this.selOK.TrackVisitedState = false;
            this.selOK.Width = 45;
            // 
            // media_mid2
            // 
            this.media_mid2.DataPropertyName = "media_mid";
            this.media_mid2.HeaderText = "媒体ID";
            this.media_mid2.Name = "media_mid2";
            this.media_mid2.ReadOnly = true;
            this.media_mid2.Visible = false;
            // 
            // songmid2
            // 
            this.songmid2.DataPropertyName = "songmid";
            this.songmid2.HeaderText = "歌曲Id";
            this.songmid2.Name = "songmid2";
            this.songmid2.ReadOnly = true;
            // 
            // songname2
            // 
            this.songname2.DataPropertyName = "songname";
            this.songname2.HeaderText = "歌曲名称";
            this.songname2.Name = "songname2";
            this.songname2.ReadOnly = true;
            this.songname2.Width = 240;
            // 
            // selRemove
            // 
            this.selRemove.DataPropertyName = "selRemove";
            this.selRemove.HeaderText = "移除";
            this.selRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.selRemove.Name = "selRemove";
            this.selRemove.ReadOnly = true;
            this.selRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selRemove.Text = "";
            this.selRemove.TrackVisitedState = false;
            this.selRemove.Width = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDownloadInfo);
            this.panel2.Location = new System.Drawing.Point(8, 606);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 38);
            this.panel2.TabIndex = 7;
            // 
            // lblDownloadInfo
            // 
            this.lblDownloadInfo.AutoSize = true;
            this.lblDownloadInfo.Location = new System.Drawing.Point(4, 11);
            this.lblDownloadInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownloadInfo.Name = "lblDownloadInfo";
            this.lblDownloadInfo.Size = new System.Drawing.Size(82, 15);
            this.lblDownloadInfo.TabIndex = 1;
            this.lblDownloadInfo.Text = "下载进度：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 778);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnChoseDownloadFold);
            this.Controls.Add(this.tbDownloadFoldPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrlList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐下载器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SongGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUrlList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SongGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurPageInfo;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.ComboBox cmbPageNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDownloadFoldPath;
        private System.Windows.Forms.Button btnChoseDownloadFold;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.DataGridView selectGrid;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.FolderBrowserDialog fldDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn media_mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn songmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewLinkColumn selOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn media_mid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn songmid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn songname2;
        private System.Windows.Forms.DataGridViewLinkColumn selRemove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDownloadInfo;
    }
}