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
    public partial class frmBookings : Form
    {
        private frmBookings()
        {
            InitializeComponent();
        }

        private static frmBookings BookingsForm;

        public static frmBookings GetInstance()
        {
            if (BookingsForm == null)
            {
                BookingsForm = new frmBookings();
            }
            return BookingsForm;
        }

        private void frmBookings_FormClosed(object sender, FormClosedEventArgs e)
        {
            BookingsForm = null;
        }
    }
}
