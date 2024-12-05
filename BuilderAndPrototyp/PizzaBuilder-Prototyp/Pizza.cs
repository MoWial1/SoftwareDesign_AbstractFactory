using System;


namespace BuilderAndPrototyp.PizzaBuilder_Prototyp
{
    public class Pizza : ICloneable
    {
        public string Dough { get; set; } 
        public string Sauce { get; set; } 
        public string Topping { get; set; } 

        public object Clone()
        {
            
            return new Pizza
            {
                Dough = this.Dough,
                Sauce = this.Sauce,
                Topping = this.Topping
            };
        }

        public override string ToString()
        {
            return $"\n\rТісто: {Dough} \r\nСоус: {Sauce} \r\nНачинка: {Topping}";
        }
    }
}
