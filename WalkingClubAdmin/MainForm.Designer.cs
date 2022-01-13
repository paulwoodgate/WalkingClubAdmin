
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
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.SubjectTypeCombobox = new System.Windows.Forms.ComboBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PhotosGrid = new System.Windows.Forms.DataGridView();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.PhotographerTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PhotoTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.reportsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotosGrid)).BeginInit();
            this.eventsTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.HtmlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reportsTabPage);
            this.tabControl1.Controls.Add(this.eventsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(5, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportsTabPage.Controls.Add(this.label15);
            this.reportsTabPage.Controls.Add(this.EndDatePicker);
            this.reportsTabPage.Controls.Add(this.label14);
            this.reportsTabPage.Controls.Add(this.SubjectTypeCombobox);
            this.reportsTabPage.Controls.Add(this.ClearButton);
            this.reportsTabPage.Controls.Add(this.CreateButton);
            this.reportsTabPage.Controls.Add(this.PhotosGrid);
            this.reportsTabPage.Controls.Add(this.label13);
            this.reportsTabPage.Controls.Add(this.PhotographerTextBox);
            this.reportsTabPage.Controls.Add(this.label12);
            this.reportsTabPage.Controls.Add(this.PhotoTextBox);
            this.reportsTabPage.Controls.Add(this.label11);
            this.reportsTabPage.Controls.Add(this.RatingTextBox);
            this.reportsTabPage.Controls.Add(this.label10);
            this.reportsTabPage.Controls.Add(this.AuthorTextBox);
            this.reportsTabPage.Controls.Add(this.label9);
            this.reportsTabPage.Controls.Add(this.TitleTextBox);
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
            this.reportsTabPage.Size = new System.Drawing.Size(926, 605);
            this.reportsTabPage.TabIndex = 1;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(655, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Event Type:";
            // 
            // SubjectTypeCombobox
            // 
            this.SubjectTypeCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SubjectTypeCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SubjectTypeCombobox.FormattingEnabled = true;
            this.SubjectTypeCombobox.Items.AddRange(new object[] {
            "",
            "Day",
            "Group"});
            this.SubjectTypeCombobox.Location = new System.Drawing.Point(744, 20);
            this.SubjectTypeCombobox.Name = "SubjectTypeCombobox";
            this.SubjectTypeCombobox.Size = new System.Drawing.Size(158, 28);
            this.SubjectTypeCombobox.TabIndex = 2;
            this.SubjectTypeCombobox.SelectedValueChanged += new System.EventHandler(this.SubjectTypeCombobox_SelectedValueChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(703, 561);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(808, 561);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(94, 29);
            this.CreateButton.TabIndex = 21;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // PhotosGrid
            // 
            this.PhotosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhotosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filename,
            this.Caption});
            this.PhotosGrid.Location = new System.Drawing.Point(119, 351);
            this.PhotosGrid.Name = "PhotosGrid";
            this.PhotosGrid.RowHeadersWidth = 51;
            this.PhotosGrid.RowTemplate.Height = 29;
            this.PhotosGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PhotosGrid.Size = new System.Drawing.Size(783, 204);
            this.PhotosGrid.TabIndex = 11;
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Filename";
            this.Filename.MinimumWidth = 6;
            this.Filename.Name = "Filename";
            this.Filename.Width = 250;
            // 
            // Caption
            // 
            this.Caption.HeaderText = "Caption";
            this.Caption.MinimumWidth = 6;
            this.Caption.Name = "Caption";
            this.Caption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Caption.Width = 480;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Photos:";
            // 
            // PhotographerTextBox
            // 
            this.PhotographerTextBox.Location = new System.Drawing.Point(119, 306);
            this.PhotographerTextBox.Name = "PhotographerTextBox";
            this.PhotographerTextBox.Size = new System.Drawing.Size(158, 27);
            this.PhotographerTextBox.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Photographer:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PhotoTextBox
            // 
            this.PhotoTextBox.Location = new System.Drawing.Point(744, 306);
            this.PhotoTextBox.Name = "PhotoTextBox";
            this.PhotoTextBox.Size = new System.Drawing.Size(158, 27);
            this.PhotoTextBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(645, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cover Photo:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(744, 269);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(158, 27);
            this.RatingTextBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(683, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Rating:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(119, 269);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(158, 27);
            this.AuthorTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Author:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(119, 93);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(783, 27);
            this.TitleTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Event:";
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Location = new System.Drawing.Point(119, 132);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportTextBox.Size = new System.Drawing.Size(783, 128);
            this.ReportTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Report:";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "dd/MM/yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(119, 57);
            this.DatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(158, 27);
            this.DatePicker.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(119, 20);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(158, 27);
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
            this.eventsTabPage.Size = new System.Drawing.Size(926, 605);
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
            // EndDatePicker
            // 
            this.EndDatePicker.CustomFormat = "dd/MM/yyyy";
            this.EndDatePicker.Enabled = false;
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(744, 57);
            this.EndDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(158, 27);
            this.EndDatePicker.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(665, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "End Date:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 690);
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
            this.reportsTabPage.ResumeLayout(false);
            this.reportsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotosGrid)).EndInit();
            this.eventsTabPage.ResumeLayout(false);
            this.eventsTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HtmlGroupBox.ResumeLayout(false);
            this.HtmlGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView PhotosGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PhotographerTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PhotoTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox SubjectTypeCombobox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
    }
}

