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
    public partial class Game : Form
    {
        int inches = 0;
        int time = 0;
        int food = 4200;
        int day = 1;
        int landmark = 2000;
        string health = "Good";
        int countDown = 16;
        int randomNumber;

        public Game()
        {
            InitializeComponent();

            
            Random randNumber = new Random();
            randomNumber = randNumber.Next(1, 100);
            

            

            lblFood.Text = food + " pounds";
            lblLandmark.Text = landmark + " inches";
            lblTime.Text = time + ":00";
            lblHealth.Text = health;
            lblTraveled.Text = inches + " inches";
            lblDay.Text = day + "";

        }

        private void tmrRunGame_Tick(object sender, EventArgs e)
        {
            picCharacter.Image = OrganTrail.Properties.Resources.Sub_clone1;
            lblFood.Text = food + " pounds";
            lblLandmark.Text = landmark + " inches";
            lblTime.Text = time + ":00";
            lblHealth.Text = health;
            lblTraveled.Text = inches + " inches";
            lblDay.Text = day + "";

            inches = inches + 20;
            time = time + 1;
            landmark = landmark - 20;
            food = food - 12;

            if (food <= 0)
            {
                food = 0;
            }

            if (landmark == -20)
            {
                tmrRunGame.Stop();
                picCharacter.Image = OrganTrail.Properties.Resources.Sub2;
                lblEvents.Text = "You reached Landmark";
                lblEvents.Visible = true;
                landmark = 2000;
                lblSpace.Visible = true;
            }

            if (countDown <= 0)
            {

            }

            if (food <= 300)
            {
                lblHealth.Text = "Bad";
            }
            else if (food > 300)
            {
                lblHealth.Text = "Good";
            }

            if (randomNumber == 15)
            {
                //++food
            }


            if (time == 25)
            {
                tmrRunGame.Stop();
                day = day + 1;
                countDown = countDown - 1;
                lblDaysLeft.Text = "Days left " + countDown;

                if (tmrRunGame.Enabled == false)
                {
                    picCharacter.Image = OrganTrail.Properties.Resources.Sub2;
                    time = time -25;

                    lblFood.Text = food + " pounds";
                    lblLandmark.Text = landmark + " inches";
                    lblTime.Text = time + ":00";
                    lblHealth.Text = health;
                    lblTraveled.Text = inches + " inches";
                    lblDay.Text = day + "";

                    if (time < 24)
                    {
                        tmrRunGame.Start();
                    }
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
            else if (gbOptions.Visible == true)
            {
                
                if (e.KeyChar == (char)Keys.D1) // Continues the game
                {
                    gbEverything.Visible = true;
                    picCharacter.Visible = true;
                    lblEnter.Visible = true;
                    gbOptions.Visible = false;
                    tmrRunGame.Start();
                    lblFacts.Text = " ";
                }
                else if (e.KeyChar == (char)Keys.D2) // opens map form
                {
                    Form mapForm = new map();
                    mapForm.Show();
                }
                else if (e.KeyChar == (char)Keys.D3) // Facts
                {
                    lblFacts.Text = "test";
                }

            }
            if (lblEvents.Visible == true)
            {
                if (e.KeyChar == (char)Keys.Back) // Continues the game
                {
                    lblEvents.Visible = false;
                    tmrRunGame.Start();
                    lblSpace.Visible = false;
                }
            }

        }
    }
}


 
    
 

