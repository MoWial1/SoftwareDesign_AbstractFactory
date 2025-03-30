using PaternDecorator.Pizza_Decorator.Pizzes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDekorator.Pizza_Decorator.Pizzes
{
    public class BasicPizza : IPizza
    {
        public string GetDescription() => "Основа піци";
        public double GetCost() => 40.0;
    }
}
