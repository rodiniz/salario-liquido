namespace Domain.Strategy;

public class EuropeSalaryStrategy : ISalaryStrategy
{
    public double Calculate(double salary) => salary - (salary * 0.20);
}
