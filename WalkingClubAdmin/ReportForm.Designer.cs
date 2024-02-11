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
            label15 = new System.Windows.Forms.Label();
            EndDatePicker = new System.Windows.Forms.DateTimePicker();
            label14 = new System.Windows.Forms.Label();
            SubjectTypeCombobox = new System.Windows.Forms.ComboBox();
            ClearButton = new System.Windows.Forms.Button();
            CreateJsonButton = new System.Windows.Forms.Button();
            PhotosGrid = new System.Windows.Forms.DataGridView();
            Photographer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label13 = new System.Windows.Forms.Label();
            PhotoTextBox = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            RatingTextBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            AuthorTextBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            TitleTextBox = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            ReportTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            DatePicker = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            IdTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            MarkDownButton = new System.Windows.Forms.Button();
            ParentTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)PhotosGrid).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(341, 42);
            label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(57, 15);
            label15.TabIndex = 47;
            label15.Text = "End Date:";
            // 
            // EndDatePicker
            // 
            EndDatePicker.CustomFormat = "dd/MM/yyyy";
            EndDatePicker.Enabled = false;
            EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            EndDatePicker.Location = new System.Drawing.Point(402, 38);
            EndDatePicker.Margin = new System.Windows.Forms.Padding(2);
            EndDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new System.Drawing.Size(139, 23);
            EndDatePicker.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(585, 12);
            label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(66, 15);
            label14.TabIndex = 33;
            label14.Text = "Event Type:";
            // 
            // SubjectTypeCombobox
            // 
            SubjectTypeCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            SubjectTypeCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            SubjectTypeCombobox.FormattingEnabled = true;
            SubjectTypeCombobox.Items.AddRange(new object[] { "Day", "Group", "Walk" });
            SubjectTypeCombobox.Location = new System.Drawing.Point(654, 10);
            SubjectTypeCombobox.Margin = new System.Windows.Forms.Padding(2);
            SubjectTypeCombobox.Name = "SubjectTypeCombobox";
            SubjectTypeCombobox.Size = new System.Drawing.Size(139, 23);
            SubjectTypeCombobox.TabIndex = 26;
            SubjectTypeCombobox.Text = "Walk";
            SubjectTypeCombobox.SelectedIndexChanged += SubjectTypeCombobox_SelectedIndexChanged;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            ClearButton.Location = new System.Drawing.Point(521, 514);
            ClearButton.Margin = new System.Windows.Forms.Padding(2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new System.Drawing.Size(82, 26);
            ClearButton.TabIndex = 45;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CreateJsonButton
            // 
            CreateJsonButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            CreateJsonButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            CreateJsonButton.Location = new System.Drawing.Point(614, 514);
            CreateJsonButton.Margin = new System.Windows.Forms.Padding(2);
            CreateJsonButton.Name = "CreateJsonButton";
            CreateJsonButton.Size = new System.Drawing.Size(82, 26);
            CreateJsonButton.TabIndex = 46;
            CreateJsonButton.Text = "Json";
            CreateJsonButton.UseVisualStyleBackColor = false;
            CreateJsonButton.Click += CreateButton_Click;
            // 
            // PhotosGrid
            // 
            PhotosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PhotosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Photographer, Filename, Caption });
            PhotosGrid.Location = new System.Drawing.Point(107, 353);
            PhotosGrid.Margin = new System.Windows.Forms.Padding(2);
            PhotosGrid.Name = "PhotosGrid";
            PhotosGrid.RowHeadersWidth = 51;
            PhotosGrid.RowTemplate.Height = 29;
            PhotosGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            PhotosGrid.Size = new System.Drawing.Size(685, 153);
            PhotosGrid.TabIndex = 40;
            // 
            // Photographer
            // 
            Photographer.HeaderText = "Photographer";
            Photographer.MinimumWidth = 9;
            Photographer.Name = "Photographer";
            Photographer.Width = 175;
            // 
            // Filename
            // 
            Filename.HeaderText = "Filename";
            Filename.MinimumWidth = 6;
            Filename.Name = "Filename";
            Filename.Width = 250;
            // 
            // Caption
            // 
            Caption.HeaderText = "Caption";
            Caption.MinimumWidth = 6;
            Caption.Name = "Caption";
            Caption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Caption.Width = 650;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(15, 358);
            label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(47, 15);
            label13.TabIndex = 44;
            label13.Text = "Photos:";
            // 
            // PhotoTextBox
            // 
            PhotoTextBox.Location = new System.Drawing.Point(107, 320);
            PhotoTextBox.Margin = new System.Windows.Forms.Padding(2);
            PhotoTextBox.Name = "PhotoTextBox";
            PhotoTextBox.Size = new System.Drawing.Size(139, 23);
            PhotoTextBox.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(17, 321);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(76, 15);
            label11.TabIndex = 42;
            label11.Text = "Cover Photo:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new System.Drawing.Point(654, 292);
            RatingTextBox.Margin = new System.Windows.Forms.Padding(2);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new System.Drawing.Size(139, 23);
            RatingTextBox.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(604, 292);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(44, 15);
            label10.TabIndex = 41;
            label10.Text = "Rating:";
            label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new System.Drawing.Point(107, 292);
            AuthorTextBox.Margin = new System.Windows.Forms.Padding(2);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new System.Drawing.Size(139, 23);
            AuthorTextBox.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(17, 292);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(47, 15);
            label9.TabIndex = 39;
            label9.Text = "Author:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new System.Drawing.Point(107, 65);
            TitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new System.Drawing.Size(685, 23);
            TitleTextBox.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(17, 66);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(39, 15);
            label8.TabIndex = 29;
            label8.Text = "Event:";
            // 
            // ReportTextBox
            // 
            ReportTextBox.Location = new System.Drawing.Point(107, 94);
            ReportTextBox.Margin = new System.Windows.Forms.Padding(2);
            ReportTextBox.Multiline = true;
            ReportTextBox.Name = "ReportTextBox";
            ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            ReportTextBox.Size = new System.Drawing.Size(685, 192);
            ReportTextBox.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(15, 96);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 15);
            label7.TabIndex = 35;
            label7.Text = "Report:";
            // 
            // DatePicker
            // 
            DatePicker.CustomFormat = "dd/MM/yyyy";
            DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            DatePicker.Location = new System.Drawing.Point(107, 38);
            DatePicker.Margin = new System.Windows.Forms.Padding(2);
            DatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new System.Drawing.Size(139, 23);
            DatePicker.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(17, 42);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(34, 15);
            label6.TabIndex = 27;
            label6.Text = "Date:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new System.Drawing.Point(107, 10);
            IdTextBox.Margin = new System.Windows.Forms.Padding(2);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new System.Drawing.Size(139, 23);
            IdTextBox.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 12);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(21, 15);
            label4.TabIndex = 24;
            label4.Text = "ID:";
            // 
            // MarkDownButton
            // 
            MarkDownButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            MarkDownButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            MarkDownButton.Location = new System.Drawing.Point(708, 514);
            MarkDownButton.Margin = new System.Windows.Forms.Padding(2);
            MarkDownButton.Name = "MarkDownButton";
            MarkDownButton.Size = new System.Drawing.Size(82, 26);
            MarkDownButton.TabIndex = 48;
            MarkDownButton.Text = "MarkDown";
            MarkDownButton.UseVisualStyleBackColor = false;
            MarkDownButton.Click += MarkDownButton_Click;
            // 
            // ParentTextBox
            // 
            ParentTextBox.Enabled = false;
            ParentTextBox.Location = new System.Drawing.Point(654, 38);
            ParentTextBox.Name = "ParentTextBox";
            ParentTextBox.Size = new System.Drawing.Size(139, 23);
            ParentTextBox.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(604, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 15);
            label1.TabIndex = 50;
            label1.Text = "Parent:";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            Controls.Add(label1);
            Controls.Add(ParentTextBox);
            Controls.Add(MarkDownButton);
            Controls.Add(label15);
            Controls.Add(EndDatePicker);
            Controls.Add(label14);
            Controls.Add(SubjectTypeCombobox);
            Controls.Add(ClearButton);
            Controls.Add(CreateJsonButton);
            Controls.Add(PhotosGrid);
            Controls.Add(label13);
            Controls.Add(PhotoTextBox);
            Controls.Add(label11);
            Controls.Add(RatingTextBox);
            Controls.Add(label10);
            Controls.Add(AuthorTextBox);
            Controls.Add(label9);
            Controls.Add(TitleTextBox);
            Controls.Add(label8);
            Controls.Add(ReportTextBox);
            Controls.Add(label7);
            Controls.Add(DatePicker);
            Controls.Add(label6);
            Controls.Add(IdTextBox);
            Controls.Add(label4);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "ReportForm";
            Size = new System.Drawing.Size(818, 550);
            ((System.ComponentModel.ISupportInitialize)PhotosGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox SubjectTypeCombobox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CreateJsonButton;
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
        private System.Windows.Forms.Button MarkDownButton;
        private System.Windows.Forms.TextBox ParentTextBox;
        private System.Windows.Forms.Label label1;
    }
}
