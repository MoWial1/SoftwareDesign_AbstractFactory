using PaternDecorator.Pizza_Decorator.Pizzes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDekorator.Pizza_Decorator
{
    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza) { }

        public override string GetDescription() => pizza.GetDescription() + ", Помідори";
        public override double GetCost() => pizza.GetCost() + 10.0;
    }
}
