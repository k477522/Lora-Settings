using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoraTest_Slave
{
    public class LoraHandle
    {

        private static readonly Lazy<LoraHandle> instance = new Lazy<LoraHandle>(() => new LoraHandle());
        public static LoraHandle GetObj
        {
            get
            {
                return instance.Value;
            }
        }
        private LoraHandle()
        {
        }

        /// <summary>
        /// Lora Mode變更事件
        /// </summary>
        public event EventHandler<Mode> ModeChange;

        /// <summary>
        /// 序列埠物件
        /// </summary>
        private SerialPort sp;

        /// <summary>
        /// 連線序列埠
        /// </summary>
        /// <param name="port">序列埠名稱名稱</param>
        /// <param name="eventHandle">資料接收事件</param>
        public void Connect(string port, SerialDataReceivedEventHandler eventHandle)
        {
            //建立序列埠物件
            sp = new SerialPort(port, 115200, Parity.None, 8, StopBits.One);
            //掛載資料接收事件
            sp.DataReceived += eventHandle;
            //打開序列埠
            sp.Open();
        }

        /// <summary>
        /// 斷開序列埠
        /// </summary>
        /// <param name="eventHandle">資料接收事件</param>
        public void DisConnect(SerialDataReceivedEventHandler eventHandle)
        {
            //有序列埠物件
            if (sp != null)
            {
                //卸載資料接收事件
                sp.DataReceived -= eventHandle;
                //關閉序列埠
                sp.Close();
                //釋放資源
                sp.Dispose();
            }
        }

        /// <summary>
        /// 將字串寫入序列埠
        /// </summary>
        /// <param name="cmd">指令字串</param>
        public void Write(string cmd)
        {
            //序列埠未打開
            if (!sp.IsOpen)
            {
                return;
            }
            //寫入
            sp.Write(cmd);
        }

        /// <summary>
        /// 讀取訊息
        /// </summary>
        /// <param name="msg">字串訊息</param>
        public void Read(string msg)
        {
            //該訊息為Lora回傳字串
            if (msg.Contains("ans"))
            {
                //根據=分割
                string ans = msg.Split('=').Last();
                //取得Lora Mode
                if (msg.Contains("LoraMode"))
                {
                    Mode mode = Mode.MASTER;
                    //Master
                    if (ans == " MASTER")
                    {
                        mode = Mode.MASTER;
                    }
                    //Slave
                    else
                    {
                        mode = Mode.SLAVE;
                    }
                    ModeChange?.Invoke(this, mode);
                }
            }
        }
    }
}
