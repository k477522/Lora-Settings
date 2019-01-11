namespace LoraTest_Slave
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TB_CmdToSend = new System.Windows.Forms.TextBox();
            this.Btn_Enable = new System.Windows.Forms.Button();
            this.Btn_Disable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Connect = new LoraTest_Slave.SwitchButton();
            this.Btn_Demo = new System.Windows.Forms.Button();
            this.Panel_M_S_Setting = new System.Windows.Forms.Panel();
            this.TLP_M_Set = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Settings = new System.Windows.Forms.GroupBox();
            this.TLP_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.NUD_Hop = new System.Windows.Forms.NumericUpDown();
            this.NUD_SF = new System.Windows.Forms.NumericUpDown();
            this.Btn_SetMaster = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMasterAddr1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMasterAddr3 = new System.Windows.Forms.TextBox();
            this.tbMasterAddr2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFreq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NUD_Pow = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Mode = new System.Windows.Forms.Button();
            this.GB_Mode = new System.Windows.Forms.GroupBox();
            this.TLP_Mode_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.NUD_AutoCount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btAutoAddSlave = new System.Windows.Forms.Button();
            this.Lab_Addr = new System.Windows.Forms.Label();
            this.Lab_AutoCount = new System.Windows.Forms.Label();
            this.tbSlaveAddr1 = new System.Windows.Forms.TextBox();
            this.tbSlaveAddr2 = new System.Windows.Forms.TextBox();
            this.tbSlaveAddr3 = new System.Windows.Forms.TextBox();
            this.tbSlaveSlot3 = new System.Windows.Forms.TextBox();
            this.Lab_Slot = new System.Windows.Forms.Label();
            this.tbSlaveSlot2 = new System.Windows.Forms.TextBox();
            this.tbSlaveSlot1 = new System.Windows.Forms.TextBox();
            this.CB_Passage = new System.Windows.Forms.ComboBox();
            this.Timer_Write = new System.Windows.Forms.Timer(this.components);
            this.Btn_DumpFreq = new System.Windows.Forms.Button();
            this.Btn_DumpSlave = new System.Windows.Forms.Button();
            this.TLP_Left = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_GetMyAddr = new System.Windows.Forms.Button();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.CB_Comport = new System.Windows.Forms.ComboBox();
            this.Btn_RemoveSlave = new System.Windows.Forms.Button();
            this.Btn_GetMode = new System.Windows.Forms.Button();
            this.Btn_GetSF = new System.Windows.Forms.Button();
            this.Btn_GetPower = new System.Windows.Forms.Button();
            this.Bar_Write = new System.Windows.Forms.ProgressBar();
            this.Btn_Pld = new System.Windows.Forms.Button();
            this.RTB_ReciveData = new System.Windows.Forms.RichTextBox();
            this.Panel_M_S_Setting.SuspendLayout();
            this.TLP_M_Set.SuspendLayout();
            this.GB_Settings.SuspendLayout();
            this.TLP_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Pow)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_Mode.SuspendLayout();
            this.TLP_Mode_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AutoCount)).BeginInit();
            this.TLP_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_CmdToSend
            // 
            this.TLP_Left.SetColumnSpan(this.TB_CmdToSend, 7);
            this.TB_CmdToSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_CmdToSend.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CmdToSend.Location = new System.Drawing.Point(3, 663);
            this.TB_CmdToSend.Name = "TB_CmdToSend";
            this.TB_CmdToSend.Size = new System.Drawing.Size(938, 25);
            this.TB_CmdToSend.TabIndex = 1;
            this.TB_CmdToSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_CmdToSend_KeyDown);
            // 
            // Btn_Enable
            // 
            this.Btn_Enable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Enable.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enable.Location = new System.Drawing.Point(798, 3);
            this.Btn_Enable.Name = "Btn_Enable";
            this.Btn_Enable.Size = new System.Drawing.Size(143, 29);
            this.Btn_Enable.TabIndex = 2;
            this.Btn_Enable.Text = "Enable";
            this.Btn_Enable.UseVisualStyleBackColor = true;
            this.Btn_Enable.Click += new System.EventHandler(this.Btn_Enable_Click);
            // 
            // Btn_Disable
            // 
            this.Btn_Disable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Disable.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Disable.Location = new System.Drawing.Point(947, 3);
            this.Btn_Disable.Name = "Btn_Disable";
            this.Btn_Disable.Size = new System.Drawing.Size(150, 29);
            this.Btn_Disable.TabIndex = 3;
            this.Btn_Disable.Text = "Disable";
            this.Btn_Disable.UseVisualStyleBackColor = true;
            this.Btn_Disable.Click += new System.EventHandler(this.Btn_Disable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.BackColor = System.Drawing.Color.Green;
            this.TLP_Left.SetColumnSpan(this.Btn_Connect, 2);
            this.Btn_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Connect.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Connect.Location = new System.Drawing.Point(3, 38);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(193, 29);
            this.Btn_Connect.Status = false;
            this.Btn_Connect.TabIndex = 7;
            this.Btn_Connect.Text = "ON";
            this.Btn_Connect.UseVisualStyleBackColor = false;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Btn_Demo
            // 
            this.Btn_Demo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Demo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Demo.Location = new System.Drawing.Point(798, 38);
            this.Btn_Demo.Name = "Btn_Demo";
            this.Btn_Demo.Size = new System.Drawing.Size(143, 29);
            this.Btn_Demo.TabIndex = 9;
            this.Btn_Demo.Text = "SlaveDemo";
            this.Btn_Demo.UseVisualStyleBackColor = true;
            this.Btn_Demo.Click += new System.EventHandler(this.Btn_Demo_Click);
            // 
            // Panel_M_S_Setting
            // 
            this.Panel_M_S_Setting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_M_S_Setting.Controls.Add(this.TLP_M_Set);
            this.Panel_M_S_Setting.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_M_S_Setting.Location = new System.Drawing.Point(1100, 0);
            this.Panel_M_S_Setting.Name = "Panel_M_S_Setting";
            this.Panel_M_S_Setting.Size = new System.Drawing.Size(250, 730);
            this.Panel_M_S_Setting.TabIndex = 11;
            this.Panel_M_S_Setting.Visible = false;
            // 
            // TLP_M_Set
            // 
            this.TLP_M_Set.ColumnCount = 1;
            this.TLP_M_Set.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_M_Set.Controls.Add(this.GB_Settings, 0, 1);
            this.TLP_M_Set.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TLP_M_Set.Controls.Add(this.GB_Mode, 0, 2);
            this.TLP_M_Set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_M_Set.Location = new System.Drawing.Point(0, 0);
            this.TLP_M_Set.Name = "TLP_M_Set";
            this.TLP_M_Set.RowCount = 4;
            this.TLP_M_Set.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_M_Set.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.TLP_M_Set.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.TLP_M_Set.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_M_Set.Size = new System.Drawing.Size(248, 728);
            this.TLP_M_Set.TabIndex = 17;
            // 
            // GB_Settings
            // 
            this.GB_Settings.Controls.Add(this.TLP_Settings);
            this.GB_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Settings.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Settings.Location = new System.Drawing.Point(3, 53);
            this.GB_Settings.Name = "GB_Settings";
            this.GB_Settings.Size = new System.Drawing.Size(242, 244);
            this.GB_Settings.TabIndex = 16;
            this.GB_Settings.TabStop = false;
            this.GB_Settings.Text = "Settings";
            // 
            // TLP_Settings
            // 
            this.TLP_Settings.ColumnCount = 4;
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Settings.Controls.Add(this.NUD_Hop, 1, 1);
            this.TLP_Settings.Controls.Add(this.NUD_SF, 1, 3);
            this.TLP_Settings.Controls.Add(this.Btn_SetMaster, 0, 5);
            this.TLP_Settings.Controls.Add(this.label3, 0, 0);
            this.TLP_Settings.Controls.Add(this.tbMasterAddr1, 1, 0);
            this.TLP_Settings.Controls.Add(this.label7, 0, 4);
            this.TLP_Settings.Controls.Add(this.tbMasterAddr3, 3, 0);
            this.TLP_Settings.Controls.Add(this.tbMasterAddr2, 2, 0);
            this.TLP_Settings.Controls.Add(this.label6, 0, 3);
            this.TLP_Settings.Controls.Add(this.label4, 0, 1);
            this.TLP_Settings.Controls.Add(this.tbFreq, 1, 2);
            this.TLP_Settings.Controls.Add(this.label5, 0, 2);
            this.TLP_Settings.Controls.Add(this.NUD_Pow, 1, 4);
            this.TLP_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Settings.Location = new System.Drawing.Point(3, 28);
            this.TLP_Settings.Name = "TLP_Settings";
            this.TLP_Settings.RowCount = 7;
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Settings.Size = new System.Drawing.Size(236, 213);
            this.TLP_Settings.TabIndex = 0;
            // 
            // NUD_Hop
            // 
            this.TLP_Settings.SetColumnSpan(this.NUD_Hop, 3);
            this.NUD_Hop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUD_Hop.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Hop.Location = new System.Drawing.Point(62, 38);
            this.NUD_Hop.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Hop.Name = "NUD_Hop";
            this.NUD_Hop.Size = new System.Drawing.Size(171, 25);
            this.NUD_Hop.TabIndex = 16;
            this.NUD_Hop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUD_SF
            // 
            this.TLP_Settings.SetColumnSpan(this.NUD_SF, 3);
            this.NUD_SF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUD_SF.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_SF.Location = new System.Drawing.Point(62, 108);
            this.NUD_SF.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_SF.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUD_SF.Name = "NUD_SF";
            this.NUD_SF.Size = new System.Drawing.Size(171, 25);
            this.NUD_SF.TabIndex = 16;
            this.NUD_SF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_SF.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Btn_SetMaster
            // 
            this.TLP_Settings.SetColumnSpan(this.Btn_SetMaster, 4);
            this.Btn_SetMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_SetMaster.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SetMaster.Location = new System.Drawing.Point(3, 178);
            this.Btn_SetMaster.Name = "Btn_SetMaster";
            this.Btn_SetMaster.Size = new System.Drawing.Size(230, 29);
            this.Btn_SetMaster.TabIndex = 24;
            this.Btn_SetMaster.Text = "Set";
            this.Btn_SetMaster.UseVisualStyleBackColor = true;
            this.Btn_SetMaster.Click += new System.EventHandler(this.Btn_SetMaster_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "MyAddr:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMasterAddr1
            // 
            this.tbMasterAddr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMasterAddr1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMasterAddr1.Location = new System.Drawing.Point(62, 3);
            this.tbMasterAddr1.Name = "tbMasterAddr1";
            this.tbMasterAddr1.Size = new System.Drawing.Size(53, 25);
            this.tbMasterAddr1.TabIndex = 2;
            this.tbMasterAddr1.Text = "0";
            this.tbMasterAddr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pow:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMasterAddr3
            // 
            this.tbMasterAddr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMasterAddr3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMasterAddr3.Location = new System.Drawing.Point(180, 3);
            this.tbMasterAddr3.Name = "tbMasterAddr3";
            this.tbMasterAddr3.Size = new System.Drawing.Size(53, 25);
            this.tbMasterAddr3.TabIndex = 13;
            this.tbMasterAddr3.Text = "0";
            this.tbMasterAddr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMasterAddr2
            // 
            this.tbMasterAddr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMasterAddr2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMasterAddr2.Location = new System.Drawing.Point(121, 3);
            this.tbMasterAddr2.Name = "tbMasterAddr2";
            this.tbMasterAddr2.Size = new System.Drawing.Size(53, 25);
            this.tbMasterAddr2.TabIndex = 12;
            this.tbMasterAddr2.Text = "0";
            this.tbMasterAddr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "SF:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hop:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFreq
            // 
            this.TLP_Settings.SetColumnSpan(this.tbFreq, 3);
            this.tbFreq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFreq.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFreq.Location = new System.Drawing.Point(62, 73);
            this.tbFreq.Name = "tbFreq";
            this.tbFreq.Size = new System.Drawing.Size(171, 25);
            this.tbFreq.TabIndex = 6;
            this.tbFreq.Text = "865000000";
            this.tbFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Freq:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUD_Pow
            // 
            this.TLP_Settings.SetColumnSpan(this.NUD_Pow, 3);
            this.NUD_Pow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUD_Pow.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Pow.Location = new System.Drawing.Point(62, 143);
            this.NUD_Pow.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUD_Pow.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_Pow.Name = "NUD_Pow";
            this.NUD_Pow.Size = new System.Drawing.Size(171, 25);
            this.NUD_Pow.TabIndex = 25;
            this.NUD_Pow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Pow.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Mode, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 44);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mode:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Mode
            // 
            this.Btn_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Mode.Font = new System.Drawing.Font("Arial Narrow", 21F, System.Drawing.FontStyle.Bold);
            this.Btn_Mode.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Btn_Mode.Location = new System.Drawing.Point(124, 3);
            this.Btn_Mode.Name = "Btn_Mode";
            this.Btn_Mode.Size = new System.Drawing.Size(115, 38);
            this.Btn_Mode.TabIndex = 1;
            this.Btn_Mode.Text = "Mode";
            this.Btn_Mode.UseVisualStyleBackColor = true;
            this.Btn_Mode.Click += new System.EventHandler(this.Btn_Mode_Click);
            // 
            // GB_Mode
            // 
            this.GB_Mode.Controls.Add(this.TLP_Mode_Settings);
            this.GB_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Mode.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Mode.Location = new System.Drawing.Point(3, 303);
            this.GB_Mode.Name = "GB_Mode";
            this.GB_Mode.Size = new System.Drawing.Size(242, 209);
            this.GB_Mode.TabIndex = 20;
            this.GB_Mode.TabStop = false;
            this.GB_Mode.Text = "Master";
            // 
            // TLP_Mode_Settings
            // 
            this.TLP_Mode_Settings.ColumnCount = 4;
            this.TLP_Mode_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Mode_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Mode_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Mode_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Mode_Settings.Controls.Add(this.NUD_AutoCount, 1, 3);
            this.TLP_Mode_Settings.Controls.Add(this.label11, 0, 0);
            this.TLP_Mode_Settings.Controls.Add(this.btAutoAddSlave, 0, 4);
            this.TLP_Mode_Settings.Controls.Add(this.Lab_Addr, 0, 1);
            this.TLP_Mode_Settings.Controls.Add(this.Lab_AutoCount, 0, 3);
            this.TLP_Mode_Settings.Controls.Add(this.tbSlaveAddr1, 1, 1);
            this.TLP_Mode_Settings.Controls.Add(this.tbSlaveAddr2, 2, 1);
            this.TLP_Mode_Settings.Controls.Add(this.tbSlaveAddr3, 3, 1);
            this.TLP_Mode_Settings.Controls.Add(this.tbSlaveSlot3, 3, 2);
            this.TLP_Mode_Settings.Controls.Add(this.Lab_Slot, 0, 2);
            this.TLP_Mode_Settings.Controls.Add(this.tbSlaveSlot2, 2, 2);
            this.TLP_Mode_Settings.Controls.Add(this.tbSlaveSlot1, 1, 2);
            this.TLP_Mode_Settings.Controls.Add(this.CB_Passage, 1, 0);
            this.TLP_Mode_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Mode_Settings.Location = new System.Drawing.Point(3, 28);
            this.TLP_Mode_Settings.Name = "TLP_Mode_Settings";
            this.TLP_Mode_Settings.RowCount = 6;
            this.TLP_Mode_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Mode_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Mode_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Mode_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Mode_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Mode_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Mode_Settings.Size = new System.Drawing.Size(236, 178);
            this.TLP_Mode_Settings.TabIndex = 16;
            // 
            // NUD_AutoCount
            // 
            this.TLP_Mode_Settings.SetColumnSpan(this.NUD_AutoCount, 3);
            this.NUD_AutoCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUD_AutoCount.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_AutoCount.Location = new System.Drawing.Point(119, 108);
            this.NUD_AutoCount.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.NUD_AutoCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_AutoCount.Name = "NUD_AutoCount";
            this.NUD_AutoCount.Size = new System.Drawing.Size(114, 25);
            this.NUD_AutoCount.TabIndex = 28;
            this.NUD_AutoCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_AutoCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "Slot Passage:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAutoAddSlave
            // 
            this.TLP_Mode_Settings.SetColumnSpan(this.btAutoAddSlave, 4);
            this.btAutoAddSlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAutoAddSlave.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutoAddSlave.Location = new System.Drawing.Point(3, 143);
            this.btAutoAddSlave.Name = "btAutoAddSlave";
            this.btAutoAddSlave.Size = new System.Drawing.Size(230, 29);
            this.btAutoAddSlave.TabIndex = 23;
            this.btAutoAddSlave.Text = "Set";
            this.btAutoAddSlave.UseVisualStyleBackColor = true;
            this.btAutoAddSlave.Click += new System.EventHandler(this.BtAutoAddSlave_Click);
            // 
            // Lab_Addr
            // 
            this.Lab_Addr.AutoSize = true;
            this.Lab_Addr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_Addr.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Addr.Location = new System.Drawing.Point(3, 38);
            this.Lab_Addr.Margin = new System.Windows.Forms.Padding(3);
            this.Lab_Addr.Name = "Lab_Addr";
            this.Lab_Addr.Size = new System.Drawing.Size(110, 29);
            this.Lab_Addr.TabIndex = 14;
            this.Lab_Addr.Text = "SlaveNode:";
            this.Lab_Addr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_AutoCount
            // 
            this.Lab_AutoCount.AutoSize = true;
            this.Lab_AutoCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_AutoCount.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_AutoCount.Location = new System.Drawing.Point(3, 108);
            this.Lab_AutoCount.Margin = new System.Windows.Forms.Padding(3);
            this.Lab_AutoCount.Name = "Lab_AutoCount";
            this.Lab_AutoCount.Size = new System.Drawing.Size(110, 29);
            this.Lab_AutoCount.TabIndex = 24;
            this.Lab_AutoCount.Text = "AutoCount:";
            this.Lab_AutoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSlaveAddr1
            // 
            this.tbSlaveAddr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSlaveAddr1.Enabled = false;
            this.tbSlaveAddr1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlaveAddr1.Location = new System.Drawing.Point(119, 38);
            this.tbSlaveAddr1.Name = "tbSlaveAddr1";
            this.tbSlaveAddr1.Size = new System.Drawing.Size(34, 25);
            this.tbSlaveAddr1.TabIndex = 15;
            this.tbSlaveAddr1.Text = "0";
            this.tbSlaveAddr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSlaveAddr2
            // 
            this.tbSlaveAddr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSlaveAddr2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlaveAddr2.Location = new System.Drawing.Point(159, 38);
            this.tbSlaveAddr2.Name = "tbSlaveAddr2";
            this.tbSlaveAddr2.Size = new System.Drawing.Size(34, 25);
            this.tbSlaveAddr2.TabIndex = 16;
            this.tbSlaveAddr2.Text = "0";
            this.tbSlaveAddr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSlaveAddr3
            // 
            this.tbSlaveAddr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSlaveAddr3.Enabled = false;
            this.tbSlaveAddr3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlaveAddr3.Location = new System.Drawing.Point(199, 38);
            this.tbSlaveAddr3.Name = "tbSlaveAddr3";
            this.tbSlaveAddr3.Size = new System.Drawing.Size(34, 25);
            this.tbSlaveAddr3.TabIndex = 17;
            this.tbSlaveAddr3.Text = "1";
            this.tbSlaveAddr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSlaveSlot3
            // 
            this.tbSlaveSlot3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSlaveSlot3.Enabled = false;
            this.tbSlaveSlot3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlaveSlot3.Location = new System.Drawing.Point(199, 73);
            this.tbSlaveSlot3.Name = "tbSlaveSlot3";
            this.tbSlaveSlot3.Size = new System.Drawing.Size(34, 25);
            this.tbSlaveSlot3.TabIndex = 21;
            this.tbSlaveSlot3.Text = "0";
            this.tbSlaveSlot3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lab_Slot
            // 
            this.Lab_Slot.AutoSize = true;
            this.Lab_Slot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_Slot.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Slot.Location = new System.Drawing.Point(3, 73);
            this.Lab_Slot.Margin = new System.Windows.Forms.Padding(3);
            this.Lab_Slot.Name = "Lab_Slot";
            this.Lab_Slot.Size = new System.Drawing.Size(110, 29);
            this.Lab_Slot.TabIndex = 18;
            this.Lab_Slot.Text = "Slot:";
            this.Lab_Slot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSlaveSlot2
            // 
            this.tbSlaveSlot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSlaveSlot2.Enabled = false;
            this.tbSlaveSlot2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlaveSlot2.Location = new System.Drawing.Point(159, 73);
            this.tbSlaveSlot2.Name = "tbSlaveSlot2";
            this.tbSlaveSlot2.Size = new System.Drawing.Size(34, 25);
            this.tbSlaveSlot2.TabIndex = 20;
            this.tbSlaveSlot2.Text = "0";
            this.tbSlaveSlot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSlaveSlot1
            // 
            this.tbSlaveSlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSlaveSlot1.Enabled = false;
            this.tbSlaveSlot1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlaveSlot1.Location = new System.Drawing.Point(119, 73);
            this.tbSlaveSlot1.Name = "tbSlaveSlot1";
            this.tbSlaveSlot1.Size = new System.Drawing.Size(34, 25);
            this.tbSlaveSlot1.TabIndex = 19;
            this.tbSlaveSlot1.Text = "0";
            this.tbSlaveSlot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CB_Passage
            // 
            this.TLP_Mode_Settings.SetColumnSpan(this.CB_Passage, 3);
            this.CB_Passage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Passage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Passage.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Passage.FormattingEnabled = true;
            this.CB_Passage.Location = new System.Drawing.Point(119, 3);
            this.CB_Passage.Name = "CB_Passage";
            this.CB_Passage.Size = new System.Drawing.Size(114, 28);
            this.CB_Passage.TabIndex = 29;
            this.CB_Passage.TextChanged += new System.EventHandler(this.CB_Passage_TextChanged);
            // 
            // Timer_Write
            // 
            this.Timer_Write.Interval = 200;
            this.Timer_Write.Tick += new System.EventHandler(this.Timer_Write_Tick);
            // 
            // Btn_DumpFreq
            // 
            this.Btn_DumpFreq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_DumpFreq.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DumpFreq.Location = new System.Drawing.Point(202, 38);
            this.Btn_DumpFreq.Name = "Btn_DumpFreq";
            this.Btn_DumpFreq.Size = new System.Drawing.Size(143, 29);
            this.Btn_DumpFreq.TabIndex = 12;
            this.Btn_DumpFreq.Text = "DumpFreq";
            this.Btn_DumpFreq.UseVisualStyleBackColor = true;
            this.Btn_DumpFreq.Click += new System.EventHandler(this.Btn_DumpFreq_Click);
            // 
            // Btn_DumpSlave
            // 
            this.Btn_DumpSlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_DumpSlave.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DumpSlave.Location = new System.Drawing.Point(649, 38);
            this.Btn_DumpSlave.Name = "Btn_DumpSlave";
            this.Btn_DumpSlave.Size = new System.Drawing.Size(143, 29);
            this.Btn_DumpSlave.TabIndex = 13;
            this.Btn_DumpSlave.Text = "DumpSlave";
            this.Btn_DumpSlave.UseVisualStyleBackColor = true;
            this.Btn_DumpSlave.Click += new System.EventHandler(this.Btn_DumpSlave_Click);
            // 
            // TLP_Left
            // 
            this.TLP_Left.ColumnCount = 8;
            this.TLP_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLP_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLP_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLP_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLP_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLP_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLP_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLP_Left.Controls.Add(this.TB_CmdToSend, 0, 3);
            this.TLP_Left.Controls.Add(this.Btn_GetMyAddr, 2, 0);
            this.TLP_Left.Controls.Add(this.Btn_Send, 7, 3);
            this.TLP_Left.Controls.Add(this.label1, 0, 0);
            this.TLP_Left.Controls.Add(this.Btn_DumpFreq, 2, 1);
            this.TLP_Left.Controls.Add(this.Btn_Enable, 6, 0);
            this.TLP_Left.Controls.Add(this.Btn_Disable, 7, 0);
            this.TLP_Left.Controls.Add(this.Btn_Demo, 6, 1);
            this.TLP_Left.Controls.Add(this.Btn_DumpSlave, 5, 1);
            this.TLP_Left.Controls.Add(this.CB_Comport, 1, 0);
            this.TLP_Left.Controls.Add(this.Btn_Connect, 0, 1);
            this.TLP_Left.Controls.Add(this.Btn_RemoveSlave, 3, 1);
            this.TLP_Left.Controls.Add(this.Btn_GetMode, 3, 0);
            this.TLP_Left.Controls.Add(this.Btn_GetSF, 4, 0);
            this.TLP_Left.Controls.Add(this.Btn_GetPower, 5, 0);
            this.TLP_Left.Controls.Add(this.Bar_Write, 0, 4);
            this.TLP_Left.Controls.Add(this.Btn_Pld, 4, 1);
            this.TLP_Left.Controls.Add(this.RTB_ReciveData, 0, 2);
            this.TLP_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Left.Location = new System.Drawing.Point(0, 0);
            this.TLP_Left.Name = "TLP_Left";
            this.TLP_Left.RowCount = 5;
            this.TLP_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Left.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Left.Size = new System.Drawing.Size(1100, 730);
            this.TLP_Left.TabIndex = 14;
            // 
            // Btn_GetMyAddr
            // 
            this.Btn_GetMyAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_GetMyAddr.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetMyAddr.Location = new System.Drawing.Point(202, 3);
            this.Btn_GetMyAddr.Name = "Btn_GetMyAddr";
            this.Btn_GetMyAddr.Size = new System.Drawing.Size(143, 29);
            this.Btn_GetMyAddr.TabIndex = 15;
            this.Btn_GetMyAddr.Text = "GetMyAddr";
            this.Btn_GetMyAddr.UseVisualStyleBackColor = true;
            this.Btn_GetMyAddr.Click += new System.EventHandler(this.Btn_GetMyAddr_Click);
            // 
            // Btn_Send
            // 
            this.Btn_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Send.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send.Location = new System.Drawing.Point(947, 663);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(150, 29);
            this.Btn_Send.TabIndex = 4;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // CB_Comport
            // 
            this.CB_Comport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Comport.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Comport.FormattingEnabled = true;
            this.CB_Comport.Location = new System.Drawing.Point(53, 3);
            this.CB_Comport.Name = "CB_Comport";
            this.CB_Comport.Size = new System.Drawing.Size(143, 28);
            this.CB_Comport.Sorted = true;
            this.CB_Comport.TabIndex = 5;
            this.CB_Comport.DropDown += new System.EventHandler(this.CB_Comport_DropDown);
            // 
            // Btn_RemoveSlave
            // 
            this.Btn_RemoveSlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_RemoveSlave.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RemoveSlave.Location = new System.Drawing.Point(351, 38);
            this.Btn_RemoveSlave.Name = "Btn_RemoveSlave";
            this.Btn_RemoveSlave.Size = new System.Drawing.Size(143, 29);
            this.Btn_RemoveSlave.TabIndex = 14;
            this.Btn_RemoveSlave.Text = "Remove All Slave";
            this.Btn_RemoveSlave.UseVisualStyleBackColor = true;
            this.Btn_RemoveSlave.Click += new System.EventHandler(this.Btn_RemoveSlave_Click);
            // 
            // Btn_GetMode
            // 
            this.Btn_GetMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_GetMode.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetMode.Location = new System.Drawing.Point(351, 3);
            this.Btn_GetMode.Name = "Btn_GetMode";
            this.Btn_GetMode.Size = new System.Drawing.Size(143, 29);
            this.Btn_GetMode.TabIndex = 16;
            this.Btn_GetMode.Text = "GetMode";
            this.Btn_GetMode.UseVisualStyleBackColor = true;
            this.Btn_GetMode.Click += new System.EventHandler(this.Btn_GetMode_Click);
            // 
            // Btn_GetSF
            // 
            this.Btn_GetSF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_GetSF.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetSF.Location = new System.Drawing.Point(500, 3);
            this.Btn_GetSF.Name = "Btn_GetSF";
            this.Btn_GetSF.Size = new System.Drawing.Size(143, 29);
            this.Btn_GetSF.TabIndex = 17;
            this.Btn_GetSF.Text = "GetSF";
            this.Btn_GetSF.UseVisualStyleBackColor = true;
            this.Btn_GetSF.Click += new System.EventHandler(this.Btn_GetSF_Click);
            // 
            // Btn_GetPower
            // 
            this.Btn_GetPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_GetPower.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetPower.Location = new System.Drawing.Point(649, 3);
            this.Btn_GetPower.Name = "Btn_GetPower";
            this.Btn_GetPower.Size = new System.Drawing.Size(143, 29);
            this.Btn_GetPower.TabIndex = 18;
            this.Btn_GetPower.Text = "GetPower";
            this.Btn_GetPower.UseVisualStyleBackColor = true;
            this.Btn_GetPower.Click += new System.EventHandler(this.Btn_GetPower_Click);
            // 
            // Bar_Write
            // 
            this.TLP_Left.SetColumnSpan(this.Bar_Write, 8);
            this.Bar_Write.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bar_Write.Location = new System.Drawing.Point(3, 698);
            this.Bar_Write.Name = "Bar_Write";
            this.Bar_Write.Size = new System.Drawing.Size(1094, 29);
            this.Bar_Write.Step = 1;
            this.Bar_Write.TabIndex = 19;
            this.Bar_Write.Visible = false;
            // 
            // Btn_Pld
            // 
            this.Btn_Pld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Pld.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.Btn_Pld.Location = new System.Drawing.Point(500, 38);
            this.Btn_Pld.Name = "Btn_Pld";
            this.Btn_Pld.Size = new System.Drawing.Size(143, 29);
            this.Btn_Pld.TabIndex = 21;
            this.Btn_Pld.Text = "Pld";
            this.Btn_Pld.UseVisualStyleBackColor = true;
            this.Btn_Pld.Visible = false;
            this.Btn_Pld.Click += new System.EventHandler(this.Btn_Pld_Click);
            // 
            // RTB_ReciveData
            // 
            this.RTB_ReciveData.BackColor = System.Drawing.Color.Black;
            this.TLP_Left.SetColumnSpan(this.RTB_ReciveData, 8);
            this.RTB_ReciveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_ReciveData.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RTB_ReciveData.ForeColor = System.Drawing.Color.Lime;
            this.RTB_ReciveData.Location = new System.Drawing.Point(3, 73);
            this.RTB_ReciveData.Name = "RTB_ReciveData";
            this.RTB_ReciveData.ReadOnly = true;
            this.RTB_ReciveData.Size = new System.Drawing.Size(1094, 584);
            this.RTB_ReciveData.TabIndex = 22;
            this.RTB_ReciveData.Text = "";
            this.RTB_ReciveData.WordWrap = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.Btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.TLP_Left);
            this.Controls.Add(this.Panel_M_S_Setting);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M/S_Edit..........Disconnection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_M_S_Setting.ResumeLayout(false);
            this.TLP_M_Set.ResumeLayout(false);
            this.GB_Settings.ResumeLayout(false);
            this.TLP_Settings.ResumeLayout(false);
            this.TLP_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Pow)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GB_Mode.ResumeLayout(false);
            this.TLP_Mode_Settings.ResumeLayout(false);
            this.TLP_Mode_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AutoCount)).EndInit();
            this.TLP_Left.ResumeLayout(false);
            this.TLP_Left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TB_CmdToSend;
        private System.Windows.Forms.Button Btn_Enable;
        private System.Windows.Forms.Button Btn_Disable;
        private System.Windows.Forms.Label label1;
        private SwitchButton Btn_Connect;
        private System.Windows.Forms.Button Btn_Demo;
        private System.Windows.Forms.Panel Panel_M_S_Setting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFreq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMasterAddr1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GB_Mode;
        private System.Windows.Forms.Button btAutoAddSlave;
        private System.Windows.Forms.TextBox tbSlaveSlot3;
        private System.Windows.Forms.TextBox tbSlaveSlot2;
        private System.Windows.Forms.TextBox tbSlaveSlot1;
        private System.Windows.Forms.Label Lab_Slot;
        private System.Windows.Forms.TextBox tbSlaveAddr3;
        private System.Windows.Forms.TextBox tbSlaveAddr2;
        private System.Windows.Forms.TextBox tbSlaveAddr1;
        private System.Windows.Forms.Label Lab_Addr;
        private System.Windows.Forms.TextBox tbMasterAddr3;
        private System.Windows.Forms.TextBox tbMasterAddr2;
        private System.Windows.Forms.Button Btn_SetMaster;
        private System.Windows.Forms.Label Lab_AutoCount;
        private System.Windows.Forms.Timer Timer_Write;
        private System.Windows.Forms.Button Btn_DumpFreq;
        private System.Windows.Forms.Button Btn_DumpSlave;
        private System.Windows.Forms.TableLayoutPanel TLP_Left;
        private System.Windows.Forms.Button Btn_RemoveSlave;
        private System.Windows.Forms.Button Btn_GetMyAddr;
        private System.Windows.Forms.TableLayoutPanel TLP_Mode_Settings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NUD_AutoCount;
        private System.Windows.Forms.ComboBox CB_Passage;
        private System.Windows.Forms.GroupBox GB_Settings;
        private System.Windows.Forms.TableLayoutPanel TLP_Settings;
        private System.Windows.Forms.TableLayoutPanel TLP_M_Set;
        private System.Windows.Forms.NumericUpDown NUD_SF;
        private System.Windows.Forms.NumericUpDown NUD_Hop;
        private System.Windows.Forms.ComboBox CB_Comport;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.NumericUpDown NUD_Pow;
        private System.Windows.Forms.Button Btn_GetMode;
        private System.Windows.Forms.Button Btn_GetSF;
        private System.Windows.Forms.Button Btn_GetPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Mode;
        private System.Windows.Forms.Button Btn_Pld;
        private System.Windows.Forms.ProgressBar Bar_Write;
        private System.Windows.Forms.RichTextBox RTB_ReciveData;
    }
}

