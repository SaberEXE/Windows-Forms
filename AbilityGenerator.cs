using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TrainerGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
                InitializeComponent();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
                string id = idInput.Text;
                string internalName = textBox1.Text;
                internalName = internalName.Replace(" ", String.Empty);
                string externalName = textBox1.Text;
                string desc = textBox2.Text;

                string path = @"c:\temp\exported.txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(id + "," + internalName.ToUpper() + "," + externalName + "," + desc);
                    Process.Start(path);
                }
            }
        static void OnProcessExit(object sender, EventArgs e)
        {
            string path = @"c:\temp\exported.txt"; // reinitialize because im lazy and dumb lol
            File.Delete(path);  // deletes file
        }

        private void saveAstxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            string internalName = textBox1.Text;
            internalName = internalName.Replace(" ", String.Empty);
            string externalName = textBox1.Text;
            string desc = textBox2.Text;
            string path = @"\";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(id + "," + internalName.ToUpper() + "," + externalName + "," + desc);
                MessageBox.Show("Saved exported.txt to the root folder of the project.");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            idInput.Clear();
        }
    }
}
