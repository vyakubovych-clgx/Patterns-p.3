using Task3.Decorators;

namespace Task3.Interfaces;

public interface ICalculatorFactory
{
    ICalculator CreateCalculator();
    ICalculator CreateCachedCalculator(); 
    ICalculator CreateLoggingCalculator();
    ICalculator CreateRoundingCalculator();
}