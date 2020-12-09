using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.CargoDecorator
{
    public abstract class CargoDecorator
    {
        private Cargo cargo;
        public CargoDecorator(Cargo _cargo)
        {
            cargo = _cargo;
        }
    }
}
