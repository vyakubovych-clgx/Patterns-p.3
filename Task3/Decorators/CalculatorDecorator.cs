using Task3.Interfaces;

namespace Task3.Decorators;

public abstract class CalculatorDecorator : ICalculator
{
    protected readonly ICalculator Calculator;

    protected CalculatorDecorator(ICalculator calculator)
    {
        Calculator = calculator;
    }

    public abstract Task<decimal> CalculatePayment(string touristName);
}