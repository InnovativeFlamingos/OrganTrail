using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganTrail
{
    public partial class gameEasy : Form
    {
        public gameEasy()
        {
            InitializeComponent();

            int time = 0;
            int food = 0;
            int miles = 0;
            int landmark = 0;
            int  ammo = 0;
            string health = "";
            int counter = 0;



            //int randomNumber;
            //Random randNumber = new Random();
            //randomNumber = randNumber.Next(1, 3);

            lblFood.Text = food + " pounds";
            lblLandmark.Text = landmark + " miles";
            lblTime.Text = time + ":";
            lblHealth.Text = health;
            lblTraveled.Text = miles + " miles";

            do
            {
                miles = +10;

                lblFood.Text = food + " pounds";
                lblLandmark.Text = landmark + " miles";
                lblTime.Text = time + ":";
                lblHealth.Text = health;
                lblTraveled.Text = miles + " miles";
            } while (counter > 10);



        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            lblNameLeader.Visible = false;
            txtName.Visible = false;
            btnContinue.Visible = false;

            lblFourNames.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            txtName1.Visible = true;
            txtName2.Visible = true;
            txtName3.Visible = true;
            txtName4.Visible = true;
            btnContinue2.Visible = true;
            txtName1.Focus();

           

        }

        private void btnContinue2_Click(object sender, EventArgs e)
        {
            lblFourNames.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            txtName1.Visible = false;
            txtName2.Visible = false;
            txtName3.Visible = false;
            txtName4.Visible = false;
            btnContinue2.Visible = false;
            gbEverything.Visible = true;
            picCharacter.Visible = true;
            lblEnter.Visible = true;

            //Form shopForm = new Shop();
            //shopForm.Show();

            string leader = txtName.Text;
            string name1 = txtName1.Text;
            string name2 = txtName2.Text;
            string name3 = txtName3.Text;
            string name4 = txtName4.Text;
        }

    
        private void KeyisPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                gbEverything.Visible = false;
                picCharacter.Visible = false;
                lblEnter.Visible = false;
                gbOptions.Visible = true;
            }
            else if (e.KeyChar == (char)Keys.D1)
            {
                gbEverything.Visible = true;
                picCharacter.Visible = true;
                lblEnter.Visible = true;
                gbOptions.Visible = false;
            }
            else if (e.KeyChar == (char)Keys.D2)
            {
                Form mapForm = new map();
                mapForm.Show();
            }

        }

    }
}
