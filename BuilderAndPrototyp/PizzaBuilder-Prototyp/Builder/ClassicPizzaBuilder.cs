

namespace BuilderAndPrototyp.PizzaBuilder_Prototyp
{
    public class ClassicPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = "Тонке тісто";
        }

        public override void BuildSauce()
        {
            pizza.Sauce = "Томатний соус";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "Сир, ковбаса, оливки";
        }
    }
}
