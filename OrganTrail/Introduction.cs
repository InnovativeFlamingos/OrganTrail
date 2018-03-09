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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void KeyisPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D9)
            {
                this.Close();
            }
        }
    }
}
