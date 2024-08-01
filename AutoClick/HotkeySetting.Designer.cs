namespace AutoClick
{
    partial class HotkeySetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeySetting));
            this.Hotkey_txt = new System.Windows.Forms.TextBox();
            this.StartAndStop = new System.Windows.Forms.Button();
            this.OkHotkey = new System.Windows.Forms.Button();
            this.CancelHotkey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hotkey_txt
            // 
            this.Hotkey_txt.Enabled = false;
            this.Hotkey_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hotkey_txt.Location = new System.Drawing.Point(140, 12);
            this.Hotkey_txt.Multiline = true;
            this.Hotkey_txt.Name = "Hotkey_txt";
            this.Hotkey_txt.Size = new System.Drawing.Size(128, 40);
            this.Hotkey_txt.TabIndex = 0;
            this.Hotkey_txt.TabStop = false;
            this.Hotkey_txt.Text = "F4";
            this.Hotkey_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartAndStop
            // 
            this.StartAndStop.Location = new System.Drawing.Point(12, 12);
            this.StartAndStop.Name = "StartAndStop";
            this.StartAndStop.Size = new System.Drawing.Size(122, 40);
            this.StartAndStop.TabIndex = 0;
            this.StartAndStop.TabStop = false;
            this.StartAndStop.Text = "Change key";
            this.StartAndStop.UseVisualStyleBackColor = true;
            this.StartAndStop.Click += new System.EventHandler(this.StartAndStop_Click);
            // 
            // OkHotkey
            // 
            this.OkHotkey.Location = new System.Drawing.Point(44, 68);
            this.OkHotkey.Name = "OkHotkey";
            this.OkHotkey.Size = new System.Drawing.Size(72, 35);
            this.OkHotkey.TabIndex = 0;
            this.OkHotkey.TabStop = false;
            this.OkHotkey.Text = "Ok";
            this.OkHotkey.UseVisualStyleBackColor = true;
            this.OkHotkey.Click += new System.EventHandler(this.OkHotkey_Click);
            // 
            // CancelHotkey
            // 
            this.CancelHotkey.Location = new System.Drawing.Point(151, 68);
            this.CancelHotkey.Name = "CancelHotkey";
            this.CancelHotkey.Size = new System.Drawing.Size(90, 35);
            this.CancelHotkey.TabIndex = 0;
            this.CancelHotkey.TabStop = false;
            this.CancelHotkey.Text = "Cancel";
            this.CancelHotkey.UseVisualStyleBackColor = true;
            this.CancelHotkey.Click += new System.EventHandler(this.CancelHotkey_Click);
            // 
            // HotkeySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 118);
            this.ControlBox = false;
            this.Controls.Add(this.CancelHotkey);
            this.Controls.Add(this.OkHotkey);
            this.Controls.Add(this.StartAndStop);
            this.Controls.Add(this.Hotkey_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotkeySetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotkeySetting";
            this.Load += new System.EventHandler(this.HotkeySetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hotkey_txt;
        private System.Windows.Forms.Button StartAndStop;
        private System.Windows.Forms.Button OkHotkey;
        private System.Windows.Forms.Button CancelHotkey;
    }
}