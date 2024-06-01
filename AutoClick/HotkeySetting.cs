using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class HotkeySetting : Form
    {
        private IKeyboardMouseEvents _keyboardMouse;
        private AutoClicker _autoClicker;
        private const string FilePath = "AutoClicker/data.txt";

        public HotkeySetting(AutoClicker autoClicker)
        {
            InitializeComponent();
            _autoClicker = autoClicker;
        }

        private void HotkeySetting_Load(object sender, EventArgs e)
        {
            this.Hotkey_txt.Text = _autoClicker.GetHotkey();
        }

        private void Subscribe()
        {
            _keyboardMouse = Hook.GlobalEvents();
            _keyboardMouse.KeyUp += KeyUpHotkey;
        }

        private void Unsubscribe()
        {
            _keyboardMouse.KeyUp -= KeyUpHotkey;
            _keyboardMouse.Dispose();
        }

        private void KeyUpHotkey(object sender, KeyEventArgs e)
        {
            this.Hotkey_txt.Text = e.KeyCode.ToString();
            this.StartAndStop.Enabled = true;
            this.OkHotkey.Enabled = true;
            this.CancelHotkey.Enabled = true;

            Unsubscribe();
        }

        private void StartAndStop_Click(object sender, EventArgs e)
        {
            Subscribe();
            this.Hotkey_txt.Text = "Please key";
            this.StartAndStop.Enabled = false;
            this.OkHotkey.Enabled = false;
            this.CancelHotkey.Enabled = false;
        }

        private void OkHotkey_Click(object sender, EventArgs e)
        {
            // Đọc nội dung của file vào danh sách
            List<string> lines = File.ReadAllLines(_autoClicker.GetFilePath()).ToList();

            // Tìm và cập nhật nội dung của hotkey và location
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith("Hotkey:"))
                {
                    lines[i] = "Hotkey: " + this.Hotkey_txt.Text;
                }
            }

            // Ghi lại toàn bộ nội dung đã cập nhật vào file
            File.WriteAllLines(_autoClicker.GetFilePath(), lines);

            _autoClicker.Show();
            _autoClicker.Form1_Load(sender, e);
            this.Close();
        }

        private void CancelHotkey_Click(object sender, EventArgs e)
        {
            _autoClicker.Show();
            _autoClicker.Form1_Load(sender, e);
            this.Close();
        }
    }
}
