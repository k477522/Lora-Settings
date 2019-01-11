using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoraTest_Slave
{

    /// <summary>
    /// 自訂切換開關
    /// </summary>
    public partial class SwitchButton : Button
    {

        /// <summary>
        /// 狀態
        /// </summary>
        private bool status = false;

        /// <summary>
        /// 狀態
        /// </summary>
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                if (value)
                {
                    //設定文本
                    this.Text = "OFF";
                    //設定顏色
                    this.BackColor = Color.Red;
                }
                else
                {
                    //設定文本
                    this.Text = "ON";
                    //設定顏色
                    this.BackColor = Color.Green;
                }
            }
        }

        public SwitchButton()
        {
            InitializeComponent();
        }
    }
}
