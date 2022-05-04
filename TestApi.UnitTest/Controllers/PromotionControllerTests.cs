using System;
using TestApi.Controllers;
using TestApi.Services;
using Xunit;
using Moq;

namespace TestApi.UnitTest.Controllers
{
    public class PromotionControllerTests
    {
 
    [Fact]
    public void GivenCorrectPromotion_WhenRestart_ThenReturnTrue()
    {
        //Given
        var mockPromotionService = new Mock<IPromotionService>();
        mockPromotionService.Setup(x => x.Restart(1)).Returns(true);

        var controller = new PromotionController(mockPromotionService.Object);
        
        //When
        var result = controller.Restart(1);
        
        //Then
        Assert.True(result);
    }

    }
}


        mockPromotionService.Verify(x=> x.Restart(1), Times.Once());
