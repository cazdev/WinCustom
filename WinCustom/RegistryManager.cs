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

        public static void applyRegistry(String reg,String filename)
        {
            // Create .reg file
            File.WriteAllText(AppData + filename, reg);

            // Apply file to registry
            Process regeditProcess = Process.Start("reg.exe", "import " + AppData + filename);
            regeditProcess.WaitForExit();
        }
    }
}
