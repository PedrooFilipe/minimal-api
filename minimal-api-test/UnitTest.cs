using minimal_api;
using Moq;

namespace minimal_api_test;

public class UnitTest1
{
    //private Mock<WeatherForecastController> mock = new Mock<WeatherForecastController>();

    [Fact]
    public void SomaValores()
    {
        
        //arrange
        int valor1 = 10;
        int valor2 = 15;

        WeatherForecastController controller = new WeatherForecastController();

        //act
        int soma = controller.Soma(valor1, valor2);

        //assert
        Assert.Equal(25, soma);

    }
}