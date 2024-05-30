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
            this.MoreRecord = new System.Windows.Forms.Button();
            this.StopRecord = new System.Windows.Forms.Button();
            this.PlayRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoreRecord
            // 
            this.MoreRecord.Location = new System.Drawing.Point(225, 12);
            this.MoreRecord.Name = "MoreRecord";
            this.MoreRecord.Size = new System.Drawing.Size(90, 45);
            this.MoreRecord.TabIndex = 3;
            this.MoreRecord.TabStop = false;
            this.MoreRecord.Text = "More";
            this.MoreRecord.UseVisualStyleBackColor = true;
            // 
            // StopRecord
            // 
            this.StopRecord.BackgroundImage = global::AutoClick.Properties.Resources.circle_24;
            this.StopRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StopRecord.Location = new System.Drawing.Point(119, 12);
            this.StopRecord.Name = "StopRecord";
            this.StopRecord.Size = new System.Drawing.Size(90, 45);
            this.StopRecord.TabIndex = 2;
            this.StopRecord.TabStop = false;
            this.StopRecord.UseVisualStyleBackColor = true;
            this.StopRecord.Click += new System.EventHandler(this.StopRecord_Click);
            // 
            // PlayRecord
            // 
            this.PlayRecord.BackgroundImage = global::AutoClick.Properties.Resources.play_24;
            this.PlayRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayRecord.Location = new System.Drawing.Point(12, 12);
            this.PlayRecord.Name = "PlayRecord";
            this.PlayRecord.Size = new System.Drawing.Size(90, 45);
            this.PlayRecord.TabIndex = 1;
            this.PlayRecord.TabStop = false;
            this.PlayRecord.UseVisualStyleBackColor = true;
            this.PlayRecord.Click += new System.EventHandler(this.PlayRecord_Click);
            // 
            // RecordAndPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 71);
            this.Controls.Add(this.StopRecord);
            this.Controls.Add(this.PlayRecord);
            this.Controls.Add(this.MoreRecord);
            this.MaximizeBox = false;
            this.Name = "RecordAndPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordAndPlay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecordAndPlay_FormClosing);
            this.Load += new System.EventHandler(this.RecordAndPlay_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MoreRecord;
        private System.Windows.Forms.Button PlayRecord;
        private System.Windows.Forms.Button StopRecord;
    }
}