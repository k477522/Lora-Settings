namespace LoraTest_Slave
{

    /// <summary>
    /// Slot通道模式
    /// </summary>
    public enum SlotPassage : int
    {

        /// <summary>
        /// 單通道含Free，每個Address 占用 1 個Slot ，包含 Free，Max Address = 32
        /// </summary>
        One_Slot_Free = 0,

        /// <summary>
        /// 單通道不含Free，每個Address 占用 1 個Slot  ，不包含 Free，Max Address = 24
        /// </summary>
        One_Slot = 1,

        /// <summary>
        /// 雙通道，每個Address 占用 2 個Slot，Max Address = 12
        /// </summary>
        Two_Slot = 2,

        /// <summary>
        /// 三通道，每個Address 占用 3 個Slot ，Max Address = 8
        /// </summary>
        Three_Slot = 3,
    }

    /// <summary>
    /// Lora模式
    /// </summary>
    public enum Mode : int
    {

        /// <summary>
        /// Master
        /// </summary>
        MASTER = 0,

        /// <summary>
        /// Slave
        /// </summary>
        SLAVE = 1
    }

    /// <summary>
    /// Slave 事件模式
    /// </summary>
    public enum SlaveEventMode : int
    {

        /// <summary>
        /// 下一個傳輸為設定的節點。For regular nodes, booking slots, Tx on fixed slots.
        /// </summary>
        Regular = 0,

        /// <summary>
        /// 下一個傳輸為設定的節點或是空的Free。For free nodes, nonbooking slots, Tx on UTX1 and UTX2 slots.For regular nodes, booking slots, Tx on nearest slots, including UTX1, UTX2 and booking slots
        /// </summary>
        Free = 1,

        /// <summary>
        /// 下一個傳輸為任何空的節點。For a l l nodes, Tx on any s l o t s when urgent issue occurs. This mode has impact on others nodes.
        /// </summary>
        Urgent = 2,
    }
}
