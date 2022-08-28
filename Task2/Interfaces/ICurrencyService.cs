namespace Task2.Interfaces;

public interface ICurrencyService
{
    Task<decimal> LoadCurrencyRate();
}