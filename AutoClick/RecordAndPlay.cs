using AutoClick.Models;
using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private List<ClickInfo> ClickInfoList = new List<ClickInfo>();
        private bool RecordBtn = true;
        private bool EventClick = false;
        private bool LoopClick = false;

        private string PlayImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "play-24.png");
        private string CircleImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "circle-24.png");
        private string SquareImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "square-24.png");

        public RecordAndPlay(AutoClicker autoClicker)
        {
            InitializeComponent();
            _autoClicker = autoClicker;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.PlayRecord, "Playback");
            toolTip.SetToolTip(this.BtnRecord, "Start recording");
        }

        private void RecordAndPlay_Load(object sender, EventArgs e)
        {
            Subscribe();
        }

        private void Subscribe()
        {
            _keyboardMouse = Hook.GlobalEvents();
            _keyboardMouse.MouseDownExt += RecordMouseClick;
            _keyboardMouse.KeyDown += RecordMouseKeyDown;
        }

        private void Unsubscribe()
        {
            _keyboardMouse.MouseDownExt -= RecordMouseClick;
            _keyboardMouse.KeyDown -= RecordMouseKeyDown;
            _keyboardMouse.Dispose();
        }

        private void RecordMouseClick(object sender, MouseEventArgs e)
        {
            if (!EventClick)
                return;
            Point cursor = Cursor.Position;
            var clickInfo = new ClickInfo
            {
                Point_x = cursor.X,
                Point_y = cursor.Y,
                TimeDelay = DateTime.UtcNow,
                TypeButton = e.Button.ToString()
            };
            ClickInfoList.Add(clickInfo);
        }

        private async void RecordMouseKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D2)
            {
                MessageBox.Show("Ctrl + 2 pressed!");
                return;
            }
            if (e.KeyCode != Keys.F6)
                return;
            HandleImagePlayRecord();
            LoopClick = LoopClick ? false : true;
            await ClickHandleRecord();
            HandleImagePlayRecord();
        }

        private async void PlayRecord_Click(object sender, EventArgs e)
        {
            try
            {
                HandleImagePlayRecord();

                await ClickHandleRecord();

                HandleImagePlayRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                this.BtnRecord.BackgroundImage =
                RecordBtn ? Image.FromFile(SquareImagePath)
                : Image.FromFile(CircleImagePath);
                this.PlayRecord.Enabled = RecordBtn ? false : true;

                if (RecordBtn)
                {
                    EventClick = true;
                    ClickInfoList = new List<ClickInfo>();
                    ClickInfo clickInfo = new ClickInfo
                    {
                        Point_x = 0,
                        Point_y = 0,
                        TimeDelay = DateTime.UtcNow,
                        TypeButton = string.Empty
                    };
                    ClickInfoList.Add(clickInfo);
                }
                else
                {
                    EventClick = false;
                }

                RecordBtn = RecordBtn ? false : true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MoreRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được nghiên cứu!");
        }

        private void HandleRecord()
        {

        }

        private async Task ClickHandleRecord()
        {
            try
            {
                while (LoopClick)
                {
                    for (int i = 0; i < ClickInfoList.Count(); i++)
                    {
                        TimeSpan delay = i < ClickInfoList.Count() - 1
                            ? ClickInfoList[i + 1].TimeDelay - ClickInfoList[i].TimeDelay
                            : TimeSpan.FromMilliseconds(0);
                        if (i == 0 || i == ClickInfoList.Count() - 1)
                        {
                            await Task.Delay(delay);
                            continue;
                        }

                        Cursor.Position = new Point(ClickInfoList[i].Point_x, ClickInfoList[i].Point_y);
                        if (ClickInfoList[i].TypeButton == "Left")
                        {
                            MouseClickSimulator.LeftClick();
                        }
                        else if (ClickInfoList[i].TypeButton == "Right")
                        {
                            MouseClickSimulator.RightClick();
                        }
                        else
                        {
                            MouseClickSimulator.MiddleClick();
                        }

                        await Task.Delay(delay);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HandleImagePlayRecord()
        {
            this.PlayRecord.BackgroundImage =
                RecordBtn ? Image.FromFile(SquareImagePath)
                : Image.FromFile(PlayImagePath);
            this.BtnRecord.Enabled = RecordBtn ? false : true;

            RecordBtn = RecordBtn ? false : true;
        }

        private string GetHotkey()
        {
            List<string> lines = File.ReadAllLines(_autoClicker.GetFilePath()).ToList();

            string hotkey = string.Empty;
            foreach (var line in lines)
            {
                if (line.StartsWith("Hotkey:"))
                {
                    hotkey = line.Substring("Hotkey:".Length).Trim();
                }
            }

            return hotkey.ToString();
        }

        private void RecordAndPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
            _autoClicker.Show();
            _autoClicker.Form1_Load(sender, e);
        }
    }
}
