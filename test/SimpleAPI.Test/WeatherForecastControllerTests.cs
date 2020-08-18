using System;
using Xunit;
using SimpleAPI.Controllers;
using Moq;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class WeatherForecastControllerTests
    {
        private readonly Mock<ILogger<WeatherForecastController>> _mockLogger;
        private readonly WeatherForecastController _controller;
        public WeatherForecastControllerTests()
        {
            _mockLogger = new Mock<ILogger<WeatherForecastController>>();

            _controller = new WeatherForecastController(_mockLogger.Object);
        }

        [Fact]
        public void GetReturnsHello()
        {
            //Arrange

            //Act
            var returnValue = _controller.Get(1);

            Assert.Equal("hello", returnValue);
        }
    }
}
