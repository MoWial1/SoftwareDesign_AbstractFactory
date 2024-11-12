using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesign.Aircraft
{
    public class PassengerPlane : Aircraft
    {
        public override string Fly()
        {
            return "Пасажирський літак здійснює політ з пасажирами.";
        }
    }

    public class BoeingPassengerPlane : PassengerPlane
    {
        public override string Fly()
        {
            return "Пасажирський літак Boeing летить з пасажирами.";
        }
    }

    public class AirbusPassengerPlane : PassengerPlane
    {
        public override string Fly()
        {
            return "Пасажирський літак Airbus летить з пасажирами.";
        }
    }

    public class LockheedMartinPassengerPlane : PassengerPlane
    {
        public override string Fly()
        {
            return "Пасажирський літак Lockheed Martin летить з пасажирами.";
        }
    }

}
