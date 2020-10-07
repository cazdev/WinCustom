using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        delegate void SetLocationCallback(Form frm, Control ctrl, Point location);

        private void SetLocation(Form frm, Control ctrl, Point location)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.side.InvokeRequired)
            {
                SetLocationCallback d = new SetLocationCallback(SetLocation);
                this.Invoke(d, new object[] { frm, ctrl, location });
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
                    SetLocation(this, c, new Point(c.Location.X + 4, c.Location.Y));
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
                    SetLocation(this, c, new Point(c.Location.X - 4, c.Location.Y));
                    Thread.Sleep(1);
                }
            }
        }

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

        private void mainNext_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(RegistryManager.AppData))
            {
                Directory.CreateDirectory(RegistryManager.AppData);
            }

            hoverCollapse.BringToFront();

            // Hide previous controls
            mainLogo.Hide();
            mainSubtitle.Hide();
            mainNext.Hide();

            // Display next screen
            frmContextMenu frm = new frmContextMenu() {
                TopLevel = false,
                AutoScroll = true
            };
            main.Controls.Add(frm);
            frm.Show();
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cazdev/wincustom");
        }

        private void mainSubtitle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cazdev/wincustom");
        }

        private void hoverExpand_MouseEnter(object sender, EventArgs e)
        {
            if (side.Location.X < 0)
            {
                var t = new Thread(() => expandControl(side, -6));
                t.Start();
            }
        }

        private void hoverCollapse_MouseEnter(object sender, EventArgs e)
        {
            var t = new Thread(() => collapseControl(side, -130));
            t.Start();
        }
    }
}
