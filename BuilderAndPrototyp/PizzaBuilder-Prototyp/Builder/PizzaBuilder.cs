

namespace BuilderAndPrototyp.PizzaBuilder_Prototyp
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public PizzaBuilder()
        {
            pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return pizza;
        }

        public abstract void BuildDough(); 
        public abstract void BuildSauce(); 
        public abstract void BuildTopping();
    }
}
