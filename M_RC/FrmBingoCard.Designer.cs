namespace M_RC
{
    partial class FrmBingoCard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpgCharacter = new System.Windows.Forms.TabPage();
            this.RoleInfoView = new System.Windows.Forms.DataGridView();
            this.PnlPage = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LblPage = new System.Windows.Forms.Label();
            this.TpgItemList = new System.Windows.Forms.TabPage();
            this.TradeInfoView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbState = new System.Windows.Forms.ComboBox();
            this.LblState = new System.Windows.Forms.Label();
            this.BtnSerch = new System.Windows.Forms.Button();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.DtpBegin = new System.Windows.Forms.DateTimePicker();
            this.LblEndTime = new System.Windows.Forms.Label();
            this.LblStartTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblRoleName = new System.Windows.Forms.Label();
            this.LblPlayId = new System.Windows.Forms.Label();
            this.backgroundWorkerServerLoad = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbPage = new System.Windows.Forms.ComboBox();
            this.BtnTradeSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.TxtCharinfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerSerch = new System.ComponentModel.BackgroundWorker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblAccount = new System.Windows.Forms.Label();
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.LblServer = new System.Windows.Forms.Label();
            this.CmbServer = new System.Windows.Forms.ComboBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNick = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorkerInitCombobox = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerPage = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.TpgCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleInfoView)).BeginInit();
            this.PnlPage.SuspendLayout();
            this.TpgItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradeInfoView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GrpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TpgCharacter);
            this.tabControl1.Controls.Add(this.TpgItemList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 158);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 379);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // TpgCharacter
            // 
            this.TpgCharacter.Controls.Add(this.RoleInfoView);
            this.TpgCharacter.Controls.Add(this.PnlPage);
            this.TpgCharacter.Location = new System.Drawing.Point(4, 21);
            this.TpgCharacter.Name = "TpgCharacter";
            this.TpgCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.TpgCharacter.Size = new System.Drawing.Size(749, 354);
            this.TpgCharacter.TabIndex = 0;
            this.TpgCharacter.Text = "角色信息";
            this.TpgCharacter.UseVisualStyleBackColor = true;
            // 
            // RoleInfoView
            // 
            this.RoleInfoView.AllowUserToAddRows = false;
            this.RoleInfoView.AllowUserToDeleteRows = false;
            this.RoleInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoleInfoView.Location = new System.Drawing.Point(3, 34);
            this.RoleInfoView.Name = "RoleInfoView";
            this.RoleInfoView.ReadOnly = true;
            this.RoleInfoView.RowTemplate.Height = 23;
            this.RoleInfoView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoleInfoView.Size = new System.Drawing.Size(743, 317);
            this.RoleInfoView.TabIndex = 23;
            this.RoleInfoView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleInfoView_CellDoubleClick);
            // 
            // PnlPage
            // 
            this.PnlPage.Controls.Add(this.comboBox2);
            this.PnlPage.Controls.Add(this.LblPage);
            this.PnlPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPage.Location = new System.Drawing.Point(3, 3);
            this.PnlPage.Name = "PnlPage";
            this.PnlPage.Size = new System.Drawing.Size(743, 31);
            this.PnlPage.TabIndex = 24;
            this.PnlPage.TabStop = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(112, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // LblPage
            // 
            this.LblPage.AutoSize = true;
            this.LblPage.Location = new System.Drawing.Point(5, 11);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(89, 12);
            this.LblPage.TabIndex = 1;
            this.LblPage.Text = "請選擇查看頁數";
            // 
            // TpgItemList
            // 
            this.TpgItemList.Controls.Add(this.TradeInfoView);
            this.TpgItemList.Controls.Add(this.groupBox1);
            this.TpgItemList.Location = new System.Drawing.Point(4, 21);
            this.TpgItemList.Name = "TpgItemList";
            this.TpgItemList.Size = new System.Drawing.Size(749, 354);
            this.TpgItemList.TabIndex = 1;
            this.TpgItemList.Text = "合成道具記錄";
            this.TpgItemList.UseVisualStyleBackColor = true;
            // 
            // TradeInfoView
            // 
            this.TradeInfoView.AllowUserToAddRows = false;
            this.TradeInfoView.AllowUserToDeleteRows = false;
            this.TradeInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TradeInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TradeInfoView.Location = new System.Drawing.Point(0, 116);
            this.TradeInfoView.Name = "TradeInfoView";
            this.TradeInfoView.ReadOnly = true;
            this.TradeInfoView.RowTemplate.Height = 23;
            this.TradeInfoView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TradeInfoView.Size = new System.Drawing.Size(749, 238);
            this.TradeInfoView.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CmbState);
            this.groupBox1.Controls.Add(this.LblState);
            this.groupBox1.Controls.Add(this.BtnSerch);
            this.groupBox1.Controls.Add(this.DtpEnd);
            this.groupBox1.Controls.Add(this.DtpBegin);
            this.groupBox1.Controls.Add(this.LblEndTime);
            this.groupBox1.Controls.Add(this.LblStartTime);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.LblRoleName);
            this.groupBox1.Controls.Add(this.LblPlayId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 116);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索條件";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 20);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "請選擇查看頁數:";
            // 
            // CmbState
            // 
            this.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Location = new System.Drawing.Point(96, 73);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(129, 20);
            this.CmbState.TabIndex = 24;
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(14, 76);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(35, 12);
            this.LblState.TabIndex = 23;
            this.LblState.Text = "狀態:";
            // 
            // BtnSerch
            // 
            this.BtnSerch.Location = new System.Drawing.Point(499, 68);
            this.BtnSerch.Name = "BtnSerch";
            this.BtnSerch.Size = new System.Drawing.Size(75, 23);
            this.BtnSerch.TabIndex = 22;
            this.BtnSerch.Text = "搜索";
            this.BtnSerch.UseVisualStyleBackColor = true;
            this.BtnSerch.Click += new System.EventHandler(this.BtnSerch_Click);
            // 
            // DtpEnd
            // 
            this.DtpEnd.Location = new System.Drawing.Point(348, 42);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(135, 21);
            this.DtpEnd.TabIndex = 21;
            // 
            // DtpBegin
            // 
            this.DtpBegin.Location = new System.Drawing.Point(96, 41);
            this.DtpBegin.Name = "DtpBegin";
            this.DtpBegin.Size = new System.Drawing.Size(129, 21);
            this.DtpBegin.TabIndex = 19;
            // 
            // LblEndTime
            // 
            this.LblEndTime.AutoSize = true;
            this.LblEndTime.Location = new System.Drawing.Point(233, 44);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new System.Drawing.Size(59, 12);
            this.LblEndTime.TabIndex = 14;
            this.LblEndTime.Text = "結束時間:";
            // 
            // LblStartTime
            // 
            this.LblStartTime.AutoSize = true;
            this.LblStartTime.Location = new System.Drawing.Point(14, 44);
            this.LblStartTime.Name = "LblStartTime";
            this.LblStartTime.Size = new System.Drawing.Size(59, 12);
            this.LblStartTime.TabIndex = 12;
            this.LblStartTime.Text = "開始時間:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(129, 21);
            this.textBox2.TabIndex = 10;
            // 
            // LblRoleName
            // 
            this.LblRoleName.AutoSize = true;
            this.LblRoleName.Location = new System.Drawing.Point(233, 17);
            this.LblRoleName.Name = "LblRoleName";
            this.LblRoleName.Size = new System.Drawing.Size(47, 12);
            this.LblRoleName.TabIndex = 9;
            this.LblRoleName.Text = "角色名:";
            // 
            // LblPlayId
            // 
            this.LblPlayId.AutoSize = true;
            this.LblPlayId.Location = new System.Drawing.Point(14, 17);
            this.LblPlayId.Name = "LblPlayId";
            this.LblPlayId.Size = new System.Drawing.Size(47, 12);
            this.LblPlayId.TabIndex = 8;
            this.LblPlayId.Text = "玩家ID:";
            // 
            // backgroundWorkerServerLoad
            // 
            this.backgroundWorkerServerLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerServerLoad_DoWork);
            this.backgroundWorkerServerLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerServerLoad_RunWorkerCompleted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(233, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "恁寁脤艘腔珜杅ㄩ";
            this.label6.Visible = false;
            // 
            // CmbPage
            // 
            this.CmbPage.FormattingEnabled = true;
            this.CmbPage.Location = new System.Drawing.Point(348, 68);
            this.CmbPage.Name = "CmbPage";
            this.CmbPage.Size = new System.Drawing.Size(121, 20);
            this.CmbPage.TabIndex = 26;
            this.CmbPage.Visible = false;
            // 
            // BtnTradeSearch
            // 
            this.BtnTradeSearch.Location = new System.Drawing.Point(475, 65);
            this.BtnTradeSearch.Name = "BtnTradeSearch";
            this.BtnTradeSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnTradeSearch.TabIndex = 22;
            this.BtnTradeSearch.Text = "脤戙";
            this.BtnTradeSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "賦旰奀潔ㄩ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(14, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "邧僻蝠眢瘍脤艘蝠眢暮翹隴牉";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "袨怓:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "羲宎奀潔ㄩ";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(312, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 11;
            // 
            // TxtCharinfo
            // 
            this.TxtCharinfo.Enabled = false;
            this.TxtCharinfo.Location = new System.Drawing.Point(96, 14);
            this.TxtCharinfo.Name = "TxtCharinfo";
            this.TxtCharinfo.Size = new System.Drawing.Size(100, 21);
            this.TxtCharinfo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "褒伎靡ㄩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "俙模IDㄩ";
            // 
            // backgroundWorkerSerch
            // 
            this.backgroundWorkerSerch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSerch_DoWork);
            this.backgroundWorkerSerch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSerch_RunWorkerCompleted);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(236, 30);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(80, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "查詢";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Location = new System.Drawing.Point(6, 59);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(53, 12);
            this.LblAccount.TabIndex = 5;
            this.LblAccount.Text = "玩家帳號";
            this.LblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAccount
            // 
            this.TxtAccount.Location = new System.Drawing.Point(8, 74);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(162, 21);
            this.TxtAccount.TabIndex = 6;
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Location = new System.Drawing.Point(6, 17);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(65, 12);
            this.LblServer.TabIndex = 7;
            this.LblServer.Text = "遊戲伺服器";
            // 
            // CmbServer
            // 
            this.CmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbServer.FormattingEnabled = true;
            this.CmbServer.Location = new System.Drawing.Point(8, 32);
            this.CmbServer.Name = "CmbServer";
            this.CmbServer.Size = new System.Drawing.Size(162, 20);
            this.CmbServer.TabIndex = 8;
            this.CmbServer.SelectedIndexChanged += new System.EventHandler(this.CmbServer_SelectedIndexChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = true;
            this.BtnClose.Location = new System.Drawing.Point(236, 72);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(80, 23);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "關閉";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.label10);
            this.GrpSearch.Controls.Add(this.TxtNick);
            this.GrpSearch.Controls.Add(this.label9);
            this.GrpSearch.Controls.Add(this.BtnClose);
            this.GrpSearch.Controls.Add(this.CmbServer);
            this.GrpSearch.Controls.Add(this.LblServer);
            this.GrpSearch.Controls.Add(this.TxtAccount);
            this.GrpSearch.Controls.Add(this.LblAccount);
            this.GrpSearch.Controls.Add(this.BtnSearch);
            this.GrpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpSearch.Location = new System.Drawing.Point(0, 0);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(757, 158);
            this.GrpSearch.TabIndex = 8;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "搜索条件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(274, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "雙擊角色資訊查詢合成道具記錄";
            // 
            // TxtNick
            // 
            this.TxtNick.Location = new System.Drawing.Point(8, 122);
            this.TxtNick.Name = "TxtNick";
            this.TxtNick.Size = new System.Drawing.Size(162, 21);
            this.TxtNick.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "玩家昵稱";
            // 
            // backgroundWorkerInitCombobox
            // 
            this.backgroundWorkerInitCombobox.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerInitCombobox_DoWork);
            this.backgroundWorkerInitCombobox.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerInitCombobox_RunWorkerCompleted);
            // 
            // backgroundWorkerPage
            // 
            this.backgroundWorkerPage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPage_DoWork);
            this.backgroundWorkerPage.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPage_RunWorkerCompleted);
            // 
            // FrmBingoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GrpSearch);
            this.Name = "FrmBingoCard";
            this.Text = "合成道具記錄";
            this.Load += new System.EventHandler(this.FrmBingoCard_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpgCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoleInfoView)).EndInit();
            this.PnlPage.ResumeLayout(false);
            this.PnlPage.PerformLayout();
            this.TpgItemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TradeInfoView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpgCharacter;
        private System.Windows.Forms.TabPage TpgItemList;
        private System.ComponentModel.BackgroundWorker backgroundWorkerServerLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbPage;
        private System.Windows.Forms.Button BtnTradeSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox TxtCharinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbState;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Button BtnSerch;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.DateTimePicker DtpBegin;
        private System.Windows.Forms.Label LblEndTime;
        private System.Windows.Forms.Label LblStartTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblRoleName;
        private System.Windows.Forms.Label LblPlayId;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSerch;
        private System.Windows.Forms.DataGridView TradeInfoView;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblAccount;
        private System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.Label LblServer;
        private System.Windows.Forms.ComboBox CmbServer;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNick;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInitCombobox;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPage;
        private System.Windows.Forms.DataGridView RoleInfoView;
        private System.Windows.Forms.Panel PnlPage;
        private System.Windows.Forms.Label LblPage;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
    }
}