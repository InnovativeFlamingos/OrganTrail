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
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
        }

        private void KeyIsPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) // Continues the game
            {
                this.Close();
            }
        }
    }
}
