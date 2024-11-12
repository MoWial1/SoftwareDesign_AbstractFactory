using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesign.Aircraft
{
    public class CargoPlane : Aircraft
    {
        public override string Fly()
        {
            return "Вантажний літак здійснює політ з вантажем.";
        }
    }


    public class BoeingCargoPlane : CargoPlane
    {
        public override string Fly()
        {
            return "Вантажний літак Boeing летить з вантажем.";
        }
    }

    public class AirbusCargoPlane : CargoPlane
    {
        public override string Fly()
        {
            return "Вантажний літак Airbus летить з вантажем.";
        }
    }

    public class LockheedMartinCargoPlane : CargoPlane
    {
        public override string Fly()
        {
            return "Вантажний літак Lockheed Martin летить з вантажем.";
        }
    }
}
