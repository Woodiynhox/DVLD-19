namespace UI___Applications
{
    partial class frmApplicationsTypes
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
            this.lblManage = new System.Windows.Forms.Label();
            this.dgvManageApplicationsTypes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageApplicationsTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManage.ForeColor = System.Drawing.Color.Red;
            this.lblManage.Location = new System.Drawing.Point(137, 235);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(453, 42);
            this.lblManage.TabIndex = 2;
            this.lblManage.Text = "Manage Applications Types";
            this.lblManage.Click += new System.EventHandler(this.lblManage_Click);
            // 
            // dgvManageApplicationsTypes
            // 
            this.dgvManageApplicationsTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageApplicationsTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvManageApplicationsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageApplicationsTypes.Location = new System.Drawing.Point(3, 296);
            this.dgvManageApplicationsTypes.Name = "dgvManageApplicationsTypes";
            this.dgvManageApplicationsTypes.Size = new System.Drawing.Size(704, 242);
            this.dgvManageApplicationsTypes.TabIndex = 3;
            this.dgvManageApplicationsTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageApplicationsTypes_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI___Applications.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(200, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::UI___Applications.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(601, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmApplicationsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 613);
            this.Controls.Add(this.dgvManageApplicationsTypes);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmApplicationsTypes";
            this.Text = "Applications Types";
            this.Load += new System.EventHandler(this.frmApplicationsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageApplicationsTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.DataGridView dgvManageApplicationsTypes;
    }
}

