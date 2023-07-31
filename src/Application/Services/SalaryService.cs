using Application.Processors;
using Domain.Strategy;

namespace Application.Services;

public sealed class SalaryService : ISalaryService
{
    public double CalculateSalary(string coutry, double salary)
    {
        SalaryProcessor processor = new();

        processor.SetSalaryStrategy(GetType(coutry));
        return processor.ProcessSalary(salary);
    }

    private static ISalaryStrategy GetType(string country) =>
        country switch
        {
            "BR" => new BrazilSalaryStrategy(),
            "PT" => new PortugalSalaryStrategy(),
            "EU" => new EuropeSalaryStrategy(),
            _ => throw new ArgumentException("We cannot process salary for this country yet"),
        };
}
