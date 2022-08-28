namespace Task3.Interfaces;

public interface ICurrencyService
{
    Task<decimal> LoadCurrencyRate();
}