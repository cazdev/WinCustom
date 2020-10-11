using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using WinCustom.Properties;

namespace WinCustom
{
    static class ScreenManager
    {
        public static displayMenus displayMenu = displayMenus.Main_Menu;

        public enum displayMenus
        {
            Context_Menu,
            Windows_Search,
            Control_Panel,
            Start_Menu,
            Taskbar,
            Main_Menu
        }

        public static T Next<T>(this T src) where T : struct
        {
            if (!typeof(T).IsEnum) throw new ArgumentException(String.Format("Argument {0} is not an Enum", typeof(T).FullName));

            T[] Arr = (T[])Enum.GetValues(src.GetType());
            int j = Array.IndexOf<T>(Arr, src) + 1;
            return (Arr.Length == j) ? Arr[0] : Arr[j];
        }

        public static T Previous<T>(this T src) where T : struct
        {
            if (!typeof(T).IsEnum) throw new ArgumentException(String.Format("Argument {0} is not an Enum", typeof(T).FullName));

            T[] Arr = (T[])Enum.GetValues(src.GetType());
            int j = Array.IndexOf<T>(Arr, src) - 1;
            return (Arr.Length == j) ? Arr[0] : Arr[j];
        }

        public static frmDisplay display = new frmDisplay()
        {
            TopLevel = false,
            AutoScroll = true
        };

        public static frmMain main = null;

        public static void SwitchCheckBox()
        {
            switch (ScreenManager.displayMenu)
            {
                case ScreenManager.displayMenus.Context_Menu:
                    if (display.mainCheckBox.Checked)
                    {
                        String filename = "CopyAsPath.reg";
                        RegistryManager.ApplyRegistry(Resources.enable_copyaspath, filename);
                    }
                    else
                    {
                        String filename = "CopyAsPath-Restore.reg";
                        RegistryManager.ApplyRegistry(Resources.disable_copyaspath, filename);
                    }
                    break;
                case ScreenManager.displayMenus.Windows_Search:
                    if (display.mainCheckBox.Checked)
                    {
                        String filename = "disable_cortana.reg";
                        RegistryManager.ApplyRegistry(Resources.disable_cortana, filename);
                    }
                    else
                    {
                        String filename = "enable_cortana.reg";
                        RegistryManager.ApplyRegistry(Resources.enable_cortana, filename);
                    }
                    break;
                case ScreenManager.displayMenus.Control_Panel:
                    if (display.mainCheckBox.Checked)
                    {
                        String filename = "add_appearance_color.reg";
                        RegistryManager.ApplyRegistry(Resources.add_appearance_color, filename);
                    }
                    else
                    {
                        String filename = "remove_appearance_color.reg";
                        RegistryManager.ApplyRegistry(Resources.remove_appearance_color, filename);
                    }
                    break;
                case ScreenManager.displayMenus.Start_Menu:
                    if (display.mainCheckBox.Checked)
                    {
                        String filename = "disable_bing.reg";
                        RegistryManager.ApplyRegistry(Resources.disable_bing, filename);
                    }
                    else
                    {
                        String filename = "enable_bing.reg";
                        RegistryManager.ApplyRegistry(Resources.enable_bing, filename);
                    }
                    break;
                case ScreenManager.displayMenus.Taskbar:
                    if (display.mainCheckBox.Checked)
                    {
                        String filename = "enable_translucent_taskbar.reg";
                        RegistryManager.ApplyRegistry(Resources.enable_translucent_taskbar, filename);
                    }
                    else
                    {
                        String filename = "disable_translucent_taskbar.reg";
                        RegistryManager.ApplyRegistry(Resources.disable_translucent_taskbar, filename);
                    }
                    break;
                default:
                    break;
            }
        }

        public static void DefaultCheckBox()
        {
            switch (ScreenManager.displayMenu)
            {
                case ScreenManager.displayMenus.Context_Menu:
                    if (RegistryManager.RegistryKeyExists(
                        @"HKEY_CLASSES_ROOT\Allfilesystemobjects\shell\windows.copyaspath", "InvokeCommandOnSelection"))
                    {
                        ScreenManager.display.mainCheckBox.Checked = true;
                    }
                    else
                    {
                        ScreenManager.display.mainCheckBox.Checked = false;
                    }
                    break;
                case ScreenManager.displayMenus.Windows_Search:
                    if (RegistryManager.GetRegistryValue(
                        @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCortana", "1"))
                    {
                        ScreenManager.display.mainCheckBox.Checked = true;
                    }
                    else
                    {
                        ScreenManager.display.mainCheckBox.Checked = false;
                    }
                    break;
                case ScreenManager.displayMenus.Control_Panel:
                    if (RegistryManager.RegistryKeyExists(
                        @"HKEY_CLASSES_ROOT\CLSID\{106ee807-9e5d-451b-a9c5-74908630cefb}", "InfoTip"))
                    {
                        ScreenManager.display.mainCheckBox.Checked = true;
                    }
                    else
                    {
                        ScreenManager.display.mainCheckBox.Checked = false;
                    }
                    break;
                case ScreenManager.displayMenus.Start_Menu:
                    if (RegistryManager.GetRegistryValue(
                        @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\Explorer", "DisableSearchBoxSuggestions", "0"))
                    {
                        ScreenManager.display.mainCheckBox.Checked = true;
                    }
                    else
                    {
                        ScreenManager.display.mainCheckBox.Checked = false;
                    }
                    break;
                case ScreenManager.displayMenus.Taskbar:
                    if (RegistryManager.RegistryKeyExists(
                        @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "UseOLEDTaskbarTransparency"))
                    {
                        ScreenManager.display.mainCheckBox.Checked = true;
                    }
                    else
                    {
                        ScreenManager.display.mainCheckBox.Checked = false;
                    }
                    break;
                default:
                    break;
            }
        }

        public static void DisplayNext()
        {
            switch (ScreenManager.displayMenu)
            {
                case ScreenManager.displayMenus.Main_Menu:

                    ScreenManager.display.Hide();
                    ScreenManager.display.Enabled = false;

                    // Hide previous controls
                    main.mainLogo.Show();
                    main.mainSubtitle.Show();
                    main.mainNext.Show();

                    display.mainNext.Hide();
                    display.mainPrevious.Hide();

                    main.mainAbout.Hide();

                    main.sideContextMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideControlPanel.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideCortana.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideStartMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideTaskbar.BackColor = Color.FromArgb(40, 40, 40);

                    break;
                case ScreenManager.displayMenus.Context_Menu:

                    // Display next screen
                    ScreenManager.display.Enabled = true;
                    ScreenManager.display.Show();

                    main.sideContextMenu.BackColor = Color.FromArgb(52, 152, 219);
                    main.sideControlPanel.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideCortana.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideStartMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideTaskbar.BackColor = Color.FromArgb(40, 40, 40);

                    main.mainAbout.Hide();

                    display.mainNext.Show();
                    display.mainPrevious.Hide();

                    display.mainPictureBox.Image = Resources.context;
                    display.mainTitle.Text = "Copy directory path";
                    display.mainSubtitle.Text = "Adds the option to copy directory path in file context menu";
                    break;
                case ScreenManager.displayMenus.Windows_Search:

                    // Display next screen
                    ScreenManager.display.Enabled = true;
                    ScreenManager.display.Show();

                    main.sideContextMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideCortana.BackColor = Color.FromArgb(52, 152, 219);
                    main.sideControlPanel.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideStartMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideTaskbar.BackColor = Color.FromArgb(40, 40, 40);

                    main.mainAbout.Hide();

                    display.mainNext.Show();
                    display.mainPrevious.Show();

                    display.mainPictureBox.Image = Resources.cortana;
                    display.mainTitle.Text = "Disable Cortana";
                    display.mainSubtitle.Text = "Disable Cortana voice assistant";
                    break;
                case ScreenManager.displayMenus.Control_Panel:

                    // Display next screen
                    ScreenManager.display.Enabled = true;
                    ScreenManager.display.Show();

                    display.mainNext.Show();
                    display.mainPrevious.Show();

                    main.mainAbout.Hide();

                    main.sideContextMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideCortana.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideControlPanel.BackColor = Color.FromArgb(52, 152, 219);
                    main.sideStartMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideTaskbar.BackColor = Color.FromArgb(40, 40, 40);

                    display.mainPictureBox.Image = Resources.appearance;

                    display.mainTitle.Text = "Enable Color and Appearance";
                    display.mainSubtitle.Text = "Adds the Color and Appearance option to Control Panel section";
                    break;
                case ScreenManager.displayMenus.Start_Menu:

                    // Display next screen
                    ScreenManager.display.Enabled = true;
                    ScreenManager.display.Show();

                    display.mainNext.Show();
                    display.mainPrevious.Show();

                    main.mainAbout.Hide();

                    main.sideContextMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideCortana.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideControlPanel.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideStartMenu.BackColor = Color.FromArgb(52, 152, 219);
                    main.sideTaskbar.BackColor = Color.FromArgb(40, 40, 40);

                    display.mainPictureBox.Image = Resources.start_menu_bing;
                    display.mainTitle.Text = "Disable bing search";
                    display.mainSubtitle.Text = "Removes bing web search from windows search";

                    break;
                case ScreenManager.displayMenus.Taskbar:

                    // Display next screen
                    ScreenManager.display.Enabled = true;
                    ScreenManager.display.Show();

                    main.mainAbout.Hide();

                    main.sideContextMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideCortana.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideControlPanel.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideStartMenu.BackColor = Color.FromArgb(40, 40, 40);
                    main.sideTaskbar.BackColor = Color.FromArgb(52, 152, 219);

                    display.mainPictureBox.Image = Resources.translucent_taskbar;
                    display.mainTitle.Text = "Enable translucent taskbar";
                    display.mainSubtitle.Text = "A translucent effect that applys to wallpaper and windows";

                    display.mainPrevious.Show();
                    display.mainNext.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
