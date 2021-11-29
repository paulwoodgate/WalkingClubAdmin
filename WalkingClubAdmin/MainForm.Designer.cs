
namespace WalkingClubAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.eventsTabPage = new System.Windows.Forms.TabPage();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MongoDbDatesCheckBox = new System.Windows.Forms.CheckBox();
            this.JsonOutputBrowseButton = new System.Windows.Forms.Button();
            this.JsonOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JsonCheckbox = new System.Windows.Forms.CheckBox();
            this.HtmlGroupBox = new System.Windows.Forms.GroupBox();
            this.HtmlOutputBrowseButton = new System.Windows.Forms.Button();
            this.HtmlSourceBrowseButton = new System.Windows.Forms.Button();
            this.HtmlOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.HtmlSourceFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HtmlCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.createButton = new System.Windows.Forms.Button();
            this.captionGrid = new System.Windows.Forms.DataGridView();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.photographerTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.eventsTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.HtmlGroupBox.SuspendLayout();
            this.reportsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reportsTabPage);
            this.tabControl1.Controls.Add(this.eventsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(5, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // eventsTabPage
            // 
            this.eventsTabPage.Controls.Add(this.GenerateButton);
            this.eventsTabPage.Controls.Add(this.groupBox1);
            this.eventsTabPage.Controls.Add(this.HtmlGroupBox);
            this.eventsTabPage.Controls.Add(this.label1);
            this.eventsTabPage.Controls.Add(this.YearCombo);
            this.eventsTabPage.Location = new System.Drawing.Point(4, 29);
            this.eventsTabPage.Name = "eventsTabPage";
            this.eventsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventsTabPage.Size = new System.Drawing.Size(926, 518);
            this.eventsTabPage.TabIndex = 0;
            this.eventsTabPage.Text = "Events";
            this.eventsTabPage.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(807, 462);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(94, 29);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MongoDbDatesCheckBox);
            this.groupBox1.Controls.Add(this.JsonOutputBrowseButton);
            this.groupBox1.Controls.Add(this.JsonOutputFileTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.JsonCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(11, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // MongoDbDatesCheckBox
            // 
            this.MongoDbDatesCheckBox.AutoSize = true;
            this.MongoDbDatesCheckBox.Checked = true;
            this.MongoDbDatesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MongoDbDatesCheckBox.Enabled = false;
            this.MongoDbDatesCheckBox.Location = new System.Drawing.Point(134, 119);
            this.MongoDbDatesCheckBox.Name = "MongoDbDatesCheckBox";
            this.MongoDbDatesCheckBox.Size = new System.Drawing.Size(141, 24);
            this.MongoDbDatesCheckBox.TabIndex = 8;
            this.MongoDbDatesCheckBox.Text = "MongoDB Dates";
            this.MongoDbDatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // JsonOutputBrowseButton
            // 
            this.JsonOutputBrowseButton.Enabled = false;
            this.JsonOutputBrowseButton.Location = new System.Drawing.Point(853, 73);
            this.JsonOutputBrowseButton.Name = "JsonOutputBrowseButton";
            this.JsonOutputBrowseButton.Size = new System.Drawing.Size(39, 29);
            this.JsonOutputBrowseButton.TabIndex = 7;
            this.JsonOutputBrowseButton.Text = "...";
            this.JsonOutputBrowseButton.UseVisualStyleBackColor = true;
            this.JsonOutputBrowseButton.Click += new System.EventHandler(this.JsonOutputBrowseButton_Click);
            // 
            // JsonOutputFileTextBox
            // 
            this.JsonOutputFileTextBox.Enabled = false;
            this.JsonOutputFileTextBox.Location = new System.Drawing.Point(134, 73);
            this.JsonOutputFileTextBox.Name = "JsonOutputFileTextBox";
            this.JsonOutputFileTextBox.Size = new System.Drawing.Size(713, 27);
            this.JsonOutputFileTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Output File:";
            // 
            // JsonCheckbox
            // 
            this.JsonCheckbox.AutoSize = true;
            this.JsonCheckbox.Location = new System.Drawing.Point(22, 27);
            this.JsonCheckbox.Name = "JsonCheckbox";
            this.JsonCheckbox.Size = new System.Drawing.Size(106, 24);
            this.JsonCheckbox.TabIndex = 0;
            this.JsonCheckbox.Text = "Create Json";
            this.JsonCheckbox.UseVisualStyleBackColor = true;
            this.JsonCheckbox.CheckedChanged += new System.EventHandler(this.JsonCheckbox_CheckedChanged);
            // 
            // HtmlGroupBox
            // 
            this.HtmlGroupBox.Controls.Add(this.HtmlOutputBrowseButton);
            this.HtmlGroupBox.Controls.Add(this.HtmlSourceBrowseButton);
            this.HtmlGroupBox.Controls.Add(this.HtmlOutputFileTextBox);
            this.HtmlGroupBox.Controls.Add(this.HtmlSourceFileTextBox);
            this.HtmlGroupBox.Controls.Add(this.label3);
            this.HtmlGroupBox.Controls.Add(this.label2);
            this.HtmlGroupBox.Controls.Add(this.HtmlCheckbox);
            this.HtmlGroupBox.Location = new System.Drawing.Point(9, 70);
            this.HtmlGroupBox.Name = "HtmlGroupBox";
            this.HtmlGroupBox.Size = new System.Drawing.Size(919, 161);
            this.HtmlGroupBox.TabIndex = 2;
            this.HtmlGroupBox.TabStop = false;
            // 
            // HtmlOutputBrowseButton
            // 
            this.HtmlOutputBrowseButton.Enabled = false;
            this.HtmlOutputBrowseButton.Location = new System.Drawing.Point(853, 118);
            this.HtmlOutputBrowseButton.Name = "HtmlOutputBrowseButton";
            this.HtmlOutputBrowseButton.Size = new System.Drawing.Size(39, 29);
            this.HtmlOutputBrowseButton.TabIndex = 6;
            this.HtmlOutputBrowseButton.Text = "...";
            this.HtmlOutputBrowseButton.UseVisualStyleBackColor = true;
            this.HtmlOutputBrowseButton.Click += new System.EventHandler(this.HtmlOutputBrowseButton_Click);
            // 
            // HtmlSourceBrowseButton
            // 
            this.HtmlSourceBrowseButton.Enabled = false;
            this.HtmlSourceBrowseButton.Location = new System.Drawing.Point(853, 71);
            this.HtmlSourceBrowseButton.Name = "HtmlSourceBrowseButton";
            this.HtmlSourceBrowseButton.Size = new System.Drawing.Size(39, 29);
            this.HtmlSourceBrowseButton.TabIndex = 5;
            this.HtmlSourceBrowseButton.Text = "...";
            this.HtmlSourceBrowseButton.UseVisualStyleBackColor = true;
            this.HtmlSourceBrowseButton.Click += new System.EventHandler(this.HtmlSourceBrowseButton_Click);
            // 
            // HtmlOutputFileTextBox
            // 
            this.HtmlOutputFileTextBox.Enabled = false;
            this.HtmlOutputFileTextBox.Location = new System.Drawing.Point(134, 118);
            this.HtmlOutputFileTextBox.Name = "HtmlOutputFileTextBox";
            this.HtmlOutputFileTextBox.Size = new System.Drawing.Size(713, 27);
            this.HtmlOutputFileTextBox.TabIndex = 4;
            // 
            // HtmlSourceFileTextBox
            // 
            this.HtmlSourceFileTextBox.Enabled = false;
            this.HtmlSourceFileTextBox.Location = new System.Drawing.Point(134, 73);
            this.HtmlSourceFileTextBox.Name = "HtmlSourceFileTextBox";
            this.HtmlSourceFileTextBox.Size = new System.Drawing.Size(713, 27);
            this.HtmlSourceFileTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source File:";
            // 
            // HtmlCheckbox
            // 
            this.HtmlCheckbox.AutoSize = true;
            this.HtmlCheckbox.Location = new System.Drawing.Point(22, 27);
            this.HtmlCheckbox.Name = "HtmlCheckbox";
            this.HtmlCheckbox.Size = new System.Drawing.Size(114, 24);
            this.HtmlCheckbox.TabIndex = 0;
            this.HtmlCheckbox.Text = "Create Html:";
            this.HtmlCheckbox.UseVisualStyleBackColor = true;
            this.HtmlCheckbox.CheckedChanged += new System.EventHandler(this.HtmlCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year:";
            // 
            // YearCombo
            // 
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Location = new System.Drawing.Point(143, 31);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(89, 28);
            this.YearCombo.TabIndex = 0;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportsTabPage.Controls.Add(this.createButton);
            this.reportsTabPage.Controls.Add(this.captionGrid);
            this.reportsTabPage.Controls.Add(this.label13);
            this.reportsTabPage.Controls.Add(this.photographerTextBox);
            this.reportsTabPage.Controls.Add(this.label12);
            this.reportsTabPage.Controls.Add(this.photoTextBox);
            this.reportsTabPage.Controls.Add(this.label11);
            this.reportsTabPage.Controls.Add(this.ratingTextBox);
            this.reportsTabPage.Controls.Add(this.label10);
            this.reportsTabPage.Controls.Add(this.authorTextBox);
            this.reportsTabPage.Controls.Add(this.label9);
            this.reportsTabPage.Controls.Add(this.titleTextBox);
            this.reportsTabPage.Controls.Add(this.label8);
            this.reportsTabPage.Controls.Add(this.ReportTextBox);
            this.reportsTabPage.Controls.Add(this.label7);
            this.reportsTabPage.Controls.Add(this.DatePicker);
            this.reportsTabPage.Controls.Add(this.label6);
            this.reportsTabPage.Controls.Add(this.IdTextBox);
            this.reportsTabPage.Controls.Add(this.label4);
            this.reportsTabPage.Location = new System.Drawing.Point(4, 29);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(926, 518);
            this.reportsTabPage.TabIndex = 1;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(808, 468);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 29);
            this.createButton.TabIndex = 19;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // captionGrid
            // 
            this.captionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.captionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caption});
            this.captionGrid.Location = new System.Drawing.Point(112, 326);
            this.captionGrid.Name = "captionGrid";
            this.captionGrid.RowHeadersWidth = 51;
            this.captionGrid.RowTemplate.Height = 29;
            this.captionGrid.Size = new System.Drawing.Size(790, 136);
            this.captionGrid.TabIndex = 18;
            // 
            // Caption
            // 
            this.Caption.HeaderText = "Caption";
            this.Caption.MinimumWidth = 6;
            this.Caption.Name = "Caption";
            this.Caption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Caption.Width = 250;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Photos:";
            // 
            // photographerTextBox
            // 
            this.photographerTextBox.Location = new System.Drawing.Point(767, 281);
            this.photographerTextBox.Name = "photographerTextBox";
            this.photographerTextBox.Size = new System.Drawing.Size(135, 27);
            this.photographerTextBox.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Photographer:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // photoTextBox
            // 
            this.photoTextBox.Location = new System.Drawing.Point(112, 281);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(125, 27);
            this.photoTextBox.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cover Photo:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(767, 241);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(135, 27);
            this.ratingTextBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Rating:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(112, 241);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(125, 27);
            this.authorTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Author:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(112, 64);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(790, 27);
            this.titleTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Event:";
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Location = new System.Drawing.Point(112, 107);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportTextBox.Size = new System.Drawing.Size(790, 113);
            this.ReportTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Report:";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "dd/MM/yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(767, 21);
            this.DatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(135, 27);
            this.DatePicker.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(112, 20);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(128, 27);
            this.IdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(777, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Walking Club Admin";
            this.tabControl1.ResumeLayout(false);
            this.eventsTabPage.ResumeLayout(false);
            this.eventsTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HtmlGroupBox.ResumeLayout(false);
            this.HtmlGroupBox.PerformLayout();
            this.reportsTabPage.ResumeLayout(false);
            this.reportsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage eventsTabPage;
        private System.Windows.Forms.TabPage reportsTabPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox YearCombo;
        private System.Windows.Forms.GroupBox HtmlGroupBox;
        private System.Windows.Forms.CheckBox HtmlCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox JsonCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HtmlOutputFileTextBox;
        private System.Windows.Forms.TextBox HtmlSourceFileTextBox;
        private System.Windows.Forms.TextBox JsonOutputFileTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox MongoDbDatesCheckBox;
        private System.Windows.Forms.Button JsonOutputBrowseButton;
        private System.Windows.Forms.Button HtmlOutputBrowseButton;
        private System.Windows.Forms.Button HtmlSourceBrowseButton;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ReportTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridView captionGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox photographerTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
    }
}

