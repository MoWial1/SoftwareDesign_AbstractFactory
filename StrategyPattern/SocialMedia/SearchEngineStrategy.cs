

namespace StrategyPattern.SocialMedia
{
    public class SearchEngineStrategy : IAdStrategy
    {
        // Виконує кампанію в пошукових системах
        public string ExecuteCampaign(string campaignName, decimal budget)
        {
            return $"Advertising campaign \"{campaignName}\" on Search Engines launched with a budget of {budget} USD.";
        }
    }
}
