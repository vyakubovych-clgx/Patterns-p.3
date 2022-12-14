using Task4.Interfaces;

namespace Task4.Decorators;

public abstract class CalculatorDecorator : ICalculator
{
    protected readonly ICalculator Calculator;

    protected CalculatorDecorator(ICalculator calculator)
    {
        Calculator = calculator;
    }

    public abstract Task<decimal> CalculatePayment(string touristName);
}