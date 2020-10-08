using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();
        }

        private void mainCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ScreenManager.SwitchCheckBox();
        }

        private void mainNext_MouseEnter(object sender, EventArgs e)
        {
            mainNext.BackgroundImage = Resources.next_button_hover;
        }

        private void mainNext_MouseLeave(object sender, EventArgs e)
        {
            mainNext.BackgroundImage = Resources.next_button;
        }

        private void mainPrevious_MouseEnter(object sender, EventArgs e)
        {
            mainPrevious.BackgroundImage = Resources.next_button_hover1;
        }

        private void mainPrevious_MouseLeave(object sender, EventArgs e)
        {
            mainPrevious.BackgroundImage = Resources.next_button1;
        }

        private void mainNext_Click(object sender, EventArgs e)
        {
            ScreenManager.displayMenu = ScreenManager.Next(ScreenManager.displayMenu);
            ScreenManager.DisplayNext();
            ScreenManager.DefaultCheckBox();
        }

        private void mainPrevious_Click(object sender, EventArgs e)
        {
            ScreenManager.displayMenu = ScreenManager.Previous(ScreenManager.displayMenu);
            ScreenManager.DisplayNext();
            ScreenManager.DefaultCheckBox();
        }
    }
}
