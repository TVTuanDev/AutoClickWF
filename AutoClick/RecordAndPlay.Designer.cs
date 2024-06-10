namespace AutoClick
{
    partial class RecordAndPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordAndPlay));
            this.MoreRecord = new System.Windows.Forms.Button();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.PlayRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Repeat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RBtnReInfinite = new System.Windows.Forms.RadioButton();
            this.RBtnRepeat = new System.Windows.Forms.RadioButton();
            this.ClickInterval = new System.Windows.Forms.GroupBox();
            this.miniseconds = new System.Windows.Forms.Label();
            this.MiniSecs_txt = new System.Windows.Forms.TextBox();
            this.secs = new System.Windows.Forms.Label();
            this.Secs_txt = new System.Windows.Forms.TextBox();
            this.mins = new System.Windows.Forms.Label();
            this.Mins_txt = new System.Windows.Forms.TextBox();
            this.Hour_txt = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat)).BeginInit();
            this.ClickInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // MoreRecord
            // 
            this.MoreRecord.Location = new System.Drawing.Point(155, 91);
            this.MoreRecord.Name = "MoreRecord";
            this.MoreRecord.Size = new System.Drawing.Size(90, 45);
            this.MoreRecord.TabIndex = 3;
            this.MoreRecord.TabStop = false;
            this.MoreRecord.Text = "More";
            this.MoreRecord.UseVisualStyleBackColor = true;
            this.MoreRecord.Click += new System.EventHandler(this.MoreRecord_Click);
            // 
            // BtnRecord
            // 
            this.BtnRecord.BackgroundImage = global::AutoClick.Properties.Resources.circle_24;
            this.BtnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRecord.Location = new System.Drawing.Point(155, 146);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(90, 45);
            this.BtnRecord.TabIndex = 2;
            this.BtnRecord.TabStop = false;
            this.BtnRecord.UseVisualStyleBackColor = true;
            this.BtnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // PlayRecord
            // 
            this.PlayRecord.BackgroundImage = global::AutoClick.Properties.Resources.play_24;
            this.PlayRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayRecord.Enabled = false;
            this.PlayRecord.Location = new System.Drawing.Point(29, 146);
            this.PlayRecord.Name = "PlayRecord";
            this.PlayRecord.Size = new System.Drawing.Size(90, 45);
            this.PlayRecord.TabIndex = 1;
            this.PlayRecord.TabStop = false;
            this.PlayRecord.UseVisualStyleBackColor = true;
            this.PlayRecord.Click += new System.EventHandler(this.PlayRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Repeat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RBtnReInfinite);
            this.groupBox1.Controls.Add(this.RBtnRepeat);
            this.groupBox1.Location = new System.Drawing.Point(266, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click repeat";
            // 
            // Repeat
            // 
            this.Repeat.Location = new System.Drawing.Point(91, 30);
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
            this.label1.Location = new System.Drawing.Point(166, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "times";
            // 
            // RBtnReInfinite
            // 
            this.RBtnReInfinite.AutoSize = true;
            this.RBtnReInfinite.Location = new System.Drawing.Point(6, 64);
            this.RBtnReInfinite.Name = "RBtnReInfinite";
            this.RBtnReInfinite.Size = new System.Drawing.Size(152, 20);
            this.RBtnReInfinite.TabIndex = 5;
            this.RBtnReInfinite.Text = "Repeat until stopped";
            this.RBtnReInfinite.UseVisualStyleBackColor = true;
            // 
            // RBtnRepeat
            // 
            this.RBtnRepeat.AutoSize = true;
            this.RBtnRepeat.Checked = true;
            this.RBtnRepeat.Location = new System.Drawing.Point(6, 32);
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
            this.ClickInterval.Size = new System.Drawing.Size(471, 73);
            this.ClickInterval.TabIndex = 8;
            this.ClickInterval.TabStop = false;
            this.ClickInterval.Text = "Click interval";
            // 
            // miniseconds
            // 
            this.miniseconds.AutoSize = true;
            this.miniseconds.Location = new System.Drawing.Point(329, 33);
            this.miniseconds.Name = "miniseconds";
            this.miniseconds.Size = new System.Drawing.Size(83, 16);
            this.miniseconds.TabIndex = 6;
            this.miniseconds.Text = "miniseconds";
            // 
            // MiniSecs_txt
            // 
            this.MiniSecs_txt.Location = new System.Drawing.Point(283, 30);
            this.MiniSecs_txt.Name = "MiniSecs_txt";
            this.MiniSecs_txt.Size = new System.Drawing.Size(40, 22);
            this.MiniSecs_txt.TabIndex = 5;
            this.MiniSecs_txt.TabStop = false;
            this.MiniSecs_txt.Text = "0";
            this.MiniSecs_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // secs
            // 
            this.secs.AutoSize = true;
            this.secs.Location = new System.Drawing.Point(239, 33);
            this.secs.Name = "secs";
            this.secs.Size = new System.Drawing.Size(36, 16);
            this.secs.TabIndex = 4;
            this.secs.Text = "secs";
            // 
            // Secs_txt
            // 
            this.Secs_txt.Location = new System.Drawing.Point(193, 30);
            this.Secs_txt.Name = "Secs_txt";
            this.Secs_txt.Size = new System.Drawing.Size(40, 22);
            this.Secs_txt.TabIndex = 3;
            this.Secs_txt.TabStop = false;
            this.Secs_txt.Text = "0";
            this.Secs_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mins
            // 
            this.mins.AutoSize = true;
            this.mins.Location = new System.Drawing.Point(147, 33);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(35, 16);
            this.mins.TabIndex = 2;
            this.mins.Text = "mins";
            // 
            // Mins_txt
            // 
            this.Mins_txt.Location = new System.Drawing.Point(101, 30);
            this.Mins_txt.Name = "Mins_txt";
            this.Mins_txt.Size = new System.Drawing.Size(40, 22);
            this.Mins_txt.TabIndex = 1;
            this.Mins_txt.TabStop = false;
            this.Mins_txt.Text = "0";
            this.Mins_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Hour_txt
            // 
            this.Hour_txt.Location = new System.Drawing.Point(6, 30);
            this.Hour_txt.Name = "Hour_txt";
            this.Hour_txt.Size = new System.Drawing.Size(40, 22);
            this.Hour_txt.TabIndex = 0;
            this.Hour_txt.TabStop = false;
            this.Hour_txt.Text = "0";
            this.Hour_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Location = new System.Drawing.Point(51, 33);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(40, 16);
            this.hours.TabIndex = 1;
            this.hours.Text = "hours";
            // 
            // Speed
            // 
            this.Speed.Enabled = false;
            this.Speed.Location = new System.Drawing.Point(69, 103);
            this.Speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(69, 22);
            this.Speed.TabIndex = 12;
            this.Speed.TabStop = false;
            this.Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Speed";
            // 
            // RecordAndPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 202);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClickInterval);
            this.Controls.Add(this.BtnRecord);
            this.Controls.Add(this.PlayRecord);
            this.Controls.Add(this.MoreRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RecordAndPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordAndPlay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecordAndPlay_FormClosing);
            this.Load += new System.EventHandler(this.RecordAndPlay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat)).EndInit();
            this.ClickInterval.ResumeLayout(false);
            this.ClickInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MoreRecord;
        private System.Windows.Forms.Button PlayRecord;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Repeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBtnReInfinite;
        private System.Windows.Forms.RadioButton RBtnRepeat;
        private System.Windows.Forms.GroupBox ClickInterval;
        private System.Windows.Forms.Label miniseconds;
        private System.Windows.Forms.TextBox MiniSecs_txt;
        private System.Windows.Forms.Label secs;
        private System.Windows.Forms.TextBox Secs_txt;
        private System.Windows.Forms.Label mins;
        private System.Windows.Forms.TextBox Mins_txt;
        private System.Windows.Forms.TextBox Hour_txt;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.Label label2;
    }
}