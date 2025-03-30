using PaternDecorator.Pizza_Decorator.Pizzes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDekorator.Pizza_Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string GetDescription() => pizza.GetDescription();
        public virtual double GetCost() => pizza.GetCost();
    }
}
