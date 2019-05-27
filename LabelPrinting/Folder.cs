using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting
{
    class Folder
    {
        public string Name { get; set; }
        public List<File> Files = new List<File>();
        public bool Access { get; set; }


        public void AddFiles()
        {

        }

        public File GetFile()
        {
            File f= new File();
            return f;
        }

        public void SetFileStatus(File file)
        {

        }

        public void ProcessFile(File file)
        {

        }

        public bool GetFileStatus(File file)
        {
            return true;
        }


    }
}
