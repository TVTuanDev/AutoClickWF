namespace AutoClick
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.Label();
            this.BtnLocation = new System.Windows.Forms.Button();
            this.CBoxButton = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ClickInterval = new System.Windows.Forms.GroupBox();
            this.miniseconds = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.secs = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mins = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ClickOptions = new System.Windows.Forms.GroupBox();
            this.CBoxType = new System.Windows.Forms.ComboBox();
            this.ClickType = new System.Windows.Forms.Label();
            this.MouseOptions = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PointY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PointX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RBtnLocation2 = new System.Windows.Forms.RadioButton();
            this.RBtnLocation1 = new System.Windows.Forms.RadioButton();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.BtnHotkey = new System.Windows.Forms.Button();
            this.ClickInterval.SuspendLayout();
            this.ClickOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Location = new System.Drawing.Point(90, 33);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(40, 16);
            this.hours.TabIndex = 1;
            this.hours.Text = "hours";
            // 
            // BtnLocation
            // 
            this.BtnLocation.Location = new System.Drawing.Point(283, 22);
            this.BtnLocation.Name = "BtnLocation";
            this.BtnLocation.Size = new System.Drawing.Size(129, 36);
            this.BtnLocation.TabIndex = 2;
            this.BtnLocation.Text = "Pick location";
            this.BtnLocation.UseVisualStyleBackColor = true;
            this.BtnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // CBoxButton
            // 
            this.CBoxButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxButton.FormattingEnabled = true;
            this.CBoxButton.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.CBoxButton.Location = new System.Drawing.Point(126, 21);
            this.CBoxButton.Name = "CBoxButton";
            this.CBoxButton.Size = new System.Drawing.Size(151, 24);
            this.CBoxButton.TabIndex = 3;
            this.CBoxButton.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Repeat";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ClickInterval
            // 
            this.ClickInterval.Controls.Add(this.miniseconds);
            this.ClickInterval.Controls.Add(this.textBox4);
            this.ClickInterval.Controls.Add(this.secs);
            this.ClickInterval.Controls.Add(this.textBox3);
            this.ClickInterval.Controls.Add(this.mins);
            this.ClickInterval.Controls.Add(this.textBox2);
            this.ClickInterval.Controls.Add(this.textBox1);
            this.ClickInterval.Controls.Add(this.hours);
            this.ClickInterval.Location = new System.Drawing.Point(12, 12);
            this.ClickInterval.Name = "ClickInterval";
            this.ClickInterval.Size = new System.Drawing.Size(641, 111);
            this.ClickInterval.TabIndex = 5;
            this.ClickInterval.TabStop = false;
            this.ClickInterval.Text = "Click interval";
            // 
            // miniseconds
            // 
            this.miniseconds.AutoSize = true;
            this.miniseconds.Location = new System.Drawing.Point(538, 33);
            this.miniseconds.Name = "miniseconds";
            this.miniseconds.Size = new System.Drawing.Size(83, 16);
            this.miniseconds.TabIndex = 6;
            this.miniseconds.Text = "miniseconds";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(447, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 22);
            this.textBox4.TabIndex = 5;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "100";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // secs
            // 
            this.secs.AutoSize = true;
            this.secs.Location = new System.Drawing.Point(395, 33);
            this.secs.Name = "secs";
            this.secs.Size = new System.Drawing.Size(36, 16);
            this.secs.TabIndex = 4;
            this.secs.Text = "secs";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(304, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mins
            // 
            this.mins.AutoSize = true;
            this.mins.Location = new System.Drawing.Point(245, 33);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(35, 16);
            this.mins.TabIndex = 2;
            this.mins.Text = "mins";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClickOptions
            // 
            this.ClickOptions.Controls.Add(this.CBoxType);
            this.ClickOptions.Controls.Add(this.ClickType);
            this.ClickOptions.Controls.Add(this.MouseOptions);
            this.ClickOptions.Controls.Add(this.CBoxButton);
            this.ClickOptions.Location = new System.Drawing.Point(12, 129);
            this.ClickOptions.Name = "ClickOptions";
            this.ClickOptions.Size = new System.Drawing.Size(300, 100);
            this.ClickOptions.TabIndex = 6;
            this.ClickOptions.TabStop = false;
            this.ClickOptions.Text = "Click options";
            // 
            // CBoxType
            // 
            this.CBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxType.FormattingEnabled = true;
            this.CBoxType.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.CBoxType.Location = new System.Drawing.Point(126, 60);
            this.CBoxType.Name = "CBoxType";
            this.CBoxType.Size = new System.Drawing.Size(151, 24);
            this.CBoxType.TabIndex = 9;
            this.CBoxType.TabStop = false;
            // 
            // ClickType
            // 
            this.ClickType.AutoSize = true;
            this.ClickType.Location = new System.Drawing.Point(6, 63);
            this.ClickType.Name = "ClickType";
            this.ClickType.Size = new System.Drawing.Size(68, 16);
            this.ClickType.TabIndex = 8;
            this.ClickType.Text = "Click type:";
            // 
            // MouseOptions
            // 
            this.MouseOptions.AutoSize = true;
            this.MouseOptions.Location = new System.Drawing.Point(6, 28);
            this.MouseOptions.Name = "MouseOptions";
            this.MouseOptions.Size = new System.Drawing.Size(90, 16);
            this.MouseOptions.TabIndex = 7;
            this.MouseOptions.Text = "Mouse button:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(332, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click repeat";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 26);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "times";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(152, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Repeat until stopped";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PointY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PointX);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RBtnLocation2);
            this.groupBox2.Controls.Add(this.RBtnLocation1);
            this.groupBox2.Controls.Add(this.BtnLocation);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 67);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursor position";
            // 
            // PointY
            // 
            this.PointY.Location = new System.Drawing.Point(541, 30);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(54, 22);
            this.PointY.TabIndex = 11;
            this.PointY.TabStop = false;
            this.PointY.Text = "0";
            this.PointY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y";
            // 
            // PointX
            // 
            this.PointX.Location = new System.Drawing.Point(447, 30);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(54, 22);
            this.PointX.TabIndex = 7;
            this.PointX.TabStop = false;
            this.PointX.Text = "0";
            this.PointX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // RBtnLocation2
            // 
            this.RBtnLocation2.AutoSize = true;
            this.RBtnLocation2.Location = new System.Drawing.Point(260, 33);
            this.RBtnLocation2.Name = "RBtnLocation2";
            this.RBtnLocation2.Size = new System.Drawing.Size(17, 16);
            this.RBtnLocation2.TabIndex = 10;
            this.RBtnLocation2.UseVisualStyleBackColor = true;
            // 
            // RBtnLocation1
            // 
            this.RBtnLocation1.AutoSize = true;
            this.RBtnLocation1.Checked = true;
            this.RBtnLocation1.Location = new System.Drawing.Point(6, 31);
            this.RBtnLocation1.Name = "RBtnLocation1";
            this.RBtnLocation1.Size = new System.Drawing.Size(120, 20);
            this.RBtnLocation1.TabIndex = 9;
            this.RBtnLocation1.TabStop = true;
            this.RBtnLocation1.Text = "Current location";
            this.RBtnLocation1.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(21, 322);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(291, 54);
            this.BtnStart.TabIndex = 13;
            this.BtnStart.Text = "Start (F5)";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(332, 322);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(310, 54);
            this.BtnStop.TabIndex = 14;
            this.BtnStop.Text = "Stop (F5)";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnRecord
            // 
            this.BtnRecord.Location = new System.Drawing.Point(332, 385);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(310, 54);
            this.BtnRecord.TabIndex = 16;
            this.BtnRecord.Text = "Record and Playback";
            this.BtnRecord.UseVisualStyleBackColor = true;
            // 
            // BtnHotkey
            // 
            this.BtnHotkey.Location = new System.Drawing.Point(21, 385);
            this.BtnHotkey.Name = "BtnHotkey";
            this.BtnHotkey.Size = new System.Drawing.Size(291, 54);
            this.BtnHotkey.TabIndex = 15;
            this.BtnHotkey.Text = "Hotkey setting";
            this.BtnHotkey.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(666, 479);
            this.Controls.Add(this.BtnRecord);
            this.Controls.Add(this.BtnHotkey);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClickOptions);
            this.Controls.Add(this.ClickInterval);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicked";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClickInterval.ResumeLayout(false);
            this.ClickInterval.PerformLayout();
            this.ClickOptions.ResumeLayout(false);
            this.ClickOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Button BtnLocation;
        private System.Windows.Forms.ComboBox CBoxButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox ClickInterval;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label miniseconds;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label secs;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label mins;
        private System.Windows.Forms.GroupBox ClickOptions;
        private System.Windows.Forms.Label ClickType;
        private System.Windows.Forms.Label MouseOptions;
        private System.Windows.Forms.ComboBox CBoxType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PointY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PointX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBtnLocation2;
        private System.Windows.Forms.RadioButton RBtnLocation1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.Button BtnHotkey;
    }
}

