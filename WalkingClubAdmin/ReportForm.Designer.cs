namespace WalkingClubAdmin
{
    partial class ReportForm
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
            this.label15 = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.SubjectTypeCombobox = new System.Windows.Forms.ComboBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PhotosGrid = new System.Windows.Forms.DataGridView();
            this.Photographer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.PhotosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1003, 83);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 30);
            this.label15.TabIndex = 47;
            this.label15.Text = "End Date:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CustomFormat = "dd/MM/yyyy";
            this.EndDatePicker.Enabled = false;
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(1121, 76);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EndDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(235, 35);
            this.EndDatePicker.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(987, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 30);
            this.label14.TabIndex = 33;
            this.label14.Text = "Event Type:";
            // 
            // SubjectTypeCombobox
            // 
            this.SubjectTypeCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SubjectTypeCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SubjectTypeCombobox.FormattingEnabled = true;
            this.SubjectTypeCombobox.Items.AddRange(new object[] {
            "Day",
            "Group",
            "Walk"});
            this.SubjectTypeCombobox.Location = new System.Drawing.Point(1121, 20);
            this.SubjectTypeCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectTypeCombobox.Name = "SubjectTypeCombobox";
            this.SubjectTypeCombobox.Size = new System.Drawing.Size(235, 38);
            this.SubjectTypeCombobox.TabIndex = 26;
            this.SubjectTypeCombobox.Text = "Walk";
            this.SubjectTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.SubjectTypeCombobox_SelectedIndexChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1059, 832);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(141, 44);
            this.ClearButton.TabIndex = 45;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(1217, 832);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(141, 44);
            this.CreateButton.TabIndex = 46;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // PhotosGrid
            // 
            this.PhotosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhotosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Photographer,
            this.Filename,
            this.Caption});
            this.PhotosGrid.Location = new System.Drawing.Point(183, 516);
            this.PhotosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PhotosGrid.Name = "PhotosGrid";
            this.PhotosGrid.RowHeadersWidth = 51;
            this.PhotosGrid.RowTemplate.Height = 29;
            this.PhotosGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PhotosGrid.Size = new System.Drawing.Size(1174, 306);
            this.PhotosGrid.TabIndex = 40;
            // 
            // Photographer
            // 
            this.Photographer.HeaderText = "Photographer";
            this.Photographer.MinimumWidth = 9;
            this.Photographer.Name = "Photographer";
            this.Photographer.Width = 175;
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
            this.label13.Location = new System.Drawing.Point(29, 516);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 30);
            this.label13.TabIndex = 44;
            this.label13.Text = "Photos:";
            // 
            // PhotoTextBox
            // 
            this.PhotoTextBox.Location = new System.Drawing.Point(183, 449);
            this.PhotoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoTextBox.Name = "PhotoTextBox";
            this.PhotoTextBox.Size = new System.Drawing.Size(235, 35);
            this.PhotoTextBox.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 452);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 30);
            this.label11.TabIndex = 42;
            this.label11.Text = "Cover Photo:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(1121, 394);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(235, 35);
            this.RatingTextBox.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1029, 398);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 30);
            this.label10.TabIndex = 41;
            this.label10.Text = "Rating:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(183, 394);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(235, 35);
            this.AuthorTextBox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 398);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 30);
            this.label9.TabIndex = 39;
            this.label9.Text = "Author:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(183, 130);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(1172, 35);
            this.TitleTextBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 30);
            this.label8.TabIndex = 29;
            this.label8.Text = "Event:";
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Location = new System.Drawing.Point(183, 188);
            this.ReportTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportTextBox.Size = new System.Drawing.Size(1172, 190);
            this.ReportTextBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 30);
            this.label7.TabIndex = 35;
            this.label7.Text = "Report:";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "dd/MM/yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(183, 76);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(235, 35);
            this.DatePicker.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Date:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(183, 20);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(235, 35);
            this.IdTextBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID:";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SubjectTypeCombobox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.PhotosGrid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PhotoTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label4);
            this.Name = "ReportForm";
            this.Size = new System.Drawing.Size(1403, 908);
            ((System.ComponentModel.ISupportInitialize)(this.PhotosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox SubjectTypeCombobox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView PhotosGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PhotoTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReportTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photographer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
    }
}
