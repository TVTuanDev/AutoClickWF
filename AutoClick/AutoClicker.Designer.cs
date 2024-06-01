namespace AutoClick
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.Hour_txt = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.Label();
            this.BtnLocation = new System.Windows.Forms.Button();
            this.CBoxButton = new System.Windows.Forms.ComboBox();
            this.RBtnRepeat = new System.Windows.Forms.RadioButton();
            this.ClickInterval = new System.Windows.Forms.GroupBox();
            this.miniseconds = new System.Windows.Forms.Label();
            this.MiniSecs_txt = new System.Windows.Forms.TextBox();
            this.secs = new System.Windows.Forms.Label();
            this.Secs_txt = new System.Windows.Forms.TextBox();
            this.mins = new System.Windows.Forms.Label();
            this.Mins_txt = new System.Windows.Forms.TextBox();
            this.ClickOptions = new System.Windows.Forms.GroupBox();
            this.CBoxType = new System.Windows.Forms.ComboBox();
            this.ClickType = new System.Windows.Forms.Label();
            this.MouseOptions = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Repeat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RBtnReInfinite = new System.Windows.Forms.RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.Repeat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hour_txt
            // 
            this.Hour_txt.Location = new System.Drawing.Point(6, 30);
            this.Hour_txt.Name = "Hour_txt";
            this.Hour_txt.Size = new System.Drawing.Size(55, 22);
            this.Hour_txt.TabIndex = 0;
            this.Hour_txt.TabStop = false;
            this.Hour_txt.Text = "0";
            this.Hour_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Location = new System.Drawing.Point(67, 33);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(40, 16);
            this.hours.TabIndex = 1;
            this.hours.Text = "hours";
            // 
            // BtnLocation
            // 
            this.BtnLocation.Location = new System.Drawing.Point(237, 21);
            this.BtnLocation.Name = "BtnLocation";
            this.BtnLocation.Size = new System.Drawing.Size(129, 36);
            this.BtnLocation.TabIndex = 0;
            this.BtnLocation.TabStop = false;
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
            this.CBoxButton.Size = new System.Drawing.Size(105, 24);
            this.CBoxButton.TabIndex = 3;
            this.CBoxButton.TabStop = false;
            // 
            // RBtnRepeat
            // 
            this.RBtnRepeat.AutoSize = true;
            this.RBtnRepeat.Location = new System.Drawing.Point(18, 28);
            this.RBtnRepeat.Name = "RBtnRepeat";
            this.RBtnRepeat.Size = new System.Drawing.Size(73, 20);
            this.RBtnRepeat.TabIndex = 4;
            this.RBtnRepeat.TabStop = true;
            this.RBtnRepeat.Text = "Repeat";
            this.RBtnRepeat.UseVisualStyleBackColor = true;
            // 
            // ClickInterval
            // 
            this.ClickInterval.Controls.Add(this.miniseconds);
            this.ClickInterval.Controls.Add(this.MiniSecs_txt);
            this.ClickInterval.Controls.Add(this.secs);
            this.ClickInterval.Controls.Add(this.Secs_txt);
            this.ClickInterval.Controls.Add(this.mins);
            this.ClickInterval.Controls.Add(this.Mins_txt);
            this.ClickInterval.Controls.Add(this.Hour_txt);
            this.ClickInterval.Controls.Add(this.hours);
            this.ClickInterval.Location = new System.Drawing.Point(12, 12);
            this.ClickInterval.Name = "ClickInterval";
            this.ClickInterval.Size = new System.Drawing.Size(549, 73);
            this.ClickInterval.TabIndex = 5;
            this.ClickInterval.TabStop = false;
            this.ClickInterval.Text = "Click interval";
            // 
            // miniseconds
            // 
            this.miniseconds.AutoSize = true;
            this.miniseconds.Location = new System.Drawing.Point(450, 33);
            this.miniseconds.Name = "miniseconds";
            this.miniseconds.Size = new System.Drawing.Size(83, 16);
            this.miniseconds.TabIndex = 6;
            this.miniseconds.Text = "miniseconds";
            // 
            // MiniSecs_txt
            // 
            this.MiniSecs_txt.Location = new System.Drawing.Point(388, 30);
            this.MiniSecs_txt.Name = "MiniSecs_txt";
            this.MiniSecs_txt.Size = new System.Drawing.Size(56, 22);
            this.MiniSecs_txt.TabIndex = 5;
            this.MiniSecs_txt.TabStop = false;
            this.MiniSecs_txt.Text = "100";
            this.MiniSecs_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // secs
            // 
            this.secs.AutoSize = true;
            this.secs.Location = new System.Drawing.Point(322, 33);
            this.secs.Name = "secs";
            this.secs.Size = new System.Drawing.Size(36, 16);
            this.secs.TabIndex = 4;
            this.secs.Text = "secs";
            // 
            // Secs_txt
            // 
            this.Secs_txt.Location = new System.Drawing.Point(260, 30);
            this.Secs_txt.Name = "Secs_txt";
            this.Secs_txt.Size = new System.Drawing.Size(56, 22);
            this.Secs_txt.TabIndex = 3;
            this.Secs_txt.TabStop = false;
            this.Secs_txt.Text = "0";
            this.Secs_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mins
            // 
            this.mins.AutoSize = true;
            this.mins.Location = new System.Drawing.Point(198, 33);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(35, 16);
            this.mins.TabIndex = 2;
            this.mins.Text = "mins";
            // 
            // Mins_txt
            // 
            this.Mins_txt.Location = new System.Drawing.Point(136, 30);
            this.Mins_txt.Name = "Mins_txt";
            this.Mins_txt.Size = new System.Drawing.Size(56, 22);
            this.Mins_txt.TabIndex = 1;
            this.Mins_txt.TabStop = false;
            this.Mins_txt.Text = "0";
            this.Mins_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClickOptions
            // 
            this.ClickOptions.Controls.Add(this.CBoxType);
            this.ClickOptions.Controls.Add(this.ClickType);
            this.ClickOptions.Controls.Add(this.MouseOptions);
            this.ClickOptions.Controls.Add(this.CBoxButton);
            this.ClickOptions.Location = new System.Drawing.Point(12, 94);
            this.ClickOptions.Name = "ClickOptions";
            this.ClickOptions.Size = new System.Drawing.Size(246, 100);
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
            this.CBoxType.Size = new System.Drawing.Size(105, 24);
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
            this.groupBox1.Controls.Add(this.Repeat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RBtnReInfinite);
            this.groupBox1.Controls.Add(this.RBtnRepeat);
            this.groupBox1.Location = new System.Drawing.Point(272, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click repeat";
            // 
            // Repeat
            // 
            this.Repeat.Location = new System.Drawing.Point(128, 28);
            this.Repeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(69, 22);
            this.Repeat.TabIndex = 8;
            this.Repeat.TabStop = false;
            this.Repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Repeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "times";
            // 
            // RBtnReInfinite
            // 
            this.RBtnReInfinite.AutoSize = true;
            this.RBtnReInfinite.Checked = true;
            this.RBtnReInfinite.Location = new System.Drawing.Point(18, 60);
            this.RBtnReInfinite.Name = "RBtnReInfinite";
            this.RBtnReInfinite.Size = new System.Drawing.Size(152, 20);
            this.RBtnReInfinite.TabIndex = 5;
            this.RBtnReInfinite.TabStop = true;
            this.RBtnReInfinite.Text = "Repeat until stopped";
            this.RBtnReInfinite.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 67);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursor position";
            // 
            // PointY
            // 
            this.PointY.Location = new System.Drawing.Point(470, 29);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(51, 22);
            this.PointY.TabIndex = 11;
            this.PointY.TabStop = false;
            this.PointY.Text = "0";
            this.PointY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y";
            // 
            // PointX
            // 
            this.PointX.Location = new System.Drawing.Point(392, 29);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(51, 22);
            this.PointX.TabIndex = 7;
            this.PointX.TabStop = false;
            this.PointX.Text = "0";
            this.PointX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // RBtnLocation2
            // 
            this.RBtnLocation2.AutoSize = true;
            this.RBtnLocation2.Location = new System.Drawing.Point(214, 30);
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
            this.BtnStart.Location = new System.Drawing.Point(17, 279);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(262, 54);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.TabStop = false;
            this.BtnStart.Text = "Start (F4)";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(295, 279);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(262, 54);
            this.BtnStop.TabIndex = 0;
            this.BtnStop.TabStop = false;
            this.BtnStop.Text = "Stop (F4)";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnRecord
            // 
            this.BtnRecord.Location = new System.Drawing.Point(295, 342);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(262, 54);
            this.BtnRecord.TabIndex = 0;
            this.BtnRecord.TabStop = false;
            this.BtnRecord.Text = "Record and Playback";
            this.BtnRecord.UseVisualStyleBackColor = true;
            this.BtnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // BtnHotkey
            // 
            this.BtnHotkey.Location = new System.Drawing.Point(17, 342);
            this.BtnHotkey.Name = "BtnHotkey";
            this.BtnHotkey.Size = new System.Drawing.Size(262, 54);
            this.BtnHotkey.TabIndex = 0;
            this.BtnHotkey.TabStop = false;
            this.BtnHotkey.Text = "Hotkey setting";
            this.BtnHotkey.UseVisualStyleBackColor = true;
            this.BtnHotkey.Click += new System.EventHandler(this.BtnHotkey_Click);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(574, 408);
            this.Controls.Add(this.BtnRecord);
            this.Controls.Add(this.BtnHotkey);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClickOptions);
            this.Controls.Add(this.ClickInterval);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicked by TuanDz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClickInterval.ResumeLayout(false);
            this.ClickInterval.PerformLayout();
            this.ClickOptions.ResumeLayout(false);
            this.ClickOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Hour_txt;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Button BtnLocation;
        private System.Windows.Forms.ComboBox CBoxButton;
        private System.Windows.Forms.RadioButton RBtnRepeat;
        private System.Windows.Forms.GroupBox ClickInterval;
        private System.Windows.Forms.TextBox Mins_txt;
        private System.Windows.Forms.Label miniseconds;
        private System.Windows.Forms.TextBox MiniSecs_txt;
        private System.Windows.Forms.Label secs;
        private System.Windows.Forms.TextBox Secs_txt;
        private System.Windows.Forms.Label mins;
        private System.Windows.Forms.GroupBox ClickOptions;
        private System.Windows.Forms.Label ClickType;
        private System.Windows.Forms.Label MouseOptions;
        private System.Windows.Forms.ComboBox CBoxType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBtnReInfinite;
        private System.Windows.Forms.NumericUpDown Repeat;
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

