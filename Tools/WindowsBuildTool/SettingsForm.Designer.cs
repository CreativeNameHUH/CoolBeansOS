namespace WindowsBuildTool
{
    partial class SettingsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MsysSelectButton = new System.Windows.Forms.Button();
            this.MsysPathTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GccSelectButton = new System.Windows.Forms.Button();
            this.GccPathTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NasmSelectButton = new System.Windows.Forms.Button();
            this.NasmPathTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MsysSelectButton);
            this.panel1.Controls.Add(this.MsysPathTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 32);
            this.panel1.TabIndex = 1;
            // 
            // MsysSelectButton
            // 
            this.MsysSelectButton.Location = new System.Drawing.Point(326, 3);
            this.MsysSelectButton.Name = "MsysSelectButton";
            this.MsysSelectButton.Size = new System.Drawing.Size(86, 23);
            this.MsysSelectButton.TabIndex = 1;
            this.MsysSelectButton.Text = "Msys2";
            this.MsysSelectButton.UseVisualStyleBackColor = true;
            this.MsysSelectButton.Click += new System.EventHandler(this.MsysSelectButton_Click);
            // 
            // MsysPathTextBox
            // 
            this.MsysPathTextBox.Location = new System.Drawing.Point(3, 3);
            this.MsysPathTextBox.Name = "MsysPathTextBox";
            this.MsysPathTextBox.ReadOnly = true;
            this.MsysPathTextBox.Size = new System.Drawing.Size(317, 23);
            this.MsysPathTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GccSelectButton);
            this.panel2.Controls.Add(this.GccPathTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 32);
            this.panel2.TabIndex = 2;
            // 
            // GccSelectButton
            // 
            this.GccSelectButton.Location = new System.Drawing.Point(326, 3);
            this.GccSelectButton.Name = "GccSelectButton";
            this.GccSelectButton.Size = new System.Drawing.Size(86, 23);
            this.GccSelectButton.TabIndex = 1;
            this.GccSelectButton.Text = "gcc";
            this.GccSelectButton.UseVisualStyleBackColor = true;
            this.GccSelectButton.Click += new System.EventHandler(this.GccSelectButton_Click);
            // 
            // GccPathTextBox
            // 
            this.GccPathTextBox.Location = new System.Drawing.Point(3, 3);
            this.GccPathTextBox.Name = "GccPathTextBox";
            this.GccPathTextBox.ReadOnly = true;
            this.GccPathTextBox.Size = new System.Drawing.Size(317, 23);
            this.GccPathTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NasmSelectButton);
            this.panel3.Controls.Add(this.NasmPathTextBox);
            this.panel3.Location = new System.Drawing.Point(12, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 32);
            this.panel3.TabIndex = 3;
            // 
            // NasmSelectButton
            // 
            this.NasmSelectButton.Location = new System.Drawing.Point(326, 3);
            this.NasmSelectButton.Name = "NasmSelectButton";
            this.NasmSelectButton.Size = new System.Drawing.Size(86, 23);
            this.NasmSelectButton.TabIndex = 1;
            this.NasmSelectButton.Text = "nasm";
            this.NasmSelectButton.UseVisualStyleBackColor = true;
            this.NasmSelectButton.Click += new System.EventHandler(this.NasmSelectButton_Click);
            // 
            // NasmPathTextBox
            // 
            this.NasmPathTextBox.Location = new System.Drawing.Point(3, 3);
            this.NasmPathTextBox.Name = "NasmPathTextBox";
            this.NasmPathTextBox.ReadOnly = true;
            this.NasmPathTextBox.Size = new System.Drawing.Size(317, 23);
            this.NasmPathTextBox.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ExitButton);
            this.panel4.Controls.Add(this.SaveButton);
            this.panel4.Location = new System.Drawing.Point(12, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 43);
            this.panel4.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(326, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(86, 37);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(86, 37);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 172);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.Text = "Windows Build Tool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button MsysSelectButton;
        private TextBox MsysPathTextBox;
        private Panel panel2;
        private Button GccSelectButton;
        private TextBox GccPathTextBox;
        private Panel panel3;
        private Button NasmSelectButton;
        private TextBox NasmPathTextBox;
        private Panel panel4;
        private Button ExitButton;
        private Button SaveButton;
    }
}