namespace Domain.Models.Salary;

public record RequestModel
{
    public CountryEnum Country { get; set; }
    public double Salary { get; set; }
}
