using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace View_Control
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cleartool";
            p.StartInfo.Arguments = "lsview -s";
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            char[] delimiters = { '\n' };
            string[] views = output.Split(delimiters);
            List<string> my_views = new List<string>();

            for (int i = 0; i < views.Length; i++ )
            {
                if(views[i].Contains("sliner"))
                {
                    my_views.Add(views[i].Remove(views[i].Length - 1));
                }
            }

            viewsList.DataSource = my_views;
        }

        private void startViewButton_Click(object sender, EventArgs e)
        {
            string selected_view = viewsList.SelectedItem.ToString();
            Console.WriteLine(viewsList.SelectedItem.ToString());

            ClearCase.startView(selected_view); 
        }

        private void stopViewButton_Click(object sender, EventArgs e)
        {
            string selected_view = viewsList.SelectedItem.ToString();
            Console.WriteLine(viewsList.SelectedItem.ToString());

            ClearCase.endView(selected_view); 
        }
    }
}
