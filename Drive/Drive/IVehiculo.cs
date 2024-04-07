using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal interface IVehiculo
    {
        void Drive();
        bool Rafuel(int gasoline);
    }
}