namespace MissionPlanner
{
    partial class AWSPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AWSPrompt));
            this.label1 = new System.Windows.Forms.Label();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Are you willing to help us improve Mission Planner by providing anonymous usage d" +
    "ata?";
            // 
            // myButton1
            // 
            this.myButton1.Location = new System.Drawing.Point(294, 41);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 7;
            this.myButton1.Text = "Yes!";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton2
            // 
            this.myButton2.Location = new System.Drawing.Point(294, 80);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(75, 23);
            this.myButton2.TabIndex = 8;
            this.myButton2.Text = "No";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton3
            // 
            this.myButton3.Location = new System.Drawing.Point(125, 118);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(428, 23);
            this.myButton3.TabIndex = 9;
            this.myButton3.Text = "I sometimes use MP with cellular data ask me if it\'s okay to connect on startup";
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // AWSPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(660, 193);
            this.ControlBox = false;
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AWSPrompt";
            this.Text = "Help us Improve Mission Planner!";
            this.Load += new System.EventHandler(this.AWSPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.MyButton myButton1;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton3;
    }
}