using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.CargoDecorator
{
    public class Cargo
    {
        public int Weight { get; set; }
        public int Price { get; set; }
        public int Location { get; set; }
        public Cargo(int price, int weight)
        {

        }
    }
}
