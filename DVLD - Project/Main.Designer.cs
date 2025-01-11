namespace DVLD___Project
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenceServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenceApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicenceApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenceServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicencesToolStripMenuItem,
            this.manageApplicationsTypeToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.applicationsToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.Applications_64;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(171, 36);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // drivingLicenceServicesToolStripMenuItem
            // 
            this.drivingLicenceServicesToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.Driver_License_48;
            this.drivingLicenceServicesToolStripMenuItem.Name = "drivingLicenceServicesToolStripMenuItem";
            this.drivingLicenceServicesToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.drivingLicenceServicesToolStripMenuItem.Text = "Driving Licence Services";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenceApplicationsToolStripMenuItem,
            this.internationalDrivingLicenceApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.Applications;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenceApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenceApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localDrivingLicenceApplicationsToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.LocalDriving_License;
            this.localDrivingLicenceApplicationsToolStripMenuItem.Name = "localDrivingLicenceApplicationsToolStripMenuItem";
            this.localDrivingLicenceApplicationsToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.localDrivingLicenceApplicationsToolStripMenuItem.Text = "Local Driving Licence Applications";
            this.localDrivingLicenceApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenceApplicationsToolStripMenuItem_Click);
            // 
            // internationalDrivingLicenceApplicationToolStripMenuItem
            // 
            this.internationalDrivingLicenceApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internationalDrivingLicenceApplicationToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.International_32;
            this.internationalDrivingLicenceApplicationToolStripMenuItem.Name = "internationalDrivingLicenceApplicationToolStripMenuItem";
            this.internationalDrivingLicenceApplicationToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.internationalDrivingLicenceApplicationToolStripMenuItem.Text = "International Driving Licence Application";
            // 
            // detainLicencesToolStripMenuItem
            // 
            this.detainLicencesToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.Detain_512;
            this.detainLicencesToolStripMenuItem.Name = "detainLicencesToolStripMenuItem";
            this.detainLicencesToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.detainLicencesToolStripMenuItem.Text = "Detain Licences";
            // 
            // manageApplicationsTypeToolStripMenuItem
            // 
            this.manageApplicationsTypeToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.Application_Types_512;
            this.manageApplicationsTypeToolStripMenuItem.Name = "manageApplicationsTypeToolStripMenuItem";
            this.manageApplicationsTypeToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.manageApplicationsTypeToolStripMenuItem.Text = "Manage Applications Type";
            this.manageApplicationsTypeToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypeToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.TestType_512;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.People_64;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.users_64;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(121, 36);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.Users_2_400;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.account_settings_64;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.Number_32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::DVLD___Project.Properties.Resources.Close_64;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD___Project.Properties.Resources.WallPaper2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1083, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "MAIN";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenceServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenceApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenceApplicationToolStripMenuItem;
    }
}

