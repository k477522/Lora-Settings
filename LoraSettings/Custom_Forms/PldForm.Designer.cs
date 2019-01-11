namespace LoraTest_Slave
{
    partial class PldForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Data = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Lab_SE_Mode = new System.Windows.Forms.Label();
            this.Lab_NodeAddr = new System.Windows.Forms.Label();
            this.NUD_Addr1 = new System.Windows.Forms.NumericUpDown();
            this.NUD_Addr2 = new System.Windows.Forms.NumericUpDown();
            this.NUD_Addr3 = new System.Windows.Forms.NumericUpDown();
            this.CB_SE_Mode = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Addr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Addr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Addr3)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Data
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TB_Data, 4);
            this.TB_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Data.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Data.Location = new System.Drawing.Point(3, 68);
            this.TB_Data.Name = "TB_Data";
            this.TB_Data.Size = new System.Drawing.Size(428, 27);
            this.TB_Data.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TB_Data, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Send, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lab_SE_Mode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lab_NodeAddr, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NUD_Addr1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NUD_Addr2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NUD_Addr3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CB_SE_Mode, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Send.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.Btn_Send.Location = new System.Drawing.Point(437, 68);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(94, 29);
            this.Btn_Send.TabIndex = 1;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Lab_SE_Mode
            // 
            this.Lab_SE_Mode.AutoSize = true;
            this.Lab_SE_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_SE_Mode.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_SE_Mode.Location = new System.Drawing.Point(3, 3);
            this.Lab_SE_Mode.Margin = new System.Windows.Forms.Padding(3);
            this.Lab_SE_Mode.Name = "Lab_SE_Mode";
            this.Lab_SE_Mode.Size = new System.Drawing.Size(128, 28);
            this.Lab_SE_Mode.TabIndex = 2;
            this.Lab_SE_Mode.Text = "SlaveEventMode:";
            this.Lab_SE_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_NodeAddr
            // 
            this.Lab_NodeAddr.AutoSize = true;
            this.Lab_NodeAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_NodeAddr.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_NodeAddr.Location = new System.Drawing.Point(3, 37);
            this.Lab_NodeAddr.Margin = new System.Windows.Forms.Padding(3);
            this.Lab_NodeAddr.Name = "Lab_NodeAddr";
            this.Lab_NodeAddr.Size = new System.Drawing.Size(128, 25);
            this.Lab_NodeAddr.TabIndex = 2;
            this.Lab_NodeAddr.Text = "NodeAddr:";
            this.Lab_NodeAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUD_Addr1
            // 
            this.NUD_Addr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUD_Addr1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Addr1.Location = new System.Drawing.Point(137, 37);
            this.NUD_Addr1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_Addr1.Name = "NUD_Addr1";
            this.NUD_Addr1.Size = new System.Drawing.Size(94, 25);
            this.NUD_Addr1.TabIndex = 4;
            this.NUD_Addr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUD_Addr2
            // 
            this.NUD_Addr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUD_Addr2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Addr2.Location = new System.Drawing.Point(237, 37);
            this.NUD_Addr2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_Addr2.Name = "NUD_Addr2";
            this.NUD_Addr2.Size = new System.Drawing.Size(94, 25);
            this.NUD_Addr2.TabIndex = 4;
            this.NUD_Addr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUD_Addr3
            // 
            this.NUD_Addr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUD_Addr3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Addr3.Location = new System.Drawing.Point(337, 37);
            this.NUD_Addr3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_Addr3.Name = "NUD_Addr3";
            this.NUD_Addr3.Size = new System.Drawing.Size(94, 25);
            this.NUD_Addr3.TabIndex = 4;
            this.NUD_Addr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CB_SE_Mode
            // 
            this.CB_SE_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SE_Mode.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.CB_SE_Mode.FormattingEnabled = true;
            this.CB_SE_Mode.Location = new System.Drawing.Point(137, 3);
            this.CB_SE_Mode.Name = "CB_SE_Mode";
            this.CB_SE_Mode.Size = new System.Drawing.Size(94, 28);
            this.CB_SE_Mode.TabIndex = 5;
            // 
            // PldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 100);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PldForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pld";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Addr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Addr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Addr3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Label Lab_SE_Mode;
        private System.Windows.Forms.Label Lab_NodeAddr;
        private System.Windows.Forms.NumericUpDown NUD_Addr1;
        private System.Windows.Forms.NumericUpDown NUD_Addr2;
        private System.Windows.Forms.NumericUpDown NUD_Addr3;
        private System.Windows.Forms.ComboBox CB_SE_Mode;
    }
}