namespace WalkingClubAdmin
{
    partial class ConvertForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FileRadioButton = new System.Windows.Forms.RadioButton();
            FolderRadioButton = new System.Windows.Forms.RadioButton();
            FileTextBox = new System.Windows.Forms.TextBox();
            FolderTextBox = new System.Windows.Forms.TextBox();
            FileSelectButton = new System.Windows.Forms.Button();
            FolderSelectButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            OutputTextBox = new System.Windows.Forms.TextBox();
            OutputButton = new System.Windows.Forms.Button();
            ConvertButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // FileRadioButton
            // 
            FileRadioButton.AutoSize = true;
            FileRadioButton.Checked = true;
            FileRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            FileRadioButton.Location = new System.Drawing.Point(60, 60);
            FileRadioButton.Name = "FileRadioButton";
            FileRadioButton.Size = new System.Drawing.Size(152, 34);
            FileRadioButton.TabIndex = 0;
            FileRadioButton.TabStop = true;
            FileRadioButton.Text = "Convert File:";
            FileRadioButton.UseVisualStyleBackColor = true;
            // 
            // FolderRadioButton
            // 
            FolderRadioButton.AutoSize = true;
            FolderRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            FolderRadioButton.Location = new System.Drawing.Point(60, 142);
            FolderRadioButton.Name = "FolderRadioButton";
            FolderRadioButton.Size = new System.Drawing.Size(178, 34);
            FolderRadioButton.TabIndex = 1;
            FolderRadioButton.Text = "Convert Folder:";
            FolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // FileTextBox
            // 
            FileTextBox.Location = new System.Drawing.Point(259, 63);
            FileTextBox.Name = "FileTextBox";
            FileTextBox.ReadOnly = true;
            FileTextBox.Size = new System.Drawing.Size(753, 35);
            FileTextBox.TabIndex = 2;
            // 
            // FolderTextBox
            // 
            FolderTextBox.Location = new System.Drawing.Point(259, 141);
            FolderTextBox.Name = "FolderTextBox";
            FolderTextBox.ReadOnly = true;
            FolderTextBox.Size = new System.Drawing.Size(753, 35);
            FolderTextBox.TabIndex = 3;
            // 
            // FileSelectButton
            // 
            FileSelectButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            FileSelectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            FileSelectButton.Location = new System.Drawing.Point(1027, 61);
            FileSelectButton.Name = "FileSelectButton";
            FileSelectButton.Size = new System.Drawing.Size(57, 40);
            FileSelectButton.TabIndex = 4;
            FileSelectButton.Text = "...";
            FileSelectButton.UseVisualStyleBackColor = false;
            FileSelectButton.Click += FileSelectButton_Click;
            // 
            // FolderSelectButton
            // 
            FolderSelectButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            FolderSelectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            FolderSelectButton.Location = new System.Drawing.Point(1027, 139);
            FolderSelectButton.Name = "FolderSelectButton";
            FolderSelectButton.Size = new System.Drawing.Size(57, 40);
            FolderSelectButton.TabIndex = 5;
            FolderSelectButton.Text = "...";
            FolderSelectButton.UseVisualStyleBackColor = false;
            FolderSelectButton.Click += FolderSelectButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(91, 236);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(147, 30);
            label1.TabIndex = 6;
            label1.Text = "Output Folder:";
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new System.Drawing.Point(259, 233);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.Size = new System.Drawing.Size(753, 35);
            OutputTextBox.TabIndex = 7;
            // 
            // OutputButton
            // 
            OutputButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            OutputButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            OutputButton.Location = new System.Drawing.Point(1027, 231);
            OutputButton.Name = "OutputButton";
            OutputButton.Size = new System.Drawing.Size(57, 40);
            OutputButton.TabIndex = 8;
            OutputButton.Text = "...";
            OutputButton.UseVisualStyleBackColor = false;
            OutputButton.Click += OutputButton_Click;
            // 
            // ConvertButton
            // 
            ConvertButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ConvertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            ConvertButton.Location = new System.Drawing.Point(573, 419);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new System.Drawing.Size(131, 40);
            ConvertButton.TabIndex = 9;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = false;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // ConvertForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            Controls.Add(ConvertButton);
            Controls.Add(OutputButton);
            Controls.Add(OutputTextBox);
            Controls.Add(label1);
            Controls.Add(FolderSelectButton);
            Controls.Add(FileSelectButton);
            Controls.Add(FolderTextBox);
            Controls.Add(FileTextBox);
            Controls.Add(FolderRadioButton);
            Controls.Add(FileRadioButton);
            Name = "ConvertForm";
            Size = new System.Drawing.Size(1261, 757);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton FileRadioButton;
        private System.Windows.Forms.RadioButton FolderRadioButton;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.Button FolderSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button ConvertButton;
    }
}
