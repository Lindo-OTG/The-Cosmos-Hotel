using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TheCosmosHotel
{
    public partial class frmMenu : MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            frmBookings f = new frmBookings();
            this.Hide();
            f.ShowDialog();
            this.Close(); 
        }

        private void btnManageCust_Click(object sender, EventArgs e)
        {
            frmCustomerss f = new frmCustomerss();
            this.Hide();
            f.ShowDialog();
            this.Close(); 
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            frmRooms f = new frmRooms();
            this.Hide();
            f.ShowDialog();
            this.Close(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
