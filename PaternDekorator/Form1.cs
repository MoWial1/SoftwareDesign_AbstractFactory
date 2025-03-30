using PaternDekorator.Pizza_Decorator.Pizzes;
using PaternDekorator.Pizza_Decorator;
using System;
using System.Windows.Forms;
using PaternDecorator.Pizza_Decorator.Pizzes;

namespace PaternDekorator
{
    public partial class Form1 : Form
    {
        private IPizza pizza;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasePizza_Click(object sender, EventArgs e)
        {
            pizza = new BasicPizza();
            UpdateUI();
        }



        private void UpdateUI()
        {
            lblDescription.Text = pizza.GetDescription();
            lblPrice.Text = $"Price: {pizza.GetCost()} uah";
        }

        private void btnClearPizza_Click(object sender, EventArgs e)
        {
            pizza = null;
            lblDescription.Text = "Pizza do not exist";
            lblPrice.Text = "Price: 0 uah";
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            if (pizza != null)
            {
                pizza = new CheeseDecorator(pizza);
                UpdateUI();
            }
        }

        private void btnTomato_Click(object sender, EventArgs e)
        {
            if (pizza != null)
            {
                pizza = new TomatoDecorator(pizza);
                UpdateUI();
            }
        }

        private void btnSalami_Click(object sender, EventArgs e)
        {
            if (pizza != null)
            {
                pizza = new SalamiDecorator(pizza);
                UpdateUI();
            }
        }
    }
}
