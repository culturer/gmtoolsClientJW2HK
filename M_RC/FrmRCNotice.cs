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
    [C_Global.CModuleAttribute("鼠豢奪燴炵緙", "FrmRCNotice", "鼠豢奪燴馱撿", "RC Group")] 

    public partial class FrmRCNotice : Form
    {
        #region 曹講
        private CEnum.Message_Body[,] mServerInfo = null;
        private CEnum.Message_Body[,] mChannelInfo = null;
        private CSocketEvent tmp_ClientEvent = null;
        private CEnum.Message_Body[,] BroadInfo = null;
        private CEnum.Message_Body[,] mResult = null;
        private CSocketEvent m_ClientEvent = null;
        CEnum.Message_Body[,] GsResult = null;
        DataTable dgTable = new DataTable();
        private bool ischeck = false;
        private bool bFirst = false;
        private int iIndexID = 0;
        private int iBoardID = -1;
        private int iPageCount = 0;
        private string delIp = "";
        #endregion

        public FrmRCNotice()
        {
            InitializeComponent();

        }


        #region 斐膘敦极
        /// <summary>
        /// 斐膘濬踱笢腔敦极
        /// </summary>
        /// <param name="oParent">MDI 最唗腔虜敦极</param>
        /// <param name="oSocket">Socket</param>
        /// <returns>濬踱笢腔敦极</returns>
        public Form CreateModule(object oParent, object oEvent)
        {
            this.m_ClientEvent = (CSocketEvent)oEvent;
            if (oParent != null)
            {
                this.MdiParent = (Form)oParent;
                this.Show();
            }
            else
            {
                this.ShowDialog();
            }
            return this;
        }
        #endregion
        
        #region 場宎趙逄晟踱
        /// <summary>
        ///﹛恅趼踱
        /// </summary>
        ConfigValue config = null;

        /// <summary>
        /// 場宎趙貌恅趼逄晟踱
        /// </summary>
        private void IntiFontLib()
        {
            config = (ConfigValue)m_ClientEvent.GetInfo("INI");
            IntiUI();
        }

        private void IntiUI()
        {
            //this.Text = config.ReadConfigValue("MFj", "FN_UI_FrmNotice");
            //this.lblIp.Text = config.ReadConfigValue("MFj", "FN_UI_FrmlblIp");
            //lblserver.Text = config.ReadConfigValue("MFj", "FN_UI_Frmlblserver");
            //btnAllselect.Text = config.ReadConfigValue("MFj", "FN_UI_FrmbtnAllselect");
            //btnRecord.Text = config.ReadConfigValue("MFj", "FN_UI_FrmbtnRecord");
            //lblstart.Text = config.ReadConfigValue("MFj", "FN_UI_Frmlblstart");
            //lblend.Text = config.ReadConfigValue("MFj", "FN_UI_Frmlblend");

            //lblinv.Text = config.ReadConfigValue("MFj", "FN_UI_Frmlblinv");
            //lblConet.Text = config.ReadConfigValue("MFj", "FN_UI_FrmlblConet");
            //CheckStart.Text = config.ReadConfigValue("MFj", "FN_UI_FrmCheckStart");
            //CheckEnd.Text = config.ReadConfigValue("MFj", "FN_UI_FrmCheckEnd");
            //lblMin.Text = config.ReadConfigValue("MFj", "FN_UI_FrmlblMin");
            //btnAdd.Text = config.ReadConfigValue("MFj", "FN_UI_FrmbtnAdd");
            //BtnClear.Text = config.ReadConfigValue("MFj", "FN_UI_FrmBtnClear");


        }
        #endregion

        #region 湮靡備
        /// <summary>
        /// 耋靡備
        /// </summary>
        private void GetChannelList()
        {
            
           
            CEnum.Message_Body[] mContent = new CEnum.Message_Body[2];
            mContent[0].eName = CEnum.TagName.ServerInfo_GameDBID;
            mContent[0].eTag = CEnum.TagFormat.TLV_INTEGER;
            mContent[0].oContent = 1;

            mContent[1].eName = CEnum.TagName.ServerInfo_GameID;
            mContent[1].eTag = CEnum.TagFormat.TLV_INTEGER;
            mContent[1].oContent = m_ClientEvent.GetInfo("GameID_RC");

            lock (typeof(C_Event.CSocketEvent))
            {
                mChannelInfo = Operation_RCode.GetServerList(this.m_ClientEvent, mContent);
            }
            if (mChannelInfo[0, 0].eName == CEnum.TagName.ERROR_Msg)
            {
                MessageBox.Show(mChannelInfo[0, 0].oContent.ToString());
                return;
            }

            TxtCode.Items.Clear();
            for (int i = 0; i < mChannelInfo.GetLength(0); i++)
            {
                TxtCode.Items.Add(mChannelInfo[i, 1].oContent.ToString());
            }
            

            //tmp_ClientEvent = m_ClientEvent.GetSocket(m_ClientEvent, Operation_RCode.GetItemAddr(mChannelInfo, CmbServer.Text));

        }
        #endregion
        
        #region 腎翻敦极樓婥(腕善蚔牁督昢蹈桶)
        private void FrmRCNotice_Load(object sender, EventArgs e)
        {
            try
            {
                this.CheckCurSend.Checked = false;
                IntiFontLib();
                GetChannelList();
                this.DptEnd.Value = DateTime.Now.AddMinutes(5);
            }
            catch
            { }

        }
        #endregion

        #region 脤戙鼠豢暮翹
        /// <summary>
        /// 鼠豢暮翹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (this.TxtCode.CheckedItems.Count <= 0)
            {
                MessageBox.Show("請選擇要查詢的大區?");
                return;
            }

            GrdList.DataSource = null;
            
            DataTable dtResult = null;
            bool newTable = true;
            
            for (int i = 0; i < TxtCode.CheckedItems.Count; i++)
            {
                string serverIp = Operation_RCode.GetItemAddr(mChannelInfo, TxtCode.CheckedItems[i].ToString());
                CEnum.Message_Body[] mContent = new CEnum.Message_Body[1];
                mContent[0].eName = CEnum.TagName.RayCity_ServerIP;
                mContent[0].eTag = CEnum.TagFormat.TLV_STRING;
                mContent[0].oContent = serverIp;

                CEnum.Message_Body[,] mResult = null;
                lock (typeof(C_Event.CSocketEvent))
                {
                    mResult = Operation_RCode.GetResult(m_ClientEvent, CEnum.ServiceKey.RayCity_BoardList_Query, mContent);
                }
                if (mResult[0, 0].eName == CEnum.TagName.ERROR_Msg)
                {
                    //MessageBox.Show(mResult[0, 0].oContent.ToString());
                    break;
                }
                CEnum.Message_Body[,] mResult2 = new CEnum.Message_Body[mResult.GetLength(0),mResult.GetLength(1)+1];
                for (int k = 0; k < mResult2.GetLength(0); k++)
                {
                    for (int j = 0; j < mResult2.GetLength(1); j++)
                    {
                        if (j == mResult2.GetLength(1) - 1)
                        {
                            mResult2[k, j].eName = CEnum.TagName.RayCity_ServerIP;
                            mResult2[k, j].eTag = CEnum.TagFormat.TLV_STRING;
                            mResult2[k, j].oContent = serverIp;
                        }
                        else
                        {
                            mResult2[k, j].eName = mResult[k, j].eName;
                            mResult2[k, j].eTag = mResult[k, j].eTag;
                            mResult2[k, j].oContent = mResult[k, j].oContent;

                        }
                    }
                }

                DataTable table = Operation_RCode.GetDataTable(this.m_ClientEvent, mResult2, out iPageCount);
                if (newTable)
                {
                    dtResult = table;
                    newTable = false;
                }
                else
                {
                    dtResult.Merge(table);
                }
                
            }
            if (dtResult == null)
            {
                MessageBox.Show("公告记录不存在！");
            }
            else
            {
                GrdList.DataSource = dtResult;
            }
        }
        #endregion

        #region 氝樓鼠豢暮翹陓洘
        /// <summary>
        /// 氝樓鼠豢陓洘囀
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {

            //if (CheckSin.Checked == false && CheckSendAll.Checked == false && CheckAll.Checked == false)
            //{
            //    MessageBox.Show("恁寁紱釬濬倰");
            //    return;
            //}
            if (this.TxtCode.CheckedItems.Count<=0)
            {
                MessageBox.Show("請選擇大區 ！");

                return;
            }

            if(TxtConnet.Text == "" || TxtConnet.Text == null)
            {
                MessageBox.Show("請先填寫公告內容");
                return;
            }

            if (TxtConnet.Text.Length>500)
            {
                MessageBox.Show("公告內容不能超過500個字");
                return;
            }
            //if (CheckCurSend.Checked == false && NumMinnute.Value < 5)
            //{
            //    MessageBox.Show(config.ReadConfigValue("MAU", "FN_Code_MsgConnet1"));
            //    return;
            //}

            if (MessageBox.Show("確認添加公告？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                bool isSuccess = true;
                for (int i = 0; i < TxtCode.CheckedItems.Count; i++)
                {
                    CEnum.Message_Body[] mContent = new CEnum.Message_Body[6];
                    if (CheckCurSend.Checked == true)
                    {
                        mContent[0].eName = CEnum.TagName.RayCity_BeginDate;
                        mContent[0].eTag = CEnum.TagFormat.TLV_TIMESTAMP;
                        mContent[0].oContent = DateTime.Now.AddMinutes(-2);


                        mContent[1].eName = CEnum.TagName.RayCity_EndDate;
                        mContent[1].eTag = CEnum.TagFormat.TLV_TIMESTAMP;
                        mContent[1].oContent = DateTime.Now.AddMinutes(2);


                        mContent[2].eName = CEnum.TagName.RayCity_Interval;
                        mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                        mContent[2].oContent = 1;
                    }
                    else
                    {
                        mContent[0].eName = CEnum.TagName.RayCity_BeginDate;
                        mContent[0].eTag = CEnum.TagFormat.TLV_TIMESTAMP;
                        mContent[0].oContent = DptStart.Value;


                        mContent[1].eName = CEnum.TagName.RayCity_EndDate;
                        mContent[1].eTag = CEnum.TagFormat.TLV_TIMESTAMP;
                        mContent[1].oContent = DptEnd.Value;


                        mContent[2].eName = CEnum.TagName.RayCity_Interval;
                        mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                        mContent[2].oContent = Convert.ToInt32(NumMinnute.Value);
                    }


                    mContent[3].eName = CEnum.TagName.RayCity_Message;
                    mContent[3].eTag = CEnum.TagFormat.TLV_STRING;
                    mContent[3].oContent = TxtConnet.Text.Trim();

                    mContent[4].eName = CEnum.TagName.UserByID;
                    mContent[4].eTag = CEnum.TagFormat.TLV_INTEGER;
                    mContent[4].oContent = int.Parse(m_ClientEvent.GetInfo("USERID").ToString());

                    mContent[5].eName = CEnum.TagName.RayCity_ServerIP;
                    mContent[5].eTag = CEnum.TagFormat.TLV_STRING;
                    mContent[5].oContent = Operation_RCode.GetItemAddr(mChannelInfo, TxtCode.CheckedItems[i].ToString());

                    CEnum.Message_Body[,] mResult1 = null;
                    lock (typeof(C_Event.CSocketEvent))
                    {
                        mResult1 = mResult = Operation_RCode.GetResult(m_ClientEvent, CEnum.ServiceKey.RayCity_BoardList_Insert, mContent);
                    }
                    if (mResult1[0, 0].eName == CEnum.TagName.ERROR_Msg)
                    {
                        MessageBox.Show(mResult1[0, 0].oContent.ToString());
                        return;
                    }

                    if (mResult1[0, 0].eName == CEnum.TagName.Status && mResult1[0, 0].oContent.Equals("FAILURE"))
                    {
                        isSuccess = false;//MessageBox.Show(config.ReadConfigValue("MSDO", "FN_Code_addfail"));
                    }
                    else
                    {
                        //MessageBox.Show(config.ReadConfigValue("MSDO", "FN_Code_addsucces"));

                    }
                }

                if (isSuccess)
                { MessageBox.Show("公告添加成功!"); }
                else
                { MessageBox.Show("公告添加失敗!"); }
            }
            


        }
        #endregion

        #region 恁寁楷冞鼠豢腔湮陓洘

        #region 恁寁垀衄湮
        //private void CheckAll_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (CheckAll.Checked == true)
        //    {
        //        SetListUI();
        //    }

        //}
        //#endregion

        //#region 恁寁等跺湮
        //private void CheckSin_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (CheckSin.Checked == true)
        //    {
        //        SetSinListUI();
        //    }

        //}
        //#endregion

        //#region 恁寁等跺湮奀腔蹈桶陓洘
        //private void SetSinListUI()
        //{
        //    CmbServer.Enabled = true;
        //    CheckSin.Checked = true;
        //    CheckAll.Checked = false;
            
        //    TxtCode.Items.Clear();

        //}
        //#endregion

        //#region 恁寁楷冞
        //private void CheckSendAll_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (CheckSendAll.Checked == true)
        //    {
        //        CheckSin.Enabled = false;
        //        CheckAll.Enabled = false;
        //        CheckSin.Checked = false;
        //        CheckAll.Checked = false;
        //        TxtCode.Items.Clear();
        //        CmbServer.Enabled = false;
        //    }
        //    else
        //    {
        //        CheckSin.Enabled = true;
        //        CheckAll.Enabled = true;
        //        CmbServer.Enabled = true;
        //    }
        //}
        #endregion

        #region 恁寁蹈桶笢腔垀衄蚔牁督昢
        private void button2_Click(object sender, EventArgs e)
        {
            if (ischeck == true)
            {
                for (int i = 0; i < TxtCode.Items.Count; i++)
                {
                    TxtCode.SetItemChecked(i, false);

                }
                ischeck = false;
            }
            else if (ischeck == false)
            {
                for (int i = 0; i < TxtCode.Items.Count; i++)
                {
                    TxtCode.SetItemChecked(i, true);
                }
                ischeck = true;
            }

        }
        #endregion

        #endregion

        #region 党蜊鼠豢暮翹陓洘
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認修改公告?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {


                CEnum.Message_Body[] mContent = new CEnum.Message_Body[3];

                //mContent[0].eName = CEnum.TagName.AU_Status;
                //mContent[0].eTag = CEnum.TagFormat.TLV_INTEGER;
                //mContent[0].oContent = ReturnStauas(cmbStauas.Text.Trim());

                //mContent[1].eName = CEnum.TagName.AU_BoardMessage;
                //mContent[1].eTag = CEnum.TagFormat.TLV_STRING;
                //mContent[1].oContent = TxtConnet.Text.Trim();

                mContent[0].eName = CEnum.TagName.UserByID;
                mContent[0].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[0].oContent = int.Parse(m_ClientEvent.GetInfo("USERID").ToString());

                mContent[1].eName = CEnum.TagName.RayCity_ServerIP;
                mContent[1].eTag = CEnum.TagFormat.TLV_STRING;
                mContent[1].oContent = delIp;

                //mContent[4].eName = CEnum.TagName.AU_BeginTime;
                //mContent[4].eTag = CEnum.TagFormat.TLV_TIMESTAMP;
                //mContent[4].oContent = DptStart.Value;

                //mContent[5].eName = CEnum.TagName.AU_EndTime;
                //mContent[5].eTag = CEnum.TagFormat.TLV_TIMESTAMP;
                //mContent[5].oContent = DptEnd.Value;

                //mContent[6].eName = CEnum.TagName.AU_Interval;
                //mContent[6].eTag = CEnum.TagFormat.TLV_INTEGER;
                //mContent[6].oContent = Convert.ToInt32(NumMinnute.Value);

                mContent[2].eName = CEnum.TagName.RayCity_NoticeID;
                mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[2].oContent = iBoardID;


                CEnum.Message_Body[,] mResult1 = Operation_RCode.GetResult(m_ClientEvent, CEnum.ServiceKey.RayCity_BoardList_Delete, mContent);

                if (mResult1[0, 0].eName == CEnum.TagName.ERROR_Msg)
                {
                    MessageBox.Show(mResult1[0, 0].oContent.ToString());
                    return;
                }

                if (mResult1[0, 0].eName == CEnum.TagName.Status && mResult1[0, 0].oContent.Equals("FAILURE"))
                {
                    MessageBox.Show("修改失敗");
                    return;
                }
                else
                {
                    MessageBox.Show("修改成功");
                    cmbStauas.Visible = false;
                    label11.Visible = false;

                    BtnEdit.Visible = false;
                    btnAdd.Visible = true;

                    Setdefault();

                    btnAdd.Enabled = true;
                    btnAdd.Visible = true;



                    lblserver.Visible = false;
                    ////cmbStauas.Visible = false;

                    DptStart.Enabled = true;
                    DptEnd.Enabled = true;
                    TxtConnet.Enabled = true;
                    NumMinnute.Enabled = true;
                }
            }
        }
        #endregion



        #region 邧僻鼠豢陓洘輛俴刉壺ㄗ帤妗珋ㄘ
        private void GrdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    iIndexID = e.RowIndex;
            //    DataTable mBoardInfo = (DataTable)GrdList.DataSource;

            //    if (mBoardInfo.Rows.Count > 0)
            //    {
            //        iBoardID = int.Parse(mBoardInfo.Rows[iIndexID][0].ToString());
            //    }
            //    if (MessageBox.Show(config.ReadConfigValue("MFj", "FN_Code_msgaddnotice"), config.ReadConfigValue("MFj", "FN_Code_msgnote"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            //    {
            //        CEnum.Message_Body[] mContent = new CEnum.Message_Body[3];

            //        mContent[0].eName = CEnum.TagName.FJ_ServerIP;
            //        mContent[0].eTag = CEnum.TagFormat.TLV_STRING;
            //        mContent[0].oContent = Operation_FJ.GetItemAddr(mChannelInfo, CmbServer.Text);

            //        mContent[1].eName = CEnum.TagName.FJ_MsgID;
            //        mContent[1].eTag = CEnum.TagFormat.TLV_INTEGER;
            //        mContent[1].oContent = iBoardID;

            //        mContent[2].eName = CEnum.TagName.UserByID;
            //        mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
            //        mContent[2].oContent = int.Parse(m_ClientEvent.GetInfo("USERID").ToString());

            //        CEnum.Message_Body[,] mResult = null;
            //        lock (typeof(C_Event.CSocketEvent))
            //        {
            //            mResult = Operation_FJ.GetResult(tmp_ClientEvent, CEnum.ServiceKey.FJ_BoardList_Delete, mContent);
            //        }
            //        if (mResult[0, 0].eName == CEnum.TagName.ERROR_Msg)
            //        {
            //            MessageBox.Show(mResult[0, 0].oContent.ToString());
            //            return;
            //        }
            //        if (mResult[0, 0].eName == CEnum.TagName.Status && mResult[0, 0].oContent.Equals("FAILURE"))
            //        {
            //            MessageBox.Show(config.ReadConfigValue("MFj", "FQA_Code_RelateDelFailed"));
            //        }
            //        else
            //        {
            //            MessageBox.Show(config.ReadConfigValue("MFj", "FQA_Code_RelateDelSuccess"));


            //            GrdList.DataSource = null;
            //            CEnum.Message_Body[] MbContent = new CEnum.Message_Body[1];

            //            MbContent[0].eName = CEnum.TagName.FJ_ServerIP;
            //            MbContent[0].eTag = CEnum.TagFormat.TLV_STRING;
            //            MbContent[0].oContent = Operation_FJ.GetItemAddr(mChannelInfo, CmbServer.Text);

            //            CEnum.Message_Body[,] QResult = null;
            //            lock (typeof(C_Event.CSocketEvent))
            //            {
            //                QResult = Operation_FJ.GetResult(tmp_ClientEvent, CEnum.ServiceKey.FJ_BoardList_Query, MbContent);
            //            }
            //            if (QResult[0, 0].eName == CEnum.TagName.ERROR_Msg)
            //            {
            //                MessageBox.Show(QResult[0, 0].oContent.ToString());
            //                return;
            //            }
            //            Operation_FJ.BuildDataTable(this.m_ClientEvent, QResult, GrdList, out iPageCount);

                       
            //        }

            //    }

            //}
            //catch
            //{ }
        }
        #endregion



        #region 秏紱釬
        private void button1_Click(object sender, EventArgs e)
        {
            Setdefault();
            btnAdd.Enabled = true;
            btnAdd.Visible = true;



            lblserver.Visible = false;
            ////cmbStauas.Visible = false;

            DptStart.Enabled = true;
            DptEnd.Enabled = true;
            TxtConnet.Enabled = true;
            NumMinnute.Enabled = true;
            BtnEdit.Visible = false;
            label11.Visible = false;
            cmbStauas.Visible = false;


        }
        #endregion



        #region 撿极腔妗珋滲杅
        
        #region 閥葩蘇硉
        /// <summary>
        /// 閥葩蘇硉
        /// </summary>
        private void Setdefault()
        {   
            DptStart.Value = DateTime.Now;
            DptEnd.Value = DateTime.Now;
            NumMinnute.Value = 10;
            TxtConnet.Clear();
            for (int i = 0; i < TxtCode.Items.Count; i++)
            {
                TxtCode.SetItemChecked(i, false);

            }

            ischeck = false;

        }
        #endregion
        
        #region 殿隙蚚","煦賃腔督昢趼睫揹
        /// <summary>
        /// 殿隙蚚","煦賃腔督昢趼睫揹
        /// </summary>
        /// <returns>ip趼睫揹</returns>
        private string ReturnSeverIP(CEnum.Message_Body[,] mbody)
        {
            ArrayList ServerNames = new ArrayList();
            ArrayList Serverips = new ArrayList();
            string Strseverip = null;

            for (int i = 0; i < TxtCode.CheckedItems.Count; i++)
            {

                ServerNames.Add(TxtCode.CheckedItems[i].ToString());

            }
            for (int i = 0; i < ServerNames.Count; i++)
            {
                Serverips.Add(Operation_RCode.GetItemAddr(mbody, ServerNames[i].ToString()));
            }

            for (int i = 0; i < Serverips.Count; i++)
            {
                Strseverip = Serverips[i].ToString() + "," + Strseverip;
            }

            return Strseverip;
        }
        #endregion

        #region 殿隙Gsip
        private string ReturnGsip(CEnum.Message_Body[,] mbody)
        {
            ArrayList ServerNames = new ArrayList();
            ArrayList Serverips = new ArrayList();
            string Strseverip = "";

            for (int i = 0; i < TxtCode.CheckedItems.Count; i++)
            {

                ServerNames.Add(TxtCode.CheckedItems[i].ToString());

            }
            for (int i = 0; i < ServerNames.Count; i++)
            {
                Serverips.Add(Operation_RCode.GetGsip(mbody, ServerNames[i].ToString()));
            }

            for (int i = 0; i < Serverips.Count; i++)
            {
                Strseverip = Serverips[i].ToString() + "," + Strseverip;
                
            }

            return Strseverip;
        }
        #endregion

        #region 數呾楷冞棒杅
        /// <summary>
        /// 數呾楷冞棒杅
        /// </summary>
        /// <returns></returns>
        private int Getcishu()
        {   


                int intcishu = Convert.ToInt32(NumMinnute.Value);

                int noticeMin = Convert.ToInt32((DptEnd.Value - DptStart.Value).TotalMinutes);

                int txtcishu = noticeMin / intcishu;

                return txtcishu;
 


        }
        #endregion

        #region 等僻鼠豢暮翹輛俴恁寁
        private void GrdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iIndexID = e.RowIndex;
                DataTable mBoardInfo = (DataTable)GrdList.DataSource;
                
                if (mBoardInfo.Rows.Count > 0)
                {
                    iBoardID = int.Parse(mBoardInfo.Rows[iIndexID][0].ToString());
                }
            }
            catch
            { }
        }
        #endregion

        #region 殿隙袨怓陓洘

        private int ReturnStauas(string strStauas)
        {
           int IntStauas = -1;
           if (strStauas == "未發送".Trim())
            {
                IntStauas = 0;
            }
            else if (strStauas == "發送中".Trim())
            {
                IntStauas = 2;
            }
            else if (strStauas == "已發送".Trim())
            {
                IntStauas = 1;
            }

            return IntStauas;
        }

        private string ReturnStauas(int intStauas)
        {
            string Stauas = null;
            switch (intStauas)
            {
                case 0:
                    Stauas = "未發送";
                    break;
                case 2 :
                    Stauas = "發送中";
                    break;
                case 1:
                    Stauas = "已發送";
                    break;
            }
            return Stauas;
        }

        #endregion

        #region 遙蚔牁督昢
        private void CmbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (bFirst)
            //{
            //    TxtCode.Items.Clear();
            //    CEnum.Message_Body[] mContent = new CEnum.Message_Body[1];

            //    mContent[0].eName = CEnum.TagName.AU_ServerIP;
            //    mContent[0].eTag = CEnum.TagFormat.TLV_STRING;
            //    mContent[0].oContent = Operation_RCode.GetItemAddr(mChannelInfo, CmbServer.Text);

                
            //    lock (typeof(C_Event.CSocketEvent))
            //    {
            //        GsResult = Operation_RCode.GetResult(tmp_ClientEvent, CEnum.ServiceKey., mContent);
            //    }
            //    if (GsResult[0, 0].eName == CEnum.TagName.ERROR_Msg)
            //    {
            //        MessageBox.Show(GsResult[0, 0].oContent.ToString());
            //        return;
            //    }
            //    for (int i = 0; i < GsResult.GetLength(0); i++)
            //    {
            //        TxtCode.Items.Add(GsResult[i, 0].oContent.ToString());
            //    }
            //}

        }
        #endregion

        #region 督昢蹈桶氝樓善TxtCode笢
        /// <summary>
        /// 督昢蹈桶氝樓善TxtCode笢
        /// </summary>
        private void SetListUI()
        {
            try
            {
                //CmbServer.Enabled = false;
                //CheckSin.Checked = false;
                //CheckAll.Checked = true;

                TxtCode.Items.Clear();
                for (int i = 0; i < mChannelInfo.GetLength(0); i++)
                {
                    TxtCode.Items.Add(mChannelInfo[i, 1].oContent.ToString());
                }
            }
            catch
            { }
        }
        #endregion

        private void ItmDelete_Click(object sender, EventArgs e)
        {
            //btnAdd.Enabled = false;
            //btnAdd.Visible = false;

            //BtnEdit.Enabled = true;
            //BtnEdit.Visible = true;

            //label11.Visible = true;
            //cmbStauas.Visible = true;
            DataTable mBoard = (DataTable)GrdList.DataSource;
            iBoardID = int.Parse(mBoard.Rows[iIndexID][0].ToString());
            delIp = mBoard.Rows[iIndexID][mBoard.Columns.Count - 1].ToString();
            if (MessageBox.Show("確認修改公告?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {


                CEnum.Message_Body[] mContent = new CEnum.Message_Body[3];

                //mContent[0].eName = CEnum.TagName.AU_Status;
                //mContent[0].eTag = CEnum.TagFormat.TLV_INTEGER;
                //mContent[0].oContent = ReturnStauas(cmbStauas.Text.Trim());

                //mContent[1].eName = CEnum.TagName.AU_BoardMessage;
                //mContent[1].eTag = CEnum.TagFormat.TLV_STRING;
                //mContent[1].oContent = TxtConnet.Text.Trim();

                mContent[0].eName = CEnum.TagName.UserByID;
                mContent[0].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[0].oContent = int.Parse(m_ClientEvent.GetInfo("USERID").ToString());

                mContent[1].eName = CEnum.TagName.RayCity_ServerIP;
                mContent[1].eTag = CEnum.TagFormat.TLV_STRING;
                mContent[1].oContent = delIp;

                //mContent[4].eName = CEnum.TagName.AU_BeginTime;
                //mContent[4].eTag = CEnum.TagFormat.TLV_TIMESTAMP;
                //mContent[4].oContent = DptStart.Value;

                //mContent[5].eName = CEnum.TagName.AU_EndTime;
                //mContent[5].eTag = CEnum.TagFormat.TLV_TIMESTAMP;
                //mContent[5].oContent = DptEnd.Value;

                //mContent[6].eName = CEnum.TagName.AU_Interval;
                //mContent[6].eTag = CEnum.TagFormat.TLV_INTEGER;
                //mContent[6].oContent = Convert.ToInt32(NumMinnute.Value);

                mContent[2].eName = CEnum.TagName.RayCity_NoticeID;
                mContent[2].eTag = CEnum.TagFormat.TLV_INTEGER;
                mContent[2].oContent = iBoardID;


                CEnum.Message_Body[,] mResult1 = Operation_RCode.GetResult(m_ClientEvent, CEnum.ServiceKey.RayCity_BoardList_Delete, mContent);

                if (mResult1[0, 0].eName == CEnum.TagName.ERROR_Msg)
                {
                    MessageBox.Show(mResult1[0, 0].oContent.ToString());
                    return;
                }

                if (mResult1[0, 0].eName == CEnum.TagName.Status && mResult1[0, 0].oContent.Equals("FAILURE"))
                {
                    MessageBox.Show("修改失敗");
                    return;
                }
                else
                {
                    MessageBox.Show("修改成功");
                    //cmbStauas.Visible = false;
                    //label11.Visible = false;

                    //BtnEdit.Visible = false;
                    //btnAdd.Visible = true;

                    Setdefault();

                    btnAdd.Enabled = true;
                    btnAdd.Visible = true;



                    lblserver.Visible = false;
                    //////cmbStauas.Visible = false;

                    DptStart.Enabled = true;
                    DptEnd.Enabled = true;
                    TxtConnet.Enabled = true;
                    NumMinnute.Enabled = true;
                }
            }
            //if (mBoard.Rows[iIndexID][4].ToString() == config.ReadConfigValue("MSDO", "FN_Code_infostate"))
            //{
            //    MessageBox.Show(config.ReadConfigValue("MSDO", "FN_Code_noticefail"));
            //    return;
            //}
            //if (mBoard.Rows[iIndexID][4].ToString() == config.ReadConfigValue("MSDO", "FN_Code_infostate1"))
            //{
            //    iBoardID = int.Parse(mBoard.Rows[iIndexID][0].ToString());
            //    DptStart.Text = mBoard.Rows[iIndexID][1].ToString();
            //    DptEnd.Text = mBoard.Rows[iIndexID][2].ToString();
            //    cmbStauas.Text = mBoard.Rows[iIndexID][4].ToString();
            //    TxtConnet.Text = mBoard.Rows[iIndexID][5].ToString();
            //    delIp = mBoard.Rows[iIndexID][mBoard.Columns.Count - 1].ToString();
            //}
            //else if (mBoard.Rows[iIndexID][4].ToString() == config.ReadConfigValue("MSDO", "FN_Code_infostate2"))
            //{
            //    iBoardID = int.Parse(mBoard.Rows[iIndexID][0].ToString());
            //    DptStart.Text = mBoard.Rows[iIndexID][1].ToString();
            //    DptStart.Enabled = false;
            //    DptEnd.Text = mBoard.Rows[iIndexID][2].ToString();
            //    DptEnd.Enabled = false;
            //    cmbStauas.Text = mBoard.Rows[iIndexID][4].ToString();
            //    TxtConnet.Text = mBoard.Rows[iIndexID][5].ToString();
            //    TxtConnet.Enabled = false;
            //    NumMinnute.Value = Convert.ToDecimal(mBoard.Rows[iIndexID][3].ToString());
            //    NumMinnute.Enabled = false;
            //    delIp = mBoard.Rows[iIndexID][mBoard.Columns.Count - 1].ToString();

            //}

        }

        #region 扢隅蕾撈楷冞奀腔羲宎奀潔﹜賦旰奀潔睿奀潔潔路
        private void CheckCurSend_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCurSend.Checked == true)
            {
                DptStart.Enabled = false;
                DptEnd.Enabled = false;
                NumMinnute.Enabled = false;
            }
            else
            {
                DptStart.Enabled = true;
                DptEnd.Enabled = true;
                NumMinnute.Enabled = true;
            }
        }
        #endregion

      

        #endregion

    }
}