namespace Domain.Strategies.Salary;

public class EuropeSalaryStrategy : ISalaryStrategy
{
    public double Calculate(double salary) => salary - salary * 0.20;
}
