using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts_PackageManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            frmPackage packageForm = frmPackage.GetInstance();
            packageForm.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers customersForm = frmCustomers.GetInstance();
            customersForm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSuppliers supplierFrom = frmSuppliers.GetInstance();
            supplierFrom.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            frmPackage packageForm = frmPackage.GetInstance();
            packageForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBookings bookingsForm = frmBookings.GetInstance();
            bookingsForm.Show();
        }
    }
}
