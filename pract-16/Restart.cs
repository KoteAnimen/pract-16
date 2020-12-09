using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_16
{
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
        }
    }
}
