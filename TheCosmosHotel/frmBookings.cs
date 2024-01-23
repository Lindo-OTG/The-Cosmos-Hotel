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
    public partial class frmBookings : MetroForm
    {
        Datahandler dh = new Datahandler();
        List<Customer> customers = new List<Customer>();
        List<Room> rooms = new List<Room>();
        List<Booking> bookings = new List<Booking>();
        public string searchid;
        public frmBookings()
        {
            InitializeComponent();
        }

        private void frmBookings_Load(object sender, EventArgs e)
        {
            bookings = dh.ViewBooking();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.ShowDialog();
            Booking book;
            bool successful = false;
            bool bookingsuccessful = false;
            string bookingDate = DateTime.Today.ToShortDateString();
            Customer cust = new Customer(txtFirstName.Text, txtSurname.Text, cmbGender.Text, dtpDOB.Text, txtNationality.Text, txtPhone.Text, txtEmail.Text, cmbRating.Text);
            try
            {
                dh.InsertCustomer(cust);
                successful = true;
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (successful)
            {
                customers = dh.ViewAllCustomers();
                foreach (var item in customers)
                {
                    if (item.Firstname == txtFirstName.Text && item.Lastname == txtSurname.Text)
                    {
                        book = new Booking(bookingDate, item.CustomerID, cmbRoomNumber.Text, dtpPChekIn.Text, dtpPCheckOut.Text);
                        try
                        {
                            dh.InsertBooking(book);
                            bookingsuccessful = true;
                        }
                        catch (Exception b)
                        {
                            MessageBox.Show(b.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }                         
            }
            if (bookingsuccessful)
            {
                try
                {
                    dh.UpdateRoom("Booked", cmbRoomNumber.Text);
                }
                catch (Exception n)
                {
                    MessageBox.Show(n.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (chkEmail.Checked)
                {
                    string fullname = cust.Firstname + " " + cust.Lastname;
                    Email em = new Email();
                    em.SendMail(cust.Email, fullname, bookings[bookings.Count-1].BookingID.ToString(), dtpPChekIn.Text, dtpPCheckOut.Text, cmbRoomNumber.Text, cmbRoomType.Text, "3500");
                }
            }
        }
        #region Useless
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void middlePanel_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtFirstName.Clear();
            txtNationality.Clear();
            txtPhone.Clear();
            txtSurname.Clear(); 
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                dh.UpdateBooking(int.Parse(txtBookingID.Text), cmbEditRoomType.Text, cmbEditRoomNo.Text, dtpPChekIn.Text, dtpPCheckOut.Text);
                MessageBox.Show("Customer Checked In", "Booking Updated 👋", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                dh.CancelBooking(int.Parse(txtBookingID.Text), dtpCancel.Text, txtReason.Text);
                MessageBox.Show("Booking has Been Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bookings.Clear();
            searchDataGridView.DataSource = null;
            bookings = dh.SearchBooking(int.Parse(txtSearch.Text));
            searchDataGridView.DataSource = bookings;
            searchid = txtSearch.Text;
            txtSearch.Clear();
            btnDelete.Enabled = true;
            btnRebook.Enabled = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dh.DeleteBooking(searchid);
                searchDataGridView.DataSource = null;
                btnDelete.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRebook_Click(object sender, EventArgs e)
        {
            Rebook r = new Rebook();
            r.bookID = searchid;
            r.ShowDialog();     
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
