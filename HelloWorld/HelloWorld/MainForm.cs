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

namespace HelloWorld
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            if (helloStartLocation.IsEmpty)
            {
                helloStartLocation = new Point(helloLabel.Location.X, helloLabel.Location.Y);
            }

            if( helloLabel.Visible == true)
            {
                helloLabel.Visible = false;
            }
            else
            {
                helloLabel.Visible = true;
                helloLabel.Location = helloStartLocation;
            }
        }

        private void clickingProgress_Click(object sender, EventArgs e)
        {
            if (clickingProgress.Value < 100)
            {
                clickingProgress.Value++;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            Point drop_point = new Point(e.X, e.Y);
            drop_point = this.PointToClient(drop_point);
            drop_point.Offset(-dragStartX, -dragStartY);
            helloLabel.Location = drop_point;
        }

        private void helloLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Drag start is {0:N}, {1:N}", e.X, e.Y);
            dragStartX = e.X;
            dragStartY = e.Y;
            helloLabel.DoDragDrop(helloLabel, DragDropEffects.Move);
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("Main form drag enter");
        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
            //Another New comment
            //New comment
            e.Effect = DragDropEffects.Move;
            Point drop_point = new Point(e.X, e.Y);
            drop_point = this.PointToClient(drop_point);
            drop_point.Offset(-dragStartX, -dragStartY);
            helloLabel.Location = drop_point;
        }

        private void labelText1_CheckedChanged(object sender, EventArgs e)
        {
            if (labelText1.Checked)
            {
                helloLabel.Text = labelText1.Text;
            }
        }

        private void labelText2_CheckedChanged(object sender, EventArgs e)
        {
            if (labelText2.Checked)
            {
                helloLabel.Text = labelText2.Text;
            }
        }

        private void runCmdButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = "/C dir";
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            char [] delimiters = {'\n'};
            List<string> cmd_out = output.Split(delimiters).ToList();
            cmdOutputBox.DataSource = cmd_out;

            Console.WriteLine(output);
        }

        private int dragStartX;
        private int dragStartY;
        private Point helloStartLocation;

    }
}
