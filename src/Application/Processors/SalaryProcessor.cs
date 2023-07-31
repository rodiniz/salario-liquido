using Domain.Strategy;

namespace Application.Processors;

public class SalaryProcessor
{
    private ISalaryStrategy _salaryStrategy;

    public void SetSalaryStrategy(ISalaryStrategy salaryStrategy)
    {
        _salaryStrategy = salaryStrategy;
    }

    public double ProcessSalary(double amount) => _salaryStrategy.Calculate(amount);
}
