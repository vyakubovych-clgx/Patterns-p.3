namespace Task1.Interfaces;

public interface ICalculator
{
    Task<decimal> CalculatePayment(string touristName);
}