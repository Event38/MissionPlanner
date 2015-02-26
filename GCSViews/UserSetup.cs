using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class UserSetup : Form
    {
        public UserSetup()
        {
            InitializeComponent();
        }

        private void UserSetup_Load(object sender, EventArgs e)
        {
            this.ShowDialog();
        }

        private void BUT_Accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
