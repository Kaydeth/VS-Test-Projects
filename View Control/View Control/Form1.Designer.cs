namespace View_Control
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
            this.viewsList = new System.Windows.Forms.ListBox();
            this.startViewButton = new System.Windows.Forms.Button();
            this.stopViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewsList
            // 
            this.viewsList.FormattingEnabled = true;
            this.viewsList.Location = new System.Drawing.Point(110, 210);
            this.viewsList.Name = "viewsList";
            this.viewsList.Size = new System.Drawing.Size(523, 238);
            this.viewsList.TabIndex = 0;
            // 
            // startViewButton
            // 
            this.startViewButton.Location = new System.Drawing.Point(222, 493);
            this.startViewButton.Name = "startViewButton";
            this.startViewButton.Size = new System.Drawing.Size(75, 23);
            this.startViewButton.TabIndex = 1;
            this.startViewButton.Text = "Start View";
            this.startViewButton.UseVisualStyleBackColor = true;
            this.startViewButton.Click += new System.EventHandler(this.startViewButton_Click);
            // 
            // stopViewButton
            // 
            this.stopViewButton.Location = new System.Drawing.Point(401, 492);
            this.stopViewButton.Name = "stopViewButton";
            this.stopViewButton.Size = new System.Drawing.Size(75, 23);
            this.stopViewButton.TabIndex = 2;
            this.stopViewButton.Text = "Stop View";
            this.stopViewButton.UseVisualStyleBackColor = true;
            this.stopViewButton.Click += new System.EventHandler(this.stopViewButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 593);
            this.Controls.Add(this.stopViewButton);
            this.Controls.Add(this.startViewButton);
            this.Controls.Add(this.viewsList);
            this.Name = "MainForm";
            this.Text = "View Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox viewsList;
        private System.Windows.Forms.Button startViewButton;
        private System.Windows.Forms.Button stopViewButton;
    }
}

