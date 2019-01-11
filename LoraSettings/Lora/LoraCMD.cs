using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoraTest_Slave
{

    /// <summary>
    /// Lora 指令集
    /// </summary>
    public class LoraCMD
    {

        /// <summary>
        /// 取得自己的Address
        /// </summary>
        public const string LoraGetMyAddr = "LoraGetMyAddr\r";

        /// <summary>
        /// 取得Lora Mode
        /// </summary>
        public const string LoraGetMode = "LoraGetMode\r";

        /// <summary>
        /// 取得SF
        /// </summary>
        public const string LoraGetSF = "LoraGetSF\r";

        /// <summary>
        /// 取得Power
        /// </summary>
        public const string LoraGetPower = "LoraGetPower\r";

        /// <summary>
        /// 取得Slave的節點，Master指令
        /// </summary>
        public const string LoraDumpSlaveNode = "LoraDumpSlaveNode\r";

        /// <summary>
        /// 取得各頻道頻率
        /// </summary>
        public const string LoraDumpChannelFreq = "LoraDumpChannelFreq\r";

        /// <summary>
        /// 加入Slave Node
        /// </summary>
        public const string LoraAddSlaveNode = "LoraAddSlaveNode ";

        /// <summary>
        /// 設定Lora Mode
        /// </summary>
        public const string LoraMode = "LoraMode ";

        /// <summary>
        /// 設定自己的Address
        /// </summary>
        public const string LoraSetMyAddr = "LoraSetMyAddr ";

        /// <summary>
        /// 設定GateWay的Address
        /// </summary>
        public const string LoraSetGateWayAddr = "LoraSetGateWayAddr ";

        /// <summary>
        /// 設定Slave Node Time Slot
        /// </summary>
        public const string LoraSetSlaveNodeSlot = "LoraSetSlaveNodeSlot ";

        /// <summary>
        /// 設定上傳的Time Slot
        /// </summary>
        public const string LoraSetUpLinkTimeSlot = "LoraSetUpLinkTimeSlot ";

        /// <summary>
        /// 設定SF(Spreading Factor)
        /// </summary>
        public const string LoraSetSF = "LoraSetSF ";

        /// <summary>
        /// 設定電源
        /// </summary>
        public const string LoraSetPower = "LoraSetPower ";

        /// <summary>
        /// 設定頻道頻率
        /// </summary>
        public const string LoraSetChannelFreq = "LoraSetChannelFreq ";

        /// <summary>
        /// 儲存頻道頻率設定
        /// </summary>
        public const string LoraSaveChannelFreq = "LoraSaveChannelFreq\r";

        /// <summary>
        /// 儲存Slave Node設定
        /// </summary>
        public const string LoraSaveSlaveNode = "LoraSaveSlaveNode ";

        /// <summary>
        /// 移除Slave節點
        /// </summary>
        public const string LoraRemoveSlaveNode = "LoraRemoveSlaveNode ";

        /// <summary>
        /// 設定跳頻
        /// </summary>
        public const string LoraFreqHop = "LoraFreqHop ";

        /// <summary>
        /// 測試模式，會固定傳送"AcSipTrain"給Master，Slave指令
        /// </summary>
        public const string LoraDemoDisable = "LoraDemoEnable 0\r";

        /// <summary>
        /// 打開Lora
        /// </summary>
        public const string LoraWorkEnable = "LoraStartWork ENABLE\r";

        /// <summary>
        /// 打開Lora
        /// </summary>
        public const string LoraWorkDisable = "LoraStartWork DISABLE\r";
    }
}
