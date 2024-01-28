
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
            tabControl1 = new System.Windows.Forms.TabControl();
            reportsTabPage = new System.Windows.Forms.TabPage();
            eventsTabPage = new System.Windows.Forms.TabPage();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(reportsTabPage);
            tabControl1.Controls.Add(eventsTabPage);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            tabControl1.Location = new System.Drawing.Point(8, 70);
            tabControl1.Margin = new System.Windows.Forms.Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1400, 1147);
            tabControl1.TabIndex = 0;
            // 
            // reportsTabPage
            // 
            reportsTabPage.BackColor = System.Drawing.Color.Transparent;
            reportsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            reportsTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            reportsTabPage.Location = new System.Drawing.Point(4, 39);
            reportsTabPage.Margin = new System.Windows.Forms.Padding(4);
            reportsTabPage.Name = "reportsTabPage";
            reportsTabPage.Padding = new System.Windows.Forms.Padding(4);
            reportsTabPage.Size = new System.Drawing.Size(1392, 1104);
            reportsTabPage.TabIndex = 1;
            reportsTabPage.Text = "Reports";
            // 
            // eventsTabPage
            // 
            eventsTabPage.BackColor = System.Drawing.Color.Transparent;
            eventsTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            eventsTabPage.Location = new System.Drawing.Point(4, 39);
            eventsTabPage.Margin = new System.Windows.Forms.Padding(4);
            eventsTabPage.Name = "eventsTabPage";
            eventsTabPage.Padding = new System.Windows.Forms.Padding(4);
            eventsTabPage.Size = new System.Drawing.Size(1392, 1104);
            eventsTabPage.TabIndex = 0;
            eventsTabPage.Text = "Events";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1166, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(237, 93);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.AppWorkspace;
            ClientSize = new System.Drawing.Size(1416, 1225);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            ForeColor = System.Drawing.SystemColors.InactiveCaption;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Padding = new System.Windows.Forms.Padding(8);
            Text = "Walking Club Admin";
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage eventsTabPage;
        private System.Windows.Forms.TabPage reportsTabPage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

