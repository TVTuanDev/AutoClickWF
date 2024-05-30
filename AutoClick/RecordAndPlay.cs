using AutoClick.Models;
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
    public partial class RecordAndPlay : Form
    {
        private AutoClicker _autoClicker;
        private IKeyboardMouseEvents _keyboardMouse;

        private List<ClickInfo> ClickInfoList;

        public RecordAndPlay(AutoClicker autoClicker)
        {
            InitializeComponent();
            _autoClicker = autoClicker;
        }

        private void RecordAndPlay_Load(object sender, EventArgs e)
        {
            
        }

        private void Subscribe()
        {
            _keyboardMouse = Hook.GlobalEvents();
            _keyboardMouse.MouseDownExt += RecordMouseClick;
        }

        private void Unsubscribe()
        {
            _keyboardMouse.MouseDownExt -= RecordMouseClick;
            _keyboardMouse.Dispose();
        }

        private void RecordMouseClick(object sender, MouseEventArgs e)
        {
            var clickInfo = new ClickInfo
            {
                Point_x = e.X,
                Point_y = e.Y,
                TimeDelay = DateTime.UtcNow,
                TypeButton = e.Button.ToString()
            };
            ClickInfoList.Add(clickInfo);
            MessageBox.Show($"Type button: {clickInfo}");
        }
        private void PlayRecord_Click(object sender, EventArgs e)
        {
            Subscribe();
        }

        private void StopRecord_Click(object sender, EventArgs e)
        {
            Unsubscribe();
        }

        private void RecordAndPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            _autoClicker.Show();
            _autoClicker.Form1_Load(sender, e);
        }
    }
}
