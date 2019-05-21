using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelPrinting
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Text = "✓";
                label7.Text = "X";
                label6.Font = new Font(label6.Font, FontStyle.Bold);
                // your code here 
                string CSVFilePathName = @"..\..\Shared\test.csv";

                string id = File.ReadLines(CSVFilePathName).Select(s => s.Split(',')).Where((string[] a) => a[2] == "CLAY").Select((string[] a) => a[0]).FirstOrDefault();

                MessageBox.Show(id);

                string[] Lines = File.ReadAllLines(CSVFilePathName);
                string[] Fields;
                Fields = Lines[0].Split(new char[] { ',' });
                int Cols = Fields.GetLength(0);

                MessageBox.Show(Cols.ToString());
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error is " + ex.ToString());
                throw;
            }
        }

        private void btnChange1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    //Directory.EnumerateFiles;

                    //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    MessageBox.Show("Files found: " + files, "Message");

                }
            }
        }
    }
}
