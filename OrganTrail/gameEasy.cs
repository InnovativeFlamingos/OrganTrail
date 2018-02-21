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
            int hours = 0;
            int min = 00;
            int food = 0;
            int miles = 0;
            int landmark = 0;
            string health = "very poor";

            hours = +1;
            min = 00;
          

            lblFood.Text = food + " pounds";
            lblLandmark.Text = landmark + " miles";
            lblTime.Text = hours + ":" + min.ToString();
            lblHealth.Text = health;
            lblTraveled.Text = miles + " miles";
            



        }

    }
}
