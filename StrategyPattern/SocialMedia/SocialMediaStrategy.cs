

namespace StrategyPattern.SocialMedia
{
    public class SocialMediaStrategy : IAdStrategy
    {
        // Виконує кампанію в соціальних мережах
        public string ExecuteCampaign(string campaignName, decimal budget)
        {
            return $"Advertising campaign \"{campaignName}\" on Social Media launched with a budget of {budget} USD.";
        }
    }
}
