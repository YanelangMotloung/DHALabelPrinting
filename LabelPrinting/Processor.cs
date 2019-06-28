using System;
using System.Collections.Generic;
using System.IO;

namespace LabelPrinting
{
    class Processor
    {
        public List<File> files = new List<File>();
        public FileSystemWatcher watcher = new FileSystemWatcher();
        
        public FileSystemWatcher OutPutwatcher1 = new FileSystemWatcher();
        public FileSystemWatcher OutPutwatcher2 = new FileSystemWatcher();
        public FileSystemWatcher OutPutwatcher3 = new FileSystemWatcher();
        public FileSystemWatcher OutPutwatcher4 = new FileSystemWatcher();
        public FileSystemWatcher OutPutwatcher5 = new FileSystemWatcher();
        
        //setting the output folders
        public string FirstFolder = string.Empty;
        public string SecondFolder = string.Empty;
        public string ThirdFolder = string.Empty;
        public string FourthFolder = string.Empty;
        public string FifthFolder = string.Empty;
        
        //the file that is in progress
        public int ProcessedEntries = 0;
        string lastFileName = string.Empty;

        private void onCreated(object sender, FileSystemEventArgs e)
        {
            FileSystemWatcher watcher = (FileSystemWatcher)sender;

            File ChangedFile = new File();
            ChangedFile.Name = e.FullPath;
            ChangedFile.Processed = false;
            ChangedFile.Extension = Path.GetExtension(ChangedFile.Name);
            this.files.Add(ChangedFile);
            System.Windows.Forms.MessageBox.Show(ChangedFile.Name);

        }

        public void WriteToFile(string folder, string content)
        {
            lastFileName = "/RECORD" + this.ProcessedEntries.ToString();
            System.IO.File.WriteAllText(folder + lastFileName + ".csv", content.ToString() + Environment.NewLine);
            ProcessedEntries++;
        }

        public bool SetWatchFolder(Folder folder)
        {
            try
            {
                this.watcher.Path = folder.Name;
                this.watcher.NotifyFilter = NotifyFilters.FileName;
                this.watcher.Filter = "*.csv";
                this.watcher.Created += new FileSystemEventHandler(onCreated);// this.ProcessFolder(folder);
                this.SetFiles(watcher.Path);
                this.watcher.EnableRaisingEvents = true;

                return true;
            }
            catch (System.Exception)
            {
                throw;
            }

        }

        internal void AppendToFile(string thirdFolder, IEnumerable<string> lines)
        {
            foreach (string line in lines)
            {
                System.IO.File.AppendAllText(thirdFolder + lastFileName + ".csv", line.ToString() + Environment.NewLine);
            }
        }

        void SetFiles(string path)
        {
            var Pathfiles = Directory.GetFiles(path);

            foreach (string file in Pathfiles)
            {
                File f = new File();
                f.Name = file;
                f.Processed = false;
                f.Extension = Path.GetExtension(f.Name);

                this.files.Add(f);
                f = null;

            }
        }

        public void WatchOutputFolders()
        {

            try
            {
                this.OutPutwatcher1.Path = FirstFolder;
                this.OutPutwatcher1.NotifyFilter = NotifyFilters.FileName;
                this.OutPutwatcher1.Filter = "*.csv";
                this.OutPutwatcher1.Created += new FileSystemEventHandler(onOutputFileCreated);
                this.SetFiles(FirstFolder);
                this.OutPutwatcher1.EnableRaisingEvents = true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private void onOutputFileCreated(object sender, FileSystemEventArgs e)
        {
            //FileSystemWatcher watcher = (FileSystemWatcher)sender;

            //File ChangedFile = new File();
            //ChangedFile.Name = e.FullPath;
            //ChangedFile.Processed = false;
            //ChangedFile.Extension = Path.GetExtension(ChangedFile.Name);

            System.Windows.Forms.MessageBox.Show("File Ready For Printing :" + e.FullPath);

        }



        // set multiple output watchers

        public FileSystemWatcher HITwatcher = new FileSystemWatcher();
        public FileSystemWatcher NOHITwatcher = new FileSystemWatcher();
        public FileSystemWatcher MULTIHITwatcher = new FileSystemWatcher();
        public FileSystemWatcher NOMATCHwatcher = new FileSystemWatcher();
        public FileSystemWatcher QCwatcher = new FileSystemWatcher();



        //set watchinput folders

        internal void SetHitFolderWatcher()
        {
            try
            {
                this.HITwatcher.Path = FirstFolder;
                this.HITwatcher.NotifyFilter = NotifyFilters.FileName;
                this.HITwatcher.Filter = "*.csv";
                this.HITwatcher.Created += new FileSystemEventHandler(onHitFileCreated);
                this.SetFiles(FirstFolder);
                this.HITwatcher.EnableRaisingEvents = true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private void onHitFileCreated(object sender, FileSystemEventArgs e)
        {
            File NewFile = new File();
            NewFile.Name = e.FullPath;
            NewFile.Processed = false;
            NewFile.Extension = Path.GetExtension(NewFile.Name);

            ConfirmFile(NewFile);
        }

        private void ConfirmFile(File newFile)
        {

        }
    }
}
