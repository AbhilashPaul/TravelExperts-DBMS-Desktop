namespace TravelExperts_PackageManager
{
    partial class frmPackage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.dgvProductsSuppliers = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblAgencyCommission = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtAgencyCommission = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPackages = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.panelPackages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblBasePrice);
            this.panel1.Controls.Add(this.dgvProductsSuppliers);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.lblAgencyCommission);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.txtBasePrice);
            this.panel1.Controls.Add(this.txtAgencyCommission);
            this.panel1.Location = new System.Drawing.Point(30, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 361);
            this.panel1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Package details";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "d MMM yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(129, 55);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(147, 25);
            this.dtpStartDate.TabIndex = 61;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(31, 58);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 17);
            this.lblStartDate.TabIndex = 48;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.ForeColor = System.Drawing.Color.White;
            this.lblBasePrice.Location = new System.Drawing.Point(386, 58);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(74, 17);
            this.lblBasePrice.TabIndex = 52;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // dgvProductsSuppliers
            // 
            this.dgvProductsSuppliers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvProductsSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductsSuppliers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvProductsSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductsSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Supplier});
            this.dgvProductsSuppliers.GridColor = System.Drawing.Color.AliceBlue;
            this.dgvProductsSuppliers.Location = new System.Drawing.Point(29, 137);
            this.dgvProductsSuppliers.Name = "dgvProductsSuppliers";
            this.dgvProductsSuppliers.ReadOnly = true;
            this.dgvProductsSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvProductsSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductsSuppliers.Size = new System.Drawing.Size(759, 172);
            this.dgvProductsSuppliers.TabIndex = 58;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 200;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 200;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 500;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 500;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "d MMM yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(129, 90);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(147, 25);
            this.dtpEndDate.TabIndex = 60;
            // 
            // lblAgencyCommission
            // 
            this.lblAgencyCommission.AutoSize = true;
            this.lblAgencyCommission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyCommission.ForeColor = System.Drawing.Color.White;
            this.lblAgencyCommission.Location = new System.Drawing.Point(386, 95);
            this.lblAgencyCommission.Name = "lblAgencyCommission";
            this.lblAgencyCommission.Size = new System.Drawing.Size(137, 17);
            this.lblAgencyCommission.TabIndex = 54;
            this.lblAgencyCommission.Text = "Agency Commission:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(32, 91);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(68, 17);
            this.lblEndDate.TabIndex = 50;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.BackColor = System.Drawing.Color.White;
            this.txtBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(532, 55);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.ReadOnly = true;
            this.txtBasePrice.Size = new System.Drawing.Size(137, 25);
            this.txtBasePrice.TabIndex = 53;
            this.txtBasePrice.TabStop = false;
            this.txtBasePrice.Tag = "Base Price";
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.BackColor = System.Drawing.Color.White;
            this.txtAgencyCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgencyCommission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencyCommission.Location = new System.Drawing.Point(532, 92);
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.ReadOnly = true;
            this.txtAgencyCommission.Size = new System.Drawing.Size(137, 25);
            this.txtAgencyCommission.TabIndex = 55;
            this.txtAgencyCommission.TabStop = false;
            this.txtAgencyCommission.Tag = "Agency Commission";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 62;
            this.label1.Text = "List of packages";
            // 
            // dgvPackages
            // 
            this.dgvPackages.AllowUserToAddRows = false;
            this.dgvPackages.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvPackages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPackages.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPackages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageID,
            this.PackageName,
            this.PackageDesc});
            this.dgvPackages.GridColor = System.Drawing.Color.AliceBlue;
            this.dgvPackages.Location = new System.Drawing.Point(30, 65);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.ReadOnly = true;
            this.dgvPackages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackages.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvPackages.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPackages.RowTemplate.Height = 25;
            this.dgvPackages.Size = new System.Drawing.Size(852, 217);
            this.dgvPackages.TabIndex = 59;
            this.dgvPackages.Click += new System.EventHandler(this.dgvPackages_Selected);
            // 
            // PackageID
            // 
            this.PackageID.HeaderText = "ID";
            this.PackageID.Name = "PackageID";
            this.PackageID.ReadOnly = true;
            // 
            // PackageName
            // 
            this.PackageName.HeaderText = "Package Name";
            this.PackageName.MinimumWidth = 200;
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            this.PackageName.Width = 200;
            // 
            // PackageDesc
            // 
            this.PackageDesc.HeaderText = "Description";
            this.PackageDesc.MinimumWidth = 500;
            this.PackageDesc.Name = "PackageDesc";
            this.PackageDesc.ReadOnly = true;
            this.PackageDesc.Width = 500;
            // 
            // panelPackages
            // 
            this.panelPackages.BackColor = System.Drawing.Color.CadetBlue;
            this.panelPackages.Controls.Add(this.label1);
            this.panelPackages.Controls.Add(this.panel1);
            this.panelPackages.Controls.Add(this.dgvPackages);
            this.panelPackages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPackages.Location = new System.Drawing.Point(3, 3);
            this.panelPackages.Name = "panelPackages";
            this.panelPackages.Size = new System.Drawing.Size(916, 656);
            this.panelPackages.TabIndex = 64;
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(922, 660);
            this.Controls.Add(this.panelPackages);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPackage";
            this.Text = "Travel Packages";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPackage_FormClosed);
            this.Load += new System.EventHandler(this.frmPackage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.panelPackages.ResumeLayout(false);
            this.panelPackages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.DataGridView dgvProductsSuppliers;
        private System.Windows.Forms.TextBox txtAgencyCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblAgencyCommission;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPackages;
    }
}

