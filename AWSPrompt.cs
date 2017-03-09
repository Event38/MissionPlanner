using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class AWSPrompt : Form
    {
        public AWSPrompt()
        {
            InitializeComponent();
        }

        private void AWSPrompt_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainV2.config["AWSUpload"] = "ASK";
            this.Close();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {  

        }

        private void myButton3_Click(object sender, EventArgs e)
        {MainV2.config["AWSUpload"] = "NO";
            this.Close();

        }

        private void myButton2_Click(object sender, EventArgs e)
        {MainV2.config["AWSUpload"] = "YES";
            this.Close();

        }
    }
}
