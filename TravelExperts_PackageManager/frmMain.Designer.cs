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
            this.tabPackage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(798, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 34);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPkgID
            // 
            this.lblPkgID.AutoSize = true;
            this.lblPkgID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgID.Location = new System.Drawing.Point(20, 28);
            this.lblPkgID.Name = "lblPkgID";
            this.lblPkgID.Size = new System.Drawing.Size(145, 20);
            this.lblPkgID.TabIndex = 36;
            this.lblPkgID.Text = "Select Package ID:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(186, 161);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(137, 22);
            this.txtStartDate.TabIndex = 49;
            this.txtStartDate.TabStop = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(20, 164);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(87, 20);
            this.lblStartDate.TabIndex = 48;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkgDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.Location = new System.Drawing.Point(186, 118);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.ReadOnly = true;
            this.txtPkgDesc.Size = new System.Drawing.Size(343, 22);
            this.txtPkgDesc.TabIndex = 47;
            this.txtPkgDesc.TabStop = false;
            this.txtPkgDesc.Tag = "Package Description";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgDesc.Location = new System.Drawing.Point(20, 121);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(159, 20);
            this.lblPkgDesc.TabIndex = 46;
            this.lblPkgDesc.Text = "Package Description:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkgName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgName.Location = new System.Drawing.Point(186, 75);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.ReadOnly = true;
            this.txtPkgName.Size = new System.Drawing.Size(343, 22);
            this.txtPkgName.TabIndex = 45;
            this.txtPkgName.TabStop = false;
            this.txtPkgName.Tag = "Package Name";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgName.Location = new System.Drawing.Point(20, 78);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(121, 20);
            this.lblPkgName.TabIndex = 44;
            this.lblPkgName.Text = "Package Name:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(186, 195);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(137, 22);
            this.txtEndDate.TabIndex = 51;
            this.txtEndDate.TabStop = false;
            this.txtEndDate.Tag = "End Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(21, 197);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(73, 18);
            this.lblEndDate.TabIndex = 50;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasePrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(186, 229);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.ReadOnly = true;
            this.txtBasePrice.Size = new System.Drawing.Size(137, 22);
            this.txtBasePrice.TabIndex = 53;
            this.txtBasePrice.TabStop = false;
            this.txtBasePrice.Tag = "Base Price";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(20, 232);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(89, 20);
            this.lblBasePrice.TabIndex = 52;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgencyCommission.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencyCommission.Location = new System.Drawing.Point(186, 266);
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.ReadOnly = true;
            this.txtAgencyCommission.Size = new System.Drawing.Size(137, 22);
            this.txtAgencyCommission.TabIndex = 55;
            this.txtAgencyCommission.TabStop = false;
            this.txtAgencyCommission.Tag = "Agency Commission";
            // 
            // lblAgencyCommission
            // 
            this.lblAgencyCommission.AutoSize = true;
            this.lblAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyCommission.Location = new System.Drawing.Point(20, 269);
            this.lblAgencyCommission.Name = "lblAgencyCommission";
            this.lblAgencyCommission.Size = new System.Drawing.Size(156, 20);
            this.lblAgencyCommission.TabIndex = 54;
            this.lblAgencyCommission.Text = "Agency Commission:";
            // 
            // tabPackage
            // 
            this.tabPackage.Controls.Add(this.tabPage1);
            this.tabPackage.Controls.Add(this.tabPage2);
            this.tabPackage.Controls.Add(this.tabPage3);
            this.tabPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPackage.Location = new System.Drawing.Point(25, 67);
            this.tabPackage.Name = "tabPackage";
            this.tabPackage.SelectedIndex = 0;
            this.tabPackage.Size = new System.Drawing.Size(839, 424);
            this.tabPackage.TabIndex = 56;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboPackages
            // 
            this.cboPackages.FormattingEnabled = true;
            this.cboPackages.Location = new System.Drawing.Point(186, 20);
            this.cboPackages.Name = "cboPackages";
            this.cboPackages.Size = new System.Drawing.Size(121, 28);
            this.cboPackages.TabIndex = 57;
            this.cboPackages.SelectedIndexChanged += new System.EventHandler(this.cboPackages_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(831, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Supplier";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 503);
            this.Controls.Add(this.tabPackage);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Travel Experts Package Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabPackage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

