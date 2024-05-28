using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public HotkeySetting(AutoClicker autoClicker)
        {
            InitializeComponent();
            _autoClicker = autoClicker;
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

        private void CancelHotkey_Click(object sender, EventArgs e)
        {
            _autoClicker.Hotkey = true;
            this.Close();
        }

        private void StartAndStop_Click(object sender, EventArgs e)
        {
            Subscribe();
            this.Hotkey_txt.Text = "Please key";
            this.StartAndStop.Enabled = false;
            this.OkHotkey.Enabled = false;
            this.CancelHotkey.Enabled = false;
            //this.Hotkey_txt.Focused = false;
        }
    }
}
