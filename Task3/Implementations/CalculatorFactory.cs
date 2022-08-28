using Task3.Decorators;
using Task3.Interfaces;

namespace Task3.Implementations;

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
}