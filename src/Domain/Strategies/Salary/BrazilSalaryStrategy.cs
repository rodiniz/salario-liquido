namespace Domain.Strategies.Salary;

public sealed class BrazilSalaryStrategy : ISalaryStrategy
{
    public double Calculate(double salary) => salary - salary * 0.10;
}
