using Task2.Decorators;
using Task2.Interfaces;

namespace Task2.Implementations;

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
}