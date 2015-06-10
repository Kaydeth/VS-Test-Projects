namespace HelloWorld
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloLabel = new System.Windows.Forms.Label();
            this.clickButton = new System.Windows.Forms.Button();
            this.clickingProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(12, 18);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(62, 13);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Hello There";
            this.helloLabel.Visible = false;
            this.helloLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.helloLabel_MouseDown);
            // 
            // clickButton
            // 
            this.clickButton.Location = new System.Drawing.Point(178, 142);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(75, 23);
            this.clickButton.TabIndex = 1;
            this.clickButton.Text = "Click Me";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // clickingProgress
            // 
            this.clickingProgress.Location = new System.Drawing.Point(85, 267);
            this.clickingProgress.Name = "clickingProgress";
            this.clickingProgress.Size = new System.Drawing.Size(280, 23);
            this.clickingProgress.TabIndex = 2;
            this.clickingProgress.Click += new System.EventHandler(this.clickingProgress_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(445, 372);
            this.Controls.Add(this.clickingProgress);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.helloLabel);
            this.Name = "MainForm";
            this.Text = "Window Title";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.ProgressBar clickingProgress;

    }
}

