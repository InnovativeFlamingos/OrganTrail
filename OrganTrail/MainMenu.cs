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
            if (radTravel.Checked == true) // Opens the game
            {

                Game game = new Game();
                game.Show();

                Form introForm = new Introduction();
                introForm.Show();

               

            }
            else if (radLearn.Checked == true) // Opens the map
            {
                map map = new map();
                map.Show();

            }
            else if (radHunting.Checked == true) // Open hunting
            {
                Hunting hunting = new Hunting();
                hunting.Show();
            }
            else if (radExit.Checked == true) //Closes game
            {
                this.Close();
            }
        }

    }
}
