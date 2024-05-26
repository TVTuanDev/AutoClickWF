using AutoClick.Models;
using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace AutoClick
{
    public partial class Form1 : Form
    {
        private MouseHook _mouseHook;
        private IKeyboardMouseEvents _keyboardMouse;
        private InputSimulator _inputSimulator;
        private bool PointClick = false;

        public Form1()
        {
            InitializeComponent();
            _inputSimulator = new InputSimulator();

            //_mouseHook = new MouseHook();
            //_mouseHook.OnMouseAction += new MouseHook.MouseActionEventHandler(MouseHook_OnMouseAction);
            //_mouseHook.SetHook();

            // KeyUp
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);

            // ComboBox
            this.CBoxButton.SelectedIndex = 0;
            this.CBoxType.SelectedIndex = 0;

            // ClickMouse
            //this.MouseClick += new MouseEventHandler(GetLocationPoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Subscribe();
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            PointClick = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Bạn đã bấm phím: " + e.KeyCode);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.BtnStop.Enabled = true;
            this.BtnStart.Enabled = false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            this.BtnStart.Enabled = true;
            this.BtnStop.Enabled = false;
        }

        //private void MouseHook_OnMouseAction(object sender, MouseEventArgs e)
        //{
        //    if (PointClick)
        //    {
        //        PointClick = false;
        //        this.PointX.Text = e.X.ToString();
        //        this.PointY.Text = e.Y.ToString();
        //    }
        //}

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    _mouseHook.Unhook();
        //    base.OnFormClosing(e);
        //}

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

        private void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                PointClick = false;
                //MessageBox.Show($"Key Pressed: {e.KeyCode}");
                int x = int.Parse(this.PointX.Text);
                int y = int.Parse(this.PointY.Text);
                //MessageBox.Show($"Point: {x}, {y}");
                _inputSimulator.Mouse.MoveMouseToPositionOnVirtualDesktop(x, y);
                _inputSimulator.Mouse.LeftButtonClick();
                //MouseClickSimulator.SimulateLeftClick(x, y);

                //Point position = Cursor.Position;
                //MessageBox.Show($"Mouse Down: {position}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }

        //private void GetLocationPoint(object sender, MouseEventArgs e)
        //{
        //    //Point clickPoint = e.Location;
        //    Point cursorPoint;
        //    if (GetCursorPos(out cursorPoint))
        //    {
        //        MessageBox.Show("Vị trí chuột click: " + cursorPoint.X + " : " + cursorPoint.Y);
        //    }
        //}

        //[DllImport("user32.dll")]
        //static extern bool GetCursorPos(out Point lpPoint);
    }
}
