

namespace BuilderAndPrototyp.PizzaBuilder_Prototyp
{
    public class Director
    {
        private PizzaBuilder builder;

        public void SetBuilder(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public Pizza ConstructPizza()
        {
            builder.BuildDough();
            builder.BuildSauce();
            builder.BuildTopping();
            return builder.GetPizza();
        }
    }
}
