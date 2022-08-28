using Task4.Interfaces;

namespace Task4.Decorators;

public class RoundingCalculator : CalculatorDecorator
{
    public RoundingCalculator(ICalculator calculator) : base(calculator)
    {
    }

    public override async Task<decimal> CalculatePayment(string touristName)
        => Math.Round(await Calculator.CalculatePayment(touristName));
}