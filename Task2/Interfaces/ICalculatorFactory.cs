namespace Task2.Interfaces;

public interface ICalculatorFactory
{
    ICalculator CreateCalculator();
    ICalculator CreateCachedCalculator();
}