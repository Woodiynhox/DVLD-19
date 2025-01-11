namespace PresentationLayer
{
    partial class frmChangePass
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCurrentPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbRepeatedPass = new System.Windows.Forms.TextBox();
            this.btnSaveNewPass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonalInfo1 = new PresentationLayer.ctrlPersonalInfo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(25, 39);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(72, 19);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Location = new System.Drawing.Point(21, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(478, 39);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(77, 19);
            this.lblIsActive.TabIndex = 2;
            this.lblIsActive.Text = "Is Active: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(228, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "UserName: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 499);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // tbCurrentPass
            // 
            this.tbCurrentPass.Location = new System.Drawing.Point(223, 412);
            this.tbCurrentPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbCurrentPass.Name = "tbCurrentPass";
            this.tbCurrentPass.PasswordChar = '*';
            this.tbCurrentPass.Size = new System.Drawing.Size(376, 20);
            this.tbCurrentPass.TabIndex = 5;
            this.tbCurrentPass.TextChanged += new System.EventHandler(this.tbCurrentPass_TextChanged);
            this.tbCurrentPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPass_Validating);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(223, 454);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(376, 20);
            this.tbNewPass.TabIndex = 6;
            // 
            // tbRepeatedPass
            // 
            this.tbRepeatedPass.Location = new System.Drawing.Point(223, 498);
            this.tbRepeatedPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbRepeatedPass.Name = "tbRepeatedPass";
            this.tbRepeatedPass.PasswordChar = '*';
            this.tbRepeatedPass.Size = new System.Drawing.Size(376, 20);
            this.tbRepeatedPass.TabIndex = 7;
            this.tbRepeatedPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbRepeatedPass_Validating);
            // 
            // btnSaveNewPass
            // 
            this.btnSaveNewPass.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewPass.Image = global::PresentationLayer.Properties.Resources.Save_321;
            this.btnSaveNewPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNewPass.Location = new System.Drawing.Point(739, 510);
            this.btnSaveNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveNewPass.Name = "btnSaveNewPass";
            this.btnSaveNewPass.Size = new System.Drawing.Size(80, 37);
            this.btnSaveNewPass.TabIndex = 8;
            this.btnSaveNewPass.Text = "Save";
            this.btnSaveNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveNewPass.UseVisualStyleBackColor = true;
            this.btnSaveNewPass.Click += new System.EventHandler(this.btnSaveNewPass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::PresentationLayer.Properties.Resources.Close_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(832, 510);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 37);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonalInfo1
            // 
            this.ctrlPersonalInfo1.Location = new System.Drawing.Point(-2, -2);
            this.ctrlPersonalInfo1.Name = "ctrlPersonalInfo1";
            this.ctrlPersonalInfo1.Size = new System.Drawing.Size(960, 311);
            this.ctrlPersonalInfo1.TabIndex = 10;
            this.ctrlPersonalInfo1.Load += new System.EventHandler(this.ctrlPersonalInfo1_Load);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 558);
            this.Controls.Add(this.ctrlPersonalInfo1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveNewPass);
            this.Controls.Add(this.tbRepeatedPass);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbCurrentPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChangePass";
            this.Text = "Change Password ";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCurrentPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbRepeatedPass;
        private System.Windows.Forms.Button btnSaveNewPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlPersonalInfo ctrlPersonalInfo1;
    }
}