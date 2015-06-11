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
            this.components = new System.ComponentModel.Container();
            this.helloLabel = new System.Windows.Forms.Label();
            this.clickButton = new System.Windows.Forms.Button();
            this.clickingProgress = new System.Windows.Forms.ProgressBar();
            this.ClickMeTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelText1 = new System.Windows.Forms.RadioButton();
            this.labelText2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.runCmdButton = new System.Windows.Forms.Button();
            this.cmdOutputBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.helloLabel.Location = new System.Drawing.Point(175, 200);
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
            this.ClickMeTip.SetToolTip(this.clickButton, "Hide/Show Label");
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // clickingProgress
            // 
            this.clickingProgress.Location = new System.Drawing.Point(53, 277);
            this.clickingProgress.Name = "clickingProgress";
            this.clickingProgress.Size = new System.Drawing.Size(280, 23);
            this.clickingProgress.TabIndex = 2;
            this.ClickMeTip.SetToolTip(this.clickingProgress, "Click to fill");
            this.clickingProgress.Click += new System.EventHandler(this.clickingProgress_Click);
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Location = new System.Drawing.Point(26, 121);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(80, 17);
            this.labelText1.TabIndex = 3;
            this.labelText1.TabStop = true;
            this.labelText1.Text = "Hello There";
            this.labelText1.UseVisualStyleBackColor = true;
            this.labelText1.CheckedChanged += new System.EventHandler(this.labelText1_CheckedChanged);
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Location = new System.Drawing.Point(26, 142);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(72, 17);
            this.labelText2.TabIndex = 4;
            this.labelText2.TabStop = true;
            this.labelText2.Text = "Good Bye";
            this.labelText2.UseVisualStyleBackColor = true;
            this.labelText2.CheckedChanged += new System.EventHandler(this.labelText2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // runCmdButton
            // 
            this.runCmdButton.Location = new System.Drawing.Point(389, 139);
            this.runCmdButton.Name = "runCmdButton";
            this.runCmdButton.Size = new System.Drawing.Size(75, 23);
            this.runCmdButton.TabIndex = 6;
            this.runCmdButton.Text = "Run";
            this.runCmdButton.UseVisualStyleBackColor = true;
            this.runCmdButton.Click += new System.EventHandler(this.runCmdButton_Click);
            // 
            // cmdOutputBox
            // 
            this.cmdOutputBox.FormattingEnabled = true;
            this.cmdOutputBox.Location = new System.Drawing.Point(368, 188);
            this.cmdOutputBox.Name = "cmdOutputBox";
            this.cmdOutputBox.Size = new System.Drawing.Size(457, 95);
            this.cmdOutputBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(867, 372);
            this.Controls.Add(this.cmdOutputBox);
            this.Controls.Add(this.runCmdButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.labelText1);
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
        private System.Windows.Forms.ToolTip ClickMeTip;
        private System.Windows.Forms.RadioButton labelText1;
        private System.Windows.Forms.RadioButton labelText2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button runCmdButton;
        private System.Windows.Forms.ListBox cmdOutputBox;

    }
}

