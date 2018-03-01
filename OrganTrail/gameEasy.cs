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
            int day = 0;
            int miles = 0;
            int counter = 0;
            int landmark = 0;
            string health = "";
            string pace = "";
            string rations = "";
        
            
            
            //int randomNumber;
            //Random randNumber = new Random();
            //randomNumber = randNumber.Next(1, 3);

            lblFood.Text = food + " pounds";
            lblLandmark.Text = landmark + " miles";
            lblTime.Text = time.ToString();
            lblHealth.Text = health;
            lblTraveled.Text = miles + " miles";


            for (time = 0; time < 24; time++)
            {
                miles = miles + 10;
                time = time + 1;

                lblFood.Text = food + " pounds";
                lblLandmark.Text = landmark + " miles";
                lblTime.Text = time + ":00";
                lblHealth.Text = health;
                lblTraveled.Text = miles + " miles";
            }


            //if (time < 24)
            //{
            //    do
            //    {
            //        miles = miles + 10;
            //        time = time + 1;

            //        lblFood.Text = food + " pounds";
            //        lblLandmark.Text = landmark + " miles";
            //        lblTime.Text = time + ":00";
            //        lblHealth.Text = health;
            //        lblTraveled.Text = miles + " miles";
            //    } while (time < 24);
            //}



            
 

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
            if (e.KeyChar == (char)Keys.Escape)
            {
                gbEverything.Visible = false;
                picCharacter.Visible = false;
                lblEnter.Visible = false;
                gbOptions.Visible = true;
            }
            else if (e.KeyChar == (char)Keys.D1) // Continues the game
            {
                gbEverything.Visible = true;
                picCharacter.Visible = true;
                lblEnter.Visible = true;
                gbOptions.Visible = false;
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
