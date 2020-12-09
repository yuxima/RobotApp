using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL
{
    class GameHistory
    {
        private GameState gameState;
        public Stack<GameMemento> History { get; set; }
        public GameHistory()
        {

        }
    }
}
