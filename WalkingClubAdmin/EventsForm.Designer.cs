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
            this.label1 = new System.Windows.Forms.Label();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.GoogleRadioButton = new System.Windows.Forms.RadioButton();
            this.ExcelRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcelSourceBrowseButton = new System.Windows.Forms.Button();
            this.ExcelSourceFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MongoDbDatesCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputFileTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.OutputFileBrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year:";
            // 
            // YearCombo
            // 
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Location = new System.Drawing.Point(214, 47);
            this.YearCombo.Margin = new System.Windows.Forms.Padding(4);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(132, 38);
            this.YearCombo.TabIndex = 2;
            // 
            // GoogleRadioButton
            // 
            this.GoogleRadioButton.AutoSize = true;
            this.GoogleRadioButton.Checked = true;
            this.GoogleRadioButton.Location = new System.Drawing.Point(214, 122);
            this.GoogleRadioButton.Name = "GoogleRadioButton";
            this.GoogleRadioButton.Size = new System.Drawing.Size(171, 34);
            this.GoogleRadioButton.TabIndex = 4;
            this.GoogleRadioButton.TabStop = true;
            this.GoogleRadioButton.Text = "Google Sheets";
            this.GoogleRadioButton.UseVisualStyleBackColor = true;
            this.GoogleRadioButton.CheckedChanged += new System.EventHandler(this.GoogleRadioButton_CheckedChanged);
            // 
            // ExcelRadioButton
            // 
            this.ExcelRadioButton.AutoSize = true;
            this.ExcelRadioButton.Location = new System.Drawing.Point(214, 162);
            this.ExcelRadioButton.Name = "ExcelRadioButton";
            this.ExcelRadioButton.Size = new System.Drawing.Size(185, 34);
            this.ExcelRadioButton.TabIndex = 6;
            this.ExcelRadioButton.Text = "Excel Workbook";
            this.ExcelRadioButton.UseVisualStyleBackColor = true;
            this.ExcelRadioButton.CheckedChanged += new System.EventHandler(this.ExcelRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Read Events From:";
            // 
            // ExcelSourceBrowseButton
            // 
            this.ExcelSourceBrowseButton.Enabled = false;
            this.ExcelSourceBrowseButton.Location = new System.Drawing.Point(1290, 219);
            this.ExcelSourceBrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExcelSourceBrowseButton.Name = "ExcelSourceBrowseButton";
            this.ExcelSourceBrowseButton.Size = new System.Drawing.Size(58, 44);
            this.ExcelSourceBrowseButton.TabIndex = 10;
            this.ExcelSourceBrowseButton.Text = "...";
            this.ExcelSourceBrowseButton.UseVisualStyleBackColor = true;
            this.ExcelSourceBrowseButton.Click += new System.EventHandler(this.ExcelSourceBrowseButton_Click);
            // 
            // ExcelSourceFileTextBox
            // 
            this.ExcelSourceFileTextBox.Enabled = false;
            this.ExcelSourceFileTextBox.Location = new System.Drawing.Point(214, 223);
            this.ExcelSourceFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExcelSourceFileTextBox.Name = "ExcelSourceFileTextBox";
            this.ExcelSourceFileTextBox.Size = new System.Drawing.Size(1068, 35);
            this.ExcelSourceFileTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Source File:";
            // 
            // MongoDbDatesCheckBox
            // 
            this.MongoDbDatesCheckBox.AutoSize = true;
            this.MongoDbDatesCheckBox.Checked = true;
            this.MongoDbDatesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MongoDbDatesCheckBox.Location = new System.Drawing.Point(214, 467);
            this.MongoDbDatesCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.MongoDbDatesCheckBox.Name = "MongoDbDatesCheckBox";
            this.MongoDbDatesCheckBox.Size = new System.Drawing.Size(192, 34);
            this.MongoDbDatesCheckBox.TabIndex = 13;
            this.MongoDbDatesCheckBox.Text = "MongoDB Dates";
            this.MongoDbDatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.Location = new System.Drawing.Point(214, 399);
            this.OutputFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.Size = new System.Drawing.Size(1068, 35);
            this.OutputFileTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Output File:";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(705, 666);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(141, 44);
            this.GenerateButton.TabIndex = 14;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // OutputFileBrowseButton
            // 
            this.OutputFileBrowseButton.Location = new System.Drawing.Point(1290, 395);
            this.OutputFileBrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.OutputFileBrowseButton.Name = "OutputFileBrowseButton";
            this.OutputFileBrowseButton.Size = new System.Drawing.Size(58, 44);
            this.OutputFileBrowseButton.TabIndex = 15;
            this.OutputFileBrowseButton.Text = "...";
            this.OutputFileBrowseButton.UseVisualStyleBackColor = true;
            this.OutputFileBrowseButton.Click += new System.EventHandler(this.OutputFileBrowseButton_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OutputFileBrowseButton);
            this.Controls.Add(this.MongoDbDatesCheckBox);
            this.Controls.Add(this.OutputFileTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExcelSourceBrowseButton);
            this.Controls.Add(this.ExcelSourceFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoogleRadioButton);
            this.Controls.Add(this.ExcelRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearCombo);
            this.Name = "EventsForm";
            this.Size = new System.Drawing.Size(1539, 836);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
