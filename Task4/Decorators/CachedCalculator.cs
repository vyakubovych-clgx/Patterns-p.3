using Task4.Interfaces;

namespace Task4.Decorators;

public class CachedCalculator : CalculatorDecorator
{
    private readonly Dictionary<string, decimal> _cache = new();

    public CachedCalculator(ICalculator calculator) : base(calculator)
    {
    }

    public override async Task<decimal> CalculatePayment(string touristName)
    {
        if (_cache.ContainsKey(touristName))
        {
            Console.WriteLine("Used result from cache.");
            return _cache[touristName];
        }

        Console.WriteLine("No matches in cache. Calculating...");
        var result = await Calculator.CalculatePayment(touristName);
        _cache.Add(touristName, result);
        return result;
    }
}