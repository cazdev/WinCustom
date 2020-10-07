using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCustom
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        //Fix control flickering
        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void topDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void topMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainSideButton_Click(object sender, EventArgs e)
        {
            if (side.Location.X < 0)
            {
                mainSideButton.BackColor = Color.FromArgb(40, 40, 40);
                var t = new Thread(() => expandControl(side, 0));
                t.Start();
            }
        }

        private void sideButton_Click(object sender, EventArgs e)
        {
            mainSideButton.BackColor = Color.FromArgb(30, 30, 30);
            var t = new Thread(() => collapseControl(side, -135));
            t.Start();
        }

        delegate void SetLocationCallback(Form frm, Control ctrl, Point location);

        private void SetLocation(Form frm, Control ctrl, Point location)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.side.InvokeRequired)
            {
                SetLocationCallback d = new SetLocationCallback(SetLocation);
                this.Invoke(d, new object[] {frm, ctrl, location });
            }
            else
            {
                this.side.Location = location;
            }
        }

        public void expandControl(Control c, int expandTo)
        {
            if (c.Location.X < expandTo)
            {
                while (c.Location.X < expandTo)
                {
                    //Thread safe control location change
                    SetLocation(this, c, new Point(c.Location.X+1, c.Location.Y));
                    Thread.Sleep(1);
                }
            }
        }

        public void collapseControl(Control c, int collapseTo)
        {
            if (c.Location.X > collapseTo)
            {
                while (c.Location.X > collapseTo)
                {
                    //Thread safe control location change
                    SetLocation(this, c, new Point(c.Location.X - 1, c.Location.Y));
                    Thread.Sleep(1);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Custon event handler for sideMenuList in order to change listbox selection colour
            sideMenuList.DrawMode = DrawMode.OwnerDrawFixed;
            this.sideMenuList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(sideMenuList_DrawItem);
            this.sideMenuList.SelectedIndexChanged += new System.EventHandler(sideMenuList_SelectedIndexChanged);
        }

        private void sideMenuList_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.DrawBackground();

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(59, 133, 211)), e.Bounds);
            }

            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void sideMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sideMenuList.Invalidate();
        }
    }
}
