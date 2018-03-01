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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (radTravel.Checked == true)
            {
                gboxOptions.Visible = false;
                gboxOptions.Enabled = false;
                gboxOptions.Left = 4;
                gboxOptions.Top = 100;
                gboxDifficulty.Left = 212;
                gboxDifficulty.Top = 103;
                gboxDifficulty.Visible = true;
                gboxDifficulty.Enabled = true;

                if (radBanker.Checked == true)
                {
                    Form bankerForm = new gameEasy();
                    bankerForm.Show();
                }
                else if (radCarp.Checked == true)
                {
                    Form carpForm = new gameMedium();
                    carpForm.Show();
                }
                else if (radFarmer.Checked == true)
                {
                    Form farmerForm = new gameHard();
                    farmerForm.Show();
                }
            }
            else if (radLearn.Checked == true)
            {
                map map = new map();
                map.Show();

            }
            else if (radExit.Checked == true)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hunting hunting = new Hunting();
            //hunting.Show();
        }
    }
}
