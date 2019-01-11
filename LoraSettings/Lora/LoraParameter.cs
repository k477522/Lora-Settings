using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoraTest_Slave
{

    /// <summary>
    /// Lora 相關參數
    /// </summary>
    public static class LoraParameter
    {
        //Slot範圍 = ( 5 <= slot <= 16) || ( 21 <= slot <= 32 ) ， ( 1 , 2 , 3 , 4 , 17 , 18 , 19 , 20 ) 為 Free 通道

        /// <summary>
        /// 單通道含Free各組的設定參數
        /// </summary>
        private static int[] One_Slot_Free = { 0, 0, 0, 0, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 0, 0, 0, 0, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };

        /// <summary>
        /// 單通道各組的設定參數。
        /// </summary>
        private static int[] One_Slot = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };

        /// <summary>
        /// 雙通道各組的設定參數。
        /// </summary>
        private static int[,] Two_Slot = { { 5, 21 }, { 6, 22 }, { 7, 23 }, { 8, 24 }, { 9, 25 }, { 10, 26 }, { 11, 27 }, { 12, 28 }, { 13, 29 }, { 14, 30 }, { 15, 31 }, { 16, 32 } };

        /// <summary>
        /// 三通道各組的設定參數。
        /// </summary>
        private static int[,] Three_Slot = { { 5, 13, 25 }, { 6, 14, 26 }, { 7, 15, 27 }, { 8, 16, 28 }, { 9, 21, 29 }, { 10, 22, 30 }, { 11, 23, 31 }, { 12, 24, 32 } };

        /// <summary>
        /// 根據ID取得參數。ex: 第一組Slot = 0，第五組Slot = 5。
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int GetOne_Slot_Free(int ID)
        {
            //確認數值
            if (ID < 1)
            {
                return 0;
            }
            return One_Slot_Free[ID - 1];
        }

        /// <summary>
        /// 根據ID取得參數。ex: 第一組Slot = 5，第五組Slot = 9。
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int GetOne_Slot(int ID)
        {
            //確認數值
            if (ID < 1)
            {
                return 0;
            }
            return One_Slot[ID - 1];
        }

        /// <summary>
        /// 根據ID，通道索引取得參數。ex: 第一組Slot = [ 5 , 21 ] ，第五組Slot = [ 9 , 25 ]。
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="slotIndex"></param>
        /// <returns></returns>
        public static int GetTwo_Slot(int ID, int slotIndex)
        {
            //確認數值
            if (ID < 1 || slotIndex < 0 || slotIndex > 1)
            {
                return 0;
            }
            return Two_Slot[ID - 1, slotIndex];
        }

        /// <summary>
        /// 根據ID，通道索引取得參數。ex: 第一組Slot = [ 5 , 13 , 25 ] ，第五組Slot = [ 9 , 21 , 29 ]。
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="slotIndex"></param>
        /// <returns></returns>
        public static int GetThree_Slot(int ID, int slotIndex)
        {
            //確認數值
            if (ID < 1 || slotIndex < 0 || slotIndex > 2)
            {
                return 0;
            }
            return Three_Slot[ID - 1, slotIndex];
        }
    }
}
