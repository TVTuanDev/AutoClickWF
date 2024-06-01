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

        private async void PlayRecord_Click(object sender, EventArgs e)
        {
            try
            {
                HandlePlayRecord();

                await ClickHandleRecord();

                HandlePlayRecord();
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
                    Subscribe();
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
                    Unsubscribe();
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

        private async Task ClickHandleRecord()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HandlePlayRecord()
        {
            this.PlayRecord.BackgroundImage =
                RecordBtn ? Image.FromFile(SquareImagePath)
                : Image.FromFile(PlayImagePath);
            this.BtnRecord.Enabled = RecordBtn ? false : true;

            RecordBtn = RecordBtn ? false : true;
        }

        private void RecordAndPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            _autoClicker.Show();
            _autoClicker.Form1_Load(sender, e);
        }
    }
}
