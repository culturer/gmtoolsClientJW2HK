using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C_Controls.LabelTextBox;
using C_Global;
using C_Event;
using Language;

namespace M_RC
{
    [C_Global.CModuleAttribute("GM帳?信息", "FrmRCGmaccont", "GM帳?信息", "Gt Group")]
    public partial class FrmRCGmaccont : Form
    {
        public FrmRCGmaccont()
        {
            InitializeComponent();
        }


        private CEnum.Message_Body[,] mServerInfo = null;
        private CSocketEvent m_ClientEvent = null;
        private CSocketEvent tmp_ClientEvent = null;

        private int iPageCount = 0;
        private bool bFirst = false;

        #region 自定义调用事件
        /// <summary>
        /// 创建类库中的窗体
        /// </summary>
        /// <param name="oParent">MDI 程序的父窗体</param>
        /// <param name="oSocket">Socket</param>
        /// <returns>类库中的窗体</returns>
        public Form CreateModule(object oParent, object oEvent)
        {
            //创建登录窗体
            FrmRCGmaccont mModuleFrm = new FrmRCGmaccont();
            mModuleFrm.m_ClientEvent = (CSocketEvent)oEvent;
            if (oParent != null)
            {
                mModuleFrm.MdiParent = (Form)oParent;
                mModuleFrm.Show();
            }
            else
            {
                mModuleFrm.ShowDialog();
            }

            return mModuleFrm;
        }
        #endregion

        #region 语言库
        /// <summary>
        ///　文字库
        /// </summary>
        ConfigValue config = null;

        /// <summary>
        /// 初始化华文字语言库
        /// </summary>
        private void IntiFontLib()
        {
            config = (ConfigValue)m_ClientEvent.GetInfo("INI");
            IntiUI();
        }

        private void IntiUI()
        {
       

        }


        #endregion

        #region
        private void FrmGmaccont_Load(object sender, EventArgs e)
        {
            try
            {
                IntiFontLib();
                comboBox1.SelectedIndex = 0;
                PnlPage.Visible = false;
                CEnum.Message_Body[] mContent = new CEnum.Message_Body[2];
                mContent[0].eName = CEnum.TagName.ServerInfo_GameDBID;
                mContent[0].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[0].oContent = 1;

                mContent[1].eName = CEnum.TagName.ServerInfo_GameID;
                mContent[1].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[1].oContent = m_ClientEvent.GetInfo("GameID_RC");

                this.backgroundWorkerFormLoad.RunWorkerAsync(mContent);
            }
            catch
            { }
        }
        #endregion

        #region
        private void backgroundWorkerFormLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            lock (typeof(C_Event.CSocketEvent))
            {
                mServerInfo = Operation_RCode.GetServerList(this.m_ClientEvent, (CEnum.Message_Body[])e.Argument);
            }
        }
        #endregion

        #region
        private void backgroundWorkerFormLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CmbServer = Operation_RCode.BuildCombox(mServerInfo, CmbServer);
        }
        #endregion

        #region
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (CmbServer.Text == "")
            {
                return;
            }

            BtnSearch.Enabled = false;
            this.RoleInfoView.DataSource = null;
            this.CmbPage.Items.Clear();
            CEnum.Message_Body[] mContent = new CEnum.Message_Body[5];

            mContent[0].eName = CEnum.TagName.RayCity_NyUserID;
            mContent[0].eTag = CEnum.TagFormat.TLV_STRING;
            mContent[0].oContent = TxtAccount.Text;

            mContent[1].eName = CEnum.TagName.RayCity_ServerIP;
            mContent[1].eTag = CEnum.TagFormat.TLV_STRING;
            mContent[1].oContent = Operation_RCode.GetItemAddr(mServerInfo, CmbServer.Text);

            if (checkBox1.Checked == true)
            {
                mContent[2].eName = CEnum.TagName.RayCity_AccountState;
                mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[2].oContent = 255;
            }
            else
            {
                mContent[2].eName = CEnum.TagName.RayCity_AccountState;
                mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[2].oContent = 999;
            }

            mContent[3].eName = CEnum.TagName.Index;
            mContent[3].eTag = CEnum.TagFormat.TLV_INTEGER;
            mContent[3].oContent = 1;

            mContent[4].eName = CEnum.TagName.PageSize;
            mContent[4].eTag = CEnum.TagFormat.TLV_INTEGER;
            mContent[4].oContent = Operation_RCode.iPageSize;

            backgroundWorkerSearch.RunWorkerAsync(mContent);


        }
        #endregion

        #region
        private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            lock (typeof(C_Event.CSocketEvent))
            {
                e.Result = Operation_RCode.GetResult(tmp_ClientEvent, CEnum.ServiceKey.RayCity_GMUser_Query, (CEnum.Message_Body[])e.Argument);
            }
        }
        #endregion

        #region
        private void backgroundWorkerSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnSearch.Enabled = true;
            CEnum.Message_Body[,] mResult = (CEnum.Message_Body[,])e.Result;
            if (mResult[0, 0].eName == CEnum.TagName.ERROR_Msg)
            {
                MessageBox.Show(mResult[0, 0].oContent.ToString());
                return;
            }

            Operation_RCode.BuildDataTable(this.m_ClientEvent, mResult, RoleInfoView, out iPageCount);

            if (iPageCount <= 1)
            {
                PnlPage.Visible = false;
            }
            else
            {
                for (int i = 0; i < iPageCount; i++)
                {
                    CmbPage.Items.Add(i + 1);
                }

                CmbPage.SelectedIndex = 0;
                bFirst = true;
                PnlPage.Visible = true;
            }
        }
        #endregion

        #region
        private void RoleInfoView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && RoleInfoView.DataSource != null)
            {
                using (DataTable dt = (DataTable)RoleInfoView.DataSource)
                {

                }
            }
            else
            {
                return;
            }
        }
        #endregion

        #region
        private void BtnActive_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                BtnActive.Enabled = false;
                CEnum.Message_Body[] mContent = new CEnum.Message_Body[4];

                mContent[0].eName = CEnum.TagName.RayCity_NyUserID;
                mContent[0].eTag = CEnum.TagFormat.TLV_STRING;
                mContent[0].oContent = textBox1.Text;

                mContent[1].eName = CEnum.TagName.RayCity_ServerIP;
                mContent[1].eTag = CEnum.TagFormat.TLV_STRING;
                mContent[1].oContent = Operation_RCode.GetItemAddr(mServerInfo, CmbServer.Text);

                mContent[2].eName = CEnum.TagName.UserByID;
                mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[2].oContent = int.Parse(m_ClientEvent.GetInfo("USERID").ToString());

                mContent[3].eName = CEnum.TagName.RayCity_AccountState;
                mContent[3].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[3].oContent = ReturnNum(comboBox1.Text);


                CEnum.Message_Body[,] result = Operation_RCode.GetResult(tmp_ClientEvent, CEnum.ServiceKey.RayCity_GMUser_Update, mContent);
                BtnActive.Enabled = true;
                if (result[0, 0].eName == CEnum.TagName.ERROR_Msg)
                {
                    MessageBox.Show(result[0, 0].oContent.ToString());
                    return;
                }
                else  if (result[0, 0].eName == CEnum.TagName.Status && result[0, 0].oContent.ToString() == "SUCCESS")
                {
                    MessageBox.Show("巨Θ");
                    //BtnSearch_Click(null, null);
                }
                else
                {
                    MessageBox.Show("巨ア毖┪眀腹ぃ");
                }
            }
            else
            {
                MessageBox.Show("叫块眀腹");

                return;
            }
        }
        #endregion

        #region
        private int ReturnNum(string strtxt)
        {
            int num = -1;
            if (strtxt == "開通GM帳?")
            {
                num = 255;
            }
            else if (strtxt == "關閉GM帳?")
            {
                num = 999;
            }
            else if (strtxt == "解封帳?")
            {
                num = 1;
            }

            else if (strtxt == "封停帳?")
            {
                num = 999;
            }

            return num;

        }
        #endregion

        #region
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }
        #endregion

        #region
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }
        #endregion

        #region
        private void CmbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bFirst)
            {
                CEnum.Message_Body[] mContent = new CEnum.Message_Body[5];

                mContent[0].eName = CEnum.TagName.RayCity_NyUserID;
                mContent[0].eTag = CEnum.TagFormat.TLV_STRING;
                mContent[0].oContent = TxtAccount.Text;

                mContent[1].eName = CEnum.TagName.RayCity_ServerIP;
                mContent[1].eTag = CEnum.TagFormat.TLV_STRING;
                mContent[1].oContent = Operation_RCode.GetItemAddr(mServerInfo, CmbServer.Text);

                if (checkBox1.Checked == true)
                {
                    mContent[2].eName = CEnum.TagName.RayCity_AccountState;
                    mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                    mContent[2].oContent = 255;
                }
                else
                {
                    mContent[2].eName = CEnum.TagName.RayCity_AccountState;
                    mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                    mContent[2].oContent = 999;
                }

                mContent[3].eName = CEnum.TagName.Index;
                mContent[3].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[3].oContent = int.Parse(CmbPage.Text);

                mContent[4].eName = CEnum.TagName.PageSize;
                mContent[4].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[4].oContent = Operation_RCode.iPageSize;

                backgroundWorkerSearch1.RunWorkerAsync(mContent);
            }
        }
        #endregion

        #region
        private void backgroundWorkerSearch1_DoWork(object sender, DoWorkEventArgs e)
        {
            lock (typeof(C_Event.CSocketEvent))
            {
                e.Result = Operation_RCode.GetResult(tmp_ClientEvent, CEnum.ServiceKey.RayCity_GMUser_Query, (CEnum.Message_Body[])e.Argument);
            }
        }
        #endregion

        #region
        private void backgroundWorkerSearch1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CEnum.Message_Body[,] mResult = (CEnum.Message_Body[,])e.Result;
            if (mResult[0, 0].eName == CEnum.TagName.ERROR_Msg)
            {
                MessageBox.Show(mResult[0, 0].oContent.ToString());
                return;
            }

            Operation_RCode.BuildDataTable(this.m_ClientEvent, mResult, RoleInfoView, out iPageCount);
        }
        #endregion

        #region
        private void CmbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmp_ClientEvent = m_ClientEvent.GetSocket(m_ClientEvent, Operation_RCode.GetItemAddr(mServerInfo, CmbServer.Text));
        }
        #endregion
    }
}