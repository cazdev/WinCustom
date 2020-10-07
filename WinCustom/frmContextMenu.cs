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
    public partial class frmContextMenu : Form
    {
        public frmContextMenu()
        {
            InitializeComponent();
        }

        private void mainApply_Click(object sender, EventArgs e)
        {
            String filename = "CopyAsPath.reg";
            RegistryManager.applyRegistry(Resources.CopyAsPath, filename);
        }

        private void mainRestore_Click(object sender, EventArgs e)
        {
            String filename = "CopyAsPath-Restore.reg";
            RegistryManager.applyRegistry(Resources.CopyAsPath_Restore, filename);
        }
    }
}
