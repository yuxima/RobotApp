using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.CargoDecorator
{
    public class ToxicCargoDecorator:CargoDecorator
    {
        private bool isToxic;
        public ToxicCargoDecorator(Cargo cargo):base(cargo)
        {

        }
        //TODO:
        //public int GiveDamage()
        //{

        //}
    }
}
