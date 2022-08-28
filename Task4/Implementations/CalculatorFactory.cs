using Task4.Decorators;
using Task4.Interfaces;

namespace Task4.Implementations;

public class CalculatorFactory : ICalculatorFactory
{
    private readonly ICurrencyService _currencyService;
    private readonly ITripRepository _tripRepository;

    public CalculatorFactory(ICurrencyService currencyService, ITripRepository tripRepository)
    {
        _currencyService = currencyService;
        _tripRepository = tripRepository;
    }

    public ICalculator CreateCalculator()
        => new InsurancePaymentCalculator(_currencyService, _tripRepository);

    public ICalculator CreateCachedCalculator()
        => new CachedCalculator(CreateCalculator());

    public ICalculator CreateLoggingCalculator()
        => new LoggingCalculator(CreateCalculator(), new Logger());

    public ICalculator CreateRoundingCalculator()
        => new RoundingCalculator(CreateCalculator());

    public ICalculator AssignResponsibility<T>(ICalculator calculator, params object[] args) where T : CalculatorDecorator
        => (T) Activator.CreateInstance(typeof(T), new[] {calculator}.Concat(args).ToArray());
}