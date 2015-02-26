namespace MissionPlanner.GCSViews
{
    partial class UserSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSetup));
            this.LBL_Model = new MissionPlanner.Controls.MyLabel();
            this.LBL_Camera = new MissionPlanner.Controls.MyLabel();
            this.CMB_Model = new MissionPlanner.Controls.MavlinkComboBox();
            this.CMB_Camera = new MissionPlanner.Controls.MavlinkComboBox();
            this.BUT_Accept = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // LBL_Model
            // 
            this.LBL_Model.Location = new System.Drawing.Point(38, 24);
            this.LBL_Model.Name = "LBL_Model";
            this.LBL_Model.resize = false;
            this.LBL_Model.Size = new System.Drawing.Size(218, 23);
            this.LBL_Model.TabIndex = 0;
            this.LBL_Model.Text = "Please choose the model you will be flying:";
            // 
            // LBL_Camera
            // 
            this.LBL_Camera.Location = new System.Drawing.Point(35, 100);
            this.LBL_Camera.Name = "LBL_Camera";
            this.LBL_Camera.resize = false;
            this.LBL_Camera.Size = new System.Drawing.Size(233, 23);
            this.LBL_Camera.TabIndex = 1;
            this.LBL_Camera.Text = "Please choose the camera you will be using:";
            // 
            // CMB_Model
            // 
            this.CMB_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Model.Enabled = false;
            this.CMB_Model.FormattingEnabled = true;
            this.CMB_Model.Items.AddRange(new object[] {
            "E382",
            "E384",
            "E384 Plus",
            "Other"});
            this.CMB_Model.Location = new System.Drawing.Point(89, 53);
            this.CMB_Model.Name = "CMB_Model";
            this.CMB_Model.param = null;
            this.CMB_Model.ParamName = null;
            this.CMB_Model.Size = new System.Drawing.Size(121, 21);
            this.CMB_Model.TabIndex = 2;
            // 
            // CMB_Camera
            // 
            this.CMB_Camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Camera.Enabled = false;
            this.CMB_Camera.FormattingEnabled = true;
            this.CMB_Camera.Items.AddRange(new object[] {
            "Canon S110",
            "Canon SX260",
            "Samsung NX1100",
            "Other"});
            this.CMB_Camera.Location = new System.Drawing.Point(89, 129);
            this.CMB_Camera.Name = "CMB_Camera";
            this.CMB_Camera.param = null;
            this.CMB_Camera.ParamName = null;
            this.CMB_Camera.Size = new System.Drawing.Size(121, 21);
            this.CMB_Camera.TabIndex = 3;
            // 
            // BUT_Accept
            // 
            this.BUT_Accept.Location = new System.Drawing.Point(89, 187);
            this.BUT_Accept.Name = "BUT_Accept";
            this.BUT_Accept.Size = new System.Drawing.Size(121, 32);
            this.BUT_Accept.TabIndex = 4;
            this.BUT_Accept.Text = "Accept";
            this.BUT_Accept.UseVisualStyleBackColor = true;
            this.BUT_Accept.Click += new System.EventHandler(this.BUT_Accept_Click);
            // 
            // UserSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 242);
            this.Controls.Add(this.BUT_Accept);
            this.Controls.Add(this.CMB_Camera);
            this.Controls.Add(this.CMB_Model);
            this.Controls.Add(this.LBL_Camera);
            this.Controls.Add(this.LBL_Model);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSetup";
            this.Text = "User Setup";
            this.Load += new System.EventHandler(this.UserSetup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyLabel LBL_Model;
        private Controls.MyLabel LBL_Camera;
        private Controls.MavlinkComboBox CMB_Model;
        private Controls.MavlinkComboBox CMB_Camera;
        private Controls.MyButton BUT_Accept;
    }
}