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

            //int randomNumber;
            //Random randNumber = new Random();
            //randomNumber = randNumber.Next(1, 3);
          

            lblFood.Text = food + " pounds";
            lblLandmark.Text = landmark + " miles";
            lblTime.Text = time + ":";
            lblHealth.Text = health;
            lblTraveled.Text = miles + " miles";
            



        }

    }
}
