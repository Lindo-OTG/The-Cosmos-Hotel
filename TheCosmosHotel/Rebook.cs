using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheCosmosHotel
{
    public partial class Rebook : Form
    {
        Datahandler dh = new Datahandler();
        List<Customer> customers = new List<Customer>();
        public string bookID;
        public Rebook()
        {
            InitializeComponent();
        }

        private void btnRebook_Click(object sender, EventArgs e)
        {
            try
            {
                dh.UpdateBooking(int.Parse(bookID), cmbRoomType.Text, cmbRoomNo.Text, dtpPChekIn.Text, dtpPCheckOut.Text);
                MessageBox.Show("Customer Checked In", "Booking Updated 👋", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
