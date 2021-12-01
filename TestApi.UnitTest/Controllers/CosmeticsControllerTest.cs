
using FluentAssertions;
using Xunit;

public class CosmeticsControllerTest {

    [Fact]
    public void GivenAny_WhenGetCosmeticses_ThenReturnCosmeticsList()
    {
        //Given
        var controller = new CosmeticsController();
        
        //When
        var result = controller.GetCosmeticses();
        
        //Then
        result.Should().BeEmpty();
    }
}