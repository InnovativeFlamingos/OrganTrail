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
        int randomSick;
        int randomFact;
        int randomBloodcell;
        Random randNumber = new Random();


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

            if (inches >= 8000)
            {
                gbEverything.Visible = false;
                picCharacter.Visible = false;
                lblEnter.Visible = false;
                gbOptions.Visible = false;

                lblSpace.Text = "Press ESCAPE to close";
                lblSpace.Visible = true;
                lblEnd.Text = "You Win!";
                lblEnd.Visible = true;


                tmrRunGame.Stop();

            }

            if (countDown <= 0)
            {
               

                gbEverything.Visible = false;
                picCharacter.Visible = false;
                lblEnter.Visible = false;
                gbOptions.Visible = false;

                lblSpace.Text = "Press ESCAPE to close";
                lblSpace.Visible = true;
                lblEnd.Text = "You ran out of O2. You Lose!";
                lblEnd.Visible = true;
                tmrRunGame.Stop();
            }


            if (mechanic <= 0)
            {
                gbEverything.Visible = false;
                picCharacter.Visible = false;
                lblEnter.Visible = false;
                gbOptions.Visible = false;

                lblSpace.Text = "Press ESCAPE to close";
                lblSpace.Visible = true;
                lblEnd.Text = "All of your mechanics are dead. You Lose!";
                lblEnd.Visible = true;
                tmrRunGame.Stop();
                

            }

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

            randomBloodcell = randNumber.Next(1, 10);

            if (randomBloodcell == 2 || randomBloodcell == 4 || randomBloodcell == 10)
            {
                picBlood1.Visible = true;
                picBlood2.Visible = true;
                picBlood3.Visible = true;
            }
            else if (randomBloodcell != 2 || randomBloodcell != 4 || randomBloodcell != 10)
            {
                picBlood1.Visible = false;
                picBlood2.Visible = false;
                picBlood3.Visible = false;
            }

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




            // good- found food, found sub, find mechanic, 
            // bad- lose (sick/die) a mechanic, break, Virus attack (hunting game?), sick names, wrong vein (lose day), 
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
                picFood.Visible = true;
                lblEvents.Visible = true;
                lblEvents.Text = "Find 30 lbs of food.";
                food = food + 30;
                lblSpace.Visible = true;
            }
            else if (randomNumber == 77 || randomNumber == 25)
            {
                lblEvents.Visible = true;
                lblEvents.Text = "Virus Attack";
                System.Threading.Thread.Sleep(1000);
                Form huntingForm = new Hunting();
                huntingForm.Show();

                lblSpace.Visible = true;
            }
            else if (randomNumber == 45 || randomNumber == 1)
            {
                lblEvents.Visible = true;
                randomSick = randNumber.Next(1, 6);
                if (randomSick == 1)
                {
                    lblEvents.Text = txtName1.Text.ToString() + " is sick";
                }
                else if (randomSick == 2)
                {
                    lblEvents.Text = txtName2.Text.ToString() + " is sick";
                }
                else if (randomSick == 3)
                {
                    lblEvents.Text = txtName3.Text.ToString() + " is sick";
                }
                else if (randomSick == 4)
                {
                    lblEvents.Text = txtName4.Text.ToString() + " is sick";
                }
                else if (randomSick == 5)
                {
                    lblEvents.Text = txtName.Text.ToString() + " is sick";
                }

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
                lblEvents.Text = "Found another sub. You got \n - 40 lbs food \n - 1 mechanic";
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
                    time = time - 25;

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
                picbackground.Visible = false;
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
                    picbackground.Visible = true;
                    gbOptions.Visible = false;
                    tmrRunGame.Start();
                    lblFacts.Text = " ";
                }
                else if (e.KeyChar == (char)Keys.D2) // Opens the map form
                {
                    Form mapForm = new map();
                    mapForm.Show();
                }

                else if (e.KeyChar == (char)Keys.D3) // Facts
                {
                    randomFact = randNumber.Next(1, 10);


                    if (randomFact == 1)
                    {
                        lblFacts.Text = "The only part of the body that has no blood supply is the cornea of the eye. It receives oxygen directly from the air.";
                    }
                    else if (randomFact == 2)
                    {
                        lblFacts.Text = "The human brain has a memory capacity which is the equivalent of more than four terabytes on a hard drive.";
                    }
                    else if (randomFact == 3)
                    {
                        lblFacts.Text = "A newborn child can breathe and swallow at the same time for up to seven months.";
                    }
                    else if (randomFact == 4)
                    {
                        lblFacts.Text = "Your skull is made up of 29 different bones.";
                    }
                    else if (randomFact == 5)
                    {
                        lblFacts.Text = "Nerve impulses sent from the brain move at a speed of 274 km/h.";
                    }
                    else if (randomFact == 6)
                    {
                        lblFacts.Text = "A single human brain generates more electrical impulses in a day than all the telephones of the world combined.";
                    }
                    else if (randomFact == 7)
                    {
                        lblFacts.Text = "The average human body contains enough sulphur to kill all the fleas on the average dog, enough carbon to make 900 pencils, enough potassium to fire a toy cannon, enough fat to make seven bars of soap and enough water to fill a 50-litre barrel.";
                    }
                    else if (randomFact == 8)
                    {
                        lblFacts.Text = "The human heart pumps 182 million litres of blood during the average lifetime.";
                    }
                    else if (randomFact == 9)
                    {
                        lblFacts.Text = "50,000 cells in your body died and were replaced by new ones while you were reading this sentence.";
                    }
                    else if (randomFact == 10)
                    {
                        lblFacts.Text = "The human embryo acquires fingerprints within three months of conception.";
                    }

                   
                }
                else if (e.KeyChar == (char)Keys.D4) // Introduction
                {
                    Form introForm = new Introduction();
                    introForm.Show();
                }

            }
            if (lblEvents.Visible == true)
            {
                if (e.KeyChar == (char)Keys.Back) // Continues the game after events
                {
                    lblEvents.Visible = false;
                    tmrRunGame.Start();
                    lblSpace.Visible = false;
                    picFood.Visible = false;
                }
              
            }
            if (lblEnd.Visible == true)
            {
                if (e.KeyChar == (char)Keys.Escape) // closes the game after you lose or win
                {
                    this.Close();
                }
            }

        }
    }
}


 
    
 

