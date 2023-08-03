namespace Domain.Models.Salary;

public record RequestModel
{
    public required string Country { get; set; }
    public double Salary { get; set; }
}
