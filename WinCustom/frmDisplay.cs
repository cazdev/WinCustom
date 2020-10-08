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
            if (mainCheckBox.Checked)
            {
                String filename = "CopyAsPath.reg";
                RegistryManager.ApplyRegistry(Resources.CopyAsPath, filename);
            }
            else
            {
                String filename = "CopyAsPath-Restore.reg";
                RegistryManager.ApplyRegistry(Resources.CopyAsPath_Restore, filename);
            }
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
    }
}
