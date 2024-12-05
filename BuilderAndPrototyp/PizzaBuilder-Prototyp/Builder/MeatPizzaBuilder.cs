
namespace BuilderAndPrototyp.PizzaBuilder_Prototyp.Builder
{
    public class MeatPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = "Класичне тісто";
        }

        public override void BuildSauce()
        {
            pizza.Sauce = "Гострий соус";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "Сир, бекон, ковбаса, курка";
        }
    }
}
