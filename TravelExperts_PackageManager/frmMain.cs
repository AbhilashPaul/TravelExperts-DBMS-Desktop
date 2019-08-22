using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageData;
using System.Windows.Forms;
/*
 * Application to manage travel packages, the products included in these packages and the suppliers
 * This is the Main Form of the application.
 * Main form allows retrieval of packages details and list of products and suppliers.
 * Simple supplier and product maintenance functionalities are also provided.
 * 
 * Author: Abhilash Paul
 * Date : 26th July 2019
 * 
 */


namespace TravelExperts_PackageManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            maximizeTheWindow();                        //open application in full screen mode
        }

        //List to hold all the packages
        List<Package> packages = new List<Package>();                  

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Retrieve all the packages
            packages = PackageDB.GetPackage();

            //Databind combo box
            cboPackages.DataSource = packages;
            cboPackages.DisplayMember = "PackageID";
            cboPackages.ValueMember = "PackageID";
        }

        /// <summary>
        /// 
        /// </summary>
        private void cboPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cboPackages.SelectedIndex;                      //get the the user selection
                Package pkg = packages[index];                              //get the package details
                DataTable products_suppliers = PackageDB.GetProductsAndSuppliers(pkg.PackageID); // get the products and suppliers
                this.DisplayPackage(pkg);                                   //display package details
                packageDGV.DataSource = products_suppliers;
            }
            catch (Exception ex)
            {
                this.ClearControls();                                                                   //clear the textboxes
                cboPackages.Focus();                                                                    //put cursor on the combo box
                MessageBox.Show("Failed to retrieve Package record with this ID. " + ex.Message +     //show package not found message
                     " Please try again.", "Package Not Found");
            }

        }

        /// <summary>
        /// Displays package details on the form
        /// </summary>
        private void DisplayPackage(Package pkg)
        {
            txtPkgName.Text = pkg.PackageName;                                      //Package Name
            txtPkgDesc.Text = pkg.PackageDesc;                                      //Package Description
            txtBasePrice.Text = pkg.BasePrice.ToString("c");                        //Base Price
            //Fields that can be null
            txtStartDate.Text = pkg.StartDate == null ? "" : ((DateTime)pkg.StartDate).ToString("d");                      //Start date
            txtEndDate.Text = pkg.EndDate == null ? "" : ((DateTime)pkg.EndDate).ToString("d");                             //End date
            txtAgencyCommission.Text = pkg.AgencyCommission == null ? "" : ((decimal)pkg.AgencyCommission).ToString("c");   //Agency Commission
        }
        

        /// <summary>
        /// This function clears all the controls
        /// </summary>
        private void ClearControls()
        {
            txtPkgName.Text = "";
            txtPkgDesc.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtBasePrice.Text = "";
            txtAgencyCommission.Text = "";
        }
        
        /// <summary>
        /// exit button event handler 
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Opens the application in full size
        /// </summary>
        /// Author: Paul
        private void maximizeTheWindow()
        {
            FormBorderStyle = FormBorderStyle.None;                             //set form border style to 'none'
            WindowState = FormWindowState.Maximized;                            //set window state to maximized
            StartPosition = FormStartPosition.CenterScreen;                     //set the form start position to the centre of the screen
        }

        /// <summary>
        /// escapes full screen mode when user press 'esc' key when form is selected
        /// </summary>
        /// Author: Paul
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;                                          //set the form border style to sizable
                WindowState = FormWindowState.Normal;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
