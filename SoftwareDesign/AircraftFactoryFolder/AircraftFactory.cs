using SoftwareDesign.Aircraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesign.AircraftFactoryApp
{
    public abstract class AircraftFactory
    {
        public abstract PassengerPlane CreatePassengerPlane();
        public abstract CargoPlane CreateCargoPlane();
        public abstract MilitaryPlane CreateMilitaryPlane();
    }
}
