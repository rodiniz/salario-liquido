namespace Domain.Models.Salary;

public record RequestModel
{
    public string? Country { get; set; }
    public double Salary { get; set; }
}
