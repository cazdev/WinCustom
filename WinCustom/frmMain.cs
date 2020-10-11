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
            ScreenManager.main = this;

            if (!Directory.Exists(RegistryManager.AppData))
            {
                Directory.CreateDirectory(RegistryManager.AppData);
            }
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
            mainNext.BackgroundImage = Resources.next_button_hover;
        }

        private void mainNext_MouseLeave(object sender, EventArgs e)
        {
            mainNext.BackgroundImage = Resources.next_button;
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
            if (!sideCollapse.Enabled)
            {
                sideExpand.Enabled = true;
            }
        }

        private void hoverCollapse_MouseEnter(object sender, EventArgs e)
        {
            if (sideExpand.Enabled)
            {
                sideExpand.Enabled = false;
            }
            
            sideCollapse.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mainSettings.Hide();
            mainAbout.Hide();
            side.Location = new Point(-133, side.Location.Y);
        }

        private void mainNextContext_Click(object sender, EventArgs e)
        {
            hoverCollapse.SendToBack();
            hoverExpand.SendToBack();

            // Hide previous controls
            mainLogo.Hide();
            mainSubtitle.Hide();
            mainNext.Hide();

            // Add display form to main panel
            main.Controls.Add(ScreenManager.display);

            ScreenManager.displayMenu = ScreenManager.displayMenus.Context_Menu;
            ScreenManager.DisplayNext();
            ScreenManager.DefaultCheckBox();
        }

        private void sideHome_Click(object sender, EventArgs e)
        {
            ScreenManager.displayMenu = ScreenManager.displayMenus.Main_Menu;
            ScreenManager.DisplayNext();
            ScreenManager.DefaultCheckBox();
        }

        private void sideExpand_Tick(object sender, EventArgs e)
        {
            if (side.Location.X < -6)
            {
                side.Location = new Point(side.Location.X + 8, side.Location.Y);
            }
            else
            {
                sideExpand.Enabled = false;
            }
        }

        private void sideCollapse_Tick(object sender, EventArgs e)
        {
            if (side.Location.X > -130)
            {
                side.Location = new Point(side.Location.X - 8, side.Location.Y);
            }
            else
            {
                sideCollapse.Enabled = false;
            }
        }

        private void sideCortana_Click(object sender, EventArgs e)
        {
            hoverCollapse.SendToBack();
            hoverExpand.SendToBack();

            // Hide previous controls
            mainLogo.Hide();
            mainSubtitle.Hide();
            mainNext.Hide();

            // Add display form to main panel
            main.Controls.Add(ScreenManager.display);

            ScreenManager.displayMenu = ScreenManager.displayMenus.Windows_Search;
            ScreenManager.DisplayNext();
            ScreenManager.DefaultCheckBox();
        }

        private void sideControlPanel_Click(object sender, EventArgs e)
        {
            hoverCollapse.SendToBack();
            hoverExpand.SendToBack();

            // Hide previous controls
            mainLogo.Hide();
            mainSubtitle.Hide();
            mainNext.Hide();

            // Add display form to main panel
            main.Controls.Add(ScreenManager.display);

            ScreenManager.displayMenu = ScreenManager.displayMenus.Control_Panel;
            ScreenManager.DisplayNext();
            ScreenManager.DefaultCheckBox();
        }

        private void sideStartMenu_Click(object sender, EventArgs e)
        {
            hoverCollapse.SendToBack();
            hoverExpand.SendToBack();

            // Hide previous controls
            mainLogo.Hide();
            mainSubtitle.Hide();
            mainNext.Hide();

            // Add display form to main panel
            main.Controls.Add(ScreenManager.display);

            ScreenManager.displayMenu = ScreenManager.displayMenus.Start_Menu;
            ScreenManager.DisplayNext();
            ScreenManager.DefaultCheckBox();
        }

        private void sideTaskbar_Click(object sender, EventArgs e)
        {
            hoverCollapse.SendToBack();
            hoverExpand.SendToBack();

            // Hide previous controls
            mainLogo.Hide();
            mainSubtitle.Hide();
            mainNext.Hide();

            // Add display form to main panel
            main.Controls.Add(ScreenManager.display);

            ScreenManager.displayMenu = ScreenManager.displayMenus.Taskbar;
            ScreenManager.DisplayNext();
            ScreenManager.DefaultCheckBox();
        }

        private void sideAbout_Click(object sender, EventArgs e)
        {
            mainAbout.Show();

            hoverCollapse.SendToBack();
            hoverExpand.SendToBack();

            ScreenManager.display.Hide();

            // Hide previous controls
            mainLogo.Hide();
            mainSubtitle.Hide();
            mainNext.Hide();
        }
    }
}
