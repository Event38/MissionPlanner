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
        public double resumealt;
        public bool gpslanding;
        public bool autoland;
        public bool resumeMission;
        public bool runway;
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
                stats.resumealt = 80;
                stats.gpslanding = false;
                stats.autoland = false;
                stats.resumeMission = false;
                stats.runway = false;
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2)
            {
                stats.batteryHigh = 12.6;
                stats.batteryLow = 11.2;
                stats.flightSpeedM = 5;
                stats.flightSpeedF = 16.4;
                stats.landwp = 2;
                stats.firmware = "Iris";
                stats.resumealt = 60;
                stats.gpslanding = false;
                stats.autoland = true;
                stats.resumeMission = true;
                stats.runway = false;
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.E386)
            {
                stats.batteryHigh = 16.8;
                stats.batteryLow = 14.2;
                stats.flightSpeedM = 13;
                stats.flightSpeedF = 42.65;
                stats.landwp = 5;
                stats.firmware = "E386";
                stats.resumealt = 80;
                stats.gpslanding = true;
                stats.autoland = true;
                stats.resumeMission = true;
                stats.runway = true;
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Scout)
            {
                stats.batteryHigh = 12.6;
                stats.batteryLow = 11.2;
                stats.flightSpeedM = 13;
                stats.flightSpeedF = 42.65;
                stats.landwp = 5;
                stats.firmware = "Scout";
                stats.resumealt = 80;
                stats.gpslanding = true;
                stats.autoland = true;
                stats.resumeMission = true;
                stats.runway = true;
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover)
            {
                stats.batteryHigh = 0;
                stats.batteryLow = 0;
                stats.flightSpeedM = 0;
                stats.flightSpeedF = 0;
                stats.resumealt = 0;
                stats.firmware = "ArduRover";
                stats.gpslanding = false;
                stats.autoland = false;
                stats.resumeMission = false;
                stats.runway = false;
            }
            else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx)
            {
                stats.batteryHigh = 0;
                stats.batteryLow = 0;
                stats.flightSpeedM = 0;
                stats.flightSpeedF = 0;
                stats.resumealt = 0;
                stats.firmware = "Ateryx";
                stats.gpslanding = false;
                stats.autoland = false;
                stats.resumeMission = false;
                stats.runway = false;
            }

            return stats;
        }


    }
}
