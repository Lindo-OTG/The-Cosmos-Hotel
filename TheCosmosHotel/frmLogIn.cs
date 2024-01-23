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
    public partial class frmLogIn : MetroForm
    {       
        public frmLogIn()
        {
            InitializeComponent();
        }
        Datahandler dh = new Datahandler();
        List<Login> users = new List<Login>();
        static bool username = false;
        static bool password = false;
        bool visible = false;
        static int attempts = 3; 
        private void frmLogIn_Load(object sender, EventArgs e)
        {
            users = dh.GetUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text !="" && txtUsername.Text != "" )
            {
                try
                {
                    foreach (var item in users)
                    {
                        if (item.Password == txtPassword.Text && item.Username == txtUsername.Text)
                        {
                            username = true;
                            password = true;
                        }
                    }
                    if (password && username)
                    {
                        MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMenu f = new frmMenu();
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (!username && !password && attempts != 0)
                    {
                        MessageBox.Show("Incorrect Details " + (attempts - 1) + " Attempts Left", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        attempts--;
                        txtPassword.Clear();
                        txtUsername.Clear();
                    }
                    else if (attempts == 0)
                    {
                        MessageBox.Show("You have used the maximum amount of attempts", "Exiting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Environment.Exit(0);
                    }
                }
                catch (Exception k)
                {
                    MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void picboxEye_Click(object sender, EventArgs e)
        {
            if (!visible)
            {
                txtPassword.UseSystemPasswordChar = false;
                picboxEye.Visible = false;
                picboxHide.Visible = true;
                visible = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }          
        }

        private void picboxHide_Click(object sender, EventArgs e)
        {
            if (visible)
            {
               txtPassword.UseSystemPasswordChar = true;
                picboxEye.Visible = true;
                picboxHide.Visible = false;
                visible = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
