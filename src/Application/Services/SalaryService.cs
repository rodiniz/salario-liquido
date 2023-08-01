using Application.Processors;
using Domain.Strategies.Salary;

namespace Application.Services;

public sealed class SalaryService : ISalaryService
{
    public double CalculateSalary(string coutry, double salary)
    {
        var processor = new SalaryProcessor();

        var operation = SelectCountryOperation(coutry.ToLower());

        processor.SetSalaryStrategy(operation);

        return processor.ProcessSalary(salary);
    }

    private static ISalaryStrategy SelectCountryOperation(string country) =>
        country switch
        {
            "br" => new BrazilSalaryStrategy(),
            "pt" => new PortugalSalaryStrategy(),
            "eu" => new EuropeSalaryStrategy(),
            _ => throw new ArgumentException("We cannot process salary for this country yet"),
        };
}
