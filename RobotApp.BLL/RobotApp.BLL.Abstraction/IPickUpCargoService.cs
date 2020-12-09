using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.BLL.Abstraction
{
    public interface IPickUpCargoService
    {
        void PickUp();
        void Undo();
    }
}
