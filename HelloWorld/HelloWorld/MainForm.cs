using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if( helloLabel.Visible == true)
            {
                helloLabel.Visible = false;
            }
            else
            {
                helloLabel.Visible = true;
                helloLabel.Location = new Point(12, 18);
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
            helloLabel.Location = this.PointToClient(new Point(e.X, e.Y));
        }

        private void helloLabel_MouseDown(object sender, MouseEventArgs e)
        {
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
        }

    }
}
