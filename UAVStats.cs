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
        public double flighttime;
        public float landwp;
        public double resumealt;
        public double amphour;
        public bool gpslanding;
        public bool autoland;
        public bool resumeMission;
        public bool runway;

        public static UAVStats setStats(string uav)
        {
            UAVStats stats = new UAVStats();
            if (uav == "E384")
            {
                stats.batteryHigh = 16.8;
                stats.batteryLow = 14.2;
                stats.flightSpeedM = 13;
                stats.flightSpeedF = 42.65;
                stats.amphour = 134.4;
                stats.landwp = 6;
                stats.firmware = "E384";
                stats.flighttime = 60;
                stats.resumealt = 80;
                stats.gpslanding = true;
                stats.autoland = false;
                stats.resumeMission = false;
                stats.runway = true;
                MainV2.comPort.MAV.cs.firmware = MainV2.Firmwares.ArduPlane;               
            }
            else if (uav == "IRIS+")
            {
                stats.batteryHigh = 12.6;
                stats.batteryLow = 11.2;
                stats.flightSpeedM = 5;
                stats.flightSpeedF = 16.4;
                stats.landwp = 1;
                stats.firmware = "Iris";
                stats.flighttime = 15;
                stats.resumealt = 60;
                stats.gpslanding = true;
                stats.autoland = true;
                stats.resumeMission = true;
                stats.amphour = 5100;
                stats.runway = true;
                MainV2.comPort.MAV.cs.firmware = MainV2.Firmwares.ArduCopter2;               

            }
            else if (uav == "E386")
            {
                stats.batteryHigh = 16.8;
                stats.batteryLow = 14.2;
                stats.flightSpeedM = 13;
                stats.flightSpeedF = 42.65;
                stats.landwp = 5;
                stats.firmware = "E386";
                stats.flighttime = 60;
                stats.resumealt = 80;
                stats.amphour = 134.4;
                stats.gpslanding = true;
                stats.autoland = true;
                stats.resumeMission = true;
                stats.runway = true;
                MainV2.comPort.MAV.cs.firmware = MainV2.Firmwares.ArduPlane;               
            }
            else if (uav == "Scout")
            {
                stats.batteryHigh = 12.6;
                stats.batteryLow = 11.2;
                stats.flightSpeedM = 13;
                stats.flightSpeedF = 42.65;
                stats.landwp = 5;
                stats.firmware = "Scout";
                stats.flighttime = 30;
                stats.resumealt = 80;
                stats.amphour = 56.61;
                stats.gpslanding = true;
                stats.autoland = true;
                stats.resumeMission = true;
                stats.runway = true;
                MainV2.comPort.MAV.cs.firmware = MainV2.Firmwares.ArduPlane;               
            }
            else if (uav == "Other")
            {
                stats.batteryHigh = 0;
                stats.batteryLow = 0;
                stats.flightSpeedM = 0;
                stats.flightSpeedF = 0;
                stats.resumealt = 0;
                stats.firmware = "ArduRover";
                stats.flighttime = 0;
                stats.amphour = 0;
                stats.gpslanding = false;
                stats.autoland = false;
                stats.resumeMission = false;
                stats.runway = false;
            }
         

            return stats;
        }


    }
}
