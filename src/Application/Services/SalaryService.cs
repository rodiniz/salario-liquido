using Application.Processors;
using Domain.Strategies.Salary;
using OneOf;

namespace Application.Services;

public sealed class SalaryService : ISalaryService
{
    public OneOf<double, CalculationFailed> CalculateSalary(string country, double salary)
    {
        var processor = new SalaryProcessor();

        var operation = SelectCountryOperation(country.ToLower());

        if (operation == null)
        {
            return new CalculationFailed($"Country {country} not supported yet");
        }
        processor.SetSalaryStrategy(operation);

        return processor.ProcessSalary(salary);
    }

    private static ISalaryStrategy? SelectCountryOperation(string country) =>
        country switch
        {
            "br" => new BrazilSalaryStrategy(),
            "pt" => new PortugalSalaryStrategy(),
            "eu" => new EuropeSalaryStrategy(),
            _ => null
        };
}
