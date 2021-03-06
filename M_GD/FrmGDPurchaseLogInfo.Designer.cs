namespace M_GD
{
    partial class FrmGDPurchaseLogInfo
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
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.LblLink = new System.Windows.Forms.Label();
            this.DtpBegin = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.tbcResult = new System.Windows.Forms.TabControl();
            this.tpgCharacter = new System.Windows.Forms.TabPage();
            this.GrdCharacter = new System.Windows.Forms.DataGridView();
            this.tpgPurchaseLog = new System.Windows.Forms.TabPage();
            this.GrdPurchaseResult = new System.Windows.Forms.DataGridView();
            this.PnlPurchaseLog = new System.Windows.Forms.Panel();
            this.LblPage = new System.Windows.Forms.Label();
            this.CmbPurchaseLog = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerFormLoad = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerPurchaseLog = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerRePurchaseLog = new System.ComponentModel.BackgroundWorker();
            this.GrpSearch.SuspendLayout();
            this.tbcResult.SuspendLayout();
            this.tpgCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).BeginInit();
            this.tpgPurchaseLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPurchaseResult)).BeginInit();
            this.PnlPurchaseLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.DtpEnd);
            this.GrpSearch.Controls.Add(this.LblLink);
            this.GrpSearch.Controls.Add(this.DtpBegin);
            this.GrpSearch.Controls.Add(this.LblDate);
            this.GrpSearch.Controls.Add(this.lblHint);
            this.GrpSearch.Controls.Add(this.btnClose);
            this.GrpSearch.Controls.Add(this.btnSearch);
            this.GrpSearch.Controls.Add(this.txtNick);
            this.GrpSearch.Controls.Add(this.lblNick);
            this.GrpSearch.Controls.Add(this.txtAccount);
            this.GrpSearch.Controls.Add(this.lblAccount);
            this.GrpSearch.Controls.Add(this.cmbServer);
            this.GrpSearch.Controls.Add(this.lblServer);
            this.GrpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpSearch.Location = new System.Drawing.Point(0, 0);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(860, 190);
            this.GrpSearch.TabIndex = 4;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "搜索条件";
            // 
            // DtpEnd
            // 
            this.DtpEnd.CustomFormat = "yyyy-MM-dd";
            this.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEnd.Location = new System.Drawing.Point(388, 125);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(188, 21);
            this.DtpEnd.TabIndex = 97;
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(317, 129);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(65, 12);
            this.LblLink.TabIndex = 96;
            this.LblLink.Text = "结束时间：";
            // 
            // DtpBegin
            // 
            this.DtpBegin.CustomFormat = "yyyy-MM-dd";
            this.DtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpBegin.Location = new System.Drawing.Point(107, 125);
            this.DtpBegin.Name = "DtpBegin";
            this.DtpBegin.Size = new System.Drawing.Size(188, 21);
            this.DtpBegin.TabIndex = 95;
            this.DtpBegin.ValueChanged += new System.EventHandler(this.DtpBegin_ValueChanged);
            this.DtpBegin.Leave += new System.EventHandler(this.DtpBegin_Leave);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(36, 129);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(65, 12);
            this.LblDate.TabIndex = 94;
            this.LblDate.Text = "开始时间：";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.Location = new System.Drawing.Point(226, 161);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(521, 12);
            this.lblHint.TabIndex = 93;
            this.lblHint.Text = "提示：查询到的购买记录有两个小时的延迟，即距当前时间两个小时之内的购买记录信息无法查询";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(319, 62);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "壽敕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(319, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "刲坰";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(107, 92);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(187, 21);
            this.txtNick.TabIndex = 29;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(36, 95);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(65, 12);
            this.lblNick.TabIndex = 28;
            this.lblNick.Text = "玩家昵称：";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(107, 58);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(187, 21);
            this.txtAccount.TabIndex = 27;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(36, 61);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(65, 12);
            this.lblAccount.TabIndex = 26;
            this.lblAccount.Text = "玩家帐号：";
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(107, 25);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(187, 20);
            this.cmbServer.TabIndex = 25;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(24, 28);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(77, 12);
            this.lblServer.TabIndex = 24;
            this.lblServer.Text = "游戏服务器：";
            // 
            // tbcResult
            // 
            this.tbcResult.Controls.Add(this.tpgCharacter);
            this.tbcResult.Controls.Add(this.tpgPurchaseLog);
            this.tbcResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcResult.Location = new System.Drawing.Point(0, 190);
            this.tbcResult.Name = "tbcResult";
            this.tbcResult.SelectedIndex = 0;
            this.tbcResult.Size = new System.Drawing.Size(860, 213);
            this.tbcResult.TabIndex = 19;
            this.tbcResult.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcResult_Selected);
            // 
            // tpgCharacter
            // 
            this.tpgCharacter.Controls.Add(this.GrdCharacter);
            this.tpgCharacter.Location = new System.Drawing.Point(4, 21);
            this.tpgCharacter.Name = "tpgCharacter";
            this.tpgCharacter.Size = new System.Drawing.Size(852, 188);
            this.tpgCharacter.TabIndex = 7;
            this.tpgCharacter.Text = "玩家角色信息";
            this.tpgCharacter.UseVisualStyleBackColor = true;
            // 
            // GrdCharacter
            // 
            this.GrdCharacter.AllowUserToAddRows = false;
            this.GrdCharacter.AllowUserToDeleteRows = false;
            this.GrdCharacter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdCharacter.Location = new System.Drawing.Point(0, 0);
            this.GrdCharacter.Name = "GrdCharacter";
            this.GrdCharacter.ReadOnly = true;
            this.GrdCharacter.RowTemplate.Height = 23;
            this.GrdCharacter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdCharacter.Size = new System.Drawing.Size(852, 188);
            this.GrdCharacter.TabIndex = 11;
            this.GrdCharacter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellDoubleClick);
            this.GrdCharacter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellClick);
            // 
            // tpgPurchaseLog
            // 
            this.tpgPurchaseLog.Controls.Add(this.GrdPurchaseResult);
            this.tpgPurchaseLog.Controls.Add(this.PnlPurchaseLog);
            this.tpgPurchaseLog.Location = new System.Drawing.Point(4, 21);
            this.tpgPurchaseLog.Name = "tpgPurchaseLog";
            this.tpgPurchaseLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPurchaseLog.Size = new System.Drawing.Size(852, 188);
            this.tpgPurchaseLog.TabIndex = 0;
            this.tpgPurchaseLog.Text = "购买记录";
            this.tpgPurchaseLog.UseVisualStyleBackColor = true;
            // 
            // GrdPurchaseResult
            // 
            this.GrdPurchaseResult.AllowUserToAddRows = false;
            this.GrdPurchaseResult.AllowUserToDeleteRows = false;
            this.GrdPurchaseResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPurchaseResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdPurchaseResult.Location = new System.Drawing.Point(3, 34);
            this.GrdPurchaseResult.Name = "GrdPurchaseResult";
            this.GrdPurchaseResult.ReadOnly = true;
            this.GrdPurchaseResult.RowTemplate.Height = 23;
            this.GrdPurchaseResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdPurchaseResult.Size = new System.Drawing.Size(846, 151);
            this.GrdPurchaseResult.TabIndex = 16;
            // 
            // PnlPurchaseLog
            // 
            this.PnlPurchaseLog.Controls.Add(this.LblPage);
            this.PnlPurchaseLog.Controls.Add(this.CmbPurchaseLog);
            this.PnlPurchaseLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPurchaseLog.Location = new System.Drawing.Point(3, 3);
            this.PnlPurchaseLog.Name = "PnlPurchaseLog";
            this.PnlPurchaseLog.Size = new System.Drawing.Size(846, 31);
            this.PnlPurchaseLog.TabIndex = 14;
            this.PnlPurchaseLog.TabStop = true;
            // 
            // LblPage
            // 
            this.LblPage.AutoSize = true;
            this.LblPage.Location = new System.Drawing.Point(5, 11);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(101, 12);
            this.LblPage.TabIndex = 1;
            this.LblPage.Text = "请选择查看页数：";
            // 
            // CmbPurchaseLog
            // 
            this.CmbPurchaseLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPurchaseLog.FormattingEnabled = true;
            this.CmbPurchaseLog.Location = new System.Drawing.Point(112, 7);
            this.CmbPurchaseLog.Name = "CmbPurchaseLog";
            this.CmbPurchaseLog.Size = new System.Drawing.Size(121, 20);
            this.CmbPurchaseLog.TabIndex = 0;
            this.CmbPurchaseLog.SelectedIndexChanged += new System.EventHandler(this.CmbPurchaseLog_SelectedIndexChanged);
            // 
            // backgroundWorkerFormLoad
            // 
            this.backgroundWorkerFormLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFormLoad_DoWork);
            this.backgroundWorkerFormLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFormLoad_RunWorkerCompleted);
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // backgroundWorkerPurchaseLog
            // 
            this.backgroundWorkerPurchaseLog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPurchaseLog_DoWork);
            this.backgroundWorkerPurchaseLog.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPurchaseLog_RunWorkerCompleted);
            // 
            // backgroundWorkerRePurchaseLog
            // 
            this.backgroundWorkerRePurchaseLog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRePurchaseLog_DoWork);
            this.backgroundWorkerRePurchaseLog.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerRePurchaseLog_RunWorkerCompleted);
            // 
            // FrmGDPurchaseLogInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 403);
            this.Controls.Add(this.tbcResult);
            this.Controls.Add(this.GrpSearch);
            this.Name = "FrmGDPurchaseLogInfo";
            this.Text = "购买记录查询";
            this.Load += new System.EventHandler(this.FrmGDPurchaseLogInfo_Load);
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.tbcResult.ResumeLayout(false);
            this.tpgCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).EndInit();
            this.tpgPurchaseLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPurchaseResult)).EndInit();
            this.PnlPurchaseLog.ResumeLayout(false);
            this.PnlPurchaseLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TabControl tbcResult;
        private System.Windows.Forms.TabPage tpgCharacter;
        private System.Windows.Forms.TabPage tpgPurchaseLog;
        private System.Windows.Forms.DataGridView GrdCharacter;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFormLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridView GrdPurchaseResult;
        private System.Windows.Forms.Panel PnlPurchaseLog;
        private System.Windows.Forms.Label LblPage;
        private System.Windows.Forms.ComboBox CmbPurchaseLog;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.Label LblLink;
        private System.Windows.Forms.DateTimePicker DtpBegin;
        private System.Windows.Forms.Label LblDate;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPurchaseLog;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRePurchaseLog;
    }
}