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
    public partial class frmSplash : MetroForm
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
           
        }
        public void fn_prbar_()
        {

            progressBar1.Increment(1);
            lblLoad.Text =progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                tmr.Stop();
                this.Hide();
                frmLogIn mon = new frmLogIn();
                mon.ShowDialog();
                this.Close();
                tmr.Stop();


            }
        }
        int i;
        private void tmr_Tick(object sender, EventArgs e)
        {
            fn_prbar_();

            do
            {
                i++;
                string time = DateTime.Now.ToLongTimeString();
                if (time.Substring(1, 0) == "0")
                {
                    lblTime.Text = time + " " + "AM";
                }
                else
                {
                    lblTime.Text = time + " " + "PM";
                }

            } while (i < 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
