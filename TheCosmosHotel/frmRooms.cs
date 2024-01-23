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
    public partial class frmRooms : MetroForm
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private int imageNum;

        public void Room1Slide()
        {
            if (imageNum == 4)
            {
                imageNum = 1;

            }
            picSlide.ImageLocation = string.Format(@"Singles\{0}.jpg", imageNum);
            imageNum++;
        }
        public void Room2Slide()
        {
            if (imageNum == 4)
            {
                imageNum = 1;

            }
            picSlide.ImageLocation = string.Format(@"Double\{0}.jpg", imageNum);
            imageNum++;
        }
        public void Room3Slide()
        {
            if (imageNum == 4)
            {
                imageNum = 1;

            }
            picSlide.ImageLocation = string.Format(@"en suite\{0}.jpg", imageNum);
            imageNum++;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            tmrDouble.Enabled = false;
            tmrEnSuite.Enabled = false;
            tmrSingle.Enabled = true;
        }

        private void tmrSingle_Tick(object sender, EventArgs e)
        {
            Room1Slide();
        }

        private void tmrDouble_Tick(object sender, EventArgs e)
        {
            Room2Slide();
        }

        private void tmrEnSuite_Tick(object sender, EventArgs e)
        {
            Room3Slide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tmrSingle.Enabled = false;
            tmrEnSuite.Enabled = false;
            tmrDouble.Enabled = true;
        }

        private void picensuite_Click(object sender, EventArgs e)
        {
            tmrDouble.Enabled = false;
            tmrSingle.Enabled = false;
            tmrEnSuite.Enabled = true;
        }
    }
}
