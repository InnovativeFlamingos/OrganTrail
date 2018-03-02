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
        int inches = 0;
        int time = 0;
        int food = 1000;
        int day = 1;
        int landmark = 1000;
        string health = "";

        public gameEasy()
        {
            InitializeComponent();

            int countDown = 0;
            string pace = "";
            string rations = "";
      
            
            //int randomNumber;
            //Random randNumber = new Random();
            //randomNumber = randNumber.Next(1, 3);

            lblFood.Text = food + " pounds";
            lblLandmark.Text = landmark + " inches";
            lblTime.Text = time + ":00";
            lblHealth.Text = health;
            lblTraveled.Text = inches + " inches";



            //for (time = 0; time <= 24; ++time)
            //{
            //    if (time == 24)
            //    {
            //        day = day + 1;
            //    }
            //    else if (time != 24)
            //    {
            //      tmrRunGame.Start();
            //    }
            //}
 

        }

        private void tmrRunGame_Tick(object sender, EventArgs e)
        {
            
            lblFood.Text = food + " pounds";
            lblLandmark.Text = landmark + " inches";
            lblTime.Text = time + ":00";
            lblHealth.Text = health;
            lblTraveled.Text = inches + " inches";
            lblDay.Text = day + "";

            inches = inches + 20;
            time = time + 2;
            landmark = landmark - 20;
            food = food - 12;

            picCharacter.Image = OrganTrail.Properties.Resources.Sub_clone1;

            if (time == 24)
            {
                tmrRunGame.Stop();
                day = day + 1;

                if (tmrRunGame.Enabled == false)
                {
                    picCharacter.Image = OrganTrail.Properties.Resources.Sub2;


                    lblFood.Text = food + " pounds";
                    lblLandmark.Text = landmark + " inches";
                    lblTime.Text = time + ":00";
                    lblHealth.Text = health;
                    lblTraveled.Text = inches + " inches";
                    lblDay.Text = day + "";
                }
            }
       
            
            
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
            gbOptions.Visible = true;

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

            if (e.KeyChar == (char)Keys.Escape) //opens option menu
            {
                gbEverything.Visible = false;
                picCharacter.Visible = false;
                lblEnter.Visible = false;
                gbOptions.Visible = true;
                tmrRunGame.Stop();
                picCharacter.Image = OrganTrail.Properties.Resources.Sub2;
                
            }
            if (gbOptions.Visible == true)
            {
                if (e.KeyChar == (char)Keys.D1) // Continues the game
                {
                    gbEverything.Visible = true;
                    picCharacter.Visible = true;
                    lblEnter.Visible = true;
                    gbOptions.Visible = false;
                    tmrRunGame.Start();
                }
                else if (e.KeyChar == (char)Keys.D2) // opens map form
                {
                    Form mapForm = new map();
                    mapForm.Show();
                }
                else if (e.KeyChar == (char)Keys.D3) // Pace
                {

                }
                else if (e.KeyChar == (char)Keys.D4) // Rations
                {

                }
                else if (e.KeyChar == (char)Keys.D5) // Opens Shop
                {
                    Form shopForm = new Shop();
                    shopForm.Show();
                }
            }

        }

     


    }
}
