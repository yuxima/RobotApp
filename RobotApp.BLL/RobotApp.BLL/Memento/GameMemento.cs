using RobotApp.BLL.CargoDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.Memento
{
    public class GameMemento
    {
        int currentBatteryCharge;
        int wayTravelled;
        int loadCapacity;
        Cargo[] cargos;
        public GameMemento(GameState state)
        {

        }
    }
}
