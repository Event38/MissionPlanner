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
            this.BUT_Accept = new MissionPlanner.Controls.MyButton();
            this.CMB_Model = new System.Windows.Forms.ComboBox();
            this.CMB_Camera = new System.Windows.Forms.ComboBox();
            this.CHK_RememberSetup = new System.Windows.Forms.CheckBox();
            this.lbl_chkDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Model
            // 
            this.LBL_Model.Location = new System.Drawing.Point(24, 24);
            this.LBL_Model.Name = "LBL_Model";
            this.LBL_Model.resize = false;
            this.LBL_Model.Size = new System.Drawing.Size(218, 23);
            this.LBL_Model.TabIndex = 0;
            this.LBL_Model.Text = "Please select the model you will be flying.";
            this.LBL_Model.Click += new System.EventHandler(this.LBL_Model_Click);
            // 
            // LBL_Camera
            // 
            this.LBL_Camera.Location = new System.Drawing.Point(35, 100);
            this.LBL_Camera.Name = "LBL_Camera";
            this.LBL_Camera.resize = false;
            this.LBL_Camera.Size = new System.Drawing.Size(233, 23);
            this.LBL_Camera.TabIndex = 1;
            this.LBL_Camera.Text = "Please choose the camera you will be using:";
            this.LBL_Camera.Visible = false;
            // 
            // BUT_Accept
            // 
            this.BUT_Accept.Location = new System.Drawing.Point(68, 100);
            this.BUT_Accept.Name = "BUT_Accept";
            this.BUT_Accept.Size = new System.Drawing.Size(121, 53);
            this.BUT_Accept.TabIndex = 4;
            this.BUT_Accept.Text = "Begin Planning";
            this.BUT_Accept.UseVisualStyleBackColor = true;
            this.BUT_Accept.Click += new System.EventHandler(this.BUT_Accept_Click);
            // 
            // CMB_Model
            // 
            this.CMB_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Model.FormattingEnabled = true;
            this.CMB_Model.Items.AddRange(new object[] {
            "E384",
            "E386",
            "Scout",
            "IRIS+",
            "Other"});
            this.CMB_Model.Location = new System.Drawing.Point(68, 53);
            this.CMB_Model.Name = "CMB_Model";
            this.CMB_Model.Size = new System.Drawing.Size(121, 21);
            this.CMB_Model.TabIndex = 5;
            this.CMB_Model.SelectedIndexChanged += new System.EventHandler(this.CMB_Model_SelectedIndexChanged_1);
            // 
            // CMB_Camera
            // 
            this.CMB_Camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Camera.FormattingEnabled = true;
            this.CMB_Camera.Items.AddRange(new object[] {
            "Canon S110",
            "Canon SX260",
            "Samsung NX1100",
            "Other"});
            this.CMB_Camera.Location = new System.Drawing.Point(89, 129);
            this.CMB_Camera.Name = "CMB_Camera";
            this.CMB_Camera.Size = new System.Drawing.Size(121, 21);
            this.CMB_Camera.TabIndex = 6;
            this.CMB_Camera.Visible = false;
            this.CMB_Camera.SelectedIndexChanged += new System.EventHandler(this.CMB_Camera_SelectedIndexChanged_1);
            // 
            // CHK_RememberSetup
            // 
            this.CHK_RememberSetup.AutoSize = true;
            this.CHK_RememberSetup.Location = new System.Drawing.Point(78, 230);
            this.CHK_RememberSetup.Name = "CHK_RememberSetup";
            this.CHK_RememberSetup.Size = new System.Drawing.Size(145, 17);
            this.CHK_RememberSetup.TabIndex = 7;
            this.CHK_RememberSetup.Text = "Remember these settings";
            this.CHK_RememberSetup.UseVisualStyleBackColor = true;
            this.CHK_RememberSetup.Visible = false;
            // 
            // lbl_chkDescription
            // 
            this.lbl_chkDescription.AutoSize = true;
            this.lbl_chkDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chkDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_chkDescription.Location = new System.Drawing.Point(46, 252);
            this.lbl_chkDescription.Name = "lbl_chkDescription";
            this.lbl_chkDescription.Size = new System.Drawing.Size(210, 26);
            this.lbl_chkDescription.TabIndex = 8;
            this.lbl_chkDescription.Text = "You can change these settings later under \r\nConfig/Tuning -> Planner";
            this.lbl_chkDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_chkDescription.Visible = false;
            // 
            // UserSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 169);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_chkDescription);
            this.Controls.Add(this.CHK_RememberSetup);
            this.Controls.Add(this.CMB_Camera);
            this.Controls.Add(this.CMB_Model);
            this.Controls.Add(this.BUT_Accept);
            this.Controls.Add(this.LBL_Camera);
            this.Controls.Add(this.LBL_Model);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Setup";
            this.Load += new System.EventHandler(this.UserSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyLabel LBL_Model;
        private Controls.MyLabel LBL_Camera;
        private Controls.MyButton BUT_Accept;
        public System.Windows.Forms.ComboBox CMB_Model;
        public System.Windows.Forms.ComboBox CMB_Camera;
        private System.Windows.Forms.Label lbl_chkDescription;
        public System.Windows.Forms.CheckBox CHK_RememberSetup;
    }
}