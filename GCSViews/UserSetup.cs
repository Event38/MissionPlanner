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
            
            
            if (CMB_Model.Text != "")
            {
                this.Close();
            }
            if (CMB_Model.Text == "E384")
            {
                MainV2._connectionControl.TOOL_APMFirmware.SelectedIndex = 0;
               MainV2.CurrentUAV = UAVStats.setStats("E384");
            }
            
            if (CMB_Model.Text == "E386")
            {
                MainV2._connectionControl.TOOL_APMFirmware.SelectedIndex = 1;
                MainV2.CurrentUAV = UAVStats.setStats("E386");
            } if (CMB_Model.Text == "IRIS+")
            {
                MainV2._connectionControl.TOOL_APMFirmware.SelectedIndex = 2;
                MainV2.CurrentUAV = UAVStats.setStats("IRIS+");
            }
            if (CMB_Model.Text == "Scout")
            {
                MainV2._connectionControl.TOOL_APMFirmware.SelectedIndex =3;
                MainV2.CurrentUAV = UAVStats.setStats("Scout");
            }

           
            if (CMB_Model.Text == "Other")
            {
                MainV2._connectionControl.TOOL_APMFirmware.SelectedIndex = 4;
                MainV2.CurrentUAV = UAVStats.setStats("Other");
            }
           
            MainV2.config["CMB_Model"] = MainV2._connectionControl.TOOL_APMFirmware.SelectedIndex;

        }

        private void CMB_Model_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void CMB_Camera_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void LBL_Model_Click(object sender, EventArgs e)
        {

        }
    }
}
