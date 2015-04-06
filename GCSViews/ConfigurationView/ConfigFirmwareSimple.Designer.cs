namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigFirmwareSimple
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigFirmwareSimple));
            this.lbl_status = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.LBL_Instructions = new System.Windows.Forms.Label();
            this.BUT_LoadFirmware = new System.Windows.Forms.Button();
            this.LBL_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_status.Location = new System.Drawing.Point(3, 443);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 31;
            this.lbl_status.Text = "Status";
            // 
            // progress
            // 
            this.progress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progress.Location = new System.Drawing.Point(3, 417);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(821, 23);
            this.progress.Step = 1;
            this.progress.TabIndex = 30;
            // 
            // LBL_Instructions
            // 
            this.LBL_Instructions.AutoSize = true;
            this.LBL_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Instructions.Location = new System.Drawing.Point(88, 162);
            this.LBL_Instructions.Name = "LBL_Instructions";
            this.LBL_Instructions.Size = new System.Drawing.Size(662, 75);
            this.LBL_Instructions.TabIndex = 33;
            this.LBL_Instructions.Text = resources.GetString("LBL_Instructions.Text");
            // 
            // BUT_LoadFirmware
            // 
            this.BUT_LoadFirmware.BackgroundImage = global::MissionPlanner.Properties.Resources.Green_panel;
            this.BUT_LoadFirmware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BUT_LoadFirmware.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_LoadFirmware.Location = new System.Drawing.Point(338, 299);
            this.BUT_LoadFirmware.Name = "BUT_LoadFirmware";
            this.BUT_LoadFirmware.Size = new System.Drawing.Size(149, 37);
            this.BUT_LoadFirmware.TabIndex = 34;
            this.BUT_LoadFirmware.Text = "Load Custom Firmware";
            this.BUT_LoadFirmware.UseVisualStyleBackColor = true;
            this.BUT_LoadFirmware.Click += new System.EventHandler(this.BUT_LoadFirmware_Click);
            // 
            // LBL_Header
            // 
            this.LBL_Header.AutoSize = true;
            this.LBL_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Header.Location = new System.Drawing.Point(153, 96);
            this.LBL_Header.Name = "LBL_Header";
            this.LBL_Header.Size = new System.Drawing.Size(508, 17);
            this.LBL_Header.TabIndex = 35;
            this.LBL_Header.Text = "Please follow the steps below in order to load new firmware on to your autopilot:" +
    "";
            // 
            // ConfigFirmwareSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_Header);
            this.Controls.Add(this.BUT_LoadFirmware);
            this.Controls.Add(this.LBL_Instructions);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.progress);
            this.Name = "ConfigFirmwareSimple";
            this.Size = new System.Drawing.Size(827, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label LBL_Instructions;
        private System.Windows.Forms.Button BUT_LoadFirmware;
        private System.Windows.Forms.Label LBL_Header;
    }
}
