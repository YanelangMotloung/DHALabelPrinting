using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting
{
    class Folder
    {
        string Name { get; set; }
        List<File> Files = new List<File>();
        bool Access { get; set; }

        public File GetFile()
        {
            File f= new File();
            return f;
        }

        public void SetFileStatus(File file)
        {

        }

        public bool GetFileStatus(File file)
        {
            return true;
        }


    }
}
