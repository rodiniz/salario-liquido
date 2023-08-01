namespace Domain.Strategies.Salary;

public class PortugalSalaryStrategy : ISalaryStrategy
{
    public double Calculate(double salary) => salary - salary * 0.30;
}
