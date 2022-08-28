using Task2.Interfaces;

namespace Task2.Decorators;

public abstract class CalculatorDecorator : ICalculator
{
    protected readonly ICalculator Calculator;

    protected CalculatorDecorator(ICalculator calculator)
    {
        Calculator = calculator;
    }

    public abstract Task<decimal> CalculatePayment(string touristName);
}