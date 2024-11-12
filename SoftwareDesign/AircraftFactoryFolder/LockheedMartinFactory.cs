using SoftwareDesign.Aircraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesign.AircraftFactoryApp
{
    public class LockheedMartinFactory : AircraftFactory
    {
        public override PassengerPlane CreatePassengerPlane() => new LockheedMartinPassengerPlane();
        public override CargoPlane CreateCargoPlane() => new LockheedMartinCargoPlane();
        public override MilitaryPlane CreateMilitaryPlane() => new LockheedMartinMilitaryPlane();
    }
}
