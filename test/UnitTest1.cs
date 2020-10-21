using System;
using Xunit;

using WebAppCore.Controllers;
using WebAppCore.Models;
using Microsoft.Extensions.Logging;

namespace test {
  public class UnitTest1 {

   /* private readonly ILogger<WeatherForecastController> logger;

    [Fact]
    public void GetMyName() {
      WeatherForecastController controller = new WeatherForecastController(logger);
      var returnValue = controller.Get(1);
      Assert.Equal("Christian", returnValue);
    }*/

    [Fact]
    public void TestSayHello() {
      Employee employee = new Employee();

      employee.Name = "Christian";
      var returnValue = employee.SayHello();

      Assert.Equal("hello Christian1", returnValue);
    }
  }
}
