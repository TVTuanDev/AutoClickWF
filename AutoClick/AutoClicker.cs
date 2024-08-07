﻿using AutoClick.Models;
using Gma.System.MouseKeyHook;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AutoClick
{
    public partial class AutoClicker : Form
    {
        private IKeyboardMouseEvents _keyboardMouse;
        private const string FilePath = "AutoClicker/data.txt";
        private bool RepeatToStop = false;

        private int MiniSecs;
        private int CountRepeat;
        private int Point_X;
        private int Point_Y;

        public AutoClicker()
        {
            InitializeComponent();

            // ComboBox
            this.CBoxButton.SelectedIndex = 0;
            this.CBoxType.SelectedIndex = 0;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Subscribe();

            if (!File.Exists(GetFilePath()))
            {
                // Đường dẫn đến thư mục
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string autoClickPath = Path.Combine(appDataPath, "AutoClicker");

                if (!Directory.Exists(autoClickPath))
                {
                    Directory.CreateDirectory(autoClickPath);
                }

                using (StreamWriter sw = File.CreateText(GetFilePath()))
                {
                    sw.WriteLine(@"Hotkey: F4");
                    sw.WriteLine(@"Location: 0,0");
                }
            }
            else
            {
                this.BtnStart.Text = $"Start ({GetHotkey()})";
                this.BtnStop.Text = $"Stop ({GetHotkey()})";
            }
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            _keyboardMouse.MouseDownExt += GlobalHookMouseDownExt;
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            await AutoClickHandle();
        }

        private async void BtnStop_Click(object sender, EventArgs e)
        {
            await AutoClickHandle();
        }

        private void Subscribe()
        {
            // Tạo đối tượng toàn cục để bắt sự kiện
            _keyboardMouse = Hook.GlobalEvents();

            // Thêm hàm của sự kiện nhấn bàn phím
            _keyboardMouse.KeyUp += GlobalHookKeyUp;
        }

        private void Unsubscribe()
        {
            // Xóa hàm của sự kiện nhấn bàn phím
            _keyboardMouse.KeyUp -= GlobalHookKeyUp;

            // Xóa đối tượng toàn cục
            // Giải phóng tài nguyên
            _keyboardMouse.Dispose();
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            Point cursorPosition = Cursor.Position;
            this.PointX.Text = cursorPosition.X.ToString();
            this.PointY.Text = cursorPosition.Y.ToString();

            _keyboardMouse.MouseDownExt -= GlobalHookMouseDownExt;
        }

        private async void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != GetHotkey())
                return;

            await AutoClickHandle();
        }

        private async Task AutoClickHandle()
        {
            this.BtnStart.Enabled = this.BtnStart.Enabled ? false : true;
            this.BtnStop.Enabled = this.BtnStop.Enabled ? false : true;

            if (this.RBtnRepeat.Checked)
                await AutoClickRepeat();
            if (this.RBtnReInfinite.Checked)
            {
                RepeatToStop = RepeatToStop ? false : true;
                await AutoClickReInfinite();
            }
        }

        private async Task AutoClickRepeat()
        {
            UpdateGlobalVariable();

            if (this.RBtnLocation1.Checked)
            {
                for (int i = 0; i < CountRepeat; i++)
                {
                    await this.Clicker();
                    await Task.Delay(MiniSecs);
                }
            }
            if (this.RBtnLocation2.Checked)
            {
                for (int i = 0; i < CountRepeat; i++)
                {
                    Cursor.Position = new Point(Point_X, Point_Y);
                    await this.Clicker();
                    await Task.Delay(MiniSecs);
                }
            }
            this.BtnStart.Enabled = this.BtnStart.Enabled ? false : true;
            this.BtnStop.Enabled = this.BtnStop.Enabled ? false : true;
        }

        private async Task AutoClickReInfinite()
        {
            UpdateGlobalVariable();

            if (this.RBtnLocation1.Checked)
            {
                while (true)
                {
                    if (RepeatToStop == false) break;
                    await this.Clicker();
                    await Task.Delay(MiniSecs);
                }
            }

            if (this.RBtnLocation2.Checked)
            {
                while (true)
                {
                    if (RepeatToStop == false) break;
                    Cursor.Position = new Point(Point_X, Point_Y);
                    await this.Clicker();
                    await Task.Delay(MiniSecs);
                }
            }
        }

        private void UpdateGlobalVariable()
        {
            int hours = int.Parse(this.Hour_txt.Text);
            int mins = int.Parse(this.Mins_txt.Text);
            int secs = int.Parse(this.Secs_txt.Text);
            int minisec = int.Parse(this.MiniSecs_txt.Text);
            MiniSecs = hours * 60 * 60 * 1000 + mins * 60 * 1000 + secs * 1000 + minisec;
            CountRepeat = Decimal.ToInt32(this.Repeat.Value);
            Point_X = int.Parse(this.PointX.Text);
            Point_Y = int.Parse(this.PointY.Text);
        }

        private async Task Clicker()
        {
            if (this.CBoxType.Text == "Single")
            {
                if (this.CBoxButton.Text == "Left")
                    MouseClickSimulator.LeftClick();
                else if (this.CBoxButton.Text == "Right")
                    MouseClickSimulator.RightClick();
                else MouseClickSimulator.MiddleClick();
            }
            else
            {
                if (this.CBoxButton.Text == "Left")
                    MouseClickSimulator.LeftClick();
                else if (this.CBoxButton.Text == "Right")
                    MouseClickSimulator.RightClick();
                else MouseClickSimulator.MiddleClick();

                await Task.Delay(100);

                if (this.CBoxButton.Text == "Left")
                    MouseClickSimulator.LeftClick();
                else if (this.CBoxButton.Text == "Right")
                    MouseClickSimulator.RightClick();
                else MouseClickSimulator.MiddleClick();
            }
        }

        private void BtnHotkey_Click(object sender, EventArgs e)
        {
            Unsubscribe();
            HotkeySetting hotkeySetting = new HotkeySetting(this);
            this.Hide();
            hotkeySetting.Show();
        }

        private void BtnRecord_Click(object sender, EventArgs e)
        {
            Unsubscribe();
            RecordAndPlay recordAndPlay = new RecordAndPlay(this);
            this.Hide();
            recordAndPlay.Show();
        }

        public string GetFilePath()
        {
            // Đường dẫn đến thư mục 
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Đường dẫn đầy đủ tới tệp tin
            string filePath = Path.Combine(appDataPath, FilePath);

            return filePath;
        }

        public string GetHotkey()
        {
            List<string> lines = File.ReadAllLines(GetFilePath()).ToList();

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }
    }
}
