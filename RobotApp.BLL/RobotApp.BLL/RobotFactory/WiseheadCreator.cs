using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.RobotFactory
{
    public class WiseheadCreator : RobotCreator
    {
        public override Robot CreateRobot(int id, string name, string avatar)
        {
            return new Wisehead(id, name, avatar);
        }
    }
}
