using StrategyPattern.SocialMedia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        private CampaignContext campaignContext = new CampaignContext();

        public Form1()
        {
            InitializeComponent();

            cmbStrategy.SelectedIndex = 0;
        }

        private void btnRunCampaign_Click(object sender, EventArgs e)
        {
            string selected = cmbStrategy.SelectedItem.ToString();
            IAdStrategy strategy = null;
            switch (selected)
            {
                case "Social Media":
                    strategy = new SocialMediaStrategy();
                    break;
                case "Search Engines":
                    strategy = new SearchEngineStrategy();
                    break;
                case "Email Marketing":
                    strategy = new EmailMarketingStrategy();
                    break;
            }

            // Встановлюємо обрану стратегію в контексті
            campaignContext.SetStrategy(strategy);

            // Зчитуємо назву кампанії та бюджет з елементів форми
            string campaignName = txtCampaignName.Text.Trim();
            decimal budget = nudBudget.Value;

            // Перевірка: назва кампанії не може бути пустою
            if (string.IsNullOrEmpty(campaignName))
            {
                MessageBox.Show("Campaign name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Перевірка: бюджет має бути не менше 100 USD
            if (budget < 100)
            {
                MessageBox.Show("Budget must be at least 100 USD!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Запускаємо кампанію та відображаємо результат
                string result = campaignContext.RunCampaign(campaignName, budget);
                lblResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

}
