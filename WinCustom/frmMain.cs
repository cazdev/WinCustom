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
using WinCustom.Properties;

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

        private frmDisplay display = new frmDisplay()
        {
            TopLevel = false,
            AutoScroll = true
        };

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

        private void mainNext_MouseEnter(object sender, EventArgs e)
        {
            mainNextContext.BackgroundImage = Resources.next_button_hover;
        }

        private void mainNext_MouseLeave(object sender, EventArgs e)
        {
            mainNextContext.BackgroundImage = Resources.next_button;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            side.Location = new Point(-133, side.Location.Y);
        }

        private void mainNextContext_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(RegistryManager.AppData))
            {
                Directory.CreateDirectory(RegistryManager.AppData);
            }

            hoverCollapse.BringToFront();

            // Hide previous controls
            display.mainPrevious.Hide();
            mainLogo.Hide();
            mainSubtitle.Hide();
            mainNextContext.Hide();

            sideContextMenu.BackColor = Color.FromArgb(52, 152, 219);

            if (RegistryManager.RegistryValueExists(
                @"HKEY_CLASSES_ROOT\Allfilesystemobjects\shell\windows.copyaspath", "InvokeCommandOnSelection"))
            {
                display.mainCheckBox.Checked = true;
            }
            else
            {
                display.mainCheckBox.Checked = false;
            }

            main.Controls.Add(display);
            //display next screen
            display.Show();
            display.Enabled = true; ;
        }

        private void sideHome_Click(object sender, EventArgs e)
        {
            // Hide previous controls
            mainLogo.Show();
            mainSubtitle.Show();
            mainNextContext.Show();
            sideContextMenu.BackColor = Color.FromArgb(40,40,40);
            sideControlPanel.BackColor = Color.FromArgb(40, 40, 40);
            sideCortana.BackColor = Color.FromArgb(40, 40, 40);
            sideStartMenu.BackColor = Color.FromArgb(40, 40, 40);
            sideTaskbar.BackColor = Color.FromArgb(40, 40, 40);

            display.Hide();
            display.Enabled = false;
        }
    }
}
