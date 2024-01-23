using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace TheCosmosHotel
{
    public partial class Payment : MetroFramework.Forms.MetroForm
    {
        public Payment()
        {
            InitializeComponent();
        }
        bool alreadyChanged = false;
        private void Payment_Load(object sender, EventArgs e)
        {
            picTickMaestro.Visible = false;
            picTickMastercard.Visible = false;
            picTickPayPal.Visible = false;
            picTickVisa.Visible = false;
            picXVisa.Visible = false;
            picXMaestro.Visible = false;
            picXMasterCard.Visible = false;
            picXPayPal.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picMaestro_Click(object sender, EventArgs e)
        {
            
        }
        private void picVisa_Click(object sender, EventArgs e)
        {
           
        }

        private void picPayPal_Click(object sender, EventArgs e)
        {
            
        }

        private void picMasterCard_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 50;
            if (txtFullName.Text == "" || txtBililAddress.Text == "" || txtCardHolderName.Text == "" || txtCardNo.Text == "" || txtCity.Text == "" || txtCvNo.Text == "" || txtExpYear.Text == "" || txtZipCode.Text == "" || cmbCountries.Text == "" || cmbExpMonth.Text == "")
            {
                MessageBox.Show("Please enter all Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                progressBar1.Value = 110;
                Thread.Sleep(1000);
                progressBar1.Style = ProgressBarStyle.Marquee;
                MessageBox.Show("Varifying Card Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Your Transaction is Successfully Paid. Your Booking ID Has Been Sent to your Email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }          
        }

        private void frmfinalPayment_BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void label14_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbCountries_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void picVisa_Click_1(object sender, EventArgs e)
        {
            picTickMaestro.Visible = false;
            picTickMastercard.Visible = false;
            picTickPayPal.Visible = false;
            picTickVisa.Visible = true;



            picXVisa.Visible = false;
            picXMaestro.Visible = true;
            picXMasterCard.Visible = true;
            picXPayPal.Visible = true;
            if (picVisa.Visible && !picXVisa.Visible && progressBar1.Value < 10)
            {
                progressBar1.Value += 10;
            }
        }

        private void Payment_TextChanged(object sender, EventArgs e)
        {
            if (!alreadyChanged)
            {
                progressBar1.Value += 50;
                alreadyChanged = true;
            }
        }

        private void picMasterCard_Click(object sender, EventArgs e)
        {
            picTickMaestro.Visible = false;
            picTickMastercard.Visible = true;
            picTickPayPal.Visible = false;
            picTickVisa.Visible = false;



            picXVisa.Visible = true;
            picXMaestro.Visible = true;
            picXMasterCard.Visible = false;
            picXPayPal.Visible = true;

            if (picMasterCard.Visible && !picXMasterCard.Visible && progressBar1.Value < 10)
            {
                progressBar1.Value += 10;
            }
        }

        private void picMaestro_Click_1(object sender, EventArgs e)
        {
            picTickMaestro.Visible = true;
            picTickMastercard.Visible = false;
            picTickPayPal.Visible = false;
            picTickVisa.Visible = false;

            picXVisa.Visible = true;
            picXMaestro.Visible = false;
            picXMasterCard.Visible = true;
            picXPayPal.Visible = true;

            if (picTickMaestro.Visible && !picXMaestro.Visible && progressBar1.Value < 10)
            {
                progressBar1.Value += 10;
            }
        }

        private void picPayPal_Click_1(object sender, EventArgs e)
        {
            picTickMaestro.Visible = false;
            picTickMastercard.Visible = false;
            picTickPayPal.Visible = true;
            picTickVisa.Visible = false;


            picXVisa.Visible = true;
            picXMaestro.Visible = true;
            picXMasterCard.Visible = true;
            picXPayPal.Visible = false;

            if (picPayPal.Visible && !picXPayPal.Visible && progressBar1.Value < 10)
            {
                progressBar1.Value += 10;
            }
        }

        private void label14_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Its Numbers at The Back of Your Card", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
