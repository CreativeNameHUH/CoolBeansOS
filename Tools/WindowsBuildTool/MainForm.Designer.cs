namespace WindowsBuildTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BootSettingsButton = new System.Windows.Forms.Button();
            this.BootSelectButton = new System.Windows.Forms.Button();
            this.BootPathTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.KernelSelectButton = new System.Windows.Forms.Button();
            this.KernelPathTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DriversSelectButton = new System.Windows.Forms.Button();
            this.DriversPathTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BootSettingsButton);
            this.panel1.Controls.Add(this.BootSelectButton);
            this.panel1.Controls.Add(this.BootPathTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 32);
            this.panel1.TabIndex = 0;
            // 
            // BootSettingsButton
            // 
            this.BootSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BootSettingsButton.BackgroundImage")));
            this.BootSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BootSettingsButton.Location = new System.Drawing.Point(418, 3);
            this.BootSettingsButton.Name = "BootSettingsButton";
            this.BootSettingsButton.Size = new System.Drawing.Size(29, 23);
            this.BootSettingsButton.TabIndex = 2;
            this.BootSettingsButton.UseVisualStyleBackColor = true;
            this.BootSettingsButton.Click += new System.EventHandler(this.BootSettingsButton_Click);
            // 
            // BootSelectButton
            // 
            this.BootSelectButton.Location = new System.Drawing.Point(326, 3);
            this.BootSelectButton.Name = "BootSelectButton";
            this.BootSelectButton.Size = new System.Drawing.Size(86, 23);
            this.BootSelectButton.TabIndex = 1;
            this.BootSelectButton.Text = "BOOT";
            this.BootSelectButton.UseVisualStyleBackColor = true;
            this.BootSelectButton.Click += new System.EventHandler(this.BootSelectButton_Click);
            // 
            // BootPathTextBox
            // 
            this.BootPathTextBox.Location = new System.Drawing.Point(3, 3);
            this.BootPathTextBox.Name = "BootPathTextBox";
            this.BootPathTextBox.ReadOnly = true;
            this.BootPathTextBox.Size = new System.Drawing.Size(317, 23);
            this.BootPathTextBox.TabIndex = 0;
            this.BootPathTextBox.Text = "Boot\\src\\";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.KernelSelectButton);
            this.panel2.Controls.Add(this.KernelPathTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 32);
            this.panel2.TabIndex = 2;
            // 
            // KernelSelectButton
            // 
            this.KernelSelectButton.Location = new System.Drawing.Point(326, 3);
            this.KernelSelectButton.Name = "KernelSelectButton";
            this.KernelSelectButton.Size = new System.Drawing.Size(86, 23);
            this.KernelSelectButton.TabIndex = 1;
            this.KernelSelectButton.Text = "KERNEL";
            this.KernelSelectButton.UseVisualStyleBackColor = true;
            this.KernelSelectButton.Click += new System.EventHandler(this.KernelSelectButton_Click);
            // 
            // KernelPathTextBox
            // 
            this.KernelPathTextBox.Location = new System.Drawing.Point(3, 3);
            this.KernelPathTextBox.Name = "KernelPathTextBox";
            this.KernelPathTextBox.ReadOnly = true;
            this.KernelPathTextBox.Size = new System.Drawing.Size(317, 23);
            this.KernelPathTextBox.TabIndex = 0;
            this.KernelPathTextBox.Text = "Kernel\\src\\";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DriversSelectButton);
            this.panel3.Controls.Add(this.DriversPathTextBox);
            this.panel3.Location = new System.Drawing.Point(12, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 32);
            this.panel3.TabIndex = 3;
            // 
            // DriversSelectButton
            // 
            this.DriversSelectButton.Enabled = false;
            this.DriversSelectButton.Location = new System.Drawing.Point(326, 3);
            this.DriversSelectButton.Name = "DriversSelectButton";
            this.DriversSelectButton.Size = new System.Drawing.Size(86, 23);
            this.DriversSelectButton.TabIndex = 1;
            this.DriversSelectButton.Text = "DRIVERS";
            this.DriversSelectButton.UseVisualStyleBackColor = true;
            // 
            // DriversPathTextBox
            // 
            this.DriversPathTextBox.Enabled = false;
            this.DriversPathTextBox.Location = new System.Drawing.Point(3, 3);
            this.DriversPathTextBox.Name = "DriversPathTextBox";
            this.DriversPathTextBox.ReadOnly = true;
            this.DriversPathTextBox.Size = new System.Drawing.Size(317, 23);
            this.DriversPathTextBox.TabIndex = 0;
            this.DriversPathTextBox.Text = "TODO";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SettingsButton);
            this.panel4.Controls.Add(this.OutputTextBox);
            this.panel4.Controls.Add(this.BuildButton);
            this.panel4.Location = new System.Drawing.Point(12, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 312);
            this.panel4.TabIndex = 4;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(698, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(3, 32);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(770, 277);
            this.OutputTextBox.TabIndex = 1;
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(3, 3);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(75, 23);
            this.BuildButton.TabIndex = 0;
            this.BuildButton.Text = "BUILD";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Build Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button BootSelectButton;
        private TextBox BootPathTextBox;
        private Panel panel2;
        private Button KernelSelectButton;
        private TextBox KernelPathTextBox;
        private Panel panel3;
        private Button DriversSelectButton;
        private TextBox DriversPathTextBox;
        private Panel panel4;
        private TextBox OutputTextBox;
        private Button BuildButton;
        private Button SettingsButton;
        private Button BootSettingsButton;
    }
}