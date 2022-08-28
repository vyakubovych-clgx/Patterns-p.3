namespace Task2.Interfaces;

public interface ICalculator
{
    Task<decimal> CalculatePayment(string touristName);
}