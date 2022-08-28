namespace Task3.Interfaces;

public interface ICalculator
{
    Task<decimal> CalculatePayment(string touristName);
}