namespace UI___Applications
{
    partial class frmMngTestTypes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManage = new System.Windows.Forms.Label();
            this.dgvManageTestTypes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTestTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI___Applications.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManage.ForeColor = System.Drawing.Color.Red;
            this.lblManage.Location = new System.Drawing.Point(209, 233);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(319, 42);
            this.lblManage.TabIndex = 3;
            this.lblManage.Text = "Manage Test Types";
            // 
            // dgvManageTestTypes
            // 
            this.dgvManageTestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvManageTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageTestTypes.Location = new System.Drawing.Point(12, 278);
            this.dgvManageTestTypes.Name = "dgvManageTestTypes";
            this.dgvManageTestTypes.Size = new System.Drawing.Size(740, 152);
            this.dgvManageTestTypes.TabIndex = 4;
            this.dgvManageTestTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageTestTypes_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::UI___Applications.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(657, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMngTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(764, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvManageTestTypes);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMngTestTypes";
            this.Text = "MngTestTypes";
            this.Load += new System.EventHandler(this.MngTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTestTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.DataGridView dgvManageTestTypes;
        private System.Windows.Forms.Button button1;
    }
}