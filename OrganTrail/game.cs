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
        int mechanic = 5;

        public Game()
        {
            InitializeComponent();   

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

            Random randNumber = new Random();
            randomNumber = randNumber.Next(1, 100);

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

           

            // good- found food, found sub, find mechanic, 
            // bad- lose (sick/die) a mechanic, break, virises attack (hunting game?), sick names, wrong vein (lose day), 
            //Total 8

            if (food <= 300)
            {
                lblHealth.Text = "Bad";
            }
            else if (food > 300)
            {
                lblHealth.Text = "Good";
            }

            if (randomNumber == 15 || randomNumber == 85)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "Wrong Vein. Lose 2 hours.";
                time = time + 2;
                food = food - 24;
                lblSpace.Visible = true;
                
            }
            else if (randomNumber == 69 || randomNumber == 96)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "Find 30 lbs of food.";
                food = food + 30;
                lblSpace.Visible = true;
            }
            else if (randomNumber == 2 || randomNumber == 99)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "Virus Attack";
                System.Threading.Thread.Sleep(5000);

                Form huntingForm = new Hunting();
                huntingForm.Show();

                lblSpace.Visible = true;
            }
            else if (randomNumber == 45 || randomNumber == 1)
            {
                lblEvents.Visible = true;
                lblEvents.Text = txtName1.ToString() +" is sick";

                lblSpace.Visible = true;
            }
            else if (randomNumber == 74 || randomNumber == 20)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "You found a mechanic.";
                ++mechanic;

                lblSpace.Visible = true;
            }
            else if (randomNumber == 50 || randomNumber == 10)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "Mechanic is sick.";
                time = time + 1;
                food = food - 12;

                lblSpace.Visible = true;
            }
            else if (randomNumber == 87 || randomNumber == 12)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "Mechanic dies.";
                --mechanic;
                lblSpace.Visible = true;
            }
            else if (randomNumber == 3 || randomNumber == 36)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "Found another sub.";
                food = food + 40;
                ++mechanic;
  
                lblSpace.Visible = true;
            }
            
            if (lblEvents.Visible == true)
            {
                tmrRunGame.Stop();
                picCharacter.Image = OrganTrail.Properties.Resources.Sub2;

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
            if (mechanic <= 0)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "All of your mechanics are dead. You lose.";

                System.Threading.Thread.Sleep(5000);
                this.Close();
            }

            if (countDown <= 0)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "You ran out of O2 You lose.";

                System.Threading.Thread.Sleep(5000);
                this.Close();
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


 
    
 

