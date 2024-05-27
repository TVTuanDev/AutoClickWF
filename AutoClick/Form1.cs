using AutoClick.Models;
using Gma.System.MouseKeyHook;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace AutoClick
{
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents _keyboardMouse;
        private bool PointClick = false;
        private bool RepeatToStop = false;

        private int MiniSecs;
        private int CountRepeat;
        private int Point_X;
        private int Point_Y;

        public Form1()
        {
            InitializeComponent();

            // ComboBox
            this.CBoxButton.SelectedIndex = 0;
            this.CBoxType.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Subscribe();
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            PointClick = true;
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            //this.BtnStart.Enabled = false;
            //this.BtnStop.Enabled = true;
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

            // Thêm hàm của sự kiện nhấp chuột
            _keyboardMouse.MouseDownExt += GlobalHookMouseDownExt;
            // Thêm hàm của sự kiện nhấn bàn phím
            _keyboardMouse.KeyUp += GlobalHookKeyUp;
        }

        private void Unsubscribe()
        {
            // Xóa hàm của sự kiện nhấp chuột
            _keyboardMouse.MouseDownExt -= GlobalHookMouseDownExt;
            // Xóa hàm của sự kiện nhấn bàn phím
            _keyboardMouse.KeyUp -= GlobalHookKeyUp;

            // Xóa đối tượng toàn cục
            // Giải phóng tài nguyên
            _keyboardMouse.Dispose();
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (PointClick)
            {
                PointClick = false;
                Point cursorPosition = Cursor.Position;
                this.PointX.Text = cursorPosition.X.ToString();
                this.PointY.Text = cursorPosition.Y.ToString();
            }
        }

        private async void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F4)
                return;
            await AutoClickHandle();
        }

        private async Task AutoClickHandle()
        {
            if (this.BtnStart.Enabled)
            {
                this.BtnStart.Enabled = false;
                this.BtnStop.Enabled = true;
            }
            else if (this.BtnStop.Enabled)
            {
                this.BtnStop.Enabled = false;
                this.BtnStart.Enabled = true;
            }

            if (this.RBtnRepeat.Checked)
                await AutoClickRepeat();
            if (this.RBtnReInfinite.Checked)
            {
                if (RepeatToStop)
                    RepeatToStop = false;
                else RepeatToStop = true;
                await AutoClickReInfinite();
            }
        }

        private async Task AutoClickRepeat()
        {
            PointClick = false;
            UpdateGlobalVariable();

            if (this.RBtnLocation1.Checked)
            {
                for (int i = 0; i < CountRepeat; i++)
                {
                    MouseClickSimulator.LeftClick();
                    await Task.Delay(MiniSecs);
                }
            }
            if (this.RBtnLocation2.Checked)
            {
                for (int i = 0; i < CountRepeat; i++)
                {
                    Cursor.Position = new Point(Point_X, Point_Y);
                    MouseClickSimulator.LeftClick();
                    await Task.Delay(MiniSecs);
                }
            }
        }

        private async Task AutoClickReInfinite()
        {
            PointClick = false;
            UpdateGlobalVariable();

            if (this.RBtnLocation1.Checked)
            {
                while (true)
                {
                    if (RepeatToStop == false) break;
                    MouseClickSimulator.LeftClick();
                    await Task.Delay(MiniSecs);
                }
            }

            if (this.RBtnLocation2.Checked)
            {
                while (true)
                {
                    if (RepeatToStop == false) break;
                    Cursor.Position = new Point(Point_X, Point_Y);
                    MouseClickSimulator.LeftClick();
                    await Task.Delay(MiniSecs);
                }
            }
            //for (int i = 0; i < CountRepeat; i++)
            //{
            //    //Cursor.Position = new Point(Point_X, Point_Y);
            //    MouseClickSimulator.LeftClick();
            //    await Task.Delay(MiniSecs);
            //}
        }

        private void UpdateGlobalVariable()
        {
            MiniSecs = int.Parse(this.MiniSecs_txt.Text);
            CountRepeat = Decimal.ToInt32(this.Repeat.Value);
            Point_X = int.Parse(this.PointX.Text);
            Point_Y = int.Parse(this.PointY.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }
    }
}
