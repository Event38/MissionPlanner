using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MissionPlanner
{
    public partial class AWSASK : Form
    {
        public AWSASK()
        {
            InitializeComponent();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                MainV2.config["AWSUpload"] = "NO";
            }
            this.Close();
        }

        private void myButton1_Click(object sender, EventArgs e)
        { 
            if (this.checkBox1.Checked == true){
            MainV2.config["AWSUpload"] = "YES";
            
            }
         MainV2.AWSUpload AwsUpload = new MainV2.AWSUpload();
            Thread AWSThread =
                new Thread(new ThreadStart(AwsUpload.Upload));
            AWSThread.IsBackground = true;

            AWSThread.Start();

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AWSASK_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
