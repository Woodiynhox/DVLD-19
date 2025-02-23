namespace UI___Applications
{
    partial class frmLocalDrivingLicenceApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicenceApplications = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sechduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenceApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(225, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Driving Licence Applications";
            // 
            // dgvLocalDrivingLicenceApplications
            // 
            this.dgvLocalDrivingLicenceApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalDrivingLicenceApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenceApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenceApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalDrivingLicenceApplications.Location = new System.Drawing.Point(3, 253);
            this.dgvLocalDrivingLicenceApplications.Name = "dgvLocalDrivingLicenceApplications";
            this.dgvLocalDrivingLicenceApplications.Size = new System.Drawing.Size(1137, 150);
            this.dgvLocalDrivingLicenceApplications.TabIndex = 2;
            this.dgvLocalDrivingLicenceApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalDrivingLicenceApplications_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 50);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // sechduleTestToolStripMenuItem
            // 
            this.sechduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsScheduleVisionTest,
            this.cmsScheduleWrittenTest,
            this.cmsScheduleStreetTest});
            this.sechduleTestToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sechduleTestToolStripMenuItem.Image = global::UI___Applications.Properties.Resources.Schedule_Test_512;
            this.sechduleTestToolStripMenuItem.Name = "sechduleTestToolStripMenuItem";
            this.sechduleTestToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.sechduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // cmsScheduleVisionTest
            // 
            this.cmsScheduleVisionTest.Image = global::UI___Applications.Properties.Resources.Vision_512;
            this.cmsScheduleVisionTest.Name = "cmsScheduleVisionTest";
            this.cmsScheduleVisionTest.Size = new System.Drawing.Size(224, 24);
            this.cmsScheduleVisionTest.Text = "Schedule Vision Test";
            this.cmsScheduleVisionTest.Click += new System.EventHandler(this.cmsScheduleVisionTest_Click);
            // 
            // cmsScheduleWrittenTest
            // 
            this.cmsScheduleWrittenTest.Image = global::UI___Applications.Properties.Resources.Written_Test_512;
            this.cmsScheduleWrittenTest.Name = "cmsScheduleWrittenTest";
            this.cmsScheduleWrittenTest.Size = new System.Drawing.Size(224, 24);
            this.cmsScheduleWrittenTest.Text = "Schedule Written Test";
            // 
            // cmsScheduleStreetTest
            // 
            this.cmsScheduleStreetTest.Image = global::UI___Applications.Properties.Resources.Street_Test_32;
            this.cmsScheduleStreetTest.Name = "cmsScheduleStreetTest";
            this.cmsScheduleStreetTest.Size = new System.Drawing.Size(224, 24);
            this.cmsScheduleStreetTest.Text = "Schedule Street Test";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::UI___Applications.Properties.Resources.LocalDriving_License;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(978, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "New Application";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI___Applications.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(379, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLocalDrivingLicenceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLocalDrivingLicenceApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmLocalDrivingLicenceApp";
            this.Text = "LocalDrivingLicenceApp";
            this.Load += new System.EventHandler(this.LocalDrivingLicenceApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenceApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenceApplications;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem cmsScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem cmsScheduleStreetTest;
    }
}