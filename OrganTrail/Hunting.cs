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
    public partial class Hunting : Form
    {
        public Hunting()
        {
            InitializeComponent();
        }
        /*---------Variables for player movement---------*/
        bool goup; // This Boolean will be used for the player to go up the screen 
        bool godown; // This Boolean will be used for the player to down up the screen
        bool goleft; // This Boolean will be used for the player to left up the screen   
        bool goright; // This Boolean will be used for the player to right up the screen
        /*---------Variables for player face diagonal and for bulletGuide diagonal ---------*/
        bool facingNE;
        bool facingSE;
        bool facingSW;
        bool facingNW;



        string bulletGuide = "up"; // This string is called bulletGuide and it will be used to guide the bullets
        double submarineHealth = 100; //This double variable is called player health
        int speed = 5; // This integer is for the speed of the player
        int ammo = 1500; // This integer will hold the number of ammo the player has start of the game
        int enemiesSpeed = 3; // This integer will the speed which the zombies move in the game
        int score = 0; // This integer will hold the score the player achieved through the game
        bool gameOver = false; // This boolean is false in the beginning and it will be used when the game is finished
        Random rnd = new Random(); // This is an instance of the random class we will use this to create a random number for this game

        // End of variables

        private void keyisdown(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver) return; // if game over is true then do nothing in this event

            // if the left key is pressed then do the following
            if (e.KeyCode == Keys.Left)
            {
                goleft = true; // change go left to true
                bulletGuide = "left"; // change bulletGuide to left
                picPlayer.Image = Properties.Resources.hunterLeft; // change the player image to LEFT image
            }

            // End of left key selection

            //if the right key is pressed then do the following
            if (e.KeyCode == Keys.Right)
            {
                goright = true; // change go right to true
                bulletGuide = "right"; // change bulletGuide to right
                picPlayer.Image = Properties.Resources.hunterRight; // change the player image to right
            }
            // End of right key selection

            // if the down key is pressed then do the following
            if (e.KeyCode == Keys.Up)
            {
                bulletGuide = "up"; // change bulletGuide to up
                goup = true; // change go up to true
                picPlayer.Image = Properties.Resources.hunterBack; // change the player image to up

            }
            // End of up key selection

            // if the down key is pressed then do the following
            if (e.KeyCode == Keys.Down)
            {
                bulletGuide = "down"; // change bulletGuide to down
                godown = true; // change go down to true
                picPlayer.Image = Properties.Resources.hunterFront; // change the player image to down
            }
            // End of the down key selection
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return; // if game over is true then do nothing in this event

            // below is the key up selection for the left key
            if (e.KeyCode == Keys.Left)
            {
                goleft = false; // change the go left boolean to false
            }

            // below is the key up selection for the right key
            if (e.KeyCode == Keys.Right)
            {
                goright = false; // change the go right boolean to false
            }

            // below is the key up selection for the up key
            if (e.KeyCode == Keys.Up)
            {
                goup = false; // change the go up boolean to false
            }

            // below is the key up selection for the left key
            if (e.KeyCode == Keys.Down)
            {
                godown = false; // change the go down boolean to false
            }

            // below is the key up selection for the space key
            if (e.KeyCode == Keys.Space && ammo > 0) // in this if statement we are checking if the space bar is up and ammo is more than 0
            {
                ammo--; // reduce ammo by 1 from total number
                shoot(bulletGuide); // invoke the shoot function with the bulletGuide string inside it
                //bulletGuide will transfer up, down, left or right to thr function and that will shoot the bullet that way.

                /*  if (ammo < 1) // if ammo is less than 1
                 {
                     DropAmmo(); // invoke the drop ammo function
                 } */
            }
        }

        private void keyispress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                lblTitle.Visible = false;
                textBox.Visible = false;
                lblInfo.Visible = false;
                timer1.Start();

            }
        }

        private void gameEngine(object sender, EventArgs e)
        {
            if (submarineHealth > 1) // if player health is greater then 1
            {
                progressBar1.Value = Convert.ToInt32(submarineHealth); // assign the progress bar to the player health integer
            }
            else
            {
                // if the player health is below 1
                //picPlayer.Image = Properties.Resources.dead; // show the player dead image
                timer1.Stop(); // stop the timer
                gameOver = true; // change game over to true
                this.Close();
            }

            if (score == 6 && submarineHealth != 0)
            {
                timer1.Stop(); // stop the timer
                gameOver = true; // change game over to true

            }

            label1.Text = "   Ammo:   " + ammo; // show the ammo amount on label 1
            label2.Text = "Kills: " + score; // show the total kills on the score

            // if the player health is less then 50
            if (submarineHealth < 50)
            {
                progressBar1.ForeColor = System.Drawing.Color.Yellow; // change the progress bar colour to red.
            }
            // if the player health is less then 20
            if (submarineHealth < 20)
            {
                progressBar1.ForeColor = System.Drawing.Color.Red; // change the progress bar colour to red.
            }

            if (goleft && picPlayer.Left > 0)
            {
                picPlayer.Left -= speed;
                // if moving left is true AND pacman is 1 pixel more from the left
                // then move the player to the LEFT
            }

            if (goright && picPlayer.Left + picPlayer.Width < 930)
            {
                picPlayer.Left += speed;
                // if moving RIGHT is true AND player left + player width is less 930 pixel
                // then move the player to the RIGHT
            }

            if (goup && picPlayer.Top > 60)
            {
                picPlayer.Top -= speed;
                // if moving TOP is true AND player is 60 pixel from the top
                // then move the player to the DOWN
            }

            if (godown && picPlayer.Top + picPlayer.Height < 700)
            {
                picPlayer.Top += speed;
                // if moving Down is true AND player top + player heght is less 700 pixel
                // then move the player to the DOWN
            }

            // run the first for each loop below 
            // X is a control and we search for all controls in this loop
            foreach (Control x in this.Controls)
            {
                /*
                // if the X is a picture box and X has a tag AMMO
                if (x is PictureBox && x.Tag == "ammo")
                {
                    // check is X in hitting the player picture box

                    if (((PictureBox)x).Bounds.IntersectsWith(picPlayer.Bounds))
                    {
                        // once the player picks up the ammo

                        this.Controls.Remove(((PictureBox)x)); // remove the ammo picture

                       ((PictureBox)x).Dispose(); // dispose the picture box completely from the program
                       ammo += 5; // add 5 ammo to the integer
                    }
                }
                 */

                // if the bullets hit the 4 borders of the game
                // if x is picture box and x has the tag of bullets

                if (x is PictureBox && x.Tag == "bullet")
                {
                    // if the bullet is less the 1 pixel to left
                    // if the bullet is more then 930 pixels to the right
                    // if the bullet is 10 pixels form top
                    // if the bullet is 700 pixels to buttom

                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove(((PictureBox)x)); // remove the bullet from the display
                        ((PictureBox)x).Dispose(); // dispose the bullet form the program
                    }
                }


                // below is the if statement which will be checking if the player hits a virus

                if (x is PictureBox && x.Tag == "virus")
                {
                    // below is the if statement thats checking if the bounds of the player and the virus

                    if (((PictureBox)x).Bounds.IntersectsWith(picPlayer.Bounds))
                    {
                        submarineHealth -= 5; // if the virus hits the submarine the we decrase the health by 1
                        this.Controls.Remove(x); // this will remove the virus from the program
                        x.Dispose(); // this will dispose the virus from program
                        makeVirus(); // this function will invoke the make virus function to add another virus to the game
                    }

                    // move viurs towards the submarine picture box

                    if (((PictureBox)x).Left > picPlayer.Left)
                    {
                        ((PictureBox)x).Left -= enemiesSpeed; // move virus towards the left of the submarine/player
                    }

                    if (((PictureBox)x).Top > picPlayer.Top)
                    {
                        ((PictureBox)x).Top -= enemiesSpeed; // move virus towards the left of the submarine/player
                    }

                    if (((PictureBox)x).Left < picPlayer.Left)
                    {
                        ((PictureBox)x).Left += enemiesSpeed; // move virus towards the left of the submarine/player
                    }

                    if (((PictureBox)x).Top < picPlayer.Top)
                    {
                        ((PictureBox)x).Top += enemiesSpeed; // move virus towards the left of the submarine/player
                    }
                }
                // below is the second for loop, this is nexted inside the first one
                // the bullet and virus needs to be different than each other
                // then we can use that to determine if the hit each other

                foreach (Control j in this.Controls)
                {
                    // below is the selection thats identifying the bullet and virus

                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "virus"))
                    {
                        // below is the if statement thats checking if bullet hits the virus
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++; // increase the kill score by 1
                            this.Controls.Remove(j); // this remove the bullet for the screen
                            j.Dispose(); // this will dispose the bullet all together from the program
                            this.Controls.Remove(x); // this will remove the virus from the program
                            x.Dispose(); // this will dispose the virus from program
                            makeVirus(); // this function will invoke the make virus function to add another virus to the game
                        }
                    }
                }
            }
        }

        /*private void DropAmmo()
        {
            // this function will make a ammo image for this game

            PictureBox ammo = new PictureBox()
        }*/

        private void shoot(string direct)
        {
            // this is the function thats makes the new bullets in this game

            Bullets shoot = new Bullets(); // create a new instance of the bullet class
            shoot.direction = direct; // assignment the dirction to the bullet
            shoot.bulletLeft = picPlayer.Left + (picPlayer.Width = 175); // place the bullet to left half of the player
            shoot.bulletTop = picPlayer.Top + (picPlayer.Height = 100); // place the bullet on top half of the player
            shoot.makeBullet(this); // run the function mkBullet from the bullet class.
        }

        private void makeVirus()
        {
            // when this function is called it will make virus in the game

            PictureBox virus = new PictureBox(); // create a new picture box called virus
            virus.Tag = "virus"; // add a tag to it called virus
            virus.Image = Properties.Resources.Backteriophage; // the default picture for the virus is zbown
            virus.Left = rnd.Next(0, 900); // generate a number between 0 and 900 and assignment that to the new virus left
            virus.Top = rnd.Next(0, 800); // generate a number between 0 and 800 and assignment that to the new virus top
            virus.SizeMode = PictureBoxSizeMode.Zoom; // set auto size for the new picture box
            virus.Size = new Size(58, 62);
            this.Controls.Add(virus); // add the picture box to the screen
            picPlayer.BringToFront(); // bring the player to the front
        }
    }
}





/*private void makezombies()
{
    // when this function is called it will make zombie in the game

    PictureBox zombie = new PictureBox(); // create a new picture box called zombie
    zombie.Tag = "zombie"; // add a tag to it called zombie
    zombie.Image = Properties.Resources.zdown; // the default picture for the zombie is zbown
    zombie.Left = rnd.Next(0, 900); // generate a number between 0 and 900 and assignment that to the new zombie left
    zombie.Top = rnd.Next(0, 800); // generate a number between 0 and 800 and assignment that to the new zombie top
    zombie.SizeMode = PictureBoxSizeMode.AutoSize; // set auto size for the new picture box
    this.Controls.Add(zombie); // add the picture box to the screen
    picPlayer.BringToFront(); // bring the player to the front
}
        
private void makezombies()
{
    // when this function is called it will make zombie in the game

    PictureBox zombie = new PictureBox(); // create a new picture box called zombie
    zombie.Tag = "zombie"; // add a tag to it called zombie
    zombie.Image = Properties.Resources.zdown; // the default picture for the zombie is zbown
    zombie.Left = rnd.Next(0, 900); // generate a number between 0 and 900 and assignment that to the new zombie left
    zombie.Top = rnd.Next(0, 800); // generate a number between 0 and 800 and assignment that to the new zombie top
    zombie.SizeMode = PictureBoxSizeMode.AutoSize; // set auto size for the new picture box
    this.Controls.Add(zombie); // add the picture box to the screen
    picPlayer.BringToFront(); // bring the player to the front
}*/