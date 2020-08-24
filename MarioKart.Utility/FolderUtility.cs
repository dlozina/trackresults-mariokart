using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioKart.Utility
{
    public class FolderUtility
    {
        public static string GetMarioKartProcessingWebRootFolder()
        {
            string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (String.IsNullOrEmpty(baseFolder)) //Kad se vrti na IIS onda bude empty https://stackoverflow.com/questions/45821839/getfolderpathspecialfolder-applicationdata-returns-empty-string
                baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var appDataRootFolder = Path.Combine(baseFolder, "Mario Kart Web");
            if (!Directory.Exists(appDataRootFolder))
                Directory.CreateDirectory(appDataRootFolder);
            return appDataRootFolder;
        }


        public static string GetTempFolderPath(string rootFolder)
        {
            var folderPath = Path.Combine(rootFolder, "Temp");
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            return folderPath;
        }
    }
}
