

namespace BuilderAndPrototyp.PizzaBuilder_Prototyp
{
    public class HawaiianPizzaBuilder : PizzaBuilder
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
            pizza.Topping = "Сир, ананаси, шинка";
        }
    }
}
