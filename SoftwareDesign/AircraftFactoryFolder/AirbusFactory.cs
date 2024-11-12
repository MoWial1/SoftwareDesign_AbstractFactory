using SoftwareDesign.Aircraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesign.AircraftFactoryApp
{
    public class AirbusFactory : AircraftFactory
    {
        public override PassengerPlane CreatePassengerPlane() => new AirbusPassengerPlane();
        public override CargoPlane CreateCargoPlane() => new AirbusCargoPlane();
        public override MilitaryPlane CreateMilitaryPlane() => new AirbusMilitaryPlane();
    }
}
