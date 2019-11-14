using Models;
using DataAccessLayer;
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
    public partial class frmCustomers : Form
    {
        private frmCustomers()
        {
            InitializeComponent();
        }

        private static frmCustomers CustomerForm;

        public static frmCustomers GetInstance()
        {
            if (CustomerForm == null)
            {
                CustomerForm = new frmCustomers();
            }
            return CustomerForm;
        }

        private void frmCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerForm = null;
        }

        //List to hold all the customers
        List<Customer> customers = new List<Customer>();
        //List to hod rewards for the selected customer
        List<Reward> customerRewards = new List<Reward>();

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                customers = CustomerDB.GetCustomers();
                

            }
            catch (Exception ex)
            {   //show package not found message
                MessageBox.Show("Failed to retrieve customer records!"+ "\nError: " + ex.Message+"\n"+
                     "Please try again.", "Customer Records Not Found");
            }

            //add rows to the dTgrid view
            if (customers != null)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    dgvCustomers.Rows.Add();
                }

                //add package data to the rows
                for (int i = 0; i <= customers.Count - 1; i++)
                {
                    dgvCustomers.Rows[i].Cells[0].Value = customers[i].CustomerId;
                    dgvCustomers.Rows[i].Cells[1].Value = customers[i].CustFirstName + " " + customers[i].CustLastName;
                }
            }
        }

        private void dgvCustomers_Click(object sender, EventArgs e)
        {
            dgvRewards.Rows.Clear();
            int index = dgvCustomers.CurrentCell.RowIndex;
            Customer selectedCustomer = customers[index];

            txtFirstName.Text = selectedCustomer.CustFirstName.Trim();
            txtLastName.Text = selectedCustomer.CustLastName.Trim();
            txtEmail.Text = selectedCustomer.CustEmail.Trim();
            txtAddress.Text = selectedCustomer.CustAddress.TrimEnd();
            txtCity.Text = selectedCustomer.CustCity.Trim();
            txtProv.Text = selectedCustomer.CustProv.Trim();
            txtPostal.Text = selectedCustomer.CustPostal.Trim();
            txtCountry.Text = selectedCustomer.CustCountry.Trim();
            txtHomePhone.Text = selectedCustomer.CustHomePhone.Trim();
            txtBusPhone.Text = selectedCustomer.CustBusPhone.Trim();

            try
            {
                customerRewards = RewardsDB.GetRewards(selectedCustomer.CustomerId);
            }
            catch (Exception ex)
            {   //show package not found message
                MessageBox.Show("Error occured while trying to retrieve reward details!"+ "\nError: " + ex.Message+"\n"+
                     "Please try again.", "Database Error");
            }


            //add rows to the dTgrid view
            if (customerRewards != null)
            {
                for (int i = 0; i < customerRewards.Count; i++)
                {
                    dgvRewards.Rows.Add();
                }

                //add package data to the rows
                for (int i = 0; i <= customerRewards.Count-1; i++)
                {
                    dgvRewards.Rows[i].Cells[0].Value = customerRewards[i].RewardName.TrimEnd();
                    dgvRewards.Rows[i].Cells[1].Value = customerRewards[i].RewardNumber.TrimEnd();
                }
            }
        }
        
    }
}
