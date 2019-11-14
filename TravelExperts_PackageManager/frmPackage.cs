using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Windows.Forms;
using Models;
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
    public partial class frmPackage : Form
    {
        private frmPackage()
        {
            InitializeComponent();
        }

        private static frmPackage PackageForm;

        public static frmPackage GetInstance()
        {
            if (PackageForm == null)
            {
                PackageForm = new frmPackage();
            }
            return PackageForm;
        }

        //List to hold all the packages
        List<Package> packages = new List<Package>();                  

        private void frmPackage_Load(object sender, EventArgs e)
        {
            //Retrieve all the packages
            packages = PackageDB.GetPackage();

            //add rows to the dTgrid view
            for (int i = 0; i < packages.Count; i++)
            {
                dgvPackages.Rows.Add();
            }

            //add package data to the rows
            for (int i = 0; i <= packages.Count-1; i++)
            {
                dgvPackages.Rows[i].Cells[0].Value = packages[i].PackageID;
                dgvPackages.Rows[i].Cells[1].Value = packages[i].PackageName;
                dgvPackages.Rows[i].Cells[2].Value = packages[i].PackageDesc;
                //dgvPackages.Rows[i].Cells[3].Value = ((DateTime)packages[i].StartDate).ToString("d");
                //dgvPackages.Rows[i].Cells[4].Value = ((DateTime)packages[i].EndDate).ToString("d");
                //dgvPackages.Rows[i].Cells[5].Value = packages[i].BasePrice.ToString("c");
                //dgvPackages.Rows[i].Cells[6].Value = ((decimal)packages[i].AgencyCommission).ToString("c");
            }
        }

        /// <summary>
        /// Displays package details on the form
        /// </summary>
        private void DisplayPackage(Package pkg)
        {                               
            txtBasePrice.Text = pkg.BasePrice.ToString("c");                        
            dtpStartDate.Value = (DateTime)pkg.StartDate;                           
            dtpEndDate.Value = (DateTime)pkg.EndDate;
            txtAgencyCommission.Text = pkg.AgencyCommission == null ? "" : ((decimal)pkg.AgencyCommission).ToString("c");   
        }
        

        /// <summary>
        /// This function clears all the controls
        /// </summary>
        private void ClearControls()
        {
            txtBasePrice.Text = "";
            txtAgencyCommission.Text = "";
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

        private void dgvPackages_Selected(object sender, EventArgs e)
        {
            dgvProductsSuppliers.Rows.Clear();

            int index = dgvPackages.CurrentCell.RowIndex;                           //get the the user selection
            Package selectedPackage = packages[index];                              //get the package details
            this.DisplayPackage(selectedPackage);                                   //display package details

            List<Product> productList = PackageDB.GetProducts(selectedPackage.PackageID);
            List<Supplier> supplierList = PackageDB.GetSuppliers(selectedPackage.PackageID);

            //add rows to the dTgrid view
            for (int i = 0; i < productList.Count; i++)
            {
                dgvProductsSuppliers.Rows.Add();
            }

            //add package data to the rows
            for (int i = 0; i <= productList.Count - 1; i++)
            {
                dgvProductsSuppliers.Rows[i].Cells[0].Value = productList[i].ProdName;
                dgvProductsSuppliers.Rows[i].Cells[1].Value = supplierList[i].SupName;
            }

        }

        private void frmPackage_FormClosed(object sender, FormClosedEventArgs e)
        {
            PackageForm = null;
        }
    }
}
