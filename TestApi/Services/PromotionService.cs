
using TestApi.Repositories;

namespace TestApi.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;
        public PromotionService(IPromotionRepository promotionRepository) => _promotionRepository = promotionRepository;

        public bool Restart(int promotionId)
        {
            return true;
        }
    }
}