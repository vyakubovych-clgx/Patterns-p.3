using Task3.Interfaces;

namespace Task3.Decorators;

public class LoggingCalculator : CalculatorDecorator
{
    private readonly ILogger _logger;

    public LoggingCalculator(ICalculator calculator, ILogger logger) : base(calculator)
    {
        _logger = logger;
    }

    public override async Task<decimal> CalculatePayment(string touristName)
    {
        _logger.Log("Start");
        var result = await Calculator.CalculatePayment(touristName);
        _logger.Log("End");
        return result;
    }
}