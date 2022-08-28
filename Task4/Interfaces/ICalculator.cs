namespace Task4.Interfaces;

public interface ICalculator
{
    Task<decimal> CalculatePayment(string touristName);
}