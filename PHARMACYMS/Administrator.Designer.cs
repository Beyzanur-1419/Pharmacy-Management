namespace PHARMACYMS
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.userNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnLogOut = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnStockM = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserM = new DevExpress.XtraEditors.SimpleButton();
            this.btnReporting = new DevExpress.XtraEditors.SimpleButton();
            this.btnDashboard = new DevExpress.XtraEditors.SimpleButton();
            this.uC_Dashboard1 = new PHARMACYMS.AdministratorUC.UC_Dashboard();
            this.uC_Reporting1 = new PHARMACYMS.AdministratorUC.UC_Reporting();
            this.uC_StockManagement1 = new PHARMACYMS.AdministratorUC.UC_StockManagement();
            this.uC_UserManagement1 = new PHARMACYMS.AdministratorUC.UC_UserManagement();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 223);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(291, 53);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Administrator";
            this.labelControl1.MouseEnter += new System.EventHandler(this.labelControl1_MouseEnter);
            this.labelControl1.MouseLeave += new System.EventHandler(this.labelControl1_MouseLeave);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.userNameLabel);
            this.panelControl1.Controls.Add(this.btnLogOut);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.btnStockM);
            this.panelControl1.Controls.Add(this.btnUserM);
            this.panelControl1.Controls.Add(this.btnReporting);
            this.panelControl1.Controls.Add(this.btnDashboard);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(340, 770);
            this.panelControl1.TabIndex = 27;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.userNameLabel.Appearance.Options.UseFont = true;
            this.userNameLabel.Appearance.Options.UseForeColor = true;
            this.userNameLabel.Location = new System.Drawing.Point(108, 708);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(111, 31);
            this.userNameLabel.TabIndex = 24;
            this.userNameLabel.Text = "username";
            this.userNameLabel.MouseEnter += new System.EventHandler(this.lblUsername_MouseEnter);
            this.userNameLabel.MouseLeave += new System.EventHandler(this.lblUsername_MouseLeave);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.uC_UserManagement1);
            this.panelControl2.Controls.Add(this.uC_StockManagement1);
            this.panelControl2.Controls.Add(this.uC_Reporting1);
            this.panelControl2.Controls.Add(this.uC_Dashboard1);
            this.panelControl2.Location = new System.Drawing.Point(340, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1100, 770);
            this.panelControl2.TabIndex = 28;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnLogOut.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.btnLogOut.Appearance.Options.UseBackColor = true;
            this.btnLogOut.Appearance.Options.UseFont = true;
            this.btnLogOut.Appearance.Options.UseForeColor = true;
            this.btnLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(3, 586);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(341, 60);
            this.btnLogOut.TabIndex = 23;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(58, 23);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.pictureEdit1.Properties.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseBorderColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(209, 194);
            this.pictureEdit1.TabIndex = 17;
            // 
            // btnStockM
            // 
            this.btnStockM.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnStockM.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStockM.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.btnStockM.Appearance.Options.UseBackColor = true;
            this.btnStockM.Appearance.Options.UseFont = true;
            this.btnStockM.Appearance.Options.UseForeColor = true;
            this.btnStockM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStockM.ImageOptions.Image")));
            this.btnStockM.Location = new System.Drawing.Point(3, 454);
            this.btnStockM.Name = "btnStockM";
            this.btnStockM.Size = new System.Drawing.Size(340, 60);
            this.btnStockM.TabIndex = 21;
            this.btnStockM.Text = "Stock Management";
            this.btnStockM.Click += new System.EventHandler(this.btnStockM_Click);
            this.btnStockM.MouseEnter += new System.EventHandler(this.btnStockM_MouseEnter);
            this.btnStockM.MouseLeave += new System.EventHandler(this.btnStockM_MouseLeave);
            // 
            // btnUserM
            // 
            this.btnUserM.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnUserM.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserM.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.btnUserM.Appearance.Options.UseBackColor = true;
            this.btnUserM.Appearance.Options.UseFont = true;
            this.btnUserM.Appearance.Options.UseForeColor = true;
            this.btnUserM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserM.ImageOptions.Image")));
            this.btnUserM.Location = new System.Drawing.Point(3, 388);
            this.btnUserM.Name = "btnUserM";
            this.btnUserM.Size = new System.Drawing.Size(340, 60);
            this.btnUserM.TabIndex = 20;
            this.btnUserM.Text = "User Management";
            this.btnUserM.Click += new System.EventHandler(this.btnUserM_Click);
            this.btnUserM.MouseEnter += new System.EventHandler(this.btnUserM_MouseEnter);
            this.btnUserM.MouseLeave += new System.EventHandler(this.btnUserM_MouseLeave);
            // 
            // btnReporting
            // 
            this.btnReporting.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnReporting.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReporting.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.btnReporting.Appearance.Options.UseBackColor = true;
            this.btnReporting.Appearance.Options.UseFont = true;
            this.btnReporting.Appearance.Options.UseForeColor = true;
            this.btnReporting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReporting.ImageOptions.Image")));
            this.btnReporting.Location = new System.Drawing.Point(3, 520);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(340, 60);
            this.btnReporting.TabIndex = 22;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            this.btnReporting.MouseEnter += new System.EventHandler(this.btnReporting_MouseEnter);
            this.btnReporting.MouseLeave += new System.EventHandler(this.btnReporting_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnDashboard.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.btnDashboard.Appearance.Options.UseBackColor = true;
            this.btnDashboard.Appearance.Options.UseFont = true;
            this.btnDashboard.Appearance.Options.UseForeColor = true;
            this.btnDashboard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.ImageOptions.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(3, 322);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(340, 60);
            this.btnDashboard.TabIndex = 18;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnDashboard_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.uC_Dashboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_Dashboard1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uC_Dashboard1.Location = new System.Drawing.Point(-5, 3);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1100, 770);
            this.uC_Dashboard1.TabIndex = 0;
            // 
            // uC_Reporting1
            // 
            this.uC_Reporting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.uC_Reporting1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_Reporting1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reporting1.Name = "uC_Reporting1";
            this.uC_Reporting1.Size = new System.Drawing.Size(1100, 770);
            this.uC_Reporting1.TabIndex = 1;
            // 
            // uC_StockManagement1
            // 
            this.uC_StockManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.uC_StockManagement1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_StockManagement1.Location = new System.Drawing.Point(0, 0);
            this.uC_StockManagement1.Name = "uC_StockManagement1";
            this.uC_StockManagement1.Size = new System.Drawing.Size(1100, 770);
            this.uC_StockManagement1.TabIndex = 2;
            // 
            // uC_UserManagement1
            // 
            this.uC_UserManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.uC_UserManagement1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_UserManagement1.Location = new System.Drawing.Point(0, 0);
            this.uC_UserManagement1.Name = "uC_UserManagement1";
            this.uC_UserManagement1.Size = new System.Drawing.Size(1100, 770);
            this.uC_UserManagement1.TabIndex = 3;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 770);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogOut;
        private DevExpress.XtraEditors.SimpleButton btnDashboard;
        private DevExpress.XtraEditors.SimpleButton btnReporting;
        private DevExpress.XtraEditors.SimpleButton btnUserM;
        private DevExpress.XtraEditors.SimpleButton btnStockM;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl userNameLabel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private AdministratorUC.UC_UserManagement uC_UserManagement1;
        private AdministratorUC.UC_StockManagement uC_StockManagement1;
        private AdministratorUC.UC_Reporting uC_Reporting1;
        private AdministratorUC.UC_Dashboard uC_Dashboard1;
    }
}