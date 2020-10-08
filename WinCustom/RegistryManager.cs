using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCustom
{
    class RegistryManager
    {
        // Folder to store reg files
        public static String AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WinCustom\\";

        public static void ApplyRegistry(String reg,String filename)
        {
            if (!File.Exists(AppData + filename))
            {
                // Create .reg file
                File.WriteAllText(AppData + filename, reg);
            }

            // Apply file to registry
            Process regeditProcess = Process.Start("reg.exe", "import " + AppData + filename);
            regeditProcess.WaitForExit();
        }


        public static bool RegistryValueExists(String keyName, String valueName)
        {
            if (Registry.GetValue(keyName, valueName, null) == null)
            {
                //key does not exist
                return false;
            }
            else
            {
                //key exists
                return true;
            }
        }
    }
}
