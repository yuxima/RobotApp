using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.RobotFactory
{
    public class CyborgCreator : RobotCreator
    {
        public override Robot CreateRobot(int id, string name, string avatar)
        {
            return new Cyborg(id, name, avatar);
        }
    }
}
