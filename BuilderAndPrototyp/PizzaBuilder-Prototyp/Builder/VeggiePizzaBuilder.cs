
namespace BuilderAndPrototyp.PizzaBuilder_Prototyp
{
    public class VeggiePizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = "Цільнозернове тісто";
        }

        public override void BuildSauce()
        {
            pizza.Sauce = "Песто";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "Сир, гриби, болгарський перець, оливки";
        }
    }
}
