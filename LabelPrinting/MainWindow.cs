using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LabelPrinting
{
    public partial class MainWindow : Form
    {
        Processor processor = new Processor();         

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ProcessFile()
        {
            foreach (File file in processor.files)
            {
                if (!file.Processed)
                {
                    label14.Text = Path.GetFileName(file.Name);
                    label15.Text = Path.GetExtension(file.Name);

                    try
                    {
                        var lines = System.IO.File.ReadAllLines(file.Name);

                     
                        foreach (string line in lines)
                        {
                            if (!string.IsNullOrEmpty(line))
                            {
                                if (line.Contains("HIT"))
                                {
                                    if (line.Contains("Multiple candidates"))
                                    {
                                        var chunk = lines.Take(4);
                                        processor.AppendToFile(processor.ThirdFolder, chunk);
                                    }
                                    else
                                    {
                                        processor.WriteToFile(processor.SecondFolder, line);
                                    }

                                }
                                else if (line.Contains("QC"))
                                {
                                    processor.WriteToFile(processor.FifthFolder, line);
                                }
                                else if (line.Contains("Merge"))
                                {
                                    processor.WriteToFile(processor.FourthFolder, line);
                                }
                                else
                                {
                                    processor.WriteToFile(processor.FirstFolder, line);
                                }

                            }

                            
                        file.Processed = true;

                        }

                    }
                    catch (System.Exception)
                    {
                        throw;
                    }
                }
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (label17.Text.CompareTo("Not Configured") == 0)
            {
                MessageBox.Show("Error : Configure the watch input folder(s) ");
            }
            else
            {
                if (string.IsNullOrEmpty(processor.FirstFolder) | string.IsNullOrEmpty(processor.SecondFolder) | string.IsNullOrEmpty(processor.ThirdFolder) | string.IsNullOrEmpty(processor.FourthFolder) | string.IsNullOrEmpty(processor.FifthFolder))
                {
                    MessageBox.Show("Error : Set the files output folder(s) before processing ");                    
                }
                else
                {
                    try
                    {
                        label12.Text = Path.GetFileName(this.processor.watcher.Path);
                        label13.Text = Directory.GetFiles(this.processor.watcher.Path).Length.ToString();

                        this.ProcessFile();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }
                }

            }
            
            
        }

        private void btnChange1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    processor.FirstFolder = fbd.SelectedPath;
                    processor.WatchOutputFolders();


                    try
                    {
                        // Attempt to get a list of security permissions from the folder. 
                        lblDirectory1.Text = Path.GetFileName(processor.FirstFolder);
                        System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(processor.FirstFolder);
                        lblDirectory1Access.Text = "✓";
                        lblDirectory1Access.ForeColor = Color.Green;


                    }
                    catch (UnauthorizedAccessException)
                    {
                        lblDirectory1Access.Text = "X";
                        lblDirectory1Access.ForeColor = Color.Red;

                    }
                }
            }

            //string[] files = Directory.GetFiles(fbd.SelectedPath);
            //Directory.EnumerateFiles;

            //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            //MessageBox.Show("Files found: " + files, "Message");


        }

        private void btnWatchFolderConf_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Folder folder = new Folder();
                    folder.Name = fbd.SelectedPath;
                    folder.Access = true;
                    //var csvFiles = Directory.EnumerateFiles(folder.Name, "*.csv");

                    try
                    {

                        if (processor.SetWatchFolder(folder))
                        {
                            label17.Text = "Configured";
                        }
                        else
                        {
                            label17.Text = "Not Configured";
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error:"+ ex.Message);
                    }
                
                }
            }
        }

        private void btnChange2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    processor.SecondFolder = fbd.SelectedPath;
                    try
                    {
                        // Attempt to get a list of security permissions from the folder. 
                        lblDirectory2.Text = Path.GetFileName(processor.SecondFolder);
                        System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(processor.SecondFolder);
                        lblDirectory2Access.Text = "✓";
                        lblDirectory2Access.ForeColor = Color.Green;


                    }
                    catch (UnauthorizedAccessException)
                    {
                        lblDirectory2Access.Text = "X";
                        lblDirectory2Access.ForeColor = Color.Red;

                    }
                }


            }
        }

        private void btnChange3_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    processor.ThirdFolder = fbd.SelectedPath;
                    try
                    {
                        // Attempt to get a list of security permissions from the folder. 
                        lblDirectory3.Text = Path.GetFileName(processor.ThirdFolder);
                        System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(processor.ThirdFolder);
                        lblDirectory3Access.Text = "✓";
                        lblDirectory3Access.ForeColor = Color.Green;


                    }
                    catch (UnauthorizedAccessException)
                    {
                        lblDirectory3Access.Text = "X";
                        lblDirectory3Access.ForeColor = Color.Red;

                    }
                }


            }
        }

        private void btnChange4_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    processor.FourthFolder = fbd.SelectedPath;
                    try
                    {
                        // Attempt to get a list of security permissions from the folder. 
                        lblDirectory4.Text = Path.GetFileName(processor.FourthFolder);
                        System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(processor.FourthFolder);
                        lblDirectory4Access.Text = "✓";
                        lblDirectory4Access.ForeColor = Color.Green;


                    }
                    catch (UnauthorizedAccessException)
                    {
                        lblDirectory4Access.Text = "X";
                        lblDirectory4Access.ForeColor = Color.Red;

                    }
                    
                }

            }
        }

        private void btnChange5_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    processor.FifthFolder = fbd.SelectedPath;
                    try
                    {
                        // Attempt to get a list of security permissions from the folder. 
                        lblDirectory5.Text = Path.GetFileName(processor.FifthFolder);
                        System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(processor.FifthFolder);
                        lblDirectory5Access.Text = "✓";
                        lblDirectory5Access.ForeColor = Color.Green;


                    }
                    catch (UnauthorizedAccessException)
                    {
                        lblDirectory5Access.Text = "X";
                        lblDirectory5Access.ForeColor = Color.Red;

                    }
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //configuration labels
            lblDirectory1.Text = "Folder Not Configured";
            lblDirectory2.Text = "Folder Not Configured";
            lblDirectory3.Text = "Folder Not Configured";
            lblDirectory4.Text = "Folder Not Configured";
            lblDirectory5.Text = "Folder Not Configured";

            //processing labels
            label12.Text = "Not Processing";
            label13.Text = "Not Processing";
            label14.Text = "Not Processing";
            label15.Text = "Not Processing";

            //watcher label
            label17.Text = "Not Configured";

            //access rights labels
            lblDirectory1Access.Text = "";
            lblDirectory2Access.Text = "";
            lblDirectory3Access.Text = "";
            lblDirectory4Access.Text = "";
            lblDirectory5Access.Text = "";

            //printer labels
            label6.Text = "Not Connected";
            label7.Text = "Not Connected";

        }
    }
}
