using System;
using Microsoft.AspNetCore.Mvc;
using TestApi.Exceptions;
using TestApi.Services;

namespace TestApi.Controllers
{
    [Route("promotion-contracts")]
    public class PromotionController: ControllerBase {

        private readonly IPromotionService _promotionService;
        public PromotionController(IPromotionService promotionService, ILogger _logger) => _promotionService = promotionService;

        [HttpPost("/{id:int}/restart")]
        public bool Restart(int id){
            try{
                return _promotionService.Restart(id);
            }catch(PromotionRestartFailedException){    
                return false;
            }
        }
    }

    public class DummyLogger implements ILogger {
        //do nothing
    }
}
