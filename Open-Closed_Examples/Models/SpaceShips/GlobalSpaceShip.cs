using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.SpaceShips
{
    internal class GlobalSpaceShip : SpaceShip, IGlobal
    {
        public GlobalSpaceShip(string serialNumber) : base(serialNumber)
        {
        }

        public string GetAccess(string key)
        {
            return "Password: OCP_Global";
        }

        internal void LetsGo(object parameter)
        {
            // some action with parameter ...

            base.LetsGo();
        }
    }
}