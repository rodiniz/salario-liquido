using OneOf;

namespace Application.Services;

public interface ISalaryService
{
    OneOf<double, CalculationFailed> CalculateSalary(string country, double salary);
}