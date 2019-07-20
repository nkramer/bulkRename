using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkRenameGUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private static string OneOffFix(bool forReal)
        {
            var builder = new StringBuilder();
            string mainDirectory = @"E:\Pictures";
            var dirs = Directory.EnumerateDirectories(mainDirectory).Where(d => d.Contains("alaska")).ToArray();
            foreach (var directory in dirs)
            {
                string prefix = Path.GetFileName(directory);
                var files = Directory.EnumerateFiles(directory);
                foreach (var oldFullName in files)
                {
                    string newShortName = Path.GetFileName(oldFullName);
                    newShortName = newShortName.Replace("DSC", prefix + " ");
                    newShortName = newShortName.Replace("100_", prefix + " ");
                    newShortName = newShortName.Replace("101_", prefix + " ");
                    newShortName = newShortName.Replace("IMG_", prefix + " ");
                    var newFullName = Path.Combine(directory, newShortName);
                    if (oldFullName != newFullName)
                    {
                        builder.Append(oldFullName + " -> " + newFullName + "\r\n");
                        if (forReal)
                        {
                            File.Move(oldFullName, newFullName);
                        }
                    }
                }
            }

            return builder.ToString();
        }

        private static string BulkRename(string directory, string searchPattern, string replacePattern, bool forReal) {
            var builder = new StringBuilder();
            foreach (var oldFullName in Directory.GetFiles(directory)) {
                string oldShortName = Path.GetFileName(oldFullName);
                if (oldShortName.StartsWith("20") && oldShortName != "ehThumbs.db" && oldShortName != "Thumbs.db") {
                    var newShortName = oldShortName.Replace(searchPattern, replacePattern);
                    var newFullName = Path.Combine(directory, newShortName);
                    builder.Append(oldFullName + " -> " + newFullName + "\r\n");
                    //Debug.WriteLine(oldFullName + " -> " + newFullName);
                    if (forReal) {
                        File.Move(oldFullName, newFullName);
                    }
                }
            }
            
            var newDir = Path.Combine(
                Path.GetDirectoryName(directory),
                Path.GetFileName(directory).Replace(searchPattern, replacePattern));
            builder.Append(directory + " -> " + newDir + "\r\n");
            if (forReal) {
                Directory.Move(directory, newDir);
            }

            return builder.ToString();
        }

        private void pickDir_Click(object sender, EventArgs e) {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            pathLabel.Text = path;
            searchBox.Text = Path.GetFileName(path);
            searchBox.Focus();
        }

        private void previewButton_Click(object sender, EventArgs e) {
            string results = BulkRename(folderBrowserDialog1.SelectedPath, searchBox.Text, replaceBox.Text, forReal: false);
            //string results = OneOffFix(forReal: true);
            resultsBox.Text = results;
        }

        private void goButton_Click(object sender, EventArgs e) {
            string results = BulkRename(folderBrowserDialog1.SelectedPath, searchBox.Text, replaceBox.Text, forReal: true);
            resultsBox.Text = results;
            MessageBox.Show("Done!");
        }
    }
}
