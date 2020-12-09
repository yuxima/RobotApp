using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.Abstraction
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
