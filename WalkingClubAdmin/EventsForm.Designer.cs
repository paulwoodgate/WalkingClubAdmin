namespace WalkingClubAdmin
{
    partial class EventsForm
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
            label1 = new System.Windows.Forms.Label();
            YearCombo = new System.Windows.Forms.ComboBox();
            GoogleRadioButton = new System.Windows.Forms.RadioButton();
            ExcelRadioButton = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            ExcelSourceBrowseButton = new System.Windows.Forms.Button();
            ExcelSourceFileTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            MongoDbDatesCheckBox = new System.Windows.Forms.CheckBox();
            OutputFileTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            GenerateButton = new System.Windows.Forms.Button();
            OutputFileBrowseButton = new System.Windows.Forms.Button();
            JsonCheckBox = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            MarkdownCheckBox = new System.Windows.Forms.CheckBox();
            MarkdownFolderTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            MarkdownFolderButton = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            FlattenSourceCheckbox = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(88, 26);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 15);
            label1.TabIndex = 3;
            label1.Text = "Year:";
            // 
            // YearCombo
            // 
            YearCombo.FormattingEnabled = true;
            YearCombo.Location = new System.Drawing.Point(127, 25);
            YearCombo.Margin = new System.Windows.Forms.Padding(2);
            YearCombo.Name = "YearCombo";
            YearCombo.Size = new System.Drawing.Size(79, 23);
            YearCombo.TabIndex = 2;
            // 
            // GoogleRadioButton
            // 
            GoogleRadioButton.AutoSize = true;
            GoogleRadioButton.Checked = true;
            GoogleRadioButton.Location = new System.Drawing.Point(127, 62);
            GoogleRadioButton.Margin = new System.Windows.Forms.Padding(2);
            GoogleRadioButton.Name = "GoogleRadioButton";
            GoogleRadioButton.Size = new System.Drawing.Size(100, 19);
            GoogleRadioButton.TabIndex = 4;
            GoogleRadioButton.TabStop = true;
            GoogleRadioButton.Text = "Google Sheets";
            GoogleRadioButton.UseVisualStyleBackColor = true;
            GoogleRadioButton.CheckedChanged += GoogleRadioButton_CheckedChanged;
            // 
            // ExcelRadioButton
            // 
            ExcelRadioButton.AutoSize = true;
            ExcelRadioButton.Location = new System.Drawing.Point(127, 82);
            ExcelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            ExcelRadioButton.Name = "ExcelRadioButton";
            ExcelRadioButton.Size = new System.Drawing.Size(109, 19);
            ExcelRadioButton.TabIndex = 6;
            ExcelRadioButton.Text = "Excel Workbook";
            ExcelRadioButton.UseVisualStyleBackColor = true;
            ExcelRadioButton.CheckedChanged += ExcelRadioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 64);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 15);
            label2.TabIndex = 7;
            label2.Text = "Read Events From:";
            // 
            // ExcelSourceBrowseButton
            // 
            ExcelSourceBrowseButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ExcelSourceBrowseButton.Enabled = false;
            ExcelSourceBrowseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            ExcelSourceBrowseButton.Location = new System.Drawing.Point(755, 111);
            ExcelSourceBrowseButton.Margin = new System.Windows.Forms.Padding(2);
            ExcelSourceBrowseButton.Name = "ExcelSourceBrowseButton";
            ExcelSourceBrowseButton.Size = new System.Drawing.Size(34, 22);
            ExcelSourceBrowseButton.TabIndex = 10;
            ExcelSourceBrowseButton.Text = "...";
            ExcelSourceBrowseButton.UseVisualStyleBackColor = false;
            ExcelSourceBrowseButton.Click += ExcelSourceBrowseButton_Click;
            // 
            // ExcelSourceFileTextBox
            // 
            ExcelSourceFileTextBox.Enabled = false;
            ExcelSourceFileTextBox.Location = new System.Drawing.Point(127, 113);
            ExcelSourceFileTextBox.Margin = new System.Windows.Forms.Padding(2);
            ExcelSourceFileTextBox.Name = "ExcelSourceFileTextBox";
            ExcelSourceFileTextBox.Size = new System.Drawing.Size(625, 23);
            ExcelSourceFileTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 114);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Source File:";
            // 
            // MongoDbDatesCheckBox
            // 
            MongoDbDatesCheckBox.AutoSize = true;
            MongoDbDatesCheckBox.Checked = true;
            MongoDbDatesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            MongoDbDatesCheckBox.Location = new System.Drawing.Point(128, 222);
            MongoDbDatesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            MongoDbDatesCheckBox.Name = "MongoDbDatesCheckBox";
            MongoDbDatesCheckBox.Size = new System.Drawing.Size(112, 19);
            MongoDbDatesCheckBox.TabIndex = 13;
            MongoDbDatesCheckBox.Text = "MongoDB Dates";
            MongoDbDatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputFileTextBox
            // 
            OutputFileTextBox.Location = new System.Drawing.Point(128, 188);
            OutputFileTextBox.Margin = new System.Windows.Forms.Padding(2);
            OutputFileTextBox.Name = "OutputFileTextBox";
            OutputFileTextBox.Size = new System.Drawing.Size(625, 23);
            OutputFileTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(41, 190);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 15);
            label5.TabIndex = 11;
            label5.Text = "Output File:";
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            GenerateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            GenerateButton.Location = new System.Drawing.Point(407, 393);
            GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new System.Drawing.Size(82, 28);
            GenerateButton.TabIndex = 14;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // OutputFileBrowseButton
            // 
            OutputFileBrowseButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            OutputFileBrowseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            OutputFileBrowseButton.Location = new System.Drawing.Point(756, 186);
            OutputFileBrowseButton.Margin = new System.Windows.Forms.Padding(2);
            OutputFileBrowseButton.Name = "OutputFileBrowseButton";
            OutputFileBrowseButton.Size = new System.Drawing.Size(34, 22);
            OutputFileBrowseButton.TabIndex = 15;
            OutputFileBrowseButton.Text = "...";
            OutputFileBrowseButton.UseVisualStyleBackColor = false;
            OutputFileBrowseButton.Click += OutputFileBrowseButton_Click;
            // 
            // JsonCheckBox
            // 
            JsonCheckBox.AutoSize = true;
            JsonCheckBox.Checked = true;
            JsonCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            JsonCheckBox.Location = new System.Drawing.Point(9, 0);
            JsonCheckBox.Margin = new System.Windows.Forms.Padding(2);
            JsonCheckBox.Name = "JsonCheckBox";
            JsonCheckBox.Size = new System.Drawing.Size(86, 19);
            JsonCheckBox.TabIndex = 16;
            JsonCheckBox.Text = "Create Json";
            JsonCheckBox.UseVisualStyleBackColor = true;
            JsonCheckBox.CheckedChanged += JsonCheckBox_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FlattenSourceCheckbox);
            groupBox1.Controls.Add(JsonCheckBox);
            groupBox1.Location = new System.Drawing.Point(33, 159);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(769, 124);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // MarkdownCheckBox
            // 
            MarkdownCheckBox.AutoSize = true;
            MarkdownCheckBox.Checked = true;
            MarkdownCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            MarkdownCheckBox.Location = new System.Drawing.Point(40, 306);
            MarkdownCheckBox.Margin = new System.Windows.Forms.Padding(2);
            MarkdownCheckBox.Name = "MarkdownCheckBox";
            MarkdownCheckBox.Size = new System.Drawing.Size(120, 19);
            MarkdownCheckBox.TabIndex = 18;
            MarkdownCheckBox.Text = "Create Markdown";
            MarkdownCheckBox.UseVisualStyleBackColor = true;
            MarkdownCheckBox.CheckedChanged += MarkdownCheckBox_CheckedChanged;
            // 
            // MarkdownFolderTextBox
            // 
            MarkdownFolderTextBox.Location = new System.Drawing.Point(127, 326);
            MarkdownFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            MarkdownFolderTextBox.Name = "MarkdownFolderTextBox";
            MarkdownFolderTextBox.Size = new System.Drawing.Size(624, 23);
            MarkdownFolderTextBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 327);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 15);
            label4.TabIndex = 20;
            label4.Text = "Output Folder:";
            // 
            // MarkdownFolderButton
            // 
            MarkdownFolderButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            MarkdownFolderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            MarkdownFolderButton.Location = new System.Drawing.Point(752, 325);
            MarkdownFolderButton.Margin = new System.Windows.Forms.Padding(2);
            MarkdownFolderButton.Name = "MarkdownFolderButton";
            MarkdownFolderButton.Size = new System.Drawing.Size(34, 22);
            MarkdownFolderButton.TabIndex = 21;
            MarkdownFolderButton.Text = "...";
            MarkdownFolderButton.UseVisualStyleBackColor = false;
            MarkdownFolderButton.Click += MarkdownFolderButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new System.Drawing.Point(32, 304);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(769, 62);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // FlattenSourceCheckbox
            // 
            FlattenSourceCheckbox.AutoSize = true;
            FlattenSourceCheckbox.Location = new System.Drawing.Point(95, 87);
            FlattenSourceCheckbox.Name = "FlattenSourceCheckbox";
            FlattenSourceCheckbox.Size = new System.Drawing.Size(149, 19);
            FlattenSourceCheckbox.TabIndex = 17;
            FlattenSourceCheckbox.Text = "Flatten Source Property";
            FlattenSourceCheckbox.UseVisualStyleBackColor = true;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            Controls.Add(MarkdownFolderButton);
            Controls.Add(label4);
            Controls.Add(MarkdownFolderTextBox);
            Controls.Add(MarkdownCheckBox);
            Controls.Add(GenerateButton);
            Controls.Add(OutputFileBrowseButton);
            Controls.Add(MongoDbDatesCheckBox);
            Controls.Add(OutputFileTextBox);
            Controls.Add(label5);
            Controls.Add(ExcelSourceBrowseButton);
            Controls.Add(ExcelSourceFileTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GoogleRadioButton);
            Controls.Add(ExcelRadioButton);
            Controls.Add(label1);
            Controls.Add(YearCombo);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "EventsForm";
            Size = new System.Drawing.Size(898, 444);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox YearCombo;
        private System.Windows.Forms.RadioButton GoogleRadioButton;
        private System.Windows.Forms.RadioButton ExcelRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExcelSourceBrowseButton;
        private System.Windows.Forms.TextBox ExcelSourceFileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox MongoDbDatesCheckBox;
        private System.Windows.Forms.TextBox OutputFileTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button OutputFileBrowseButton;
        private System.Windows.Forms.CheckBox JsonCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox MarkdownCheckBox;
        private System.Windows.Forms.TextBox MarkdownFolderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MarkdownFolderButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox FlattenSourceCheckbox;
    }
}
