using System;

using MissionPlanner;


namespace MissionPlanner
{
    public class UAVStats
    {   
        public string camera;
        public string firmware;
        public double batteryLow;
        public double batteryHigh;
        public double flightSpeedM;
        public double flightSpeedF;
        public float landwp;

        public static UAVStats setStats()
        {
            UAVStats stats = new UAVStats();
            if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane)
            {
                stats.batteryHigh = 16.8;
                stats.batteryLow = 14.2;
                stats.flightSpeedM = 13;
                stats.flightSpeedF = 42.65;
                stats.landwp = 2;
                stats.firmware = "E384";
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2)
            {
                stats.batteryHigh = 12.6;
                stats.batteryLow = 11.2;
                stats.flightSpeedM = 5;
                stats.flightSpeedF = 16.4;
                stats.landwp = 2;
                stats.firmware = "Iris";

            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.E386)
            {
                stats.batteryHigh = 16.8;
                stats.batteryLow = 14.2;
                stats.flightSpeedM = 13;
                stats.flightSpeedF = 42.65;
                stats.landwp = 5;
                stats.firmware = "E386";
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Scout)
            {
                stats.batteryHigh = 12.6;
                stats.batteryLow = 11.2;
                stats.flightSpeedM = 13;
                stats.flightSpeedF = 42.65;
                stats.landwp = 5;
                stats.firmware = "Scout";
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover)
            {
                stats.batteryHigh = 0;
                stats.batteryLow = 0;
                stats.flightSpeedM = 0;
                stats.flightSpeedF = 0;
                stats.firmware = "ArduRover";
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx)
            {
                stats.batteryHigh = 0;
                stats.batteryLow = 0;
                stats.flightSpeedM = 0;
                stats.flightSpeedF = 0;
                stats.firmware = "Ateryx";
            }

            return stats;
        }


    }
}
