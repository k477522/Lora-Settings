using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace LoraTest_Slave
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// 委派
        /// </summary>
        /// <param name="ShowFunction"></param>
        private delegate void DataShow(string ShowFunction);

        /// <summary>
        /// 委派物件
        /// </summary>
        private DataShow dataShow;

        /// <summary>
        /// 指令歷史紀錄
        /// </summary>
        private List<string> HistoryCmd = new List<string>();

        /// <summary>
        /// 指令歷史紀錄索引索引
        /// </summary>
        private int HistoryIndex = 0;

        /// <summary>
        /// 指令集
        /// </summary>
        List<string> WriteSeq = new List<string>();

        /// <summary>
        /// Slot通道模式
        /// </summary>
        private SlotPassage Passage = SlotPassage.One_Slot_Free;

        /// <summary>
        /// LoraMode模式
        /// </summary>
        private Mode mode = Mode.MASTER;

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        private bool ErrorMsg = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表單載入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //顯示/隱藏按鈕
            EnableBtn(false);
            //設定Comport選項
            SetComport();
            //設定Slot通道選項
            SetSlotPassage();
            //建立委派的物件
            dataShow = new DataShow(ShowCMD);
            //輸入對話框聚焦
            TB_CmdToSend.Focus();
        }

        /// <summary>
        /// 顯示/隱藏按鈕
        /// </summary>
        /// <param name="enable"></param>
        private void EnableBtn(bool enable)
        {
            Btn_Demo.Visible = enable;
            Btn_Pld.Visible = enable;
            Btn_Enable.Visible = enable;
            Btn_Disable.Visible = enable;
            Btn_DumpSlave.Visible = enable;
            Btn_DumpFreq.Visible = enable;
            Btn_RemoveSlave.Visible = enable;
            Btn_GetMyAddr.Visible = enable;
            Btn_GetMode.Visible = enable;
            Btn_GetSF.Visible = enable;
            Btn_GetPower.Visible = enable;
            Btn_Send.Enabled = enable;
            TB_CmdToSend.Enabled = enable;
        }

        /// <summary>
        /// 設定Comport選項
        /// </summary>
        private void SetComport()
        {
            //清除所有項目
            CB_Comport.Items.Clear();
            //遍歷所有序列埠
            foreach (string name in SerialPort.GetPortNames())
            {
                //將入項目
                CB_Comport.Items.Add(name);
            }
            //設定預設選項
            CB_Comport.SelectedIndex = 0;
        }

        /// <summary>
        /// 設定Slot 通道選項
        /// </summary>
        private void SetSlotPassage()
        {
            //遍歷所有Slot通道模式
            foreach (string name in Enum.GetNames(typeof(SlotPassage)))
            {
                //加入選項
                CB_Passage.Items.Add(name);
            }
            //設定通道預設選項
            CB_Passage.SelectedIndex = 0;
        }

        /// <summary>
        /// 根據Mode設定專屬指令
        /// </summary>
        /// <param name="mode"></param>
        private void SetModeSettings(Mode mode)
        {
            //設定目前LoraMode
            this.mode = mode;
            //設定字串
            Btn_Mode.Text = mode.ToString();
            //設定字串
            GB_Mode.Text = mode.ToString();
            //切換Mode
            switch (mode)
            {
                //Master
                case Mode.MASTER:
                    //改為SlaveNode
                    Lab_Addr.Text = "SlaveNode";
                    //打開AutoAddSlaveNode
                    Lab_AutoCount.Visible = true;
                    NUD_AutoCount.Visible = true;
                    //根據定義開發該Address欄位
                    tbSlaveAddr1.Enabled = false;
                    tbSlaveAddr2.Enabled = true;
                    tbSlaveAddr3.Enabled = false;
                    tbSlaveAddr1.Text = "0";
                    tbSlaveAddr3.Text = "0";
                    //隱藏Slot設定
                    Lab_Slot.Visible = false;
                    tbSlaveSlot1.Visible = false;
                    tbSlaveSlot2.Visible = false;
                    tbSlaveSlot3.Visible = false;
                    //設定個專屬按鈕
                    Btn_DumpSlave.Visible = true;
                    Btn_Demo.Visible = false;
                    break;
                //Slave
                case Mode.SLAVE:
                    //改為GateWayAddr
                    Lab_Addr.Text = "GateWayAddr";
                    //關閉AutoAddSlaveNode
                    Lab_AutoCount.Visible = false;
                    NUD_AutoCount.Visible = false;
                    //根據定義開發該Address欄位
                    tbSlaveAddr1.Enabled = true;
                    tbSlaveAddr2.Enabled = false;
                    tbSlaveAddr3.Enabled = false;
                    tbSlaveAddr2.Text = "0";
                    tbSlaveAddr3.Text = "0";
                    //顯示Slot設定
                    Lab_Slot.Visible = true;
                    tbSlaveSlot1.Visible = true;
                    tbSlaveSlot2.Visible = true;
                    tbSlaveSlot3.Visible = true;
                    //設定個專屬按鈕
                    Btn_DumpSlave.Visible = false;
                    Btn_Demo.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// 序列埠清單打開時，重新掃描序列埠
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Comport_DropDown(object sender, EventArgs e)
        {
            //設定comport選項
            SetComport();
        }

        /// <summary>
        /// LoraMode變更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetObj_ModeChange(object sender, Mode e)
        {
            SetModeSettings(e);
        }

        /// <summary>
        /// 接收資料事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //有資料時
            while ((sender as SerialPort).BytesToRead > 0)
            {
                //觸發委派，處理接受資料
                Invoke(dataShow, (sender as SerialPort).ReadLine());
            }
        }

        /// <summary>
        /// 顯示接收資料
        /// </summary>
        /// <param name="s">資料</param>
        private void ShowCMD(string s)
        {
            //無資料
            if (s == "")
            {
                //訊息視窗換行
                RTB_ReciveData.AppendText("\r\n");
            }
            //有資料
            else
            {
                //根據資料字串改變顯示顏色
                //ERROR
                if (s.Contains("ERROR"))
                {
                    //設定下一個字串顏色
                    RTB_ReciveData.SelectionColor = Color.Red;
                    //有錯誤訊息
                    ErrorMsg = true;
                }
                else if (s.Contains(">>"))
                {
                    //設定下一個字串顏色
                    RTB_ReciveData.SelectionColor = Color.Lime;
                }
                //預設
                else
                {
                    //設定下一個字串顏色
                    RTB_ReciveData.SelectionColor = Color.Aqua;
                }
                //訊息視窗顯示時間+資料
                RTB_ReciveData.AppendText(DateTime.Now.ToString("HH:mm:ss") + "\t" + s + "\r\n");
                //分析訊息
                LoraHandle.GetObj.Read(s);
            }
            //設定選取點
            RTB_ReciveData.SelectionStart = RTB_ReciveData.Text.Length;
            //捲動卷軸至選取點
            RTB_ReciveData.ScrollToCaret();
        }

        /// <summary>
        /// 連線按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            //輸入框聚焦
            TB_CmdToSend.Focus();
            //無Comport
            if (CB_Comport.SelectedIndex < 0)
            {
                return;
            }
            //切換啟用/不啟用
            Btn_Connect.Status = !Btn_Connect.Status;
            string portName = CB_Comport.SelectedItem.ToString();
            //ON
            if (Btn_Connect.Status)
            {
                //設定程式標題
                ShowCMD("");
                ShowCMD(string.Format("Connect to \"{0}\"", portName));
                this.Text = "M/S_Edit..........Connection";
                //關閉序列埠選取功能
                CB_Comport.Enabled = false;
                //連接序列埠
                LoraHandle.GetObj.Connect(portName, SerialPort_DataReceived);
                //掛載Mode變更事件
                LoraHandle.GetObj.ModeChange += GetObj_ModeChange;
                //取得LoraMode
                Btn_GetMode_Click(this, null);
                //打開功能按鈕
                EnableBtn(true);
                //Master、Slave設定畫面顯示
                Panel_M_S_Setting.Show();
            }
            //OFF
            else
            {
                //設定程式標題
                ShowCMD("");
                ShowCMD(string.Format("Disconnect from \"{0}\"", portName));
                this.Text = "M/S_Edit..........Disconnection";
                //打開序列埠選取功能
                CB_Comport.Enabled = true;
                //斷開序列埠
                LoraHandle.GetObj.DisConnect(SerialPort_DataReceived);
                //關閉功能按鈕
                EnableBtn(false);
                //Master、Slave設定畫面隱藏
                Panel_M_S_Setting.Hide();
            }
        }

        /// <summary>
        /// 切換Lora模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Mode_Click(object sender, EventArgs e)
        {
            //目前Lora模式
            switch (this.mode)
            {
                //Master
                case Mode.MASTER:
                    //切換成Slave
                    SetModeSettings(Mode.SLAVE);
                    break;
                //Slave
                case Mode.SLAVE:
                    //切換成Master
                    SetModeSettings(Mode.MASTER);
                    break;
            }
            //寫入指令
            Write(LoraCMD.LoraMode + string.Format("{0}\r", this.mode.ToString()));
        }

        /// <summary>
        /// 取得Address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_GetMyAddr_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraGetMyAddr);
        }

        /// <summary>
        /// 取得Lora Mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_GetMode_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraGetMode);
        }

        /// <summary>
        /// 取得SF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_GetSF_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraGetSF);
        }

        /// <summary>
        /// 取得電源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_GetPower_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraGetPower);
        }

        /// <summary>
        /// 打開連線
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Enable_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraWorkEnable);
        }

        /// <summary>
        /// 關閉連線
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Disable_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraWorkDisable);
        }

        /// <summary>
        /// Master  取得 Slave清單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DumpSlave_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraDumpSlaveNode);
        }

        /// <summary>
        /// 取得頻率清單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DumpFreq_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraDumpChannelFreq);
        }

        /// <summary>
        /// Slave專用，測試模式，會固定傳送"AcSipTrain"給Master
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Demo_Click(object sender, EventArgs e)
        {
            //寫入指令
            Write(LoraCMD.LoraDemoDisable);
        }

        /// <summary>
        /// 移除所有Slave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_RemoveSlave_Click(object sender, EventArgs e)
        {
            //清除指令集
            WriteSeq.Clear();
            //輸入框聚焦
            TB_CmdToSend.Focus();
            //遍歷所有Slave(32個)
            for (int i = 1; i <= 32; i++)
            {
                //加入移除Slave指令
                WriteSeq.Add(LoraCMD.LoraRemoveSlaveNode + i + "\r");
            }
            //開啟自動寫入功能
            Open_Auto_Write();
        }

        /// <summary>
        /// 傳送資料按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Pld_Click(object sender, EventArgs e)
        {
            //建立資料輸入視窗
            PldForm pldForm = new PldForm(this.mode);
            //掛載資料輸入事件
            pldForm.SendData += PldForm_SendData;
            //顯示強制回應視窗
            pldForm.ShowDialog();
        }

        /// <summary>
        /// Pld傳送資料事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PldForm_SendData(object sender, string e)
        {
            //根據Lora Mode
            switch (this.mode)
            {
                //MASTER
                case Mode.MASTER:
                    LoraHandle.GetObj.Write("LoraMasterPld " + e);
                    break;
                //SLAVE
                case Mode.SLAVE:
                    LoraHandle.GetObj.Write("LoraSlavePld " + e);
                    break;
            }
        }

        /// <summary>
        /// 傳送指令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Send_Click(object sender, EventArgs e)
        {
            //聚焦輸入框
            TB_CmdToSend.Focus();
            //取得輸入的指令
            string cmd = TB_CmdToSend.Text;
            //沒有輸入指令
            if (cmd == "")
            {
                return;
            }
            //輸入的指令加入換行
            cmd = cmd + "\r\r\n";
            //顯示指令
            ShowCMD("");
            ShowCMD(cmd);
            //寫入指令
            LoraHandle.GetObj.Write(cmd);
            //將指令加入歷史紀錄
            HistoryCmd.Add(TB_CmdToSend.Text);
            //設定指令歷史紀錄索引
            HistoryIndex = HistoryCmd.Count - 1;
            //清空輸入框
            TB_CmdToSend.Text = "";
        }

        /// <summary>
        /// 輸入框按鍵事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_CmdToSend_KeyDown(object sender, KeyEventArgs e)
        {
            //有指令的歷史紀錄時
            if (HistoryCmd.Count > 0)
            {
                //向上鍵
                if (e.KeyData == Keys.Up)
                {
                    //索引-1
                    HistoryIndex--;
                    //小於索引
                    if (HistoryIndex < 0)
                    {
                        //設定為第一個
                        HistoryIndex = 0;
                    }
                    //設定輸入框指令
                    TB_CmdToSend.Text = HistoryCmd[HistoryIndex];
                }
                //向下鍵
                else if (e.KeyData == Keys.Down)
                {
                    //索引+1
                    HistoryIndex++;
                    //大於索引
                    if (HistoryIndex > HistoryCmd.Count - 1)
                    {
                        //設定為最後一個
                        HistoryIndex = HistoryCmd.Count - 1;
                    }
                    //設定輸入框指令
                    TB_CmdToSend.Text = HistoryCmd[HistoryIndex];
                }
            }
        }

        /// <summary>
        /// 設定Master參數
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SetMaster_Click(object sender, EventArgs e)
        {
            //Address未輸入
            if (tbMasterAddr1.Text == "" || tbMasterAddr2.Text == "" || tbMasterAddr3.Text == "")
            {
                //顯示訊息
                MessageBox.Show("Master Addr Err!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //頻率未設定
            if (tbFreq.Text == "")
            {
                //顯示訊息
                MessageBox.Show("Master Freq Err!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //清除指令集
            WriteSeq.Clear();
            //SetMyAddr
            WriteSeq.Add(LoraCMD.LoraSetMyAddr + string.Format("{0} {1} {2}\r", tbMasterAddr1.Text, tbMasterAddr2.Text, tbMasterAddr3.Text));
            //SetFreqHop
            WriteSeq.Add(LoraCMD.LoraFreqHop + string.Format("{0}\r", NUD_Hop.Value));
            //SetChannelFreq
            WriteSeq.Add(LoraCMD.LoraSetChannelFreq + string.Format("{0} {1}\r", 0, tbFreq.Text));
            //SaveChannelFreq
            WriteSeq.Add(LoraCMD.LoraSaveChannelFreq);
            //SetSF
            WriteSeq.Add(LoraCMD.LoraSetSF + string.Format("{0}\r", NUD_SF.Value));
            //SetPower
            WriteSeq.Add(LoraCMD.LoraSetPower + string.Format("{0}\r", NUD_Pow.Value));
            //開啟自動寫入功能
            Open_Auto_Write();
        }

        /// <summary>
        /// 自動加入Slave按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAutoAddSlave_Click(object sender, EventArgs e)
        {
            //清除指令集
            WriteSeq.Clear();
            //根據不同Lora Mode自動設定
            switch (this.mode)
            {
                //AutoAddSlaveNode
                case Mode.MASTER:
                    //加入移除所有Slave的指令，預先移除所有Slave避免加入時發生重複錯誤。
                    for (int i = 1; i <= 32; i++)
                    {
                        //加入指令
                        WriteSeq.Add(LoraCMD.LoraRemoveSlaveNode + i + "\r");
                    }
                    //新增指定數量的Slave
                    for (int ID = 1; ID <= Convert.ToInt32(NUD_AutoCount.Value); ID++)
                    {
                        //Add Slave : LoraAddSlaveNode addr2 addr1 addr0
                        WriteSeq.Add(LoraCMD.LoraAddSlaveNode + string.Format("0 {0} {1}\r", tbSlaveAddr2.Text, ID));
                        //根據不同通道去設定Slot
                        switch (Passage)
                        {
                            //單通道含Free
                            case SlotPassage.One_Slot_Free:
                                //Slot非0則設定Slot，0則是Free 通道，不需設定
                                if (LoraParameter.GetOne_Slot_Free(ID) != 0)
                                {
                                    //Set Slot : LoraSetSlaveNodeSlot NodeID slot1
                                    WriteSeq.Add(LoraCMD.LoraSetSlaveNodeSlot + string.Format("{0} {1}\r", ID, LoraParameter.GetOne_Slot_Free(ID)));
                                }
                                break;
                            //單通道不含Free
                            case SlotPassage.One_Slot:
                                //Set Slot : LoraSetSlaveNodeSlot NodeID slot1
                                WriteSeq.Add(LoraCMD.LoraSetSlaveNodeSlot + string.Format("{0} {1}\r", ID, LoraParameter.GetOne_Slot(ID)));
                                break;
                            //雙通道
                            case SlotPassage.Two_Slot:
                                //Set Slot : LoraSetSlaveNodeSlot NodeID slot1 slot2
                                WriteSeq.Add(LoraCMD.LoraSetSlaveNodeSlot + string.Format("{0} {1} {2}\r", ID, LoraParameter.GetTwo_Slot(ID, 0), LoraParameter.GetTwo_Slot(ID, 1)));
                                break;
                            //三通道
                            case SlotPassage.Three_Slot:
                                //Set Slot : LoraSetSlaveNodeSlot NodeID slot1 slot2 slot3
                                WriteSeq.Add(LoraCMD.LoraSetSlaveNodeSlot + string.Format("{0} {1} {2} {3}\r", ID, LoraParameter.GetThree_Slot(ID, 0), LoraParameter.GetThree_Slot(ID, 1), LoraParameter.GetThree_Slot(ID, 2)));
                                break;
                        }
                        //Save Slave : LoraSaveSlaveNode NodeID
                        WriteSeq.Add(LoraCMD.LoraSaveSlaveNode + string.Format("{0}\r", ID));
                    }
                    break;

                //GateWay&Slot
                case Mode.SLAVE:
                    //設定GateWayAddress
                    WriteSeq.Add(LoraCMD.LoraSetGateWayAddr + string.Format("{0} 0 0\r", tbSlaveAddr1.Text));
                    switch (this.Passage)
                    {
                        //Free通道
                        case SlotPassage.One_Slot_Free:
                            //設定UpLinkTimeSlot。0 , 0 , 0
                            WriteSeq.Add(LoraCMD.LoraSetUpLinkTimeSlot + string.Format("0 0 0\r"));
                            break;
                        //單通道不含Free
                        case SlotPassage.One_Slot:
                            //設定UpLinkTimeSlot。slot1
                            WriteSeq.Add(LoraCMD.LoraSetUpLinkTimeSlot + string.Format("{0}\r", tbSlaveSlot1.Text));
                            break;
                        //雙通道
                        case SlotPassage.Two_Slot:
                            //設定UpLinkTimeSlot。slo1 ，slot2
                            WriteSeq.Add(LoraCMD.LoraSetUpLinkTimeSlot + string.Format("{0} {1}\r", tbSlaveSlot1.Text, tbSlaveSlot2.Text));
                            break;
                        //三通道
                        case SlotPassage.Three_Slot:
                            //設定UpLinkTimeSlot。slot1 ， slot2 ， slot3
                            WriteSeq.Add(LoraCMD.LoraSetUpLinkTimeSlot + string.Format("{0} {1} {2}\r", tbSlaveSlot1.Text, tbSlaveSlot2.Text, tbSlaveSlot3.Text));
                            break;
                    }
                    break;
            }
            //開啟自動寫入功能
            Open_Auto_Write();
        }

        /// <summary>
        /// 設定Time Slot通道數。(Address所使用的Time Slot數量)單通道:1:1、雙通道1:2、三通道:1:3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Passage_TextChanged(object sender, EventArgs e)
        {
            //設定Slot通道
            this.Passage = (SlotPassage)CB_Passage.SelectedIndex;
            //根據通道
            switch (this.Passage)
            {
                //單通道含Free
                case SlotPassage.One_Slot_Free:
                    // Max: 32 Address、1 Address : 1 Time Slot、8 Free
                    NUD_AutoCount.Maximum = 32;
                    tbSlaveSlot1.Enabled = false;
                    tbSlaveSlot2.Enabled = false;
                    tbSlaveSlot3.Enabled = false;
                    tbSlaveSlot1.Text = "0";
                    tbSlaveSlot2.Text = "0";
                    tbSlaveSlot3.Text = "0";
                    break;
                //單通道不含Free
                case SlotPassage.One_Slot:
                    //Max: 24 Address、1 Address : 1 Time Slot
                    NUD_AutoCount.Maximum = 24;
                    tbSlaveSlot1.Enabled = true;
                    tbSlaveSlot2.Enabled = false;
                    tbSlaveSlot3.Enabled = false;
                    tbSlaveSlot2.Text = "0";
                    tbSlaveSlot3.Text = "0";
                    break;
                //雙通道
                case SlotPassage.Two_Slot:
                    //Max: 12 Address、1 Address : 2 Time Slot
                    NUD_AutoCount.Maximum = 12;
                    tbSlaveSlot1.Enabled = true;
                    tbSlaveSlot2.Enabled = true;
                    tbSlaveSlot3.Enabled = false;
                    tbSlaveSlot3.Text = "0";
                    break;
                //三通道
                case SlotPassage.Three_Slot:
                    //Max: 8 Address、 1 Address : 3 Time Slot
                    NUD_AutoCount.Maximum = 8;
                    tbSlaveSlot1.Enabled = true;
                    tbSlaveSlot2.Enabled = true;
                    tbSlaveSlot3.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// 開啟自動寫入功能
        /// </summary>
        private void Open_Auto_Write()
        {
            //關閉視窗操作
            this.Enabled = false;
            //設定進度條的最大值為指令數量
            Bar_Write.Maximum = WriteSeq.Count;
            //顯示進度條
            Bar_Write.Visible = true;
            //開啟自動寫入計時器
            Timer_Write.Start();
        }

        /// <summary>
        /// 關閉自動寫入功能
        /// </summary>
        private void Close_Auto_Write()
        {
            //啟用視窗操作
            this.Enabled = true;
            //設定進度條的進度為0
            Bar_Write.Value = 0;
            //顯示進度條
            Bar_Write.Visible = false;
            //開啟自動寫入計時器
            Timer_Write.Stop();
        }

        /// <summary>
        /// 每一段指定時間，寫入指令。目前設定為200ms。(若是時間太快，導致寫入頻率太快會導致Lora當機)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Write_Tick(object sender, EventArgs e)
        {
            //有指令
            if (WriteSeq.Count > 0)
            {
                //寫入指令
                LoraHandle.GetObj.Write(WriteSeq[0]);
                //刪除以寫入指令
                WriteSeq.RemoveAt(0);
                //增加進度條
                Bar_Write.PerformStep();
            }
            else
            {
                //關閉自動寫入功能
                Close_Auto_Write();
                //寫入訊息視窗
                ShowCMD("");
                //寫入訊息視窗
                ShowCMD("------------------------------------------------------Set Finish-----------------------------------------------------");
                //如果有錯誤訊息
                if (ErrorMsg == true)
                {
                    //顯示訊息
                    MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorMsg = false;
                }
                //正常訊息
                else
                {
                    //顯示訊息
                    MessageBox.Show("Set Finish", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 將指令寫入
        /// </summary>
        /// <param name="cmd"></param>
        private void Write(string cmd)
        {
            ShowCMD("");
            ShowCMD(cmd + "\r\n");
            //聚焦輸入框
            TB_CmdToSend.Focus();
            //寫入指令
            LoraHandle.GetObj.Write(cmd);
        }

        /// <summary>
        /// Form關閉時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //斷開序列埠
            LoraHandle.GetObj.DisConnect(SerialPort_DataReceived);
        }
    }
}
