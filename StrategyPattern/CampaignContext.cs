using StrategyPattern.SocialMedia;
using System;

namespace StrategyPattern
{
    // Контекст кампанії, який використовує стратегію для виконання рекламної кампанії
    public class CampaignContext
    {
        private IAdStrategy strategy;

        public void SetStrategy(IAdStrategy strategy)
        {
            this.strategy = strategy;
        }

        // Запускає кампанію, використовуючи встановлену стратегію
        public string RunCampaign(string campaignName, decimal budget)
        {
            if (strategy == null)
                throw new InvalidOperationException("Strategy is not set!");
            return strategy.ExecuteCampaign(campaignName, budget);
        }
    }
}
