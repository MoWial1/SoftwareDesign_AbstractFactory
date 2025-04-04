

namespace StrategyPattern.SocialMedia
{
    public interface IAdStrategy
    {
        // Виконує рекламну кампанію з заданою назвою та бюджетом,
        // повертаючи повідомлення з результатом кампанії.
        string ExecuteCampaign(string campaignName, decimal budget);
    }
}
