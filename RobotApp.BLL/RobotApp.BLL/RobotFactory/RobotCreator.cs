using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.RobotFactory
{
    public abstract class RobotCreator
    {
        //TODO: Method which use CreateRobot()
        public abstract Robot CreateRobot(int id, string name, string avatar);
    }
}
