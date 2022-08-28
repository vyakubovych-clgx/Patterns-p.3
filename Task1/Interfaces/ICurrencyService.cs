namespace Task1.Interfaces;

public interface ICurrencyService
{
    Task<decimal> LoadCurrencyRate();
}