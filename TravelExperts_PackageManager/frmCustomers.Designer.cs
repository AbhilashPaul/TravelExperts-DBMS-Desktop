namespace TravelExperts_PackageManager
{
    partial class frmCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.splitContainerCustomer = new System.Windows.Forms.SplitContainer();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProv = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPostal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCountry = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtHomePhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBusPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvRewards = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustomer)).BeginInit();
            this.splitContainerCustomer.Panel1.SuspendLayout();
            this.splitContainerCustomer.Panel2.SuspendLayout();
            this.splitContainerCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerCustomer
            // 
            this.splitContainerCustomer.Location = new System.Drawing.Point(14, 16);
            this.splitContainerCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerCustomer.Name = "splitContainerCustomer";
            // 
            // splitContainerCustomer.Panel1
            // 
            this.splitContainerCustomer.Panel1.Controls.Add(this.dgvCustomers);
            // 
            // splitContainerCustomer.Panel2
            // 
            this.splitContainerCustomer.Panel2.Controls.Add(this.dgvRewards);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtBusPhone);
            this.splitContainerCustomer.Panel2.Controls.Add(this.materialLabel6);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtHomePhone);
            this.splitContainerCustomer.Panel2.Controls.Add(this.materialLabel5);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtCountry);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtPostal);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtProv);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtCity);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtAddress);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtEmail);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtLastName);
            this.splitContainerCustomer.Panel2.Controls.Add(this.txtFirstName);
            this.splitContainerCustomer.Panel2.Controls.Add(this.materialLabel4);
            this.splitContainerCustomer.Panel2.Controls.Add(this.materialLabel3);
            this.splitContainerCustomer.Panel2.Controls.Add(this.materialLabel2);
            this.splitContainerCustomer.Panel2.Controls.Add(this.materialLabel1);
            this.splitContainerCustomer.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerCustomer.Panel2.ForeColor = System.Drawing.Color.White;
            this.splitContainerCustomer.Size = new System.Drawing.Size(1174, 744);
            this.splitContainerCustomer.SplitterDistance = 354;
            this.splitContainerCustomer.SplitterWidth = 5;
            this.splitContainerCustomer.TabIndex = 45;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName});
            this.dgvCustomers.GridColor = System.Drawing.Color.AliceBlue;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 4);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(349, 860);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.Click += new System.EventHandler(this.dgvCustomers_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 40;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 200;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 200;
            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(44, 210);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(244, 23);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TabStop = false;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(44, 128);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(244, 23);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Hint = "";
            this.txtLastName.Location = new System.Drawing.Point(312, 47);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.Size = new System.Drawing.Size(176, 23);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TabStop = false;
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(42, 47);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(246, 23);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TabStop = false;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialLabel4.Location = new System.Drawing.Point(39, 171);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 17);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Address";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialLabel3.Location = new System.Drawing.Point(39, 95);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(42, 17);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Email";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialLabel2.Location = new System.Drawing.Point(307, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 17);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Last Name";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialLabel1.Location = new System.Drawing.Point(37, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 17);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "First Name";
            // 
            // txtCity
            // 
            this.txtCity.Depth = 0;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCity.Hint = "";
            this.txtCity.Location = new System.Drawing.Point(312, 210);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.MaxLength = 32767;
            this.txtCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.Size = new System.Drawing.Size(176, 23);
            this.txtCity.TabIndex = 8;
            this.txtCity.TabStop = false;
            this.txtCity.UseSystemPasswordChar = false;
            // 
            // txtProv
            // 
            this.txtProv.Depth = 0;
            this.txtProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProv.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtProv.Hint = "";
            this.txtProv.Location = new System.Drawing.Point(44, 271);
            this.txtProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProv.MaxLength = 32767;
            this.txtProv.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProv.Name = "txtProv";
            this.txtProv.PasswordChar = '\0';
            this.txtProv.SelectedText = "";
            this.txtProv.SelectionLength = 0;
            this.txtProv.SelectionStart = 0;
            this.txtProv.Size = new System.Drawing.Size(70, 23);
            this.txtProv.TabIndex = 9;
            this.txtProv.TabStop = false;
            this.txtProv.UseSystemPasswordChar = false;
            // 
            // txtPostal
            // 
            this.txtPostal.Depth = 0;
            this.txtPostal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPostal.Hint = "";
            this.txtPostal.Location = new System.Drawing.Point(167, 271);
            this.txtPostal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPostal.MaxLength = 32767;
            this.txtPostal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.PasswordChar = '\0';
            this.txtPostal.SelectedText = "";
            this.txtPostal.SelectionLength = 0;
            this.txtPostal.SelectionStart = 0;
            this.txtPostal.Size = new System.Drawing.Size(121, 23);
            this.txtPostal.TabIndex = 10;
            this.txtPostal.TabStop = false;
            this.txtPostal.UseSystemPasswordChar = false;
            // 
            // txtCountry
            // 
            this.txtCountry.Depth = 0;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCountry.Hint = "";
            this.txtCountry.Location = new System.Drawing.Point(312, 271);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountry.MaxLength = 32767;
            this.txtCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PasswordChar = '\0';
            this.txtCountry.SelectedText = "";
            this.txtCountry.SelectionLength = 0;
            this.txtCountry.SelectionStart = 0;
            this.txtCountry.Size = new System.Drawing.Size(176, 23);
            this.txtCountry.TabIndex = 11;
            this.txtCountry.TabStop = false;
            this.txtCountry.UseSystemPasswordChar = false;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Depth = 0;
            this.txtHomePhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomePhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtHomePhone.Hint = "";
            this.txtHomePhone.Location = new System.Drawing.Point(310, 126);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomePhone.MaxLength = 32767;
            this.txtHomePhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.PasswordChar = '\0';
            this.txtHomePhone.SelectedText = "";
            this.txtHomePhone.SelectionLength = 0;
            this.txtHomePhone.SelectionStart = 0;
            this.txtHomePhone.Size = new System.Drawing.Size(178, 23);
            this.txtHomePhone.TabIndex = 13;
            this.txtHomePhone.TabStop = false;
            this.txtHomePhone.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialLabel5.Location = new System.Drawing.Point(305, 93);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(88, 17);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Home Phone";
            // 
            // txtBusPhone
            // 
            this.txtBusPhone.Depth = 0;
            this.txtBusPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusPhone.Hint = "";
            this.txtBusPhone.Location = new System.Drawing.Point(533, 126);
            this.txtBusPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusPhone.MaxLength = 32767;
            this.txtBusPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusPhone.Name = "txtBusPhone";
            this.txtBusPhone.PasswordChar = '\0';
            this.txtBusPhone.SelectedText = "";
            this.txtBusPhone.SelectionLength = 0;
            this.txtBusPhone.SelectionStart = 0;
            this.txtBusPhone.Size = new System.Drawing.Size(196, 23);
            this.txtBusPhone.TabIndex = 15;
            this.txtBusPhone.TabStop = false;
            this.txtBusPhone.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialLabel6.Location = new System.Drawing.Point(528, 95);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(108, 17);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "Business  Phone";
            // 
            // dgvRewards
            // 
            this.dgvRewards.AllowUserToAddRows = false;
            this.dgvRewards.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvRewards.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRewards.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvRewards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRewards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRewards.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRewards.GridColor = System.Drawing.Color.AliceBlue;
            this.dgvRewards.Location = new System.Drawing.Point(40, 332);
            this.dgvRewards.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRewards.Name = "dgvRewards";
            this.dgvRewards.ReadOnly = true;
            this.dgvRewards.Size = new System.Drawing.Size(414, 129);
            this.dgvRewards.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Reward Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Reward Number";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1219, 775);
            this.Controls.Add(this.splitContainerCustomer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCustomers";
            this.Text = "Customers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomers_FormClosed);
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.splitContainerCustomer.Panel1.ResumeLayout(false);
            this.splitContainerCustomer.Panel2.ResumeLayout(false);
            this.splitContainerCustomer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustomer)).EndInit();
            this.splitContainerCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHomePhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCountry;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPostal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProv;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusPhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridView dgvRewards;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}