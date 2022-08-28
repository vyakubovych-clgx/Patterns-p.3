using Task4.Decorators;

namespace Task4.Interfaces;

public interface ICalculatorFactory
{
    ICalculator CreateCalculator();
    ICalculator CreateCachedCalculator(); 
    ICalculator CreateLoggingCalculator();
    ICalculator CreateRoundingCalculator();
    ICalculator AssignResponsibility<T>(ICalculator calculator, params object[] args) where T : CalculatorDecorator;
}