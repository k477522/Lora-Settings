using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoraTest_Slave
{
    public partial class PldForm : Form
    {

        /// <summary>
        /// 傳送資料事件
        /// </summary>
        public event EventHandler<string> SendData;

        /// <summary>
        /// Lora Mode
        /// </summary>
        private Mode mode;

        public PldForm(Mode mode)
        {
            InitializeComponent();
            //設定Slave Event Mode選項
            SetSlaveEventModeItems();
            //根據Lora Mode 設定選向
            SetModeSettings(mode);
            //設定mode
            this.mode = mode;
        }

        /// <summary>
        /// 設定Slave Event Mode選項
        /// </summary>
        private void SetSlaveEventModeItems()
        {
            //清除選項
            CB_SE_Mode.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                //加入選項
                CB_SE_Mode.Items.Add((SlaveEventMode)i);
            }
            //設定預設選項
            CB_SE_Mode.SelectedIndex = 0;
        }

        /// <summary>
        /// 根據Lora Mode 設定選向
        /// </summary>
        /// <param name="mode"></param>
        private void SetModeSettings(Mode mode)
        {
            //根據Lora Mode
            switch (mode)
            {
                //MASTER
                case Mode.MASTER:
                    Lab_SE_Mode.Hide();
                    CB_SE_Mode.Hide();
                    Lab_NodeAddr.Show();
                    NUD_Addr1.Show();
                    NUD_Addr2.Show();
                    NUD_Addr3.Show();
                    break;
                //SLAVE
                case Mode.SLAVE:
                    Lab_SE_Mode.Show();
                    CB_SE_Mode.Show();
                    Lab_NodeAddr.Hide();
                    NUD_Addr1.Hide();
                    NUD_Addr2.Hide();
                    NUD_Addr3.Hide();
                    break;
            }
        }

        /// <summary>
        /// 傳送按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Send_Click(object sender, EventArgs e)
        {
            string data = string.Empty;
            //根據Lora Mode
            switch (this.mode)
            {
                //MASTER
                case Mode.MASTER:
                    data = string.Format("{0} {1} {2} {3}\r", NUD_Addr1.Value, NUD_Addr2.Value, NUD_Addr3.Value, TB_Data.Text);
                    break;
                //SLAVE
                case Mode.SLAVE:
                    data = string.Format("{0} {1}\r", CB_SE_Mode.SelectedIndex, TB_Data.Text);
                    break;
            }
            //觸發資料傳送事件
            SendData?.Invoke(this, data);
            //關閉視窗
            this.Close();
        }
    }
}
