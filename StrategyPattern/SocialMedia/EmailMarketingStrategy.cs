

namespace StrategyPattern.SocialMedia
{
    public class EmailMarketingStrategy : IAdStrategy
    {
        // Виконує кампанію для email-маркетингу
        public string ExecuteCampaign(string campaignName, decimal budget)
        {
            return $"Advertising campaign \"{campaignName}\" for Email Marketing launched with a budget of {budget} USD.";
        }
    }
}
