using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.Abstraction
{
    public interface IMoveService
    {
        void Move();
        void Undo();
    }
}
