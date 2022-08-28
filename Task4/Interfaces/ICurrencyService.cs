namespace Task4.Interfaces;

public interface ICurrencyService
{
    Task<decimal> LoadCurrencyRate();
}