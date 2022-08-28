using Task1.Interfaces;

namespace Task1.Implementations;

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
}