using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting
{
    class Processor
    {
        const int NumberOfFolders = 5;
        List<Folder> Folders = new List<Folder>(NumberOfFolders);

        public void ProcessFolder(string folder)
        {
        }

        public void WatchFolder(List<Folder> folders)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = "";
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.csv";
            watcher.Changed += new FileSystemEventHandler(ProcessFolder(watcher.Path));
            watcher.EnableRaisingEvents = true;
            
        }
    }
}
