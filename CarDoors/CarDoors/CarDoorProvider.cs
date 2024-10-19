using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDoors
{
    public class CarDoorProvider
    {
        private int _numberOfDoors = 0;

        public int GetDoors()
        {
            return _numberOfDoors;
        }

        public void SetDoors(int quantityToSet)
        {
            _numberOfDoors = quantityToSet;
        }
    }
}
