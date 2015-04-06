using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Arduino;
using MissionPlanner.Controls;
using System.IO;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigFirmwareSimple : UserControl
    {
        public ConfigFirmwareSimple()
        {
            InitializeComponent();
        }

        string custom_fw_dir = "";

        Utilities.Firmware fw = new Utilities.Firmware();

        /// <summary>
        /// for when updating fw to hardware
        /// </summary>
        /// <param name="progress"></param>
        /// <param name="status"></param>
        void fw_Progress1(int progress, string status)
        {
            bool change = false;

            if (progress != -1)
            {
                if (this.progress.Value != progress)
                {
                    this.progress.Value = progress;
                    change = true;
                }

            }
            if (lbl_status.Text != status)
            {
                lbl_status.Text = status;
                change = true;
            }

            if (change)
                this.Refresh();
        }

        private void BUT_LoadFirmware_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog { Filter = "Firmware (*.hex;*.px4;*.vrx)|*.hex;*.px4;*.vrx" };
            if (Directory.Exists(custom_fw_dir))
                fd.InitialDirectory = custom_fw_dir;
            fd.ShowDialog();
            if (File.Exists(fd.FileName))
            {
                custom_fw_dir = Path.GetDirectoryName(fd.FileName);

                //fw.Progress -= fw_Progress;
                fw.Progress += fw_Progress1;

                BoardDetect.boards boardtype = BoardDetect.boards.none;
                try
                {
                    boardtype = BoardDetect.DetectBoard(MainV2.comPortName);
                }
                catch
                {
                    CustomMessageBox.Show("Can not connect to com port and detect board type", Strings.ERROR);
                    return;
                }

                fw.UploadFlash(MainV2.comPortName, fd.FileName, boardtype);
            }
        }
    }
}
