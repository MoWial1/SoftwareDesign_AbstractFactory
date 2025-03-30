using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDecorator.Pizza_Decorator.Pizzes
{
    public interface IPizza
    {
        string GetDescription();
        double GetCost();
    }
}
