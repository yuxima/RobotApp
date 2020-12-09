using System;
using System.Collections.Generic;
using System.Text;
using RobotApp.BLL.Abstraction;

namespace RobotApp.BLL.Commands
{
    class MoveCommand : ICommand
    {
        private GameState gameState;

        void Execute()
        {
            throw new NotImplementedException();
        }

        void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
