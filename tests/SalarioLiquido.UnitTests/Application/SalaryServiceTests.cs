using Application.Services;

namespace SalarioLiquido.UnitTests.Application;

public sealed class SalaryServiceTests
{
    [Theory]
    [InlineData("BR", 1000, 900)]
    [InlineData("br", 1500, 1350)]
    [InlineData("PT", 2000, 1400)]
    [InlineData("pt", 2500, 1750)]
    [InlineData("EU", 3000, 2400)]
    [InlineData("eu", 3500, 2800)]
    public void CalculateSalary_ShouldReturn_LiquidSalaryCalculated(string country, double salary, double expected)
    {
        // Arrange
        var salaryService = new SalaryService();

        // Act
        var liquidSalary = salaryService.CalculateSalary(country, salary);

        // Assert
        Assert.Equal(expected, liquidSalary);
    }

    [Theory]
    [InlineData("US", 1000)]
    [InlineData("AR", 2000)]
    [InlineData("TEST", 3000)]
    [InlineData("*", 3000)]
    public void CalculateSalary_ShouldReturn_ErrorTryingCalculatingSalaryForAnNotImplemented(string country, double salary)
    {
        // Arrange
        var salaryService = new SalaryService();

        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => salaryService.CalculateSalary(country, salary));
    }
}
