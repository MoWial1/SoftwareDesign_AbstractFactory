using SoftwareDesign.Aircraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesign.AircraftFactoryApp
{
    public class BoeingFactory : AircraftFactory
    {
        public override PassengerPlane CreatePassengerPlane() => new BoeingPassengerPlane();
        public override CargoPlane CreateCargoPlane() => new BoeingCargoPlane();
        public override MilitaryPlane CreateMilitaryPlane() => new BoeingMilitaryPlane();
    }
}
