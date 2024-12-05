using BuilderAndPrototyp.PizzaBuilder_Prototyp.Builder;
using BuilderAndPrototyp.PizzaBuilder_Prototyp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuilderAndPrototyp
{
    public partial class Form1 : Form
    {
        private Director director; 
        private PizzaBuilder currentBuilder; 
        private int step; 

        private Pizza lastBuiltPizza; 
        private List<Pizza> clonedPizzas = new List<Pizza>(); 

        public Form1()
        {
            InitializeComponent();
            director = new Director();
            director.SetBuilder(new ClassicPizzaBuilder());
            lastBuiltPizza = director.ConstructPizza();
        }

        private void btnCreatePizza_Click(object sender, EventArgs e)
        {
            if (rbClassicPizza.Checked)
            {
                currentBuilder = new ClassicPizzaBuilder();
            }
            else if (rbVeggiePizza.Checked)
            {
                currentBuilder = new VeggiePizzaBuilder();
            }
            else if (rbHawaiianPizza.Checked)
            {
                currentBuilder = new HawaiianPizzaBuilder();
            }
            else if (rbMeatPizza.Checked)
            {
                currentBuilder = new MeatPizzaBuilder();
            }

            if (currentBuilder != null)
            {
                director.SetBuilder(currentBuilder);
                lastBuiltPizza = director.ConstructPizza(); // Побудувати піцу
                tbResult.Text = $"Побудована піца:\n\r{lastBuiltPizza}";
            }
            else
            {
                MessageBox.Show("Оберіть тип піци.");
            }
        }

        private void btnClonePizza_Click(object sender, EventArgs e)
        {
            if (lastBuiltPizza != null)
            {
                Pizza clonedPizza = (Pizza)lastBuiltPizza.Clone(); // Клонування піци
                tbResult.Text = $"Клонована піца:\n\r{clonedPizza}"; // Відображення у текстовому полі
            }
            else
            {
                MessageBox.Show("Спочатку створіть піцу, яку потрібно клонувати.");
            }
        }
    }
}
