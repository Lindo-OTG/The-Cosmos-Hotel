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
    public partial class frmCustomerss : MetroForm
    {
        Datahandler dh = new Datahandler();
        Customer custs;
        List<Customer> customers = new List<Customer>();
        Customer s = new Customer();
        public frmCustomerss()
        {
            InitializeComponent();
        }

        private void frmCustomerss_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theCosmosHotelDataSet.CustDetails' table. You can move, or remove it, as needed.
            this.custDetailsTableAdapter.Fill(this.theCosmosHotelDataSet.CustDetails);
            // TODO: This line of code loads data into the 'theCosmosHotelDataSet2.CustDetails' table. You can move, or remove it, as needed.
            customers = dh.ViewAllCustomers();
        }
        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustID.Text != "" && txtEmail.Text != "" && txtSurname.Text != "" && txtPhone.Text !="" && txtNationality.Text!="")
            {
                custs = new Customer(int.Parse(txtCustID.Text), txtFirstname.Text, txtSurname.Text, cmbGender.Text, dtpDOB.Text, txtNationality.Text, txtPhone.Text, txtEmail.Text, cmbRating.Text);
                try
                {
                    dh.UpdateCustomer(custs);
                    MessageBox.Show("Customer Details Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCustID.Clear();
                txtEmail.Clear();
                txtFirstname.Clear();
                txtNationality.Clear();
                txtPhone.Clear();
                txtSurname.Clear();
                cmbGender.Refresh();
                cmbRating.Refresh();
            }
            else
            {
                MessageBox.Show("Please fill in all Fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustID.Clear();
                txtEmail.Clear();
                txtFirstname.Clear();
                txtNationality.Clear();
                txtPhone.Clear();
                txtSurname.Clear();
                cmbGender.Refresh();
                cmbRating.Refresh();
                txtCustID.Style = MetroFramework.MetroColorStyle.Red;
                txtEmail.Style = MetroFramework.MetroColorStyle.Red;
                txtFirstname.Style = MetroFramework.MetroColorStyle.Red;
                txtNationality.Style = MetroFramework.MetroColorStyle.Red;
                txtPhone.Style = MetroFramework.MetroColorStyle.Red;
                txtSurname.Style = MetroFramework.MetroColorStyle.Red;
            }          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustID.Text == "")
            {
                MessageBox.Show("Please Enter The Customer ID of the Customer you want to delete", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustID.Style = MetroFramework.MetroColorStyle.Red;
            }
            else if (txtCustID.Text != "")
            {
                DialogResult sure = MessageBox.Show("By Deleting this Customer, you also deleting all bookings made by them.\n\nAre You Sure You want to Delete this Customer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sure == DialogResult.Yes)
                {
                    try
                    {
                        dh.DeleteBookingByCustomer(int.Parse(txtCustID.Text));
                        dh.DeleteCustomer(int.Parse(txtCustID.Text));
                        MessageBox.Show("Customer Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCustID.Clear();
                        txtEmail.Clear();
                        txtFirstname.Clear();
                        txtNationality.Clear();
                        txtPhone.Clear();
                        txtSurname.Clear();
                        cmbGender.Refresh();
                        cmbRating.Refresh();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (sure == DialogResult.No)
                {
                    txtCustID.Clear();
                    txtEmail.Clear();
                    txtFirstname.Clear();
                    txtNationality.Clear();
                    txtPhone.Clear();
                    txtSurname.Clear();
                    cmbGender.Refresh();
                    cmbRating.Refresh();
                }
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (txtSearch.Text != "")
            {
                foreach (var item in customers)
                {
                    if (item.CustomerID == int.Parse(txtSearch.Text))
                    {
                        s = item;
                        found = true;
                    }
                }
                if(!found)
                {
                    MessageBox.Show("Customer ID not found", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                rotxtName.Text = s.Firstname;
                rotxtsurname.Text = s.Lastname;
                rotxtDOB.Text = s.DateOfBirth;
                rotxtEmail.Text = s.Email;
                rotxtGender.Text = s.Gender;
                rotxtNation.Text = s.Nationality;
                rotxtPhone.Text = s.Phonenumber;
                rotxtRating.Text = s.Creditrating;
                txtSearch.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter a Customer ID", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Clear();
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
