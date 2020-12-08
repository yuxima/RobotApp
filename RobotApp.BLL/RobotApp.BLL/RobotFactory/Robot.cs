using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.RobotFactory
{
    public abstract class Robot
    {
        public int BatteryChargeCapacity { get; set; }
        public int LoadCapacity { get; set; }
        public int CurrentBatteryCharge { get; set; }
        public int WayTraveled { get; set; }
        public int RobotId { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Legend { get; set; }
        public Robot(int id, string name, string avatar)
        {

        }
    }
}
