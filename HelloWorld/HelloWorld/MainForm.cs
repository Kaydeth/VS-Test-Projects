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

        private int dragStartX;
        private int dragStartY;
        private Point helloStartLocation;
    }
}
