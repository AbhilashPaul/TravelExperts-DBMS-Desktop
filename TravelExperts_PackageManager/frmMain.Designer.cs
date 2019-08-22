namespace TravelExperts_PackageManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPkgID = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtAgencyCommission = new System.Windows.Forms.TextBox();
            this.lblAgencyCommission = new System.Windows.Forms.Label();
            this.tabPackage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboPackages = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.packageDGV = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabPackage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(920, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 40);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPkgID
            // 
            this.lblPkgID.AutoSize = true;
            this.lblPkgID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgID.ForeColor = System.Drawing.Color.White;
            this.lblPkgID.Location = new System.Drawing.Point(96, 63);
            this.lblPkgID.Name = "lblPkgID";
            this.lblPkgID.Size = new System.Drawing.Size(173, 25);
            this.lblPkgID.TabIndex = 36;
            this.lblPkgID.Text = "Select Package ID:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(297, 196);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(137, 33);
            this.txtStartDate.TabIndex = 49;
            this.txtStartDate.TabStop = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(96, 199);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(107, 25);
            this.lblStartDate.TabIndex = 48;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPkgDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkgDesc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.Location = new System.Drawing.Point(297, 153);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.ReadOnly = true;
            this.txtPkgDesc.Size = new System.Drawing.Size(532, 33);
            this.txtPkgDesc.TabIndex = 47;
            this.txtPkgDesc.TabStop = false;
            this.txtPkgDesc.Tag = "Package Description";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgDesc.ForeColor = System.Drawing.Color.White;
            this.lblPkgDesc.Location = new System.Drawing.Point(96, 156);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(198, 25);
            this.lblPkgDesc.TabIndex = 46;
            this.lblPkgDesc.Text = "Package Description:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPkgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkgName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgName.Location = new System.Drawing.Point(297, 110);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.ReadOnly = true;
            this.txtPkgName.Size = new System.Drawing.Size(343, 33);
            this.txtPkgName.TabIndex = 45;
            this.txtPkgName.TabStop = false;
            this.txtPkgName.Tag = "Package Name";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgName.ForeColor = System.Drawing.Color.White;
            this.lblPkgName.Location = new System.Drawing.Point(96, 113);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(148, 25);
            this.lblPkgName.TabIndex = 44;
            this.lblPkgName.Text = "Package Name:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(297, 230);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(137, 33);
            this.txtEndDate.TabIndex = 51;
            this.txtEndDate.TabStop = false;
            this.txtEndDate.Tag = "End Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(97, 232);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(97, 25);
            this.lblEndDate.TabIndex = 50;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(691, 192);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.ReadOnly = true;
            this.txtBasePrice.Size = new System.Drawing.Size(137, 33);
            this.txtBasePrice.TabIndex = 53;
            this.txtBasePrice.TabStop = false;
            this.txtBasePrice.Tag = "Base Price";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.ForeColor = System.Drawing.Color.White;
            this.lblBasePrice.Location = new System.Drawing.Point(490, 195);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(106, 25);
            this.lblBasePrice.TabIndex = 52;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtAgencyCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgencyCommission.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencyCommission.Location = new System.Drawing.Point(691, 229);
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.ReadOnly = true;
            this.txtAgencyCommission.Size = new System.Drawing.Size(137, 33);
            this.txtAgencyCommission.TabIndex = 55;
            this.txtAgencyCommission.TabStop = false;
            this.txtAgencyCommission.Tag = "Agency Commission";
            // 
            // lblAgencyCommission
            // 
            this.lblAgencyCommission.AutoSize = true;
            this.lblAgencyCommission.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyCommission.ForeColor = System.Drawing.Color.White;
            this.lblAgencyCommission.Location = new System.Drawing.Point(490, 232);
            this.lblAgencyCommission.Name = "lblAgencyCommission";
            this.lblAgencyCommission.Size = new System.Drawing.Size(196, 25);
            this.lblAgencyCommission.TabIndex = 54;
            this.lblAgencyCommission.Text = "Agency Commission:";
            // 
            // tabPackage
            // 
            this.tabPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabPackage.Controls.Add(this.tabPage1);
            this.tabPackage.Controls.Add(this.tabPage2);
            this.tabPackage.Controls.Add(this.tabPage3);
            this.tabPackage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPackage.Location = new System.Drawing.Point(49, 152);
            this.tabPackage.Name = "tabPackage";
            this.tabPackage.Padding = new System.Drawing.Point(24, 9);
            this.tabPackage.SelectedIndex = 0;
            this.tabPackage.Size = new System.Drawing.Size(948, 569);
            this.tabPackage.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.packageDGV);
            this.tabPage1.Controls.Add(this.cboPackages);
            this.tabPage1.Controls.Add(this.lblPkgID);
            this.tabPage1.Controls.Add(this.txtEndDate);
            this.tabPage1.Controls.Add(this.txtAgencyCommission);
            this.tabPage1.Controls.Add(this.lblEndDate);
            this.tabPage1.Controls.Add(this.lblAgencyCommission);
            this.tabPage1.Controls.Add(this.txtBasePrice);
            this.tabPage1.Controls.Add(this.lblPkgName);
            this.tabPage1.Controls.Add(this.lblBasePrice);
            this.tabPage1.Controls.Add(this.txtPkgName);
            this.tabPage1.Controls.Add(this.lblPkgDesc);
            this.tabPage1.Controls.Add(this.txtPkgDesc);
            this.tabPage1.Controls.Add(this.txtStartDate);
            this.tabPage1.Controls.Add(this.lblStartDate);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packages";
            // 
            // cboPackages
            // 
            this.cboPackages.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboPackages.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPackages.FormattingEnabled = true;
            this.cboPackages.Location = new System.Drawing.Point(297, 55);
            this.cboPackages.Name = "cboPackages";
            this.cboPackages.Size = new System.Drawing.Size(74, 33);
            this.cboPackages.TabIndex = 57;
            this.cboPackages.SelectedIndexChanged += new System.EventHandler(this.cboPackages_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(831, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Supplier";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // packageDGV
            // 
            this.packageDGV.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.packageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageDGV.GridColor = System.Drawing.Color.LavenderBlush;
            this.packageDGV.Location = new System.Drawing.Point(122, 293);
            this.packageDGV.Name = "packageDGV";
            this.packageDGV.ReadOnly = true;
            this.packageDGV.Size = new System.Drawing.Size(671, 172);
            this.packageDGV.TabIndex = 58;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblHeader.Location = new System.Drawing.Point(554, 34);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(458, 86);
            this.lblHeader.TabIndex = 57;
            this.lblHeader.Text = "Travel Experts";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 741);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabPackage);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Travel Experts Package Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabPackage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPkgID;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtAgencyCommission;
        private System.Windows.Forms.Label lblAgencyCommission;
        private System.Windows.Forms.TabControl tabPackage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cboPackages;
        private System.Windows.Forms.DataGridView packageDGV;
        private System.Windows.Forms.Label lblHeader;
    }
}

