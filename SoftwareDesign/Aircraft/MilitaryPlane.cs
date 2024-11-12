using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesign.Aircraft
{
    public class MilitaryPlane : Aircraft
    {
        public override string Fly()
        {
            return "Військовий літак здійснює політ.";
        }
    }


    public class BoeingMilitaryPlane : MilitaryPlane
    {
        public override string Fly()
        {
            return "Військовий літак Boeing на військовому завданні.";
        }
    }

    public class AirbusMilitaryPlane : MilitaryPlane
    {
        public override string Fly()
        {
            return "Військовий літак Airbus на військовому завданні.";
        }
    }

    public class LockheedMartinMilitaryPlane : MilitaryPlane
    {
        public override string Fly()
        {
            return "Військовий літак Lockheed Martin на військовому завданні.";
        }
    }
}
