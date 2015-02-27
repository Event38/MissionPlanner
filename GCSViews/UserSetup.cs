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
            CMB_Model.Text = MainV2.instance.UserModel;
            CMB_Camera.Text = MainV2.instance.UserCamera;
        }

        private void BUT_Accept_Click(object sender, EventArgs e)
        {
            if (CHK_RememberSetup.Checked == true)
            {
                MainV2.instance.SaveUserSetup = true;
            }
            else
            {
                MainV2.instance.SaveUserSetup = false;
            }


            MainV2.instance.UserModel = CMB_Model.Text;
            MainV2.instance.UserCamera = CMB_Camera.Text;
            MainV2.instance.updateUserSetup();
           
            this.Close();
        }

        private void CMB_Model_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void CMB_Camera_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
