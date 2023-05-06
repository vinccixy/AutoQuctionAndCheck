namespace AutoQuctionAndCheck {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.type = new System.Windows.Forms.GroupBox();
            this.multi_radio = new System.Windows.Forms.RadioButton();
            this.radio_100 = new System.Windows.Forms.RadioButton();
            this.radio_10 = new System.Windows.Forms.RadioButton();
            this.AntoNext_check = new System.Windows.Forms.CheckBox();
            this.quick_btn = new System.Windows.Forms.Button();
            this.slow_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.AntoResult_Check = new System.Windows.Forms.CheckBox();
            this.result_tbx = new System.Windows.Forms.TextBox();
            this.quection_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.type.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // type
            // 
            this.type.Controls.Add(this.multi_radio);
            this.type.Controls.Add(this.radio_100);
            this.type.Controls.Add(this.radio_10);
            this.type.Location = new System.Drawing.Point(14, 12);
            this.type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.type.Name = "type";
            this.type.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.type.Size = new System.Drawing.Size(369, 81);
            this.type.TabIndex = 0;
            this.type.TabStop = false;
            this.type.Text = "题目类型";
            // 
            // multi_radio
            // 
            this.multi_radio.AutoSize = true;
            this.multi_radio.Location = new System.Drawing.Point(246, 21);
            this.multi_radio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.multi_radio.Name = "multi_radio";
            this.multi_radio.Size = new System.Drawing.Size(49, 16);
            this.multi_radio.TabIndex = 2;
            this.multi_radio.Text = "乘法";
            this.multi_radio.UseVisualStyleBackColor = true;
            this.multi_radio.CheckedChanged += new System.EventHandler(this.multi_radio_CheckedChanged);
            // 
            // radio_100
            // 
            this.radio_100.AutoSize = true;
            this.radio_100.Location = new System.Drawing.Point(127, 20);
            this.radio_100.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radio_100.Name = "radio_100";
            this.radio_100.Size = new System.Drawing.Size(96, 16);
            this.radio_100.TabIndex = 1;
            this.radio_100.Text = "100内加减法";
            this.radio_100.UseVisualStyleBackColor = true;
            this.radio_100.CheckedChanged += new System.EventHandler(this.radio_100_CheckedChanged);
            // 
            // radio_10
            // 
            this.radio_10.AutoSize = true;
            this.radio_10.Checked = true;
            this.radio_10.Location = new System.Drawing.Point(8, 21);
            this.radio_10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radio_10.Name = "radio_10";
            this.radio_10.Size = new System.Drawing.Size(89, 16);
            this.radio_10.TabIndex = 0;
            this.radio_10.TabStop = true;
            this.radio_10.Text = "10内加减法";
            this.radio_10.UseVisualStyleBackColor = true;
            this.radio_10.CheckedChanged += new System.EventHandler(this.radio_10_CheckedChanged);
            // 
            // AntoNext_check
            // 
            this.AntoNext_check.AutoSize = true;
            this.AntoNext_check.Checked = true;
            this.AntoNext_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AntoNext_check.Location = new System.Drawing.Point(390, 22);
            this.AntoNext_check.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AntoNext_check.Name = "AntoNext_check";
            this.AntoNext_check.Size = new System.Drawing.Size(115, 16);
            this.AntoNext_check.TabIndex = 1;
            this.AntoNext_check.Text = "自动显示下一题";
            this.AntoNext_check.UseVisualStyleBackColor = true;
            // 
            // quick_btn
            // 
            this.quick_btn.Location = new System.Drawing.Point(524, 14);
            this.quick_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.quick_btn.Name = "quick_btn";
            this.quick_btn.Size = new System.Drawing.Size(88, 23);
            this.quick_btn.TabIndex = 2;
            this.quick_btn.Text = "快些";
            this.quick_btn.UseVisualStyleBackColor = true;
            this.quick_btn.Click += new System.EventHandler(this.quick_btn_Click);
            // 
            // slow_btn
            // 
            this.slow_btn.Location = new System.Drawing.Point(635, 13);
            this.slow_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.slow_btn.Name = "slow_btn";
            this.slow_btn.Size = new System.Drawing.Size(88, 23);
            this.slow_btn.TabIndex = 3;
            this.slow_btn.Text = "慢些";
            this.slow_btn.UseVisualStyleBackColor = true;
            this.slow_btn.Click += new System.EventHandler(this.slow_btn_Click);
            // 
            // Next_btn
            // 
            this.Next_btn.Location = new System.Drawing.Point(391, 61);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(88, 23);
            this.Next_btn.TabIndex = 4;
            this.Next_btn.Text = "下一题";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // AntoResult_Check
            // 
            this.AntoResult_Check.AutoSize = true;
            this.AntoResult_Check.Checked = true;
            this.AntoResult_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AntoResult_Check.Location = new System.Drawing.Point(524, 130);
            this.AntoResult_Check.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AntoResult_Check.Name = "AntoResult_Check";
            this.AntoResult_Check.Size = new System.Drawing.Size(102, 16);
            this.AntoResult_Check.TabIndex = 6;
            this.AntoResult_Check.Text = "自动显示答案";
            this.AntoResult_Check.UseVisualStyleBackColor = true;
            this.AntoResult_Check.CheckedChanged += new System.EventHandler(this.AntoResult_Check_CheckedChanged);
            // 
            // result_tbx
            // 
            this.result_tbx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result_tbx.ForeColor = System.Drawing.Color.Black;
            this.result_tbx.Location = new System.Drawing.Point(538, 190);
            this.result_tbx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.result_tbx.Name = "result_tbx";
            this.result_tbx.Size = new System.Drawing.Size(132, 21);
            this.result_tbx.TabIndex = 20;
            // 
            // quection_tbx
            // 
            this.quection_tbx.Location = new System.Drawing.Point(321, 190);
            this.quection_tbx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.quection_tbx.Name = "quection_tbx";
            this.quection_tbx.Size = new System.Drawing.Size(157, 21);
            this.quection_tbx.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quection_tbx);
            this.Controls.Add(this.result_tbx);
            this.Controls.Add(this.AntoResult_Check);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.slow_btn);
            this.Controls.Add(this.quick_btn);
            this.Controls.Add(this.AntoNext_check);
            this.Controls.Add(this.type);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RadioButton multi_radio;
        private System.Windows.Forms.RadioButton radio_100;
        private System.Windows.Forms.RadioButton radio_10;
        private System.Windows.Forms.CheckBox AntoNext_check;
        private System.Windows.Forms.Button quick_btn;
        private System.Windows.Forms.Button slow_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.CheckBox AntoResult_Check;
        private System.Windows.Forms.TextBox result_tbx;
        private System.Windows.Forms.TextBox quection_tbx;
        private System.Windows.Forms.Label label1;
    }
}

